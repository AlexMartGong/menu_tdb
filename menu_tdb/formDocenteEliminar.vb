Imports MySql.Data.MySqlClient

Public Class formDocenteEliminar

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand

    Private Sub formDocenteEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            adCon.Open()
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spCambiarEstatusDocente(?p_id_docente, ?p_estatus)"
            cm.Parameters.AddWithValue("p_id_docente", CInt(txtFolioDocente.Text))
            cm.Parameters.AddWithValue("p_estatus", cbsBaja.Text)
            cm.ExecuteNonQuery()
            MsgBox("Datos Guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtFolioDocente.Text = ""
        cbsBaja.Text = ""
    End Sub

End Class