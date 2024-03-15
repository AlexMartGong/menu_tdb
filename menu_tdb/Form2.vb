Imports System.Security.Cryptography.Pkcs
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim adCon As MySqlConnection
    Private cm As MySqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            adCon.Open()
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spDocenteInsertar(?p_id_docente, ?p_nombre, ?p_perfil)"
            cm.Parameters.AddWithValue("p_id_docente", CInt(txtFolioDocente.Text))
            cm.Parameters.AddWithValue("p_nombre", txtNombre.Text)
            cm.Parameters.AddWithValue("p_perfil", txtPerfil.Text)
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
        txtNombre.Text = ""
        txtPerfil.Text = ""
        txtFolioDocente.Text = ""
    End Sub

End Class