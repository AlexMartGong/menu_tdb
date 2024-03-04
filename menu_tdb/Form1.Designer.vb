<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        panel_menu = New Panel()
        panel_foreingKeys = New Panel()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        btn_foreingKeys = New Button()
        panel_noforeingKeys = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        btn_carrera = New Button()
        btn_docente = New Button()
        btn_noForeingKeys = New Button()
        panel_logo = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        panel_menu.SuspendLayout()
        panel_foreingKeys.SuspendLayout()
        panel_noforeingKeys.SuspendLayout()
        panel_logo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panel_menu
        ' 
        panel_menu.AutoScroll = True
        panel_menu.BackColor = Color.White
        panel_menu.Controls.Add(panel_foreingKeys)
        panel_menu.Controls.Add(btn_foreingKeys)
        panel_menu.Controls.Add(panel_noforeingKeys)
        panel_menu.Controls.Add(btn_noForeingKeys)
        panel_menu.Controls.Add(panel_logo)
        panel_menu.Dock = DockStyle.Left
        panel_menu.Location = New Point(0, 0)
        panel_menu.Name = "panel_menu"
        panel_menu.Size = New Size(350, 784)
        panel_menu.TabIndex = 0
        ' 
        ' panel_foreingKeys
        ' 
        panel_foreingKeys.BackColor = Color.WhiteSmoke
        panel_foreingKeys.Controls.Add(Button6)
        panel_foreingKeys.Controls.Add(Button7)
        panel_foreingKeys.Controls.Add(Button8)
        panel_foreingKeys.Controls.Add(Button9)
        panel_foreingKeys.Dock = DockStyle.Top
        panel_foreingKeys.Location = New Point(0, 449)
        panel_foreingKeys.Name = "panel_foreingKeys"
        panel_foreingKeys.Size = New Size(350, 170)
        panel_foreingKeys.TabIndex = 4
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(0, 120)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(35, 0, 0, 0)
        Button6.Size = New Size(350, 40)
        Button6.TabIndex = 3
        Button6.Text = "Button6"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(0, 80)
        Button7.Name = "Button7"
        Button7.Padding = New Padding(35, 0, 0, 0)
        Button7.Size = New Size(350, 40)
        Button7.TabIndex = 2
        Button7.Text = "Button7"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(0, 40)
        Button8.Name = "Button8"
        Button8.Padding = New Padding(35, 0, 0, 0)
        Button8.Size = New Size(350, 40)
        Button8.TabIndex = 1
        Button8.Text = "Button8"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Dock = DockStyle.Top
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Location = New Point(0, 0)
        Button9.Name = "Button9"
        Button9.Padding = New Padding(35, 0, 0, 0)
        Button9.Size = New Size(350, 40)
        Button9.TabIndex = 0
        Button9.Text = "Button9"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = True
        ' 
        ' btn_foreingKeys
        ' 
        btn_foreingKeys.Dock = DockStyle.Top
        btn_foreingKeys.FlatAppearance.BorderSize = 0
        btn_foreingKeys.FlatStyle = FlatStyle.Flat
        btn_foreingKeys.Location = New Point(0, 404)
        btn_foreingKeys.Name = "btn_foreingKeys"
        btn_foreingKeys.Padding = New Padding(10, 0, 0, 0)
        btn_foreingKeys.Size = New Size(350, 45)
        btn_foreingKeys.TabIndex = 3
        btn_foreingKeys.Text = "Con llaves foráneas"
        btn_foreingKeys.TextAlign = ContentAlignment.MiddleLeft
        btn_foreingKeys.UseVisualStyleBackColor = True
        ' 
        ' panel_noforeingKeys
        ' 
        panel_noforeingKeys.BackColor = Color.WhiteSmoke
        panel_noforeingKeys.Controls.Add(Button4)
        panel_noforeingKeys.Controls.Add(Button3)
        panel_noforeingKeys.Controls.Add(btn_carrera)
        panel_noforeingKeys.Controls.Add(btn_docente)
        panel_noforeingKeys.Dock = DockStyle.Top
        panel_noforeingKeys.Location = New Point(0, 234)
        panel_noforeingKeys.Name = "panel_noforeingKeys"
        panel_noforeingKeys.Size = New Size(350, 170)
        panel_noforeingKeys.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(0, 120)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(35, 0, 0, 0)
        Button4.Size = New Size(350, 40)
        Button4.TabIndex = 3
        Button4.Text = "Button4"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(0, 80)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(35, 0, 0, 0)
        Button3.Size = New Size(350, 40)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btn_carrera
        ' 
        btn_carrera.Dock = DockStyle.Top
        btn_carrera.FlatAppearance.BorderSize = 0
        btn_carrera.FlatStyle = FlatStyle.Flat
        btn_carrera.Location = New Point(0, 40)
        btn_carrera.Name = "btn_carrera"
        btn_carrera.Padding = New Padding(35, 0, 0, 0)
        btn_carrera.Size = New Size(350, 40)
        btn_carrera.TabIndex = 1
        btn_carrera.Text = "Carrera"
        btn_carrera.TextAlign = ContentAlignment.MiddleLeft
        btn_carrera.UseVisualStyleBackColor = True
        ' 
        ' btn_docente
        ' 
        btn_docente.Dock = DockStyle.Top
        btn_docente.FlatAppearance.BorderSize = 0
        btn_docente.FlatStyle = FlatStyle.Flat
        btn_docente.Location = New Point(0, 0)
        btn_docente.Name = "btn_docente"
        btn_docente.Padding = New Padding(35, 0, 0, 0)
        btn_docente.Size = New Size(350, 40)
        btn_docente.TabIndex = 0
        btn_docente.Text = "Docente"
        btn_docente.TextAlign = ContentAlignment.MiddleLeft
        btn_docente.UseVisualStyleBackColor = True
        ' 
        ' btn_noForeingKeys
        ' 
        btn_noForeingKeys.Dock = DockStyle.Top
        btn_noForeingKeys.FlatAppearance.BorderSize = 0
        btn_noForeingKeys.FlatStyle = FlatStyle.Flat
        btn_noForeingKeys.Location = New Point(0, 189)
        btn_noForeingKeys.Name = "btn_noForeingKeys"
        btn_noForeingKeys.Padding = New Padding(10, 0, 0, 0)
        btn_noForeingKeys.Size = New Size(350, 45)
        btn_noForeingKeys.TabIndex = 1
        btn_noForeingKeys.Text = "Sin llaves foráneas"
        btn_noForeingKeys.TextAlign = ContentAlignment.MiddleLeft
        btn_noForeingKeys.UseVisualStyleBackColor = True
        ' 
        ' panel_logo
        ' 
        panel_logo.BackColor = Color.White
        panel_logo.Controls.Add(PictureBox1)
        panel_logo.Dock = DockStyle.Top
        panel_logo.Location = New Point(0, 0)
        panel_logo.Name = "panel_logo"
        panel_logo.Size = New Size(350, 189)
        panel_logo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(335, 171)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(931, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(447, 784)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 784)
        Controls.Add(PictureBox2)
        Controls.Add(panel_menu)
        MinimumSize = New Size(1400, 840)
        Name = "Form1"
        Text = "Form1"
        panel_menu.ResumeLayout(False)
        panel_foreingKeys.ResumeLayout(False)
        panel_noforeingKeys.ResumeLayout(False)
        panel_logo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents panel_logo As Panel
    Friend WithEvents btn_noForeingKeys As Button
    Friend WithEvents panel_noforeingKeys As Panel
    Friend WithEvents btn_docente As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_carrera As Button
    Friend WithEvents panel_foreingKeys As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_foreingKeys As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
