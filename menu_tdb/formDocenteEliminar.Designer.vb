<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDocenteEliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDocenteEliminar))
        txtFolioDocente = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cbsBaja = New ComboBox()
        btnBaja = New Button()
        btnCerrar = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFolioDocente
        ' 
        txtFolioDocente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFolioDocente.Font = New Font("Roboto", 10F)
        txtFolioDocente.Location = New Point(12, 304)
        txtFolioDocente.Name = "txtFolioDocente"
        txtFolioDocente.Size = New Size(1476, 32)
        txtFolioDocente.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label1.Location = New Point(31, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 22)
        Label1.TabIndex = 2
        Label1.Text = "Folio Docente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label2.Location = New Point(31, 411)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 22)
        Label2.TabIndex = 3
        Label2.Text = "Baja"
        ' 
        ' cbsBaja
        ' 
        cbsBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbsBaja.Font = New Font("Roboto", 10F)
        cbsBaja.FormattingEnabled = True
        cbsBaja.Items.AddRange(New Object() {"activo", "inactivo"})
        cbsBaja.Location = New Point(12, 436)
        cbsBaja.Name = "cbsBaja"
        cbsBaja.Size = New Size(1476, 32)
        cbsBaja.TabIndex = 4
        ' 
        ' btnBaja
        ' 
        btnBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBaja.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnBaja.FlatStyle = FlatStyle.Flat
        btnBaja.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnBaja.ForeColor = Color.White
        btnBaja.Location = New Point(1308, 474)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(180, 40)
        btnBaja.TabIndex = 5
        btnBaja.Text = "Baja"
        btnBaja.UseVisualStyleBackColor = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.Red
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Roboto", 14F)
        btnCerrar.ForeColor = Color.White
        btnCerrar.Location = New Point(12, 30)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(120, 50)
        btnCerrar.TabIndex = 6
        btnCerrar.Text = "X"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1476, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' formDocenteEliminar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 840)
        Controls.Add(PictureBox1)
        Controls.Add(btnCerrar)
        Controls.Add(btnBaja)
        Controls.Add(cbsBaja)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFolioDocente)
        FormBorderStyle = FormBorderStyle.None
        Name = "formDocenteEliminar"
        Text = "formDocenteEliminar"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFolioDocente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbsBaja As ComboBox
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
