Imports MySql.Data.MySqlClient

Public Class formDocenteModificar

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand

    Private Sub formDocenteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            adCon.Open()
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spDocenteModificar(?p_id_docente, ?p_nombre, ?p_perfil)"
            cm.Parameters.AddWithValue("p_id_docente", CInt(txtIdDocente.Text))
            cm.Parameters.AddWithValue("p_nombre", txtNombre.Text)
            cm.Parameters.AddWithValue("p_perfil", txtPerfil.Text)
            cm.ExecuteNonQuery()
            MsgBox("Datos Guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class