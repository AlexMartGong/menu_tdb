<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarreraAgregaer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCarreraAgregaer))
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        txtNoCarrera = New TextBox()
        txtNombreCarrera = New TextBox()
        btnExit = New Button()
        btnInsertar = New Button()
        btnCancelar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1476, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label5.Location = New Point(39, 340)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 22)
        Label5.TabIndex = 25
        Label5.Text = "Nombre de la carrera"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label4.Location = New Point(39, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 22)
        Label4.TabIndex = 24
        Label4.Text = "No. Carrera"
        ' 
        ' txtNoCarrera
        ' 
        txtNoCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoCarrera.Font = New Font("Roboto", 10F)
        txtNoCarrera.Location = New Point(16, 282)
        txtNoCarrera.Name = "txtNoCarrera"
        txtNoCarrera.Size = New Size(1475, 32)
        txtNoCarrera.TabIndex = 23
        ' 
        ' txtNombreCarrera
        ' 
        txtNombreCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombreCarrera.Font = New Font("Roboto", 10F)
        txtNombreCarrera.Location = New Point(16, 365)
        txtNombreCarrera.Name = "txtNombreCarrera"
        txtNombreCarrera.Size = New Size(1475, 32)
        txtNombreCarrera.TabIndex = 21
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
        btnExit.TabIndex = 20
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInsertar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnInsertar.FlatStyle = FlatStyle.Flat
        btnInsertar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnInsertar.ForeColor = Color.White
        btnInsertar.Location = New Point(1313, 412)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(180, 40)
        btnInsertar.TabIndex = 19
        btnInsertar.Text = "Guardar"
        btnInsertar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancelar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(1127, 412)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(180, 40)
        btnCancelar.TabIndex = 28
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' formCarreraAgregaer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1501, 867)
        Controls.Add(btnCancelar)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNoCarrera)
        Controls.Add(txtNombreCarrera)
        Controls.Add(btnExit)
        Controls.Add(btnInsertar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "formCarreraAgregaer"
        Text = "formCarreraAgregaer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoCarrera As TextBox
    Friend WithEvents txtNombreCarrera As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnCancelar As Button
End Class
