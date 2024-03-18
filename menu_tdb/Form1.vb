Imports MySql.Data.MySqlClient

Public Class Form1
    Dim adCon As MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()

        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try

    End Sub

    Private Sub hideSubmenu()
        panel_foreingKeys.Visible = False
        panel_noforeingKeys.Visible = False
        pnlPeriodo.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnCarre_Click(sender As Object, e As EventArgs) Handles btnCarrera.Click
        showSubmenu(panel_foreingKeys)
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
        showSubmenu(panel_noforeingKeys)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        openChildForm(New formDocenteModificar)
        hideSubmenu()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        openChildForm(New Form2)
        hideSubmenu()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        openChildForm(New formCarreraBaja)
        hideSubmenu()
    End Sub

    Private Sub btnCarraraAgregar_Click(sender As Object, e As EventArgs) Handles btnCarraraAgregar.Click
        openChildForm(New formCarreraAgregaer)
        hideSubmenu()
    End Sub

    Private Sub btnCarraraBaja_Click(sender As Object, e As EventArgs) Handles btnCarraraBaja.Click
        openChildForm(New formCarreraBaja)
        hideSubmenu
    End Sub

    Private Sub btnCarraraMostrar_Click(sender As Object, e As EventArgs) Handles btnCarraraMostrar.Click
        openChildForm(New formCarraraMostrar)
        hideSubmenu()
    End Sub

    Private Sub btnCarraraModificar_Click(sender As Object, e As EventArgs) Handles btnCarraraModificar.Click
        openChildForm(New formCarreraModificar)
        hideSubmenu()
    End Sub

    Private Sub btnCarreraBuscar_Click(sender As Object, e As EventArgs) Handles btnCarreraBuscar.Click
        openChildForm(New formCarreraBuscar)
        hideSubmenu()
    End Sub

    Private Sub btnPeriodo_Click(sender As Object, e As EventArgs) Handles btnPeriodo.Click
        showSubmenu(pnlPeriodo)
    End Sub

    Private Sub btnPeriodoAgregar_Click(sender As Object, e As EventArgs) Handles btnPeriodoAgregar.Click
        openChildForm(New formPeriodoAgregar)
        hideSubmenu()
    End Sub

    Private Sub btnPeriodoBaja_Click(sender As Object, e As EventArgs) Handles btnPeriodoBaja.Click
        openChildForm(New formPeriodoBaja)
        hideSubmenu()
    End Sub

    Private Sub btnPeriodoMostrar_Click(sender As Object, e As EventArgs) Handles btnPeriodoMostrar.Click
        openChildForm(New formPeriodoMostrar)
        hideSubmenu()
    End Sub

    Private Sub btnPeriodoModificar_Click(sender As Object, e As EventArgs) Handles btnPeriodoModificar.Click
        openChildForm(New formPeriodoModificar)
        hideSubmenu()
    End Sub

    Private Sub btnPeriodoBuscar_Click(sender As Object, e As EventArgs) Handles btnPeriodoBuscar.Click
        openChildForm(New formPeriodoBuscar)
        hideSubmenu()
    End Sub
End Class