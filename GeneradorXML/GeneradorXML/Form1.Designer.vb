<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.Pleca1 = New System.Windows.Forms.Label()
        Me.btnDireccion = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.gpbTipo = New System.Windows.Forms.GroupBox()
        Me.rdbDiario = New System.Windows.Forms.RadioButton()
        Me.rdbSemanal = New System.Windows.Forms.RadioButton()
        Me.gpbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(12, 37)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(181, 13)
        Me.lblFechaInicial.TabIndex = 5
        Me.lblFechaInicial.Text = "Fecha inicial de semana de entrega: "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFinal.Location = New System.Drawing.Point(12, 73)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(181, 35)
        Me.lblFechaFinal.TabIndex = 6
        Me.lblFechaFinal.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fecha final de semana de entrega"
        '
        'Pleca1
        '
        Me.Pleca1.BackColor = System.Drawing.Color.Olive
        Me.Pleca1.Location = New System.Drawing.Point(12, 135)
        Me.Pleca1.Name = "Pleca1"
        Me.Pleca1.Size = New System.Drawing.Size(238, 1)
        Me.Pleca1.TabIndex = 7
        '
        'btnDireccion
        '
        Me.btnDireccion.Location = New System.Drawing.Point(225, 178)
        Me.btnDireccion.Name = "btnDireccion"
        Me.btnDireccion.Size = New System.Drawing.Size(25, 22)
        Me.btnDireccion.TabIndex = 8
        Me.btnDireccion.Text = "..."
        Me.btnDireccion.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(12, 180)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 20)
        Me.txtDireccion.TabIndex = 9
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(175, 206)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label1.Location = New System.Drawing.Point(12, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Archivo"
        '
        'dtpInicial
        '
        Me.dtpInicial.Location = New System.Drawing.Point(12, 53)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(235, 20)
        Me.dtpInicial.TabIndex = 12
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(12, 102)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(235, 20)
        Me.dtpFinal.TabIndex = 13
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(157, 18)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Información del pedido"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(110, 246)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Descargar plantilla de pedido"
        '
        'gpbTipo
        '
        Me.gpbTipo.Controls.Add(Me.rdbDiario)
        Me.gpbTipo.Controls.Add(Me.rdbSemanal)
        Me.gpbTipo.Location = New System.Drawing.Point(109, 140)
        Me.gpbTipo.Name = "gpbTipo"
        Me.gpbTipo.Size = New System.Drawing.Size(141, 30)
        Me.gpbTipo.TabIndex = 17
        Me.gpbTipo.TabStop = False
        '
        'rdbDiario
        '
        Me.rdbDiario.AutoSize = True
        Me.rdbDiario.Location = New System.Drawing.Point(88, 8)
        Me.rdbDiario.Name = "rdbDiario"
        Me.rdbDiario.Size = New System.Drawing.Size(52, 17)
        Me.rdbDiario.TabIndex = 1
        Me.rdbDiario.Text = "Diario"
        Me.rdbDiario.UseVisualStyleBackColor = True
        '
        'rdbSemanal
        '
        Me.rdbSemanal.AutoSize = True
        Me.rdbSemanal.Checked = True
        Me.rdbSemanal.Location = New System.Drawing.Point(6, 8)
        Me.rdbSemanal.Name = "rdbSemanal"
        Me.rdbSemanal.Size = New System.Drawing.Size(66, 17)
        Me.rdbSemanal.TabIndex = 0
        Me.rdbSemanal.TabStop = True
        Me.rdbSemanal.Text = "Semanal"
        Me.rdbSemanal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 273)
        Me.Controls.Add(Me.gpbTipo)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnDireccion)
        Me.Controls.Add(Me.Pleca1)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(282, 312)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(282, 312)
        Me.Name = "Form1"
        Me.Text = "Programación Pedidos Damora Crane"
        Me.gpbTipo.ResumeLayout(False)
        Me.gpbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents Pleca1 As System.Windows.Forms.Label
    Friend WithEvents btnDireccion As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents gpbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDiario As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSemanal As System.Windows.Forms.RadioButton

End Class
