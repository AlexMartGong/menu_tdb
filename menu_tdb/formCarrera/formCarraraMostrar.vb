Imports MySql.Data.MySqlClient

Public Class formCarraraMostrar

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

    Private Sub formCarraraMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
            mostrarTodos()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub mostrarTodos()
        Try
            Dim sentencia As String = "call spMostrarCarreras"
            adCon = New MySqlConnection(cadena)
            adCon.Open()
            da = New MySqlDataAdapter(sentencia, adCon)
            Dim ds As New DataSet
            da.Fill(ds, "entidades")
            dgvDatos.DataSource = ds.Tables("entidades")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mostrar docentes")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class