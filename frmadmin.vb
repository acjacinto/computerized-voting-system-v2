Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO

Public Class frmadmin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim pos As Integer = 0

    Dim sql As String
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_reader As MySqlClient.MySqlDataReader
    Dim dbDataSet As New DataTable

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim mb = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If mb = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else

        End If

    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        loadAdmin()

        pnladmin.Visible = True
        pnlcandidates.Visible = False
        pnlvotes.Visible = False
        pnlparty.Visible = False
    End Sub

    Private Sub frmadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcandidatestable()
        loadVotersTable()
        loadAdmin()
        loadPartyTable()

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=cstgdb;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try
    End Sub

    Private Sub getCandidatePic()
        Dim arrImage() As Byte
        Try
            sql = "SELECT * FROM candidates WHERE Name = '" & lblnamecandid.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_reader = sql_command.ExecuteReader()
            sql_reader.Read()
            arrImage = sql_reader.Item("image")
            Dim mstream As New System.IO.MemoryStream(arrImage)
            pbcandid.BackgroundImage = Image.FromStream(mstream)
            sql_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub loadcandidatestable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select image,Name,Position,Votes,party from cstgdb.candidates"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgcandid.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btncandidates_Click(sender As Object, e As EventArgs) Handles btncandidates.Click
        pnlcandidates.Visible = True
        pnladmin.Visible = False
        pnlvotes.Visible = False
        pnlparty.Visible = False
        loadcandidatestable()
    End Sub

    Private Sub dgcandid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcandid.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgcandid.Rows(index)


        lblnamecandid.Text = selectedRow.Cells(1).Value.ToString()
        lblpositioncandid.Text = selectedRow.Cells(2).Value.ToString()
        lblvotescandid.Text = selectedRow.Cells(3).Value.ToString()
        lblpartycandid.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub dgcandid_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgcandid.CellDoubleClick
        Dim OBJ As New frmcandidates
        OBJ.StringPass = lblnamecandid.Text
        OBJ.Show()
    End Sub

    Private Sub dgcandid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcandid.CellContentClick
        getCandidatePic()
    End Sub

    Private Sub btnaddcandid_Click(sender As Object, e As EventArgs) Handles btnaddcandid.Click
        frmaddcandidate.ShowDialog()
    End Sub

    Private Sub clearCandid()
        lblnamecandid.Text = ""
        lblpositioncandid.Text = ""
        lblvotescandid.Text = "0"
        lblpartycandid.Text = "NONE"
        pbcandid.BackgroundImage = CSTGvotingsystem.My.Resources.addcandidate
    End Sub

    Private Sub btnremovecandid_Click(sender As Object, e As EventArgs) Handles btnremovecandid.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim mb = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Try

            If mb = Windows.Forms.DialogResult.Yes Then
                MysqlConn.Open()
                Dim Query As String

                Query = "delete from cstgdb.candidates where Name='" & lblnamecandid.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MessageBox.Show("Successfully deleted")
                    MysqlConn.Close()

                End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        loadcandidatestable()
        clearCandid()
    End Sub

    Private Sub btnvoters_Click(sender As Object, e As EventArgs) Handles btnvoters.Click
        pnlvotes.Visible = True
        pnladmin.Visible = False
        pnlcandidates.Visible = False
        pnlparty.Visible = False

        loadVotersTable()

    End Sub

    Private Sub loadVotersTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select StudentNumber as 'Student_No',Name,Surname,Course,Year,Status from cstgdb.studentaccount"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvoters.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnadmininfo_Click(sender As Object, e As EventArgs) Handles btnadmininfo.Click
        btnadmininfo.Visible = False
        btnadmininfoC.Visible = True
        btnadmininfoS.Visible = True
        btnadmininfoC.Enabled = True
        btnadmininfoS.Enabled = True
        pbinfo.Visible = True
        lblinfo.Visible = True
        pnlinfo.Visible = True

        btnadmininfoA.Visible = True
        btnadminaccountA.Visible = False
        btnadminaccount.Visible = True

        btnadminaccountC.Visible = False
        btnadminaccountS.Visible = False
        btnadminaccountC.Enabled = False
        btnadminaccountS.Enabled = False
        pbaccount.Visible = False
        lblaccount.Visible = False
        pnlaccount.Visible = False
    End Sub

    Private Sub btnadminaccount_Click(sender As Object, e As EventArgs) Handles btnadminaccount.Click
        btnadminaccount.Visible = False
        btnadminaccountC.Visible = True
        btnadminaccountS.Visible = True
        btnadminaccountC.Enabled = True
        btnadminaccountS.Enabled = True
        pbaccount.Visible = True
        lblaccount.Visible = True
        pnlaccount.Visible = True

        btnadminaccountA.Visible = True
        btnadmininfoA.Visible = False
        btnadmininfo.Visible = True

        btnadmininfoC.Visible = False
        btnadmininfoS.Visible = False
        btnadmininfoC.Enabled = False
        btnadmininfoS.Enabled = False
        pbinfo.Visible = False
        lblinfo.Visible = False
        pnlinfo.Visible = False
    End Sub

    Private Sub btnadmincancel_Click(sender As Object, e As EventArgs) Handles btnadmincancel.Click
        loadAdmin()
        pbinfo.Visible = True
        lblinfo.Visible = True

        pbaccount.Visible = False
        lblaccount.Visible = False

        btnadmininfoC.Enabled = True
        btnadmininfoS.Enabled = True
        btnadmininfoC.Visible = True
        btnadmininfoS.Visible = True

        btnadminaccountC.Enabled = False
        btnadminaccountS.Enabled = False
        btnadminaccountC.Visible = False
        btnadminaccountS.Visible = False

        btnadmininfoA.Visible = True
        btnadminaccountA.Visible = False
        pnlinfo.Visible = True

        btnadmininfo.Visible = False
        btnadminaccount.Visible = True
        pnlaccount.Visible = False

    End Sub

    Private Sub btnadmininfoC_Click(sender As Object, e As EventArgs) Handles btnadmininfoC.Click
        txtadminfname.Text = ""
        txtadminlname.Text = ""
    End Sub

    Private Sub btnadmininfoS_Click(sender As Object, e As EventArgs) Handles btnadmininfoS.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim pass As String

        If (txtadminfname.Text <> "" And txtadminlname.Text <> "") Then
            pass = InputBox("Type old password", "Conformation")
            If pass = txtadminconfirm.Text Then
                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "update cstgdb.admin set fname='" & txtadminfname.Text & "',lname='" & txtadminlname.Text & "' where id='1'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Successfully Updated")
                    loadAdmin()
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
                MessageBox.Show("Old password doesn't match", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
                MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnadminshowpass_Click(sender As Object, e As EventArgs) Handles btnadminshowpass.Click
        If txtadminpass.PasswordChar = "•" Then
            txtadminpass.PasswordChar = ""
        Else
            txtadminpass.PasswordChar = "•"
        End If
    End Sub

    Private Sub btnadminaccountC_Click(sender As Object, e As EventArgs) Handles btnadminaccountC.Click
        txtadminuname.Text = ""
        txtadminpass.Text = ""
    End Sub

    Private Sub btnadminaccountS_Click(sender As Object, e As EventArgs) Handles btnadminaccountS.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim pass As String

        If (txtadminuname.Text <> "" And txtadminpass.Text <> "") Then
            pass = InputBox("Type old password", "Conformation")
            If pass = txtadminconfirm.Text Then


                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "update cstgdb.admin set Username='" & txtadminuname.Text & "',Password='" & txtadminpass.Text & "' where id='1'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Username and password successfully Updated")
                    loadAdmin()
                    btnadminshowpass.Enabled = True
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
                MessageBox.Show("Old password doesn't match", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub loadAdmin()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.admin where id = '1'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                txtadminfname.Text = READER.GetString("fname")
                txtadminlname.Text = READER.GetString("lname")
                txtadminuname.Text = READER.GetString("Username")
                txtadminpass.Text = READER.GetString("Password")
                txtadminconfirm.Text = READER.GetString("Password")
            End While


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnparty_Click(sender As Object, e As EventArgs) Handles btnparty.Click
        pnladmin.Visible = False
        pnlcandidates.Visible = False
        pnlvotes.Visible = False
        pnlparty.Visible = True
        loadPartyTable()
    End Sub

    Private Sub btnpartynew_Click(sender As Object, e As EventArgs) Handles btnpartynew.Click
        btnpartysave.Enabled = True
        partyClear()
        txtpartyname.Enabled = True
    End Sub
    Private Sub partyClear()
        txtpartycam.Text = ""
        txtpartyname.Text = ""
        txtpartydesc.Text = ""
        txtpartysy.Text = ""
    End Sub

    Private Sub btnpartysave_Click(sender As Object, e As EventArgs) Handles btnpartysave.Click
        btnpartysave.Enabled = False
        txtpartyname.Enabled = False

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        If (txtpartyname.Text <> "") Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into cstgdb.partylist (Name,Description,sy,campaign) values ('" & txtpartyname.Text & "', '" & txtpartydesc.Text & "','" & txtpartysy.Text & "','" & txtpartycam.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Successfully added")
                loadPartyTable()
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub loadPartyTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Name,Description,SY,Campaign from cstgdb.partylist"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgparty.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnpartyupdate_Click(sender As Object, e As EventArgs) Handles btnpartyupdate.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        If (txtadminuname.Text <> "" And txtadminpass.Text <> "") Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update cstgdb.partylist set Description='" & txtpartydesc.Text & "',sy='" & txtpartysy.Text & "',campaign='" & txtpartycam.Text & "' where Name='" & txtpartyname.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Party successfully Updated")
                loadPartyTable()
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnpartyremove_Click(sender As Object, e As EventArgs) Handles btnpartyremove.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim mb = MessageBox.Show("Are you sure you want to delete " & txtpartyname.Text & " Party?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Try

            If mb = Windows.Forms.DialogResult.Yes Then
                MysqlConn.Open()
                Dim Query As String

                If (txtpartyname.Text <> "") Then
                    Query = "delete from cstgdb.partylist where Name='" & txtpartyname.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MessageBox.Show("Successfully deleted")
                    MysqlConn.Close()
                Else
                    MessageBox.Show("Select a party to remove.")
                End If

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        loadPartyTable()
        partyClear()
    End Sub

    Private Sub dgparty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgparty.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgparty.Rows(index)
        txtpartyname.Text = selectedRow.Cells(0).Value.ToString()
        txtpartydesc.Text = selectedRow.Cells(1).Value.ToString()
        txtpartysy.Text = selectedRow.Cells(2).Value.ToString()
        txtpartycam.Text = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub dgvoters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvoters.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvoters.Rows(index)
        lblstudnum.Text = selectedRow.Cells(0).Value.ToString()
        lblstudfname.Text = selectedRow.Cells(1).Value.ToString()
        lblstudlname.Text = selectedRow.Cells(2).Value.ToString()
        lblstudcourse.Text = selectedRow.Cells(3).Value.ToString()
        lblstudyear.Text = selectedRow.Cells(4).Value.ToString()
        lblstudstatus.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnvotersadd_Click(sender As Object, e As EventArgs) Handles btnvotersadd.Click
        frmaddvoters.ShowDialog()
        loadVotersTable()
    End Sub

    Private Sub votersClear()
        lblstudnum.Text = "000000"
        lblstudfname.Text = "------------"
        lblstudlname.Text = "------------"
        lblstudcourse.Text = "BSC*"
        lblstudyear.Text = "0"
        lblstudstatus.Text = "-------"
    End Sub

    Private Sub btnremovevoters_Click(sender As Object, e As EventArgs) Handles btnremovevoters.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim mb = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Try

            If mb = Windows.Forms.DialogResult.Yes Then
                MysqlConn.Open()
                Dim Query As String

                If (lblstudnum.Text <> "000000") Then
                    Query = "delete from cstgdb.studentaccount where StudentNumber='" & lblstudnum.Text & "'"
                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MessageBox.Show("Successfully deleted")

                    MysqlConn.Close()
                Else
                    MessageBox.Show("Select a student to remove.")
                End If

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        loadVotersTable()
        votersClear()
    End Sub

    Private Sub txtstudnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstudnum.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtstudnum_TextChanged(sender As Object, e As EventArgs) Handles txtstudnum.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Student_No like '%{0}%'", txtstudnum.Text)
        dgvoters.DataSource = DV
    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Surname like '%{0}%'", txtlastname.Text)
        dgvoters.DataSource = DV
    End Sub

    Private Sub cbstudcourse_TextChanged(sender As Object, e As EventArgs) Handles cbstudcourse.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Course like '%{0}%'", cbstudcourse.Text)
        dgvoters.DataSource = DV
    End Sub

    Private Sub cbstudyear_TextChanged(sender As Object, e As EventArgs) Handles cbstudyear.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Year like '%{0}%'", cbstudyear.Text)
        dgvoters.DataSource = DV
    End Sub

    Private Sub cbstudstatus_TextChanged(sender As Object, e As EventArgs) Handles cbstudstatus.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Status like '%{0}%'", cbstudstatus.Text)
        dgvoters.DataSource = DV
    End Sub
End Class