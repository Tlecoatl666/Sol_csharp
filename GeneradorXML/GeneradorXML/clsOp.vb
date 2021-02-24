Imports System.IO
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.Xml
Imports System.Text
Imports ComponentAce.Compression.ZipForge
Imports ComponentAce.Compression.Archiver

Public Class clsOp
    Public Usr, pwd, FchInicial, FchFinal, NombreXml, TipoAmbiente, Tipo As String


    Private Function EnviarArch() As Boolean
        Try
            Dim Rsp As String, MsgFinal As String, stringBuilder As New StringBuilder(), xResp As New XmlDocument
            Dim Dir As String = My.Computer.FileSystem.CurrentDirectory + "\XML\"
            Dir = If(TipoAmbiente = 0, Dir + "Pruebas\" + NombreXml + "\", Dir + "Desarrollo\" + NombreXml + "\")
            Dim Ar As Array = File.ReadAllBytes(Dir + NombreXml + ".zip")

            If Not (pwd = "" Or Usr = "") Then
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Crea contraseña y cifra con SHA256
                Dim sha256 As SHA256 = SHA256Managed.Create()
                Dim bytes As Byte() = UTF8Encoding.UTF8.GetBytes(Usr + pwd + Date.Now.ToString("dd/MM/yyyy"))
                Dim hash As Byte() = sha256.ComputeHash(bytes)

                For i As Integer = 0 To hash.Length - 1
                    stringBuilder.Append(hash(i).ToString("X2"))
                Next
                Dim Pass As String = stringBuilder.ToString.Replace("{", "")
                Pass = Pass.Replace("}", "")
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                '>>>>>>>>>>>>>>>>>>>>>>>> Envio de archivo y respuesta del mismo
                Dim Cliente As New Pemex.ServicioPedidosClienteDelegateClient
                Rsp = UTF8Encoding.UTF8.GetString(Cliente.enviaPedidosCliente(Usr, Pass.ToLower, Date.Now.ToString("dd/MM/yyyy"), Ar, Tipo, TipoAmbiente))
                xResp.LoadXml(Rsp) : MsgFinal = xResp.LastChild.InnerText 'Carga e interpreta las respuestas
                MessageBox.Show(MsgFinal, "Notificación de respuesta.", MessageBoxButtons.OK) 'Muesta la respuesta del WS
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            End If
            If MsgFinal.Contains("001") Then: Return True :Else:Return False:End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Snd:1.", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

    Public Function CrearXML(ByVal PathArchivo As String) As Boolean
        CrearXML = False
        Try
            Dim x As Double, y As Integer = 1
            NombreXml = Usr + "-" + FchInicial + "-" + FchFinal
            Dim Dir As String = My.Computer.FileSystem.CurrentDirectory + "\XML\"
            Dir = If(TipoAmbiente = 0, Dir + "Pruebas\" + NombreXml + "\", Dir + "Desarrollo\" + NombreXml + "\")
            If Directory.Exists(Dir) Then
            Else : Directory.CreateDirectory(Dir)
            End If

            Dim Arch As String() = Directory.GetFiles(Dir)

            For Each d As String In Arch
                If Path.GetExtension(d).ToLower = ".zip" Then
                    y += 1
                End If
            Next
            y = If(y = 0, 1, y)

            Dim Data As DataTable = ConvertirExceltoDataSet(PathArchivo).Tables(0)
            Dim Doc As New XmlDocument, Atri As XmlAttribute, Element As XmlElement, xmlDeclaration As XmlDeclaration
            xmlDeclaration = Doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            Element = Doc.DocumentElement
            Doc.InsertBefore(xmlDeclaration, Element)
            Element = Doc.CreateElement(String.Empty, "pedidosClientes", String.Empty)
            Doc.AppendChild(Element)

            For Each rw As DataRow In Data.Rows
                If Not (rw("Fecha entrega").ToString = "") Then
                    Element = Doc.CreateElement(String.Empty, "pedidoCli", String.Empty)
                    Element.SetAttribute("fechaEntrega", rw("Fecha entrega").ToString)
                    Element.SetAttribute("claveTerminal", rw("Clave terminal").ToString)
                    Element.SetAttribute("claveDestino", rw("Clave destino").ToString)
                    Element.SetAttribute("tipoReparto", rw("Tipo reparto").ToString)
                    Element.SetAttribute("claveProducto", rw("Clave producto").ToString)
                    Element.SetAttribute("turno", rw("Turno").ToString)
                    Element.SetAttribute("claveVehiculo", rw("Clave vehiculo").ToString)
                    Element.SetAttribute("tipoEmbarque", rw("Tipo embarque").ToString)

                    Doc.LastChild.AppendChild(Element)
                    ''>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Generación multiple de XML
                    'x += 1
                    'If x = 1785 Then
                    '    Doc.Save(Application.StartupPath + "\XML\" + NombreXml + "\" + NombreXml + "-" + y.ToString + ".xml")
                    '    y += 1
                    '    Doc = New XmlDocument
                    '    xmlDeclaration = Doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
                    '    Element = Doc.DocumentElement
                    '    Doc.InsertBefore(xmlDeclaration, Element)
                    '    Element = Doc.CreateElement(String.Empty, "pedidosClientes", String.Empty)
                    '    Doc.AppendChild(Element)
                    '    x = 0
                    'End If
                Else : Exit For
                End If
            Next

            Doc.Save(Dir + NombreXml + "-" + y.ToString + ".xml")
            If GenerarZip() Then
                'EnviarArch()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error C-XML:1.", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

    Private Function ConvertirExceltoDataSet(ByVal PathArchivo As String) As DataSet
        Try

            ConvertirExceltoDataSet = New DataSet
            '1.- crear La cadena de conexión al archivo de excel.
            Dim sConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" _
                & "Data Source=" & PathArchivo _
                & ";" & "Extended Properties=Excel 12.0;"
            '2.- Crear la conexión
            Dim objConn As New OleDbConnection(sConnectionString)
            '3.- Abrir la conexión.
            objConn.Open()
            '4. Crear el objeto que realizara la consulta
            Dim objCmdSelect As New OleDbCommand("SELECT * FROM [Pedido$]", objConn)
            '5. Crear el adaptador de datos
            Dim objAdapterExcel As New OleDbDataAdapter()
            objAdapterExcel.Dispose()
            '6. Aplicar el comando al adaptador
            objAdapterExcel.SelectCommand = objCmdSelect
            '8. llenar el data Set
            objAdapterExcel.Fill(ConvertirExceltoDataSet, "Pedido")

            objConn.Close()
            Return ConvertirExceltoDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Ds:1.", MessageBoxButtons.OK)
            Return ConvertirExceltoDataSet
        End Try
    End Function

    Private Function GenerarZip() As Boolean
        Try
            Dim Dir As String = My.Computer.FileSystem.CurrentDirectory + "\XML\"
            Dir = If(TipoAmbiente = 0, Dir + "Pruebas\" + NombreXml + "\", Dir + "Desarrollo\" + NombreXml + "\")
            Dim Arch As String() = Directory.GetFiles(Dir)
            Dim archiver As New ZipForge, Num As Integer = 1, NombreArchivo As String

            For Each d As String In Archz
                If Path.GetExtension(d).ToLower = ".zip" Then
                    Num += 1
                End If
            Next

            For Each d As String In Arch
                If Not (Path.GetExtension(d).ToLower = ".zip") Then
                    NombreArchivo = Dir + NombreXml + ".zip"
                    archiver.FileName = NombreArchivo ' + "_" + Usr + "_" + pwd + "_" + Tipo 
                    archiver.OpenArchive(FileMode.Create)
                    archiver.BaseDir = Dir
                    archiver.AddFiles(d)
                    archiver.CloseArchive()
                    If EnviarArch() Then
                        File.Copy(NombreArchivo, Dir + "(" + Num.ToString + ").zip")
                        File.Delete(d) : File.Delete(NombreArchivo) : Num += 1
                    Else
                        File.Delete(NombreArchivo) : File.Delete(d)
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Zip:1.", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

End Class