Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO

Public Class frmvotingballot
    Public Property Presname As String
    Public Property Presvote As String
    Public Property Prescv As String
    Public Property Vicename As String
    Public Property Vicevote As String
    Public Property Vicecv As String
    Public Property Secname As String
    Public Property Secvote As String
    Public Property Seccv As String
    Public Property Trename As String
    Public Property Trevote As String
    Public Property Trecv As String
    Public Property Audname As String
    Public Property Audvote As String
    Public Property Audcv As String
    Public Property Proname As String
    Public Property Provote As String
    Public Property Procv As String
    Public Property Musename As String
    Public Property Musevote As String
    Public Property Musecv As String
    Public Property Escortname As String
    Public Property Escortvote As String
    Public Property Escortcv As String

    Public Property Studnum As String
    Public Property Course As String


    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlClient.MySqlDataReader
    Dim dbDataSet As New DataTable

    Private Sub frmvotingballot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Name of Selected Candidate
        txtpresname.Text = Presname
        txtvicename.Text = Vicename
        txtsecname.Text = Secname
        txttrename.Text = Trename
        txtaudname.Text = Audname
        txtproname.Text = Proname
        txtmusename.Text = Musename
        txtescortname.Text = Escortname

        txtpresvote.Text = Presvote
        txtvicevote.Text = Vicevote
        txtsecvote.Text = Secvote
        txttrevote.Text = Trevote
        txtaudvote.Text = Audvote
        txtprovote.Text = Provote
        txtmusevote.Text = Musevote
        txtescortvote.Text = Escortvote

        txtprescv.Text = Prescv
        txtvicecv.Text = Vicecv
        txtseccv.Text = Seccv
        txttrecv.Text = Trecv
        txtaudcv.Text = Audcv
        txtprocv.Text = Procv
        txtmusecv.Text = Musecv
        txtescortcv.Text = Escortcv

        txtstudnum.Text = Studnum
        txtcourse.Text = Course

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=cstgdb;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try

        'LOAD CANDIDATES IMAGE
        Dim arrImage() As Byte

        'Load Pres Pic
        Try
            If txtpresname.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtpresname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbpres.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load VicePres Pic
        Try
            If txtvicename.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtvicename.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbvice.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load Secretary Pic
        Try
            If txtsecname.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtsecname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbsec.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load Treasurer Pic
        Try
            If txttrename.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txttrename.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbtre.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load Auditor Pic
        Try
            If txtaudname.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtaudname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbaud.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load P.R.O Pic
        Try
            If txtproname.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtproname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbpro.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load Muse Pic
        Try
            If txtmusename.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtmusename.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbmuse.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Load Escort Pic
        Try
            If txtescortname.Text <> "NONE" Then
                sql = "SELECT * FROM candidates WHERE Name = '" & txtescortname.Text & "'"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_reader = sql_command.ExecuteReader()
                sql_reader.Read()
                arrImage = sql_reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbescort.BackgroundImage = Image.FromStream(mstream)
                sql_reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub btnvote_Click(sender As Object, e As EventArgs) Handles btnvote.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim total As Integer
        Dim cv As Integer

        'President final cast
        Try
            If txtpresname.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtpresvote.Text) + 1
                txtpresvote.Text = total
                cv = Val(txtprescv.Text) + 1
                txtprescv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtpresvote.Text & "',BSCS='" & txtprescv.Text & "' where Name='" & txtpresname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtpresvote.Text & "',BSCT='" & txtprescv.Text & "' where Name='" & txtpresname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Vice President final cast
        Try
            If txtvicename.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtvicevote.Text) + 1
                txtvicevote.Text = total
                cv = Val(txtvicecv.Text) + 1
                txtvicecv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtvicevote.Text & "',BSCS='" & txtvicecv.Text & "' where Name='" & txtvicename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtvicevote.Text & "',BSCT='" & txtvicecv.Text & "' where Name='" & txtvicename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Secretary final cast
        Try
            If txtsecname.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtsecvote.Text) + 1
                txtsecvote.Text = total
                cv = Val(txtseccv.Text) + 1
                txtseccv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtsecvote.Text & "',BSCS='" & txtseccv.Text & "' where Name='" & txtsecname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtsecvote.Text & "',BSCT='" & txtseccv.Text & "' where Name='" & txtsecname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Treasurer final cast
        Try
            If txttrename.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txttrevote.Text) + 1
                txttrevote.Text = total
                cv = Val(txttrecv.Text) + 1
                txttrecv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txttrevote.Text & "',BSCS='" & txttrecv.Text & "' where Name='" & txttrename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txttrevote.Text & "',BSCT='" & txttrecv.Text & "' where Name='" & txttrename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Auditor final cast
        Try
            If txtaudname.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtaudvote.Text) + 1
                txtaudvote.Text = total
                cv = Val(txtaudcv.Text) + 1
                txtaudcv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtaudvote.Text & "',BSCS='" & txtaudcv.Text & "' where Name='" & txtaudname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtaudvote.Text & "',BSCT='" & txtaudcv.Text & "' where Name='" & txtaudname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'P.R.O final cast
        Try
            If txtproname.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtprovote.Text) + 1
                txtprovote.Text = total
                cv = Val(txtprocv.Text) + 1
                txtprocv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtprovote.Text & "',BSCS='" & txtprocv.Text & "' where Name='" & txtproname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtprovote.Text & "',BSCT='" & txtprocv.Text & "' where Name='" & txtproname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Muse final cast
        Try
            If txtmusename.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtmusevote.Text) + 1
                txtmusevote.Text = total
                cv = Val(txtmusecv.Text) + 1
                txtmusecv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtmusevote.Text & "',BSCS='" & txtmusecv.Text & "' where Name='" & txtmusename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtmusevote.Text & "',BSCT='" & txtmusecv.Text & "' where Name='" & txtmusename.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Escort final cast
        Try
            If txtescortname.Text <> "NONE" Then
                MysqlConn.Open()
                Dim Query As String
                total = Val(txtescortvote.Text) + 1
                txtescortvote.Text = total
                cv = Val(txtescortcv.Text) + 1
                txtescortcv.Text = cv

                If txtcourse.Text = "BSCS" Then
                    Query = "update cstgdb.candidates set Votes='" & txtescortvote.Text & "',BSCS='" & txtescortcv.Text & "' where Name='" & txtescortname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                Else
                    Query = "update cstgdb.candidates set Votes='" & txtescortvote.Text & "',BSCT='" & txtescortcv.Text & "' where Name='" & txtescortname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        'STUDENT STATUS
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update cstgdb.studentaccount set Status='Done_Voting' where StudentNumber='" & txtstudnum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim mb = MessageBox.Show("your vote has been cast", "Done Voting", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If mb = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class