<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDocenteBuscar
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
        dgvDatos = New DataGridView()
        btnBuscar = New Button()
        btnExit = New Button()
        txtFiltrar = New TextBox()
        lblBuscar = New Label()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDatos
        ' 
        dgvDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(12, 225)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersWidth = 62
        dgvDatos.Size = New Size(1476, 603)
        dgvDatos.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(1308, 161)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(180, 40)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Roboto", 14F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(12, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 50)
        btnExit.TabIndex = 11
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtFiltrar
        ' 
        txtFiltrar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFiltrar.Font = New Font("Roboto", 10F)
        txtFiltrar.Location = New Point(12, 169)
        txtFiltrar.Name = "txtFiltrar"
        txtFiltrar.Size = New Size(1290, 32)
        txtFiltrar.TabIndex = 12
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        lblBuscar.Location = New Point(12, 144)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(134, 22)
        lblBuscar.TabIndex = 13
        lblBuscar.Text = "Folio Docente"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1500, 840)
        Controls.Add(lblBuscar)
        Controls.Add(txtFiltrar)
        Controls.Add(btnExit)
        Controls.Add(btnBuscar)
        Controls.Add(dgvDatos)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFiltrar As TextBox
    Friend WithEvents lblBuscar As Label
End Class
