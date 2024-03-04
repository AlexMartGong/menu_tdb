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

    Private Sub btn_noForeingKeys_Click(sender As Object, e As EventArgs) Handles btn_noForeingKeys.Click
        showSubmenu(panel_noforeingKeys)
    End Sub

    Private Sub btn_foreingKeys_Click(sender As Object, e As EventArgs) Handles btn_foreingKeys.Click
        showSubmenu(panel_foreingKeys)
    End Sub

    Private Sub btn_docente_Click(sender As Object, e As EventArgs) Handles btn_docente.Click


        hideSubmenu()
    End Sub

    Private Sub btn_carrera_Click(sender As Object, e As EventArgs) Handles btn_carrera.Click


        hideSubmenu()
    End Sub
End Class
