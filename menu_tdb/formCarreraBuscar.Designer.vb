<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarreraBuscar
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
        lblBuscar = New Label()
        txtFiltrar = New TextBox()
        btnExit = New Button()
        btnBuscar = New Button()
        dgvDatos = New DataGridView()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        lblBuscar.Location = New Point(16, 150)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(113, 22)
        lblBuscar.TabIndex = 18
        lblBuscar.Text = "No. Carrera"
        ' 
        ' txtFiltrar
        ' 
        txtFiltrar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFiltrar.Font = New Font("Roboto", 10F)
        txtFiltrar.Location = New Point(16, 175)
        txtFiltrar.Name = "txtFiltrar"
        txtFiltrar.Size = New Size(1290, 32)
        txtFiltrar.TabIndex = 17
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Roboto", 14F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(16, 18)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 50)
        btnExit.TabIndex = 16
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.BackColor = Color.FromArgb(CByte(255), CByte(78), CByte(100))
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Roboto Medium", 9F, FontStyle.Bold)
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(1313, 168)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(180, 40)
        btnBuscar.TabIndex = 15
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvDatos
        ' 
        dgvDatos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(16, 232)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersWidth = 62
        dgvDatos.Size = New Size(1476, 623)
        dgvDatos.TabIndex = 14
        ' 
        ' formCarreraBuscar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1501, 867)
        Controls.Add(lblBuscar)
        Controls.Add(txtFiltrar)
        Controls.Add(btnExit)
        Controls.Add(btnBuscar)
        Controls.Add(dgvDatos)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "formCarreraBuscar"
        Text = "formCarreraBuscar"
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtFiltrar As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvDatos As DataGridView
End Class
