Imports MySql.Data.MySqlClient

Public Class formDocenteEliminar

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtFolioDocente.Text.Length >= 1 Then
            Try
                Dim folio As Integer
                If Integer.TryParse(txtFolioDocente.Text, folio) Then
                    Dim sentencia As String = "call spBuscarDocentePorFolio(" & CInt(txtFolioDocente.Text) & ")"
                    adCon.Open()
                    da = New MySqlDataAdapter(sentencia, adCon)
                    Dim ds As New DataSet
                    da.Fill(ds, "entidades")

                    If ds.Tables("entidades").Rows.Count > 0 Then
                        txtNombre.Text = ds.Tables("entidades").Rows(0)("nombre_docente").ToString()
                        txtPerfil.Text = ds.Tables("entidades").Rows(0)("perfil").ToString()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar docente")
            Finally
                adCon.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class