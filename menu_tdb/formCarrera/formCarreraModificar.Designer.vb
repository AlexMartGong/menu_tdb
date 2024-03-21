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
        btnCancelar = New Button()
        btnBuscar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1476, 163)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label5.Location = New Point(40, 443)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 22)
        Label5.TabIndex = 32
        Label5.Text = "Nombre de la carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label4.Location = New Point(39, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 22)
        Label4.TabIndex = 31
        Label4.Text = "No. Carrera"
        ' 
        ' txtNoCarrera
        ' 
        txtNoCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoCarrera.Font = New Font("Roboto", 10F)
        txtNoCarrera.Location = New Point(16, 295)
        txtNoCarrera.Name = "txtNoCarrera"
        txtNoCarrera.Size = New Size(1475, 32)
        txtNoCarrera.TabIndex = 30
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Roboto", 10F)
        txtNombre.Location = New Point(17, 468)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(1475, 32)
        txtNombre.TabIndex = 29
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(16, 18)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(120, 50)
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
        btnModificar.Location = New Point(1314, 514)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(180, 40)
        btnModificar.TabIndex = 27
        btnModificar.Text = "Guardar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancelar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(1128, 514)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(180, 40)
        btnCancelar.TabIndex = 34
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(1309, 261)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(180, 40)
        btnBuscar.TabIndex = 35
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' formCarreraModificar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1501, 867)
        Controls.Add(btnBuscar)
        Controls.Add(btnCancelar)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNoCarrera)
        Controls.Add(txtNombre)
        Controls.Add(btnExit)
        Controls.Add(btnModificar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
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
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscar As Button
End Class
