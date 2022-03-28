Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO


Public Class frmcandidates
    Public Property StringPass As String
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim pos As Integer = 0

    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlClient.MySqlDataReader

    Private Sub getCandidatePic()
        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & txtname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbcandid.Image = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub pbparty_Click(sender As Object, e As EventArgs) Handles pbcandid.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbcandid.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub frmcandidates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=cstgdb;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try

        txtname.Text = StringPass

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & txtname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblparty.Text = READER.GetString("Party")
                lblposition.Text = READER.GetString("Position")
                txtage.Text = READER.GetString("Age")
                cbgender.Text = READER.GetString("Gender")
                cbcourse.Text = READER.GetString("Course")
                txtcam.Text = READER.GetString("Campaign")
            End While
            getCandidatePic()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbcandid.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "UPDATE cstgdb.candidates SET Age=@age,Gender=@gender,Campaign=@campaign,Image=@image,Course=@course WHERE Name ='" & txtname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@age", txtage.Text)
                sql_command.Parameters.AddWithValue("@gender", cbgender.Text)
                sql_command.Parameters.AddWithValue("@campaign", txtcam.Text)
                sql_command.Parameters.AddWithValue("@course", cbcourse.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)

                MessageBox.Show("Successfully Updated")
                sql_command.ExecuteNonQuery()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class