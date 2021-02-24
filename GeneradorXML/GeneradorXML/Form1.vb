Imports System.Xml
Imports System.IO

Public Class Form1

    Private Sub btnDireccion_Click(sender As Object, e As EventArgs) Handles btnDireccion.Click
        Try
            Dim ofdArchivo As New OpenFileDialog
            ofdArchivo.Filter = "Excel|*.xlsx; *.xls"
            ofdArchivo.Title = "Seleccione el archivo de Excel que contiene la información a enviar"

            If ofdArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtDireccion.Text = ofdArchivo.FileName
            End If
            txtDireccion.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If File.Exists(txtDireccion.Text) Then

                If txtDireccion.Text = "" Then
                    MessageBox.Show("La dirección del archivo no es valido, por favor validar información.", "Error al enviar.", MessageBoxButtons.OK)
                    Exit Sub
                End If

                If (dtpInicial.Value > dtpFinal.Value) Then
                    MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final del pedido, favor de validar las fechas.", "Error en fechas del pedido.", MessageBoxButtons.OK)
                    Exit Sub
                End If

                Dim frm As New frmUsuario
                frm.lblRuta.Text = txtDireccion.Text
                frm.lblFchInicial.Text = dtpInicial.Value.ToString("ddMMyyyy")
                frm.lblFchFinal.Text = dtpFinal.Value.ToString("ddMMyyyy")
                frm.lblAmbiente.Text = "1"
                frm.lblTipo.Text = If(rdbSemanal.Checked, "S", "D")
                frm.ShowDialog()

            Else
                MessageBox.Show("La dirección o archivo no valido, por favor validar información.")
                txtDireccion.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Gn:1.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim Nombre As String = My.Computer.FileSystem.CurrentDirectory + "/Plantilla_Pedido.xlsx"
            Dim sfdSave As New SaveFileDialog
            sfdSave.Filter = "Excel| *.xlsx"
            sfdSave.Title = "Guardar archivo de plantilla"            

            If (File.Exists(Nombre)) Then
                If sfdSave.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.CopyFile(Nombre, sfdSave.FileName, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                    Process.Start("explorer.exe", sfdSave.FileName)
                End If                
            Else
                MessageBox.Show("No se encontró el archivo especificado.", "Error Gn:3.", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Gn:2.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
