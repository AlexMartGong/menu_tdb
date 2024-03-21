Imports MySql.Data.MySqlClient

Public Class formDocenteModificar

    Dim adCon As MySqlConnection
    Private cm As MySqlCommand
    Private da As MySqlDataAdapter

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
            adCon.Open
            cm = New MySqlCommand
            cm.Connection = adCon
            cm.CommandType = CommandType.Text
            cm.CommandText = "call spDocenteModificar(?p_id_docente, ?p_nombre, ?p_perfil)"
            cm.Parameters.AddWithValue("p_id_docente", CInt(txtIdDocente.Text))
            cm.Parameters.AddWithValue("p_nombre", txtNombre.Text)
            cm.Parameters.AddWithValue("p_perfil", txtPerfil.Text)
            cm.ExecuteNonQuery
            MsgBox("Datos Guardados")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adCon.Close
        End Try
        LimpiarCampos
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Text = ""
        txtPerfil.Text = ""
        txtIdDocente.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdDocente.Text.Length >= 1 Then
            Try
                Dim folio As Integer
                If Integer.TryParse(txtIdDocente.Text, folio) Then
                    Dim sentencia As String = "call spBuscarDocentePorFolio(" & CInt(txtIdDocente.Text) & ")"
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
End Class