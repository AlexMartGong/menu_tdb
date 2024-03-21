<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarreraBaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCarreraBaja))
        PictureBox1 = New PictureBox()
        btnCerrar = New Button()
        btnBaja = New Button()
        cbsBaja = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtNoCarrera = New TextBox()
        btnCancelar = New Button()
        btnBuscar = New Button()
        Label3 = New Label()
        txtNombreCarrera = New TextBox()
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
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.Red
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Roboto", 14F)
        btnCerrar.ForeColor = Color.White
        btnCerrar.Location = New Point(16, 18)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(120, 50)
        btnCerrar.TabIndex = 13
        btnCerrar.Text = "X"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnBaja
        ' 
        btnBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBaja.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnBaja.FlatStyle = FlatStyle.Flat
        btnBaja.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnBaja.ForeColor = Color.White
        btnBaja.Location = New Point(1312, 629)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(180, 40)
        btnBaja.TabIndex = 12
        btnBaja.Text = "Guardar"
        btnBaja.UseVisualStyleBackColor = False
        ' 
        ' cbsBaja
        ' 
        cbsBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbsBaja.Font = New Font("Roboto", 10F)
        cbsBaja.FormattingEnabled = True
        cbsBaja.Items.AddRange(New Object() {"activo", "inactivo"})
        cbsBaja.Location = New Point(16, 572)
        cbsBaja.Name = "cbsBaja"
        cbsBaja.Size = New Size(1475, 32)
        cbsBaja.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label2.Location = New Point(36, 547)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 22)
        Label2.TabIndex = 10
        Label2.Text = "Baja"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label1.Location = New Point(36, 267)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 22)
        Label1.TabIndex = 9
        Label1.Text = "No. Carrera"
        ' 
        ' txtNoCarrera
        ' 
        txtNoCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoCarrera.Font = New Font("Roboto", 10F)
        txtNoCarrera.Location = New Point(16, 292)
        txtNoCarrera.Name = "txtNoCarrera"
        txtNoCarrera.Size = New Size(1475, 32)
        txtNoCarrera.TabIndex = 8
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancelar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(1126, 629)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(180, 40)
        btnCancelar.TabIndex = 15
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
        btnBuscar.Location = New Point(1312, 246)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(180, 40)
        btnBuscar.TabIndex = 16
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label3.Location = New Point(33, 405)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 22)
        Label3.TabIndex = 18
        Label3.Text = "Nombre carrera"
        ' 
        ' txtNombreCarrera
        ' 
        txtNombreCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombreCarrera.Font = New Font("Roboto", 10F)
        txtNombreCarrera.Location = New Point(13, 430)
        txtNombreCarrera.Name = "txtNombreCarrera"
        txtNombreCarrera.Size = New Size(1475, 32)
        txtNombreCarrera.TabIndex = 17
        ' 
        ' formCarreraBaja
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1501, 867)
        Controls.Add(Label3)
        Controls.Add(txtNombreCarrera)
        Controls.Add(btnBuscar)
        Controls.Add(btnCancelar)
        Controls.Add(PictureBox1)
        Controls.Add(btnCerrar)
        Controls.Add(btnBaja)
        Controls.Add(cbsBaja)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNoCarrera)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "formCarreraBaja"
        Text = "formCarreraBaja"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents cbsBaja As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoCarrera As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreCarrera As TextBox
End Class
