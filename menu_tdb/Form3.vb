Imports MySql.Data.MySqlClient

Public Class Form3
    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        dgvDatos.DataSource = Nothing
        If txtFiltrar.Text.Length >= 1 Then
            Try
                Dim folio As Integer
                If Integer.TryParse(txtFiltrar.Text, folio) Then
                    Dim sentencia As String = "call spBuscarDocentePorFolio(" & CInt(txtFiltrar.Text) & ")"
                    adCon.Open()
                    da = New MySqlDataAdapter(sentencia, adCon)
                    Dim ds As New DataSet
                    da.Fill(ds, "entidades")
                    dgvDatos.DataSource = ds.Tables("entidades")
                Else
                    ' Si no es un número, busca por nombre.
                    Dim sentencia As String = "call spBuscarDocentePorNombre(" & txtFiltrar.Text & ")"
                    adCon.Open()
                    da = New MySqlDataAdapter(sentencia, adCon)
                    Dim ds As New DataSet
                    da.Fill(ds, "entidades")
                    dgvDatos.DataSource = ds.Tables("entidades")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar docente")
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

End Class