Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmaddvoters
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
        votersClear()
    End Sub

    Private Sub votersClear()
        txtstudnum.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        cbcourse.Text = "BSCS"
        cbyear.Text = "1"

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        votersClear()
        Me.Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        If (txtstudnum.Text <> "") Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into cstgdb.studentaccount (StudentNumber,Name,Surname,Course,Year,Status) values ('" & txtstudnum.Text & "', '" & txtfname.Text & "','" & txtlname.Text & "','" & cbcourse.Text & "','" & cbyear.Text & "','Not_Voted')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Successfully added")
                MysqlConn.Close()
                votersClear()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtstudnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstudnum.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class