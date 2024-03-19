<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPeriodoAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPeriodoAgregar))
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        txtFolioPeriodo = New TextBox()
        txtFecha = New TextBox()
        btnExit = New Button()
        btnInsertar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1476, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label5.Location = New Point(34, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 22)
        Label5.TabIndex = 25
        Label5.Text = "Periodo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        Label4.Location = New Point(34, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 22)
        Label4.TabIndex = 24
        Label4.Text = "Folio Periodo"
        ' 
        ' txtFolioPeriodo
        ' 
        txtFolioPeriodo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFolioPeriodo.Font = New Font("Roboto", 10F)
        txtFolioPeriodo.Location = New Point(12, 276)
        txtFolioPeriodo.Name = "txtFolioPeriodo"
        txtFolioPeriodo.Size = New Size(1476, 32)
        txtFolioPeriodo.TabIndex = 23
        ' 
        ' txtFecha
        ' 
        txtFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFecha.Font = New Font("Roboto", 10F)
        txtFecha.Location = New Point(12, 358)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(1476, 32)
        txtFecha.TabIndex = 21
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
        btnInsertar.Location = New Point(1308, 396)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(180, 40)
        btnInsertar.TabIndex = 19
        btnInsertar.Text = "Insertar"
        btnInsertar.UseVisualStyleBackColor = False
        ' 
        ' formPeriodoAgregar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 840)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtFolioPeriodo)
        Controls.Add(txtFecha)
        Controls.Add(btnExit)
        Controls.Add(btnInsertar)
        FormBorderStyle = FormBorderStyle.None
        Name = "formPeriodoAgregar"
        Text = "formPeriodoAgregar"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFolioPeriodo As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnInsertar As Button
End Class
