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
        pnlPeriodo = New Panel()
        btnPeriodoModificar = New Button()
        btnPeriodoMostrar = New Button()
        btnPeriodoBaja = New Button()
        btnPeriodoAgregar = New Button()
        btnPeriodo = New Button()
        panel_foreingKeys = New Panel()
        btnCarraraModificar = New Button()
        btnCarraraMostrar = New Button()
        btnCarraraBaja = New Button()
        btnCarraraAgregar = New Button()
        btnCarrera = New Button()
        panel_noforeingKeys = New Panel()
        btnModificar = New Button()
        btnMostrar = New Button()
        btnBuscar = New Button()
        btnBaja = New Button()
        btnInsertar = New Button()
        btnNoforenKey = New Button()
        panel_logo = New Panel()
        picLogo = New PictureBox()
        panelChildForm = New Panel()
        PictureBox2 = New PictureBox()
        panel_menu.SuspendLayout()
        pnlPeriodo.SuspendLayout()
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
        panel_menu.Controls.Add(pnlPeriodo)
        panel_menu.Controls.Add(btnPeriodo)
        panel_menu.Controls.Add(panel_foreingKeys)
        panel_menu.Controls.Add(btnCarrera)
        panel_menu.Controls.Add(panel_noforeingKeys)
        panel_menu.Controls.Add(btnNoforenKey)
        panel_menu.Controls.Add(panel_logo)
        panel_menu.Dock = DockStyle.Left
        panel_menu.Location = New Point(0, 0)
        panel_menu.Margin = New Padding(2)
        panel_menu.Name = "panel_menu"
        panel_menu.Size = New Size(245, 481)
        panel_menu.TabIndex = 0
        ' 
        ' pnlPeriodo
        ' 
        pnlPeriodo.BackColor = Color.WhiteSmoke
        pnlPeriodo.Controls.Add(btnPeriodoModificar)
        pnlPeriodo.Controls.Add(btnPeriodoMostrar)
        pnlPeriodo.Controls.Add(btnPeriodoBaja)
        pnlPeriodo.Controls.Add(btnPeriodoAgregar)
        pnlPeriodo.Dock = DockStyle.Top
        pnlPeriodo.Location = New Point(0, 426)
        pnlPeriodo.Margin = New Padding(2)
        pnlPeriodo.Name = "pnlPeriodo"
        pnlPeriodo.Size = New Size(228, 102)
        pnlPeriodo.TabIndex = 6
        ' 
        ' btnPeriodoModificar
        ' 
        btnPeriodoModificar.Dock = DockStyle.Top
        btnPeriodoModificar.FlatAppearance.BorderSize = 0
        btnPeriodoModificar.FlatStyle = FlatStyle.Flat
        btnPeriodoModificar.Font = New Font("Roboto", 9F)
        btnPeriodoModificar.Location = New Point(0, 72)
        btnPeriodoModificar.Margin = New Padding(2)
        btnPeriodoModificar.Name = "btnPeriodoModificar"
        btnPeriodoModificar.Padding = New Padding(24, 0, 0, 0)
        btnPeriodoModificar.Size = New Size(228, 24)
        btnPeriodoModificar.TabIndex = 3
        btnPeriodoModificar.Text = "Modificar"
        btnPeriodoModificar.TextAlign = ContentAlignment.MiddleLeft
        btnPeriodoModificar.UseVisualStyleBackColor = True
        ' 
        ' btnPeriodoMostrar
        ' 
        btnPeriodoMostrar.Dock = DockStyle.Top
        btnPeriodoMostrar.FlatAppearance.BorderSize = 0
        btnPeriodoMostrar.FlatStyle = FlatStyle.Flat
        btnPeriodoMostrar.Font = New Font("Roboto", 9F)
        btnPeriodoMostrar.Location = New Point(0, 48)
        btnPeriodoMostrar.Margin = New Padding(2)
        btnPeriodoMostrar.Name = "btnPeriodoMostrar"
        btnPeriodoMostrar.Padding = New Padding(24, 0, 0, 0)
        btnPeriodoMostrar.Size = New Size(228, 24)
        btnPeriodoMostrar.TabIndex = 2
        btnPeriodoMostrar.Text = "Mostrar"
        btnPeriodoMostrar.TextAlign = ContentAlignment.MiddleLeft
        btnPeriodoMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnPeriodoBaja
        ' 
        btnPeriodoBaja.Dock = DockStyle.Top
        btnPeriodoBaja.FlatAppearance.BorderSize = 0
        btnPeriodoBaja.FlatStyle = FlatStyle.Flat
        btnPeriodoBaja.Font = New Font("Roboto", 9F)
        btnPeriodoBaja.Location = New Point(0, 24)
        btnPeriodoBaja.Margin = New Padding(2)
        btnPeriodoBaja.Name = "btnPeriodoBaja"
        btnPeriodoBaja.Padding = New Padding(24, 0, 0, 0)
        btnPeriodoBaja.Size = New Size(228, 24)
        btnPeriodoBaja.TabIndex = 1
        btnPeriodoBaja.Text = "Baja"
        btnPeriodoBaja.TextAlign = ContentAlignment.MiddleLeft
        btnPeriodoBaja.UseVisualStyleBackColor = True
        ' 
        ' btnPeriodoAgregar
        ' 
        btnPeriodoAgregar.Dock = DockStyle.Top
        btnPeriodoAgregar.FlatAppearance.BorderSize = 0
        btnPeriodoAgregar.FlatStyle = FlatStyle.Flat
        btnPeriodoAgregar.Font = New Font("Roboto", 9F)
        btnPeriodoAgregar.Location = New Point(0, 0)
        btnPeriodoAgregar.Margin = New Padding(2)
        btnPeriodoAgregar.Name = "btnPeriodoAgregar"
        btnPeriodoAgregar.Padding = New Padding(24, 0, 0, 0)
        btnPeriodoAgregar.Size = New Size(228, 24)
        btnPeriodoAgregar.TabIndex = 0
        btnPeriodoAgregar.Text = "Agregar"
        btnPeriodoAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnPeriodoAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnPeriodo
        ' 
        btnPeriodo.Dock = DockStyle.Top
        btnPeriodo.FlatAppearance.BorderSize = 0
        btnPeriodo.FlatStyle = FlatStyle.Flat
        btnPeriodo.Font = New Font("Roboto", 10F)
        btnPeriodo.Location = New Point(0, 399)
        btnPeriodo.Margin = New Padding(2)
        btnPeriodo.Name = "btnPeriodo"
        btnPeriodo.Padding = New Padding(7, 0, 0, 0)
        btnPeriodo.Size = New Size(228, 27)
        btnPeriodo.TabIndex = 5
        btnPeriodo.Text = "Periodo"
        btnPeriodo.TextAlign = ContentAlignment.MiddleLeft
        btnPeriodo.UseVisualStyleBackColor = True
        ' 
        ' panel_foreingKeys
        ' 
        panel_foreingKeys.BackColor = Color.WhiteSmoke
        panel_foreingKeys.Controls.Add(btnCarraraModificar)
        panel_foreingKeys.Controls.Add(btnCarraraMostrar)
        panel_foreingKeys.Controls.Add(btnCarraraBaja)
        panel_foreingKeys.Controls.Add(btnCarraraAgregar)
        panel_foreingKeys.Dock = DockStyle.Top
        panel_foreingKeys.Location = New Point(0, 297)
        panel_foreingKeys.Margin = New Padding(2)
        panel_foreingKeys.Name = "panel_foreingKeys"
        panel_foreingKeys.Size = New Size(228, 102)
        panel_foreingKeys.TabIndex = 4
        ' 
        ' btnCarraraModificar
        ' 
        btnCarraraModificar.Dock = DockStyle.Top
        btnCarraraModificar.FlatAppearance.BorderSize = 0
        btnCarraraModificar.FlatStyle = FlatStyle.Flat
        btnCarraraModificar.Font = New Font("Roboto", 9F)
        btnCarraraModificar.Location = New Point(0, 72)
        btnCarraraModificar.Margin = New Padding(2)
        btnCarraraModificar.Name = "btnCarraraModificar"
        btnCarraraModificar.Padding = New Padding(24, 0, 0, 0)
        btnCarraraModificar.Size = New Size(228, 24)
        btnCarraraModificar.TabIndex = 3
        btnCarraraModificar.Text = "Modificar"
        btnCarraraModificar.TextAlign = ContentAlignment.MiddleLeft
        btnCarraraModificar.UseVisualStyleBackColor = True
        ' 
        ' btnCarraraMostrar
        ' 
        btnCarraraMostrar.Dock = DockStyle.Top
        btnCarraraMostrar.FlatAppearance.BorderSize = 0
        btnCarraraMostrar.FlatStyle = FlatStyle.Flat
        btnCarraraMostrar.Font = New Font("Roboto", 9F)
        btnCarraraMostrar.Location = New Point(0, 48)
        btnCarraraMostrar.Margin = New Padding(2)
        btnCarraraMostrar.Name = "btnCarraraMostrar"
        btnCarraraMostrar.Padding = New Padding(24, 0, 0, 0)
        btnCarraraMostrar.Size = New Size(228, 24)
        btnCarraraMostrar.TabIndex = 2
        btnCarraraMostrar.Text = "Mostrar"
        btnCarraraMostrar.TextAlign = ContentAlignment.MiddleLeft
        btnCarraraMostrar.UseVisualStyleBackColor = True
        ' 
        ' btnCarraraBaja
        ' 
        btnCarraraBaja.Dock = DockStyle.Top
        btnCarraraBaja.FlatAppearance.BorderSize = 0
        btnCarraraBaja.FlatStyle = FlatStyle.Flat
        btnCarraraBaja.Font = New Font("Roboto", 9F)
        btnCarraraBaja.Location = New Point(0, 24)
        btnCarraraBaja.Margin = New Padding(2)
        btnCarraraBaja.Name = "btnCarraraBaja"
        btnCarraraBaja.Padding = New Padding(24, 0, 0, 0)
        btnCarraraBaja.Size = New Size(228, 24)
        btnCarraraBaja.TabIndex = 1
        btnCarraraBaja.Text = "Baja"
        btnCarraraBaja.TextAlign = ContentAlignment.MiddleLeft
        btnCarraraBaja.UseVisualStyleBackColor = True
        ' 
        ' btnCarraraAgregar
        ' 
        btnCarraraAgregar.Dock = DockStyle.Top
        btnCarraraAgregar.FlatAppearance.BorderSize = 0
        btnCarraraAgregar.FlatStyle = FlatStyle.Flat
        btnCarraraAgregar.Font = New Font("Roboto", 9F)
        btnCarraraAgregar.Location = New Point(0, 0)
        btnCarraraAgregar.Margin = New Padding(2)
        btnCarraraAgregar.Name = "btnCarraraAgregar"
        btnCarraraAgregar.Padding = New Padding(24, 0, 0, 0)
        btnCarraraAgregar.Size = New Size(228, 24)
        btnCarraraAgregar.TabIndex = 0
        btnCarraraAgregar.Text = "Agregar"
        btnCarraraAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnCarraraAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnCarrera
        ' 
        btnCarrera.Dock = DockStyle.Top
        btnCarrera.FlatAppearance.BorderSize = 0
        btnCarrera.FlatStyle = FlatStyle.Flat
        btnCarrera.Font = New Font("Roboto", 10F)
        btnCarrera.Location = New Point(0, 270)
        btnCarrera.Margin = New Padding(2)
        btnCarrera.Name = "btnCarrera"
        btnCarrera.Padding = New Padding(7, 0, 0, 0)
        btnCarrera.Size = New Size(228, 27)
        btnCarrera.TabIndex = 3
        btnCarrera.Text = "Carrera"
        btnCarrera.TextAlign = ContentAlignment.MiddleLeft
        btnCarrera.UseVisualStyleBackColor = True
        ' 
        ' panel_noforeingKeys
        ' 
        panel_noforeingKeys.BackColor = Color.WhiteSmoke
        panel_noforeingKeys.Controls.Add(btnModificar)
        panel_noforeingKeys.Controls.Add(btnMostrar)
        panel_noforeingKeys.Controls.Add(btnBuscar)
        panel_noforeingKeys.Controls.Add(btnBaja)
        panel_noforeingKeys.Controls.Add(btnInsertar)
        panel_noforeingKeys.Dock = DockStyle.Top
        panel_noforeingKeys.Location = New Point(0, 140)
        panel_noforeingKeys.Margin = New Padding(2)
        panel_noforeingKeys.Name = "panel_noforeingKeys"
        panel_noforeingKeys.Size = New Size(228, 130)
        panel_noforeingKeys.TabIndex = 2
        ' 
        ' btnModificar
        ' 
        btnModificar.Dock = DockStyle.Top
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Roboto", 9F)
        btnModificar.Location = New Point(0, 96)
        btnModificar.Margin = New Padding(2)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(24, 0, 0, 0)
        btnModificar.Size = New Size(228, 24)
        btnModificar.TabIndex = 4
        btnModificar.Text = "Modificar"
        btnModificar.TextAlign = ContentAlignment.MiddleLeft
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Dock = DockStyle.Top
        btnMostrar.FlatAppearance.BorderSize = 0
        btnMostrar.FlatStyle = FlatStyle.Flat
        btnMostrar.Font = New Font("Roboto", 9F)
        btnMostrar.Location = New Point(0, 72)
        btnMostrar.Margin = New Padding(2)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Padding = New Padding(24, 0, 0, 0)
        btnMostrar.Size = New Size(228, 24)
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
        btnBuscar.Location = New Point(0, 48)
        btnBuscar.Margin = New Padding(2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(24, 0, 0, 0)
        btnBuscar.Size = New Size(228, 24)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleLeft
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnBaja
        ' 
        btnBaja.Dock = DockStyle.Top
        btnBaja.FlatAppearance.BorderSize = 0
        btnBaja.FlatStyle = FlatStyle.Flat
        btnBaja.Font = New Font("Roboto", 9F)
        btnBaja.Location = New Point(0, 24)
        btnBaja.Margin = New Padding(2)
        btnBaja.Name = "btnBaja"
        btnBaja.Padding = New Padding(24, 0, 0, 0)
        btnBaja.Size = New Size(228, 24)
        btnBaja.TabIndex = 1
        btnBaja.Text = "Baja"
        btnBaja.TextAlign = ContentAlignment.MiddleLeft
        btnBaja.UseVisualStyleBackColor = True
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Dock = DockStyle.Top
        btnInsertar.FlatAppearance.BorderSize = 0
        btnInsertar.FlatStyle = FlatStyle.Flat
        btnInsertar.Font = New Font("Roboto", 9F)
        btnInsertar.Location = New Point(0, 0)
        btnInsertar.Margin = New Padding(2)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Padding = New Padding(24, 0, 0, 0)
        btnInsertar.Size = New Size(228, 24)
        btnInsertar.TabIndex = 0
        btnInsertar.Text = "Agregar"
        btnInsertar.TextAlign = ContentAlignment.MiddleLeft
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnNoforenKey
        ' 
        btnNoforenKey.Dock = DockStyle.Top
        btnNoforenKey.FlatAppearance.BorderSize = 0
        btnNoforenKey.FlatStyle = FlatStyle.Flat
        btnNoforenKey.Font = New Font("Roboto", 10F)
        btnNoforenKey.Location = New Point(0, 113)
        btnNoforenKey.Margin = New Padding(2)
        btnNoforenKey.Name = "btnNoforenKey"
        btnNoforenKey.Padding = New Padding(7, 0, 0, 0)
        btnNoforenKey.Size = New Size(228, 27)
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
        panel_logo.Margin = New Padding(2)
        panel_logo.Name = "panel_logo"
        panel_logo.Size = New Size(228, 113)
        panel_logo.TabIndex = 0
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(8, 7)
        picLogo.Margin = New Padding(2)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(234, 103)
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
        panelChildForm.Location = New Point(245, 0)
        panelChildForm.Margin = New Padding(2)
        panelChildForm.Name = "panelChildForm"
        panelChildForm.Size = New Size(790, 481)
        panelChildForm.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(513, 0)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(275, 479)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 481)
        Controls.Add(panelChildForm)
        Controls.Add(panel_menu)
        Margin = New Padding(2)
        MinimumSize = New Size(985, 520)
        Name = "Form1"
        Text = "Form1"
        panel_menu.ResumeLayout(False)
        pnlPeriodo.ResumeLayout(False)
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
    Friend WithEvents btnBaja As Button
    Friend WithEvents panel_foreingKeys As Panel
    Friend WithEvents btnCarraraModificar As Button
    Friend WithEvents btnCarraraMostrar As Button
    Friend WithEvents btnCarraraBaja As Button
    Friend WithEvents btnCarraraAgregar As Button
    Friend WithEvents btnCarrera As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents pnlPeriodo As Panel
    Friend WithEvents btnPeriodoModificar As Button
    Friend WithEvents btnPeriodoMostrar As Button
    Friend WithEvents btnPeriodoBaja As Button
    Friend WithEvents btnPeriodoAgregar As Button
    Friend WithEvents btnPeriodo As Button

End Class
