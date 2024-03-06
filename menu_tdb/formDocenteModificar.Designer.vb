<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDocenteModificar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtIdDocente = New TextBox()
        txtPerfil = New TextBox()
        txtNombre = New TextBox()
        btnExit = New Button()
        btnModificar = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label3.Location = New Point(34, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 22)
        Label3.TabIndex = 25
        Label3.Text = "Perfil"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label5.Location = New Point(34, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 22)
        Label5.TabIndex = 24
        Label5.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label4.Location = New Point(34, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 22)
        Label4.TabIndex = 23
        Label4.Text = "Folio Docente"
        ' 
        ' txtIdDocente
        ' 
        txtIdDocente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtIdDocente.Font = New Font("Roboto", 10F)
        txtIdDocente.Location = New Point(12, 165)
        txtIdDocente.Name = "txtIdDocente"
        txtIdDocente.Size = New Size(1476, 32)
        txtIdDocente.TabIndex = 22
        ' 
        ' txtPerfil
        ' 
        txtPerfil.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPerfil.Font = New Font("Roboto", 10F)
        txtPerfil.Location = New Point(12, 328)
        txtPerfil.Name = "txtPerfil"
        txtPerfil.Size = New Size(1476, 32)
        txtPerfil.TabIndex = 21
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Roboto", 10F)
        txtNombre.Location = New Point(12, 247)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(1476, 32)
        txtNombre.TabIndex = 20
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(12, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(120, 50)
        btnExit.TabIndex = 19
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnModificar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnModificar.ForeColor = Color.White
        btnModificar.Location = New Point(1308, 366)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(180, 40)
        btnModificar.TabIndex = 18
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' formDocenteModificar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 840)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtIdDocente)
        Controls.Add(txtPerfil)
        Controls.Add(txtNombre)
        Controls.Add(btnExit)
        Controls.Add(btnModificar)
        FormBorderStyle = FormBorderStyle.None
        Name = "formDocenteModificar"
        Text = "formDocenteModificar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdDocente As TextBox
    Friend WithEvents txtPerfil As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnModificar As Button
End Class
