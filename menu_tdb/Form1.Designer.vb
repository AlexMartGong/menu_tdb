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
        btnMostrar = New Button()
        btnBuscar = New Button()
        btnEliminar = New Button()
        btnInsertar = New Button()
        btnNoforenKey = New Button()
        panel_logo = New Panel()
        picLogo = New PictureBox()
        panelChildForm = New Panel()
        PictureBox2 = New PictureBox()
        btnModificar = New Button()
        panel_menu.SuspendLayout()
        panel_foreingKeys.SuspendLayout()
        panel_noforeingKeys.SuspendLayout()
        panel_logo.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelChildForm.SuspendLayout()
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
        panel_menu.Controls.Add(btnNoforenKey)
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
        panel_foreingKeys.Location = New Point(0, 495)
        panel_foreingKeys.Name = "panel_foreingKeys"
        panel_foreingKeys.Size = New Size(350, 170)
        panel_foreingKeys.TabIndex = 4
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Roboto", 9F)
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
        Button7.Font = New Font("Roboto", 9F)
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
        Button8.Font = New Font("Roboto", 9F)
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
        Button9.Font = New Font("Roboto", 9F)
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
        btn_foreingKeys.Font = New Font("Roboto", 10F)
        btn_foreingKeys.Location = New Point(0, 450)
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
        panel_noforeingKeys.Controls.Add(btnModificar)
        panel_noforeingKeys.Controls.Add(btnMostrar)
        panel_noforeingKeys.Controls.Add(btnBuscar)
        panel_noforeingKeys.Controls.Add(btnEliminar)
        panel_noforeingKeys.Controls.Add(btnInsertar)
        panel_noforeingKeys.Dock = DockStyle.Top
        panel_noforeingKeys.Location = New Point(0, 234)
        panel_noforeingKeys.Name = "panel_noforeingKeys"
        panel_noforeingKeys.Size = New Size(350, 216)
        panel_noforeingKeys.TabIndex = 2
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Dock = DockStyle.Top
        btnMostrar.FlatAppearance.BorderSize = 0
        btnMostrar.FlatStyle = FlatStyle.Flat
        btnMostrar.Font = New Font("Roboto", 9F)
        btnMostrar.Location = New Point(0, 120)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Padding = New Padding(35, 0, 0, 0)
        btnMostrar.Size = New Size(350, 40)
        btnMostrar.TabIndex = 3
        btnMostrar.Text = "Mostrar"
        btnMostrar.TextAlign = ContentAlignment.MiddleLeft
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Dock = DockStyle.Top
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Roboto", 9F)
        btnBuscar.Location = New Point(0, 80)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(35, 0, 0, 0)
        btnBuscar.Size = New Size(350, 40)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleLeft
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Dock = DockStyle.Top
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Roboto", 9F)
        btnEliminar.Location = New Point(0, 40)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(35, 0, 0, 0)
        btnEliminar.Size = New Size(350, 40)
        btnEliminar.TabIndex = 1
        btnEliminar.Text = "Baja"
        btnEliminar.TextAlign = ContentAlignment.MiddleLeft
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Dock = DockStyle.Top
        btnInsertar.FlatAppearance.BorderSize = 0
        btnInsertar.FlatStyle = FlatStyle.Flat
        btnInsertar.Font = New Font("Roboto", 9F)
        btnInsertar.Location = New Point(0, 0)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Padding = New Padding(35, 0, 0, 0)
        btnInsertar.Size = New Size(350, 40)
        btnInsertar.TabIndex = 0
        btnInsertar.Text = "Insertar"
        btnInsertar.TextAlign = ContentAlignment.MiddleLeft
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnNoforenKey
        ' 
        btnNoforenKey.Dock = DockStyle.Top
        btnNoforenKey.FlatAppearance.BorderSize = 0
        btnNoforenKey.FlatStyle = FlatStyle.Flat
        btnNoforenKey.Font = New Font("Roboto", 10F)
        btnNoforenKey.Location = New Point(0, 189)
        btnNoforenKey.Name = "btnNoforenKey"
        btnNoforenKey.Padding = New Padding(10, 0, 0, 0)
        btnNoforenKey.Size = New Size(350, 45)
        btnNoforenKey.TabIndex = 1
        btnNoforenKey.Text = "Docente"
        btnNoforenKey.TextAlign = ContentAlignment.MiddleLeft
        btnNoforenKey.UseVisualStyleBackColor = True
        ' 
        ' panel_logo
        ' 
        panel_logo.BackColor = Color.White
        panel_logo.Controls.Add(picLogo)
        panel_logo.Dock = DockStyle.Top
        panel_logo.Location = New Point(0, 0)
        panel_logo.Name = "panel_logo"
        panel_logo.Size = New Size(350, 189)
        panel_logo.TabIndex = 0
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(12, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(335, 171)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' panelChildForm
        ' 
        panelChildForm.BackColor = Color.White
        panelChildForm.BorderStyle = BorderStyle.FixedSingle
        panelChildForm.Controls.Add(PictureBox2)
        panelChildForm.Dock = DockStyle.Fill
        panelChildForm.Location = New Point(350, 0)
        panelChildForm.Name = "panelChildForm"
        panelChildForm.Size = New Size(1128, 784)
        panelChildForm.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(733, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(393, 782)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' btnModificar
        ' 
        btnModificar.Dock = DockStyle.Top
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Roboto", 9F)
        btnModificar.Location = New Point(0, 160)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(35, 0, 0, 0)
        btnModificar.Size = New Size(350, 40)
        btnModificar.TabIndex = 4
        btnModificar.Text = "Modificar"
        btnModificar.TextAlign = ContentAlignment.MiddleLeft
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1478, 784)
        Controls.Add(panelChildForm)
        Controls.Add(panel_menu)
        MinimumSize = New Size(1400, 840)
        Name = "Form1"
        Text = "Form1"
        panel_menu.ResumeLayout(False)
        panel_foreingKeys.ResumeLayout(False)
        panel_noforeingKeys.ResumeLayout(False)
        panel_logo.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        panelChildForm.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents panel_logo As Panel
    Friend WithEvents btnNoforenKey As Button
    Friend WithEvents panel_noforeingKeys As Panel
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents panel_foreingKeys As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_foreingKeys As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnModificar As Button

End Class
