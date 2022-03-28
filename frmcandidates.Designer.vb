<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcandidates
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcandidates))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlsignup = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.cbcourse = New System.Windows.Forms.ComboBox()
        Me.lblparty = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.pbcandid = New System.Windows.Forms.PictureBox()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.btnback = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcam = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtage = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btncancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlsignup.SuspendLayout()
        CType(Me.pbcandid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnlsignup
        '
        Me.pnlsignup.BackColor = System.Drawing.Color.Transparent
        Me.pnlsignup.BackgroundImage = CType(resources.GetObject("pnlsignup.BackgroundImage"), System.Drawing.Image)
        Me.pnlsignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlsignup.Controls.Add(Me.cbcourse)
        Me.pnlsignup.Controls.Add(Me.lblparty)
        Me.pnlsignup.Controls.Add(Me.Label4)
        Me.pnlsignup.Controls.Add(Me.Label2)
        Me.pnlsignup.Controls.Add(Me.cbgender)
        Me.pnlsignup.Controls.Add(Me.pbcandid)
        Me.pnlsignup.Controls.Add(Me.lblposition)
        Me.pnlsignup.Controls.Add(Me.btnback)
        Me.pnlsignup.Controls.Add(Me.Label6)
        Me.pnlsignup.Controls.Add(Me.Label7)
        Me.pnlsignup.Controls.Add(Me.txtcam)
        Me.pnlsignup.Controls.Add(Me.Label8)
        Me.pnlsignup.Controls.Add(Me.txtage)
        Me.pnlsignup.Controls.Add(Me.Label9)
        Me.pnlsignup.Controls.Add(Me.txtname)
        Me.pnlsignup.Controls.Add(Me.btncancel)
        Me.pnlsignup.Controls.Add(Me.Label1)
        Me.pnlsignup.Controls.Add(Me.btnupdate)
        Me.pnlsignup.GradientBottomLeft = System.Drawing.Color.Navy
        Me.pnlsignup.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopRight = System.Drawing.Color.Violet
        Me.pnlsignup.Location = New System.Drawing.Point(0, 0)
        Me.pnlsignup.Name = "pnlsignup"
        Me.pnlsignup.Quality = 10
        Me.pnlsignup.Size = New System.Drawing.Size(731, 485)
        Me.pnlsignup.TabIndex = 24
        '
        'cbcourse
        '
        Me.cbcourse.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcourse.FormattingEnabled = True
        Me.cbcourse.Items.AddRange(New Object() {"BSCS", "BSCT"})
        Me.cbcourse.Location = New System.Drawing.Point(478, 241)
        Me.cbcourse.Name = "cbcourse"
        Me.cbcourse.Size = New System.Drawing.Size(120, 28)
        Me.cbcourse.TabIndex = 40
        Me.cbcourse.Text = "BSCS"
        '
        'lblparty
        '
        Me.lblparty.AutoSize = True
        Me.lblparty.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparty.ForeColor = System.Drawing.Color.White
        Me.lblparty.Location = New System.Drawing.Point(473, 55)
        Me.lblparty.Name = "lblparty"
        Me.lblparty.Size = New System.Drawing.Size(73, 30)
        Me.lblparty.TabIndex = 39
        Me.lblparty.Text = "party"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(400, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 30)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Party:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(520, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Gender"
        '
        'cbgender
        '
        Me.cbgender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbgender.Location = New System.Drawing.Point(524, 190)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(120, 28)
        Me.cbgender.TabIndex = 36
        Me.cbgender.Text = "Male"
        '
        'pbcandid
        '
        Me.pbcandid.BackColor = System.Drawing.Color.Transparent
        Me.pbcandid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcandid.Image = Global.CSTGvotingsystem.My.Resources.Resources.addimage2
        Me.pbcandid.Location = New System.Drawing.Point(102, 88)
        Me.pbcandid.Name = "pbcandid"
        Me.pbcandid.Size = New System.Drawing.Size(201, 288)
        Me.pbcandid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbcandid.TabIndex = 35
        Me.pbcandid.TabStop = False
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.ForeColor = System.Drawing.Color.White
        Me.lblposition.Location = New System.Drawing.Point(179, 55)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(104, 30)
        Me.lblposition.TabIndex = 34
        Me.lblposition.Text = "Position"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback.Image = Global.CSTGvotingsystem.My.Resources.Resources.arrow_back_128
        Me.btnback.ImageActive = Nothing
        Me.btnback.Location = New System.Drawing.Point(12, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(37, 22)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnback.TabIndex = 33
        Me.btnback.TabStop = False
        Me.btnback.Zoom = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(408, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Course"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(377, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Campaign"
        '
        'txtcam
        '
        Me.txtcam.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtcam.BorderColor = System.Drawing.Color.White
        Me.txtcam.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcam.ForeColor = System.Drawing.Color.White
        Me.txtcam.Location = New System.Drawing.Point(381, 309)
        Me.txtcam.Multiline = True
        Me.txtcam.Name = "txtcam"
        Me.txtcam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcam.Size = New System.Drawing.Size(263, 78)
        Me.txtcam.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(377, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Age"
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtage.BorderColor = System.Drawing.Color.White
        Me.txtage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.White
        Me.txtage.Location = New System.Drawing.Point(381, 191)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(137, 27)
        Me.txtage.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(377, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Name"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtname.BorderColor = System.Drawing.Color.White
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.White
        Me.txtname.Location = New System.Drawing.Point(381, 123)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(263, 27)
        Me.txtname.TabIndex = 25
        '
        'btncancel
        '
        Me.btncancel.ActiveBorderThickness = 1
        Me.btncancel.ActiveCornerRadius = 20
        Me.btncancel.ActiveFillColor = System.Drawing.Color.LightCoral
        Me.btncancel.ActiveForecolor = System.Drawing.Color.White
        Me.btncancel.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.ButtonText = "Cancel"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btncancel.IdleBorderThickness = 1
        Me.btncancel.IdleCornerRadius = 20
        Me.btncancel.IdleFillColor = System.Drawing.Color.White
        Me.btncancel.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btncancel.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btncancel.Location = New System.Drawing.Point(367, 409)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(126, 46)
        Me.btncancel.TabIndex = 22
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Position:"
        '
        'btnupdate
        '
        Me.btnupdate.ActiveBorderThickness = 1
        Me.btnupdate.ActiveCornerRadius = 20
        Me.btnupdate.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnupdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnupdate.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BackgroundImage = CType(resources.GetObject("btnupdate.BackgroundImage"), System.Drawing.Image)
        Me.btnupdate.ButtonText = "Update"
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.IdleBorderThickness = 1
        Me.btnupdate.IdleCornerRadius = 20
        Me.btnupdate.IdleFillColor = System.Drawing.Color.White
        Me.btnupdate.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnupdate.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.Location = New System.Drawing.Point(230, 409)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(126, 46)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmcandidates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 486)
        Me.Controls.Add(Me.pnlsignup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcandidates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcandidates"
        Me.pnlsignup.ResumeLayout(False)
        Me.pnlsignup.PerformLayout()
        CType(Me.pbcandid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlsignup As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblposition As Label
    Friend WithEvents btnback As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label7 As Label
    Public WithEvents txtcam As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label8 As Label
    Public WithEvents txtage As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As Label
    Public WithEvents txtname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pbcandid As PictureBox
    Friend WithEvents lblparty As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbgender As ComboBox
    Friend WithEvents cbcourse As ComboBox
    Friend WithEvents Label6 As Label
End Class
