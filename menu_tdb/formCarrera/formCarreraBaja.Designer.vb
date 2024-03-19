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
        PictureBox1.Size = New Size(1033, 94)
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
        btnCerrar.Location = New Point(11, 11)
        btnCerrar.Margin = New Padding(2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(84, 30)
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
        btnBaja.Location = New Point(918, 282)
        btnBaja.Margin = New Padding(2)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(126, 24)
        btnBaja.TabIndex = 12
        btnBaja.Text = "Baja"
        btnBaja.UseVisualStyleBackColor = False
        ' 
        ' cbsBaja
        ' 
        cbsBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbsBaja.Font = New Font("Roboto", 10F)
        cbsBaja.FormattingEnabled = True
        cbsBaja.Items.AddRange(New Object() {"activo", "inactivo"})
        cbsBaja.Location = New Point(11, 255)
        cbsBaja.Margin = New Padding(2)
        cbsBaja.Name = "cbsBaja"
        cbsBaja.Size = New Size(1034, 23)
        cbsBaja.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label2.Location = New Point(25, 240)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 14)
        Label2.TabIndex = 10
        Label2.Text = "Baja"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label1.Location = New Point(25, 160)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 14)
        Label1.TabIndex = 9
        Label1.Text = "No. Carrera"
        ' 
        ' txtNoCarrera
        ' 
        txtNoCarrera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoCarrera.Font = New Font("Roboto", 10F)
        txtNoCarrera.Location = New Point(11, 175)
        txtNoCarrera.Margin = New Padding(2)
        txtNoCarrera.Name = "txtNoCarrera"
        txtNoCarrera.Size = New Size(1034, 24)
        txtNoCarrera.TabIndex = 8
        ' 
        ' formCarreraBaja
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1051, 520)
        Controls.Add(PictureBox1)
        Controls.Add(btnCerrar)
        Controls.Add(btnBaja)
        Controls.Add(cbsBaja)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNoCarrera)
        FormBorderStyle = FormBorderStyle.None
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
End Class
