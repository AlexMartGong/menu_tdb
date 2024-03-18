<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarreraModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCarreraModificar))
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        txtNoCarrera = New TextBox()
        txtNombre = New TextBox()
        btnExit = New Button()
        btnModificar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 45)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1033, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label5.Location = New Point(27, 211)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 14)
        Label5.TabIndex = 32
        Label5.Text = "Nombre de la carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label4.Location = New Point(27, 162)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 14)
        Label4.TabIndex = 31
        Label4.Text = "No. Carrera"
        ' 
        ' txtNoCarrera
        ' 
        txtNoCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoCarrera.Font = New Font("Roboto", 10F)
        txtNoCarrera.Location = New Point(11, 177)
        txtNoCarrera.Margin = New Padding(2)
        txtNoCarrera.Name = "txtNoCarrera"
        txtNoCarrera.Size = New Size(1034, 24)
        txtNoCarrera.TabIndex = 30
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Roboto", 10F)
        txtNombre.Location = New Point(11, 226)
        txtNombre.Margin = New Padding(2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(1034, 24)
        txtNombre.TabIndex = 29
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(11, 11)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 30)
        btnExit.TabIndex = 28
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
        btnModificar.Location = New Point(919, 254)
        btnModificar.Margin = New Padding(2)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(126, 24)
        btnModificar.TabIndex = 27
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' formCarreraModificar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1051, 520)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNoCarrera)
        Controls.Add(txtNombre)
        Controls.Add(btnExit)
        Controls.Add(btnModificar)
        FormBorderStyle = FormBorderStyle.None
        Name = "formCarreraModificar"
        Text = "formCarreraModificar"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoCarrera As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnModificar As Button
End Class
