Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()
        panel_foreingKeys.Visible = False
        panel_noforeingKeys.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btn_noForeingKeys_Click(sender As Object, e As EventArgs) Handles btnNoforenKey.Click
        showSubmenu(panel_noforeingKeys)
    End Sub

    Private Sub btn_foreingKeys_Click(sender As Object, e As EventArgs) Handles btn_foreingKeys.Click
        showSubmenu(panel_foreingKeys)
    End Sub

    Private Sub btn_docente_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        openChildForm(New Form2)

        hideSubmenu()
    End Sub

    Private Sub btn_carrera_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        openChildForm(New formDocenteEliminar)

        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        openChildForm(New Form3)

        hideSubmenu()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        openChildForm(New formMostrarDocentes)
        hideSubmenu()
    End Sub

    Private Sub btnDocente(sender As Object, e As EventArgs) Handles btnNoforenKey.Click

    End Sub

End Class
