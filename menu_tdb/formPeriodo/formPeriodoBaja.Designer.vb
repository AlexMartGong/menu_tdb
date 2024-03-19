<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPeriodoBaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPeriodoBaja))
        PictureBox1 = New PictureBox()
        btnCerrar = New Button()
        btnBaja = New Button()
        cbsBaja = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtFolioPeriodo = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1476, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.Red
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Roboto", 14F)
        btnCerrar.ForeColor = Color.White
        btnCerrar.Location = New Point(12, 12)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(120, 50)
        btnCerrar.TabIndex = 20
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
        btnBaja.Location = New Point(1307, 464)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(180, 40)
        btnBaja.TabIndex = 19
        btnBaja.Text = "Baja"
        btnBaja.UseVisualStyleBackColor = False
        ' 
        ' cbsBaja
        ' 
        cbsBaja.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbsBaja.Font = New Font("Roboto", 10F)
        cbsBaja.FormattingEnabled = True
        cbsBaja.Items.AddRange(New Object() {"activo", "inactivo"})
        cbsBaja.Location = New Point(12, 419)
        cbsBaja.Name = "cbsBaja"
        cbsBaja.Size = New Size(1475, 32)
        cbsBaja.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label2.Location = New Point(32, 394)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 22)
        Label2.TabIndex = 17
        Label2.Text = "Baja"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label1.Location = New Point(32, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 22)
        Label1.TabIndex = 16
        Label1.Text = "Folio Periodo"
        ' 
        ' txtFolioPeriodo
        ' 
        txtFolioPeriodo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFolioPeriodo.Font = New Font("Roboto", 10F)
        txtFolioPeriodo.Location = New Point(12, 286)
        txtFolioPeriodo.Name = "txtFolioPeriodo"
        txtFolioPeriodo.Size = New Size(1475, 32)
        txtFolioPeriodo.TabIndex = 15
        ' 
        ' formPeriodoBaja
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
        Controls.Add(txtFolioPeriodo)
        FormBorderStyle = FormBorderStyle.None
        Name = "formPeriodoBaja"
        Text = "formPeriodoBaja"
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
    Friend WithEvents txtFolioPeriodo As TextBox
End Class
