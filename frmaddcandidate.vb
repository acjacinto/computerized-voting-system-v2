Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO

Public Class frmaddcandidate
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim pos As Integer = 0

    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlClient.MySqlDataReader

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub frmaddcandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=cstgdb;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try

        'Load Procedures
        loadPresTable()
        loadViceTable()
        loadSecTable()
        loadTreTable()
        loadAudTable()
        loadProTable()
        loadMuseTable()
        loadEscortTable()

        'POPULATE COMBOBOX PARTY
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.partylist"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim party = READER.GetString("Name")
                cbpresparty.Items.Add(party)
                cbviceparty.Items.Add(party)
                cbsecparty.Items.Add(party)
                cbtreparty.Items.Add(party)
                cbaudparty.Items.Add(party)
                cbproparty.Items.Add(party)
                cbmuseparty.Items.Add(party)
                cbescortparty.Items.Add(party)
            End While
            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'LOAD PRESIDENT & CLEAR
    Private Sub loadPresTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'President'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgpres.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearPres()
        txtpresname.Text = ""
        txtprescam.Text = ""
        cbprescourse.Text = "BSCS"
        cbpresyear.Text = "2"
        cbpresparty.Text = "NONE"
        pbpres.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD VICE PRESIDENT & CLEAR
    Private Sub loadViceTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Vice_President'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvice.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearVice()
        txtvicename.Text = ""
        txtvicecam.Text = ""
        cbvicecourse.Text = "BSCS"
        cbviceyear.Text = "2"
        cbviceparty.Text = "NONE"
        pbvice.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD SECRETARY & CLEAR
    Private Sub loadSecTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Secretary'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgsec.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearSec()
        txtsecname.Text = ""
        txtseccam.Text = ""
        cbseccourse.Text = "BSCS"
        cbsecyear.Text = "1"
        cbsecparty.Text = "NONE"
        pbsec.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD TREASURER & CLEAR
    Private Sub loadTreTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Treasurer'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgtre.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearTre()
        txttrename.Text = ""
        txttrecam.Text = ""
        cbtrecourse.Text = "BSCS"
        cbtreyear.Text = "1"
        cbtreparty.Text = "NONE"
        pbtre.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD AUDITOR & CLEAR
    Private Sub loadAudTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Auditor'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgaud.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearAud()
        txtaudname.Text = ""
        txtaudcam.Text = ""
        cbaudcourse.Text = "BSCS"
        cbaudyear.Text = "1"
        cbaudparty.Text = "NONE"
        pbaud.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD P.R.O & CLEAR
    Private Sub loadProTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'PRO'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgpro.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearPro()
        txtproname.Text = ""
        txtprocam.Text = ""
        cbprocourse.Text = "BSCS"
        cbproyear.Text = "1"
        cbproparty.Text = "NONE"
        pbpro.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD MUSE & CLEAR
    Private Sub loadMuseTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Muse'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgmuse.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearMuse()
        txtmusename.Text = ""
        txtmusecam.Text = ""
        cbmusecourse.Text = "BSCS"
        cbmuseyear.Text = "1"
        cbmuseparty.Text = "NONE"
        pbmuse.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'LOAD ESCORT & CLEAR
    Private Sub loadEscortTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Course,Year,Position,Votes,party from cstgdb.candidates where Position = 'Escort'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgescort.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clearEscort()
        txtescortname.Text = ""
        txtescortcam.Text = ""
        cbescortcourse.Text = "BSCS"
        cbescortyear.Text = "1"
        cbescortparty.Text = "NONE"
        pbescort.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    'PRESIDENT
    Private Sub btnpresS_Click(sender As Object, e As EventArgs) Handles btnpresS.Click

        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbpres.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtpresname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtpresname.Text)
                sql_command.Parameters.AddWithValue("@pos", "President")
                sql_command.Parameters.AddWithValue("@cam", txtprescam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbpresparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbprescourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbpresyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadPresTable()
                clearPres()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbpres_Click(sender As Object, e As EventArgs) Handles pbpres.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbpres.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnpresC_Click(sender As Object, e As EventArgs) Handles btnpresC.Click
        clearPres()
    End Sub

    'VICE PRESIDENT
    Private Sub btnviceS_Click(sender As Object, e As EventArgs) Handles btnviceS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbvice.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtvicename.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtvicename.Text)
                sql_command.Parameters.AddWithValue("@pos", "Vice_President")
                sql_command.Parameters.AddWithValue("@cam", txtvicecam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbviceparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbvicecourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbviceyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadViceTable()
                clearVice()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbvice_Click(sender As Object, e As EventArgs) Handles pbvice.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbvice.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnviceC_Click(sender As Object, e As EventArgs) Handles btnviceC.Click
        clearVice()
    End Sub

    'SECRETARY
    Private Sub btnsecS_Click(sender As Object, e As EventArgs) Handles btnsecS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbsec.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtsecname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtsecname.Text)
                sql_command.Parameters.AddWithValue("@pos", "Secretary")
                sql_command.Parameters.AddWithValue("@cam", txtseccam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbsecparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbseccourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbsecyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadSecTable()
                clearSec()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbsec_Click(sender As Object, e As EventArgs) Handles pbsec.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbsec.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnsecC_Click(sender As Object, e As EventArgs) Handles btnsecC.Click
        clearSec()
    End Sub

    'TREASURER
    Private Sub btntreS_Click(sender As Object, e As EventArgs) Handles btntreS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbtre.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txttrename.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txttrename.Text)
                sql_command.Parameters.AddWithValue("@pos", "Treasurer")
                sql_command.Parameters.AddWithValue("@cam", txttrecam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbtreparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbtrecourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbtreyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadTreTable()
                clearTre()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbtre_Click(sender As Object, e As EventArgs) Handles pbtre.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbtre.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btntreC_Click(sender As Object, e As EventArgs) Handles btntreC.Click
        clearTre()
    End Sub

    Private Sub btnaudS_Click(sender As Object, e As EventArgs) Handles btnaudS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbaud.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtaudname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtaudname.Text)
                sql_command.Parameters.AddWithValue("@pos", "Auditor")
                sql_command.Parameters.AddWithValue("@cam", txtaudcam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbaudparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbaudcourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbaudyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadAudTable()
                clearAud()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbaud_Click(sender As Object, e As EventArgs) Handles pbaud.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbaud.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnaudC_Click(sender As Object, e As EventArgs) Handles btnaudC.Click
        clearAud()
    End Sub

    Private Sub btnproS_Click(sender As Object, e As EventArgs) Handles btnproS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbpro.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtproname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtproname.Text)
                sql_command.Parameters.AddWithValue("@pos", "PRO")
                sql_command.Parameters.AddWithValue("@cam", txtprocam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbproparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbprocourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbproyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadProTable()
                clearPro()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbpro_Click(sender As Object, e As EventArgs) Handles pbpro.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbpro.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnproC_Click(sender As Object, e As EventArgs) Handles btnproC.Click
        clearPro()
    End Sub

    Private Sub btnmuseS_Click(sender As Object, e As EventArgs) Handles btnmuseS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbmuse.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtmusename.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtmusename.Text)
                sql_command.Parameters.AddWithValue("@pos", "Muse")
                sql_command.Parameters.AddWithValue("@cam", txtmusecam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbmuseparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbmusecourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbmuseyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadMuseTable()
                clearMuse()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbmuse_Click(sender As Object, e As EventArgs) Handles pbmuse.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbmuse.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnmuseC_Click(sender As Object, e As EventArgs) Handles btnmuseC.Click
        clearMuse()
    End Sub

    Private Sub btnescortS_Click(sender As Object, e As EventArgs) Handles btnescortS.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbescort.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try

            If (txtescortname.Text = "") Then
                MessageBox.Show("You cant leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "INSERT INTO candidates (Name,Position,Campaign,Image,Votes,Party,Course,Year,BSCS,BSCT) VALUES (@name,@pos,@cam,@image,@votes,@party,@course,@year,@bscs,@bsct)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@name", txtescortname.Text)
                sql_command.Parameters.AddWithValue("@pos", "Escort")
                sql_command.Parameters.AddWithValue("@cam", txtescortcam.Text)
                sql_command.Parameters.AddWithValue("@image", arrImage)
                sql_command.Parameters.AddWithValue("@votes", 0)
                sql_command.Parameters.AddWithValue("@party", cbescortparty.Text)
                sql_command.Parameters.AddWithValue("@course", cbescortcourse.Text)
                sql_command.Parameters.AddWithValue("@year", cbescortyear.Text)
                sql_command.Parameters.AddWithValue("@bscs", 0)
                sql_command.Parameters.AddWithValue("@bsct", 0)

                MessageBox.Show("Candidate insert successfully")
                sql_command.ExecuteNonQuery()
                loadEscortTable()
                clearEscort()

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub pbescort_Click(sender As Object, e As EventArgs) Handles pbescort.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pbescort.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnescortC_Click(sender As Object, e As EventArgs) Handles btnescortC.Click
        clearEscort()
    End Sub

    'BUTTONS
    Private Sub btnpres_Click(sender As Object, e As EventArgs) Handles btnpres.Click
        pnlpres.Visible = True
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadPresTable()

    End Sub

    Private Sub btnvice_Click(sender As Object, e As EventArgs) Handles btnvice.Click
        pnlpres.Visible = False
        pnlvice.Visible = True
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadViceTable()

    End Sub

    Private Sub btnsecretary_Click(sender As Object, e As EventArgs) Handles btnsecretary.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = True
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadSecTable()

    End Sub

    Private Sub btntreasurer_Click(sender As Object, e As EventArgs) Handles btntreasurer.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = True
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadTreTable()

    End Sub

    Private Sub btnauditor_Click(sender As Object, e As EventArgs) Handles btnauditor.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = True
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadAudTable()

    End Sub

    Private Sub btnpro_Click(sender As Object, e As EventArgs) Handles btnpro.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = True
        pnlmuse.Visible = False
        pnlescort.Visible = False

        loadProTable()

    End Sub

    Private Sub btnmuse_Click(sender As Object, e As EventArgs) Handles btnmuse.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = True
        pnlescort.Visible = False

        loadMuseTable()

    End Sub

    Private Sub btnescort_Click(sender As Object, e As EventArgs) Handles btnescort.Click
        pnlpres.Visible = False
        pnlvice.Visible = False
        pnlsec.Visible = False
        pnltreasurer.Visible = False
        pnlauditor.Visible = False
        pnlpro.Visible = False
        pnlmuse.Visible = False
        pnlescort.Visible = True

        loadEscortTable()

    End Sub
End Class