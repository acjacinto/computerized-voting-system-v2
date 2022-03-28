Imports MySql.Data.MySqlClient



Public Class frmlogin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Clear in frmlogin
    Sub clear()
        txtsstudnum.Text = ""
        lblfname.Text = ""
        lbllname.Text = ""
        lblcourse.Text = ""
        lblyear.Text = ""
        txtspass.Text = ""
        btngen.Visible = False
        btngen.Enabled = False
        txtspass.Enabled = False
        pnlsignup.Visible = False
    End Sub

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.studentaccount where StudentNumber='" & txtstudnum.Text & "' and password ='" & txtpass.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                txtstudstatus.Text = READER.GetString("Status")
            End While

            If count = 1 Then
                If txtstudstatus.Text = "Not_Voted" Then
                    Dim OBJ As New studentvotingform
                    OBJ.StringPass = txtstudnum.Text
                    OBJ.Show()
                    txtstudnum.Text = ""
                    txtpass.Text = ""
                    txtstudnum.Select()
                    Me.Hide()
                Else
                    MessageBox.Show("You have already Voted")
                    txtstudnum.Text = ""
                    txtpass.Text = ""
                    txtstudnum.Select()
                End If

            Else
                    MessageBox.Show("Incorrect combination of username or password")
            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub

    Private Sub lblsignup_Click(sender As Object, e As EventArgs) Handles lblsignup.Click
        pnlsignup.Visible = True
    End Sub

    Private Sub lblsignin_Click_1(sender As Object, e As EventArgs) Handles lblsignin.Click
        clear()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        If (txtsstudnum.Text <> "" And lblfname.Text <> "") Then
            Try
                If rbgen.Checked Then
                    txtbox.Text = lblgen2.Text
                Else
                    txtbox.Text = txtspass.Text
                End If

                MysqlConn.Open()
                Dim Query As String
                Query = "update cstgdb.studentaccount set Password='" & txtbox.Text & "' where StudentNumber='" & txtsstudnum.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Successfully Updated")
                MysqlConn.Close()
                clear()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            MessageBox.Show("You can't leave the fields empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnshowpass_Click(sender As Object, e As EventArgs) Handles btnshowpass.Click

        If txtpass.PasswordChar = "•" Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "•"
        End If

    End Sub

    Private Sub pblogo_Click(sender As Object, e As EventArgs) Handles pblogo.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.admin where Username='" & txtstudnum.Text & "' and Password ='" & txtpass.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                frmadmin.ShowDialog()
            Else
                MessageBox.Show("Incorrect combination of username or password")
            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub rbgen_CheckedChanged(sender As Object, e As EventArgs)
        btngen.Enabled = rbgen.Checked
    End Sub

    Private Sub btngen_Click_1(sender As Object, e As EventArgs) Handles btngen.Click
        Dim rn As New Random
        lblgen2.Text = (rn.Next(1000, 10000))
    End Sub

    Private Sub txtsstudnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsstudnum.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnverify_Click(sender As Object, e As EventArgs) Handles btnverify.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=;database=cstgdb"
        Dim READER As MySqlDataReader
        Dim pass As String

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cstgdb.studentaccount where StudentNumber = '" & txtsstudnum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            If txtsstudnum.Text <> "" Then

                Dim count As Integer
                    count = 0

                    While READER.Read
                        count = count + 1
                        lblfname.Text = READER.GetString("Name")
                        lbllname.Text = READER.GetString("Surname")
                        lblcourse.Text = READER.GetString("Course")
                        lblyear.Text = READER.GetString("Year")
                        txtvpass.Text = READER.GetString("Password")
                    End While

                If count = 1 Then
                    If txtvpass.Text = " " Then
                        btngen.Visible = True
                    Else
                        btnsignup.Enabled = False
                        rbgen.Enabled = False
                        rbpass.Enabled = False
                        Dim mb = MessageBox.Show("Do you want to update your password?", "Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If mb = Windows.Forms.DialogResult.Yes Then
                            pass = InputBox("Type old password", "Conformation")
                            If pass = txtvpass.Text Then
                                btnsignup.Enabled = True
                                rbgen.Enabled = True
                                rbpass.Enabled = True
                            End If
                        End If
                    End If

                Else
                        MessageBox.Show("No records found")
                End If
            Else
                MessageBox.Show("Please put your student number to verify")
            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub rbgen_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbgen.CheckedChanged
        btngen.Enabled = rbgen.Checked
        txtbox.Text = lblgen2.Text
        txtspass.Text = ""
    End Sub

    Private Sub rbpass_CheckedChanged(sender As Object, e As EventArgs) Handles rbpass.CheckedChanged
        txtspass.Enabled = rbpass.Checked
        txtbox.Text = txtspass.Text
        lblgen2.Text = "0000"
    End Sub

    Private Sub btnshowpass2_Click_1(sender As Object, e As EventArgs) Handles btnshowpass2.Click
        If txtspass.PasswordChar = "•" Then
            txtspass.PasswordChar = ""
        Else
            txtspass.PasswordChar = "•"
        End If
    End Sub
End Class
