<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.txtUsr = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblUsr = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblFchInicial = New System.Windows.Forms.Label()
        Me.lblFchFinal = New System.Windows.Forms.Label()
        Me.lblAmbiente = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsr
        '
        Me.txtUsr.Location = New System.Drawing.Point(82, 12)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(144, 20)
        Me.txtUsr.TabIndex = 0
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(82, 38)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(144, 20)
        Me.txtPwd.TabIndex = 1
        '
        'lblUsr
        '
        Me.lblUsr.AutoSize = True
        Me.lblUsr.Location = New System.Drawing.Point(12, 15)
        Me.lblUsr.Name = "lblUsr"
        Me.lblUsr.Size = New System.Drawing.Size(49, 13)
        Me.lblUsr.TabIndex = 2
        Me.lblUsr.Text = "Usuario: "
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(12, 41)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(64, 13)
        Me.lblPwd.TabIndex = 3
        Me.lblPwd.Text = "Contraseña:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(82, 69)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(187, 74)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(0, 13)
        Me.lblRuta.TabIndex = 5
        Me.lblRuta.Visible = False
        '
        'lblFchInicial
        '
        Me.lblFchInicial.AutoSize = True
        Me.lblFchInicial.Location = New System.Drawing.Point(0, 74)
        Me.lblFchInicial.Name = "lblFchInicial"
        Me.lblFchInicial.Size = New System.Drawing.Size(0, 13)
        Me.lblFchInicial.TabIndex = 6
        Me.lblFchInicial.Visible = False
        '
        'lblFchFinal
        '
        Me.lblFchFinal.AutoSize = True
        Me.lblFchFinal.Location = New System.Drawing.Point(0, 93)
        Me.lblFchFinal.Name = "lblFchFinal"
        Me.lblFchFinal.Size = New System.Drawing.Size(0, 13)
        Me.lblFchFinal.TabIndex = 7
        Me.lblFchFinal.Visible = False
        '
        'lblAmbiente
        '
        Me.lblAmbiente.AutoSize = True
        Me.lblAmbiente.Location = New System.Drawing.Point(232, 82)
        Me.lblAmbiente.Name = "lblAmbiente"
        Me.lblAmbiente.Size = New System.Drawing.Size(0, 13)
        Me.lblAmbiente.TabIndex = 8
        Me.lblAmbiente.Visible = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(27, 82)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(0, 13)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Visible = False
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 104)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblAmbiente)
        Me.Controls.Add(Me.lblFchFinal)
        Me.Controls.Add(Me.lblFchInicial)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.lblUsr)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUsr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(260, 143)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(260, 143)
        Me.Name = "frmUsuario"
        Me.Text = "Usuario y contraseña de Pemex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsr As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents lblUsr As System.Windows.Forms.Label
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents lblFchInicial As System.Windows.Forms.Label
    Friend WithEvents lblFchFinal As System.Windows.Forms.Label
    Friend WithEvents lblAmbiente As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
End Class
