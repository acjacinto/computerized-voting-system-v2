Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO

Public Class studentvotingform
    Public Property StringPass As String

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlClient.MySqlDataReader
    Dim dbDataSet As New DataTable
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim mb = MessageBox.Show("Are you sure you want to close the voting form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If mb = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            frmlogin.Show()
        Else

        End If
    End Sub

    Private Sub loadstudinfo()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            'Student Info
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.studentaccount where StudentNumber='" & lblstudnum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblname.Text = READER.GetString("Name")
                lblsurname.Text = READER.GetString("Surname")
                lblcourse.Text = READER.GetString("Course")
                lblyear.Text = READER.GetString("Year")
                lblstatus.Text = READER.GetString("Status")
            End While

            If lblstatus.Text <> "Not_Voted" Then
                Me.Close()
                frmlogin.Show()
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub studentvotingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblstudnum.Text = StringPass

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try

            loadstudinfo()

            lblfullname.Text = lblname.Text & " " & lblsurname.Text

            'Party
            MysqlConn.Open()
            Dim Querys As String
            Querys = "select * from cstgdb.partylist"
            COMMAND = New MySqlCommand(Querys, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim partyname = READER.GetString("Name")
                cbparty.Items.Add(partyname)
            End While

            MysqlConn.Close()

            'President
            MysqlConn.Open()
            Dim Query0 As String
            Query0 = "select * from cstgdb.candidates where Position = 'President'"
            COMMAND = New MySqlCommand(Query0, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim presname = READER.GetString("Name")
                cbpresname.Items.Add(presname)
            End While

            MysqlConn.Close()

            'Vice President
            MysqlConn.Open()
            Dim Query1 As String
            Query1 = "select * from cstgdb.candidates where Position = 'Vice_President'"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim vicename = READER.GetString("Name")
                cbvicename.Items.Add(vicename)
            End While

            MysqlConn.Close()

            'Secretary
            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "select * from cstgdb.candidates where Position = 'Secretary'"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim secname = READER.GetString("Name")
                cbsecname.Items.Add(secname)
            End While

            MysqlConn.Close()

            'Treasurer
            MysqlConn.Open()
            Dim Query3 As String
            Query3 = "select * from cstgdb.candidates where Position = 'Treasurer'"
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim trename = READER.GetString("Name")
                cbtrename.Items.Add(trename)
            End While

            MysqlConn.Close()

            'Auditor
            MysqlConn.Open()
            Dim Query4 As String
            Query4 = "select * from cstgdb.candidates where Position = 'Auditor'"
            COMMAND = New MySqlCommand(Query4, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim audname = READER.GetString("Name")
                cbaudname.Items.Add(audname)
            End While

            MysqlConn.Close()

            'P.R.O
            MysqlConn.Open()
            Dim Query5 As String
            Query5 = "select * from cstgdb.candidates where Position = 'PRO'"
            COMMAND = New MySqlCommand(Query5, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim proname = READER.GetString("Name")
                cbproname.Items.Add(proname)
            End While

            MysqlConn.Close()

            'Muse
            MysqlConn.Open()
            Dim Query6 As String
            Query6 = "select * from cstgdb.candidates where Position = 'Muse'"
            COMMAND = New MySqlCommand(Query6, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim musename = READER.GetString("Name")
                cbmusename.Items.Add(musename)
            End While

            MysqlConn.Close()

            'Escort
            MysqlConn.Open()
            Dim Query7 As String
            Query7 = "select * from cstgdb.candidates where Position = 'Escort'"
            COMMAND = New MySqlCommand(Query7, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim escortname = READER.GetString("Name")
                cbescortname.Items.Add(escortname)
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=cstgdb;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try
    End Sub




    'PRESIDENT
    Private Sub cbpresname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpresname.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbpresname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtprescourse.Text = READER.GetString("Course")
                txtpresyear.Text = READER.GetString("Year")
                txtpresparty.Text = READER.GetString("Party")
                txtprescam.Text = READER.GetString("Campaign")
                txtpresvote.Text = READER.GetInt32("Votes")
                txtprescv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnpres.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbpresname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbpres.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnprescancel_Click(sender As Object, e As EventArgs) Handles btnprescancel.Click
        cbpresname.Text = "NONE"
        txtprescourse.Text = ""
        txtpresyear.Text = ""
        txtpresparty.Text = ""
        txtprescam.Text = ""
        pbpres.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnpres.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'VICE PRESIDENT
    Private Sub cbvicename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbvicename.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbvicename.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtvicecourse.Text = READER.GetString("Course")
                txtviceyear.Text = READER.GetString("Year")
                txtviceparty.Text = READER.GetString("Party")
                txtvicecam.Text = READER.GetString("Campaign")
                txtvicevote.Text = READER.GetInt32("Votes")
                txtvicecv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnvice.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbvicename.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbvice.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnvicecancel_Click(sender As Object, e As EventArgs) Handles btnvicecancel.Click
        cbvicename.Text = "NONE"
        txtvicecourse.Text = ""
        txtviceyear.Text = ""
        txtviceparty.Text = ""
        txtvicecam.Text = ""
        pbvice.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnvice.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'SECRETARY
    Private Sub cbsecname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsecname.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbsecname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtseccourse.Text = READER.GetString("Course")
                txtsecyear.Text = READER.GetString("Year")
                txtsecparty.Text = READER.GetString("Party")
                txtseccam.Text = READER.GetString("Campaign")
                txtsecvote.Text = READER.GetInt32("Votes")
                txtseccv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnsecretary.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbsecname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbsec.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnseccancel_Click(sender As Object, e As EventArgs) Handles btnseccancel.Click
        cbsecname.Text = "NONE"
        txtseccourse.Text = ""
        txtsecyear.Text = ""
        txtsecparty.Text = ""
        txtseccam.Text = ""
        pbsec.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnsecretary.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'TREASURER
    Private Sub cbtrename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtrename.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbtrename.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txttrecourse.Text = READER.GetString("Course")
                txttreyear.Text = READER.GetString("Year")
                txttreparty.Text = READER.GetString("Party")
                txttrecam.Text = READER.GetString("Campaign")
                txttrevote.Text = READER.GetInt32("Votes")
                txttrecv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btntreasurer.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbtrename.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbtre.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btntrecancel_Click(sender As Object, e As EventArgs) Handles btntrecancel.Click
        cbtrename.Text = "NONE"
        txttrecourse.Text = ""
        txttreyear.Text = ""
        txttreparty.Text = ""
        txttrecam.Text = ""
        pbtre.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btntreasurer.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'AUDITOR
    Private Sub cbaudname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbaudname.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbaudname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtaudcourse.Text = READER.GetString("Course")
                txtaudyear.Text = READER.GetString("Year")
                txtaudparty.Text = READER.GetString("Party")
                txtaudcam.Text = READER.GetString("Campaign")
                txtaudvote.Text = READER.GetInt32("Votes")
                txtaudcv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnauditor.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbaudname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbaud.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnaudcancel_Click(sender As Object, e As EventArgs) Handles btnaudcancel.Click
        cbaudname.Text = "NONE"
        txtaudcourse.Text = ""
        txtaudyear.Text = ""
        txtaudparty.Text = ""
        txtaudcam.Text = ""
        pbaud.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnauditor.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'PRO
    Private Sub cbproname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproname.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbproname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtprocourse.Text = READER.GetString("Course")
                txtproyear.Text = READER.GetString("Year")
                txtproparty.Text = READER.GetString("Party")
                txtprocam.Text = READER.GetString("Campaign")
                txtprovote.Text = READER.GetInt32("Votes")
                txtprocv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnpro.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbproname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbpro.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnprocancel_Click(sender As Object, e As EventArgs) Handles btnprocancel.Click
        cbproname.Text = "NONE"
        txtprocourse.Text = ""
        txtproyear.Text = ""
        txtproparty.Text = ""
        txtprocam.Text = ""
        pbpro.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnpro.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'MUSE
    Private Sub cbmusename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmusename.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbmusename.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtmusecourse.Text = READER.GetString("Course")
                txtmuseyear.Text = READER.GetString("Year")
                txtmuseparty.Text = READER.GetString("Party")
                txtmusecam.Text = READER.GetString("Campaign")
                txtmusevote.Text = READER.GetInt32("Votes")
                txtmusecv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnmuse.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbmusename.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbmuse.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnmusecancel_Click(sender As Object, e As EventArgs) Handles btnmusecancel.Click
        cbmusename.Text = "NONE"
        txtmusecourse.Text = ""
        txtmuseyear.Text = ""
        txtmuseparty.Text = ""
        txtmusecam.Text = ""
        pbmuse.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnmuse.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    'ESCORT
    Private Sub cbescortname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbescortname.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.candidates where Name='" & cbescortname.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtescortcourse.Text = READER.GetString("Course")
                txtescortyear.Text = READER.GetString("Year")
                txtescortparty.Text = READER.GetString("Party")
                txtescortcam.Text = READER.GetString("Campaign")
                txtescortvote.Text = READER.GetInt32("Votes")
                txtescortcv.Text = READER.GetInt32(lblcourse.Text)
            End While

            btnescort.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & cbescortname.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbescort.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnescortcancel_Click(sender As Object, e As EventArgs) Handles btnescortcancel.Click
        cbescortname.Text = "NONE"
        txtescortcourse.Text = ""
        txtescortyear.Text = ""
        txtescortparty.Text = ""
        txtescortcam.Text = ""
        pbescort.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
        btnescort.Iconimage = CSTGvotingsystem.My.Resources.user
    End Sub

    Private Sub btnpres_Click(sender As Object, e As EventArgs) Handles btnpres.Click
        pnlparty.Visible = False
        pnlpres.Visible = True
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btnvice_Click(sender As Object, e As EventArgs) Handles btnvice.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = True
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btnsecretary_Click(sender As Object, e As EventArgs) Handles btnsecretary.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = True
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btntreasurer_Click(sender As Object, e As EventArgs) Handles btntreasurer.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = True
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btnauditor_Click(sender As Object, e As EventArgs) Handles btnauditor.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = True
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btnpro_Click(sender As Object, e As EventArgs) Handles btnpro.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = True
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    Private Sub btnmuse_Click(sender As Object, e As EventArgs) Handles btnmuse.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = True
        pnlescort.Visible = False
    End Sub

    Private Sub btnescort_Click(sender As Object, e As EventArgs) Handles btnescort.Click
        pnlparty.Visible = False
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = True
    End Sub

    Private Sub btnvote_Click(sender As Object, e As EventArgs) Handles btnvote.Click
        Dim OBJ As New frmvotingballot
        OBJ.Presname = cbpresname.Text
        OBJ.Vicename = cbvicename.Text
        OBJ.Secname = cbsecname.Text
        OBJ.Trename = cbtrename.Text
        OBJ.Audname = cbaudname.Text
        OBJ.Proname = cbproname.Text
        OBJ.Musename = cbmusename.Text
        OBJ.Escortname = cbescortname.Text

        OBJ.Presvote = txtpresvote.Text
        OBJ.Vicevote = txtvicevote.Text
        OBJ.Secvote = txtsecvote.Text
        OBJ.Trevote = txttrevote.Text
        OBJ.Audvote = txtaudvote.Text
        OBJ.Provote = txtprovote.Text
        OBJ.Musevote = txtmusevote.Text
        OBJ.Escortvote = txtescortvote.Text

        OBJ.Prescv = txtprescv.Text
        OBJ.Vicecv = txtvicecv.Text
        OBJ.Seccv = txtseccv.Text
        OBJ.Trecv = txttrecv.Text
        OBJ.Audcv = txtaudcv.Text
        OBJ.Procv = txtprocv.Text
        OBJ.Musecv = txtmusecv.Text
        OBJ.Escortcv = txtescortcv.Text

        OBJ.Studnum = lblstudnum.Text
        OBJ.Course = lblcourse.Text
        OBJ.ShowDialog()
        loadstudinfo()
    End Sub

    Private Sub btnparty_Click(sender As Object, e As EventArgs) Handles btnparty.Click
        pnlparty.Visible = True
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltre.Visible = False
        pnlaud.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False
    End Sub

    'PARTYLIST
    Private Sub cbparty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbparty.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.partylist where Name='" & cbparty.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtpartydesc.Text = READER.GetString("Description")
                txtpartycam.Text = READER.GetString("Campaign")
            End While

            btnpres.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnvice.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnsecretary.Iconimage = CSTGvotingsystem.My.Resources.checked
            btntreasurer.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnauditor.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnpro.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnmuse.Iconimage = CSTGvotingsystem.My.Resources.checked
            btnescort.Iconimage = CSTGvotingsystem.My.Resources.checked

            MysqlConn.Close()

            'MEMBER PRESIDENT
            MysqlConn.Open()
            Dim Query1 As String
            Query1 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='President'"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblpresM.Text = READER.GetString("Name")
            End While
            cbpresname.Text = lblpresM.Text
            MysqlConn.Close()

            'MEMBER VICE PRESIDENT
            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Vice_President'"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblviceM.Text = READER.GetString("Name")
            End While
            cbvicename.Text = lblviceM.Text
            MysqlConn.Close()

            'MEMBER SECRETARY
            MysqlConn.Open()
            Dim Query3 As String
            Query3 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Secretary'"
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblsecM.Text = READER.GetString("Name")
            End While
            cbsecname.Text = lblsecM.Text
            MysqlConn.Close()

            'MEMBER TREASURER
            MysqlConn.Open()
            Dim Query4 As String
            Query4 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Treasurer'"
            COMMAND = New MySqlCommand(Query4, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lbltreM.Text = READER.GetString("Name")
            End While
            cbtrename.Text = lbltreM.Text
            MysqlConn.Close()

            'MEMBER AUDITOR
            MysqlConn.Open()
            Dim Query5 As String
            Query5 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Auditor'"
            COMMAND = New MySqlCommand(Query5, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblaudM.Text = READER.GetString("Name")
            End While
            cbaudname.Text = lblaudM.Text
            MysqlConn.Close()

            'MEMBER P.R.O
            MysqlConn.Open()
            Dim Query6 As String
            Query6 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='PRO'"
            COMMAND = New MySqlCommand(Query6, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblproM.Text = READER.GetString("Name")
            End While
            cbproname.Text = lblproM.Text
            MysqlConn.Close()

            'MEMBER MUSE
            MysqlConn.Open()
            Dim Query7 As String
            Query7 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Muse'"
            COMMAND = New MySqlCommand(Query7, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblmuseM.Text = READER.GetString("Name")
            End While
            cbmusename.Text = lblmuseM.Text
            MysqlConn.Close()

            'MEMBER ESCORT
            MysqlConn.Open()
            Dim Query8 As String
            Query8 = "select * from cstgdb.candidates where Party='" & cbparty.Text & "' and Position='Escort'"
            COMMAND = New MySqlCommand(Query8, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                lblescortM.Text = READER.GetString("Name")
            End While
            cbescortname.Text = lblescortM.Text
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        pnlabout.Visible = True
        pnlmember.Visible = False
    End Sub

    Private Sub btnmembers_Click(sender As Object, e As EventArgs) Handles btnmembers.Click
        pnlabout.Visible = False
        pnlmember.Visible = True
    End Sub

    Private Sub partycancel_Click(sender As Object, e As EventArgs) Handles partycancel.Click

        cbparty.Text = "NONE"
        txtpartydesc.Text = ""
        txtpartycam.Text = ""

        lblpresM.Text = "NONE"
        lblviceM.Text = "NONE"
        lblsecM.Text = "NONE"
        lbltreM.Text = "NONE"
        lblaudM.Text = "NONE"
        lblproM.Text = "NONE"
        lblmuseM.Text = "NONE"
        lblescortM.Text = "NONE"

        btnpres.Iconimage = CSTGvotingsystem.My.Resources.user
        btnvice.Iconimage = CSTGvotingsystem.My.Resources.user
        btnsecretary.Iconimage = CSTGvotingsystem.My.Resources.user
        btntreasurer.Iconimage = CSTGvotingsystem.My.Resources.user
        btnauditor.Iconimage = CSTGvotingsystem.My.Resources.user
        btnpro.Iconimage = CSTGvotingsystem.My.Resources.user
        btnmuse.Iconimage = CSTGvotingsystem.My.Resources.user
        btnescort.Iconimage = CSTGvotingsystem.My.Resources.user

        cbpresname.Text = "NONE"
        txtprescourse.Text = ""
        txtpresyear.Text = ""
        txtpresparty.Text = ""
        txtprescam.Text = ""
        pbpres.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbvicename.Text = "NONE"
        txtvicecourse.Text = ""
        txtviceyear.Text = ""
        txtviceparty.Text = ""
        txtvicecam.Text = ""
        pbvice.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbsecname.Text = "NONE"
        txtseccourse.Text = ""
        txtsecyear.Text = ""
        txtsecparty.Text = ""
        txtseccam.Text = ""
        pbsec.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbtrename.Text = "NONE"
        txttrecourse.Text = ""
        txttreyear.Text = ""
        txttreparty.Text = ""
        txttrecam.Text = ""
        pbtre.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbaudname.Text = "NONE"
        txtaudcourse.Text = ""
        txtaudyear.Text = ""
        txtaudparty.Text = ""
        txtaudcam.Text = ""
        pbaud.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbproname.Text = "NONE"
        txtprocourse.Text = ""
        txtproyear.Text = ""
        txtproparty.Text = ""
        txtprocam.Text = ""
        pbpro.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbmusename.Text = "NONE"
        txtmusecourse.Text = ""
        txtmuseyear.Text = ""
        txtmuseparty.Text = ""
        txtmusecam.Text = ""
        pbmuse.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate

        cbescortname.Text = "NONE"
        txtescortcourse.Text = ""
        txtescortyear.Text = ""
        txtescortparty.Text = ""
        txtescortcam.Text = ""
        pbescort.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub
End Class