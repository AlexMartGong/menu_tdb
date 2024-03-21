Imports MySql.Data.MySqlClient

Public Class formCarreraAgregaer

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

    Private Sub formCarreraAgregaer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            adCon.Open()
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spCarreraInsertar(?p_clave_c, ?p_nombre)"
            cm.Parameters.AddWithValue("p_clave_c", CInt(txtNoCarrera.Text))
            cm.Parameters.AddWithValue("p_nombre", txtNombreCarrera.Text)
            cm.ExecuteNonQuery()
            MsgBox("Datos Guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub
End Class