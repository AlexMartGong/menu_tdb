Imports MySql.Data.MySqlClient

Public Class formCarreraBaja

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

    Private Sub formCarreraBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adCon = New MySqlConnection(cadena)
            adCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "Error al conectar la base de datos")
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtNoCarrera.Text.Length >= 1 Then
            Try
                Dim folio As Integer
                If Integer.TryParse(txtNoCarrera.Text, folio) Then
                    Dim sentencia As String = "call spBuscarCarreraPorFolio(" & CInt(txtNoCarrera.Text) & ")"
                    adCon.Open()
                    da = New MySqlDataAdapter(sentencia, adCon)
                    Dim ds As New DataSet
                    da.Fill(ds, "entidades")

                    If ds.Tables("entidades").Rows.Count > 0 Then
                        txtNombreCarrera.Text = ds.Tables("entidades").Rows(0)("nombre_carrera").ToString()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar docente")
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            adCon.Open()
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spCambiarEstatusCarrera(?p_clave_c, ?p_estatus)"
            cm.Parameters.AddWithValue("p_clave_c", CInt(txtNoCarrera.Text))
            cm.Parameters.AddWithValue("p_estatus", cbsBaja.Text)
            cm.ExecuteNonQuery()
            MsgBox("Datos Guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class