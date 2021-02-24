Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class frmUsuario

    Dim clsOp As New clsOp
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Aceptar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Gn:1.", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.TopMost = True
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyData = Keys.Control + Keys.Alt + Keys.F5) Then
            lblAmbiente.Text = If(lblAmbiente.Text = "0", "1", "0")
            Me.Text = If(lblAmbiente.Text = "0", "**Usuario y contraseña de Pemex: PBE", "Usuario y contraseña de Pemex")
        ElseIf e.KeyData = Keys.Control + Keys.Enter Then
            MessageBox.Show(Application.StartupPath, "Directorio", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub txtPwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyData = Keys.Enter Then
            Aceptar()
        End If
    End Sub

    Private Sub Aceptar()
        Try
            clsOp.Usr = txtUsr.Text
            clsOp.pwd = txtPwd.Text
            clsOp.FchInicial = lblFchInicial.Text
            clsOp.FchFinal = lblFchFinal.Text
            clsOp.TipoAmbiente = lblAmbiente.Text
            clsOp.Tipo = lblTipo.Text

            clsOp.CrearXML(lblRuta.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Gn:1.", MessageBoxButtons.OK)
        End Try
    End Sub
End Class