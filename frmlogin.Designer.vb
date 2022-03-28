<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlsignin = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pnlsignup = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.lblgen2 = New System.Windows.Forms.Label()
        Me.rbpass = New System.Windows.Forms.RadioButton()
        Me.txtspass = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.rbgen = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnshowpass2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btngen = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtgen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblgen = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.txtyear = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtcourse = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnverify = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblsignin = New System.Windows.Forms.Label()
        Me.btncancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsstudnum = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnsignup = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtstudnum = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblsignup = New System.Windows.Forms.Label()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.txtpass = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.bunifu = New Bunifu.Framework.UI.BunifuTextbox()
        Me.asas = New Bunifu.Framework.UI.BunifuTextbox()
        Me.btnsignin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnshowpass = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtvpass = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtstudstatus = New System.Windows.Forms.TextBox()
        Me.pnlsignin.SuspendLayout()
        Me.pnlsignup.SuspendLayout()
        CType(Me.btnshowpass2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnshowpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnlsignin
        '
        Me.pnlsignin.BackColor = System.Drawing.Color.Transparent
        Me.pnlsignin.BackgroundImage = CType(resources.GetObject("pnlsignin.BackgroundImage"), System.Drawing.Image)
        Me.pnlsignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlsignin.Controls.Add(Me.pnlsignup)
        Me.pnlsignin.Controls.Add(Me.txtstudnum)
        Me.pnlsignin.Controls.Add(Me.lblsignup)
        Me.pnlsignin.Controls.Add(Me.btnclose)
        Me.pnlsignin.Controls.Add(Me.Label9)
        Me.pnlsignin.Controls.Add(Me.pblogo)
        Me.pnlsignin.Controls.Add(Me.txtpass)
        Me.pnlsignin.Controls.Add(Me.bunifu)
        Me.pnlsignin.Controls.Add(Me.asas)
        Me.pnlsignin.Controls.Add(Me.btnsignin)
        Me.pnlsignin.Controls.Add(Me.btnshowpass)
        Me.pnlsignin.GradientBottomLeft = System.Drawing.Color.Navy
        Me.pnlsignin.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.pnlsignin.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.pnlsignin.GradientTopRight = System.Drawing.Color.Violet
        Me.pnlsignin.Location = New System.Drawing.Point(0, 0)
        Me.pnlsignin.Name = "pnlsignin"
        Me.pnlsignin.Quality = 10
        Me.pnlsignin.Size = New System.Drawing.Size(347, 529)
        Me.pnlsignin.TabIndex = 0
        '
        'pnlsignup
        '
        Me.pnlsignup.BackColor = System.Drawing.Color.Transparent
        Me.pnlsignup.BackgroundImage = CType(resources.GetObject("pnlsignup.BackgroundImage"), System.Drawing.Image)
        Me.pnlsignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlsignup.Controls.Add(Me.txtstudstatus)
        Me.pnlsignup.Controls.Add(Me.txtvpass)
        Me.pnlsignup.Controls.Add(Me.txtbox)
        Me.pnlsignup.Controls.Add(Me.lblgen2)
        Me.pnlsignup.Controls.Add(Me.rbpass)
        Me.pnlsignup.Controls.Add(Me.txtspass)
        Me.pnlsignup.Controls.Add(Me.rbgen)
        Me.pnlsignup.Controls.Add(Me.Label8)
        Me.pnlsignup.Controls.Add(Me.Label5)
        Me.pnlsignup.Controls.Add(Me.btnshowpass2)
        Me.pnlsignup.Controls.Add(Me.btngen)
        Me.pnlsignup.Controls.Add(Me.txtgen)
        Me.pnlsignup.Controls.Add(Me.lblgen)
        Me.pnlsignup.Controls.Add(Me.lblyear)
        Me.pnlsignup.Controls.Add(Me.lblcourse)
        Me.pnlsignup.Controls.Add(Me.lbllname)
        Me.pnlsignup.Controls.Add(Me.lblfname)
        Me.pnlsignup.Controls.Add(Me.txtyear)
        Me.pnlsignup.Controls.Add(Me.txtcourse)
        Me.pnlsignup.Controls.Add(Me.btnverify)
        Me.pnlsignup.Controls.Add(Me.lblsignin)
        Me.pnlsignup.Controls.Add(Me.btncancel)
        Me.pnlsignup.Controls.Add(Me.Label7)
        Me.pnlsignup.Controls.Add(Me.Label6)
        Me.pnlsignup.Controls.Add(Me.Label4)
        Me.pnlsignup.Controls.Add(Me.txtlname)
        Me.pnlsignup.Controls.Add(Me.Label3)
        Me.pnlsignup.Controls.Add(Me.txtfname)
        Me.pnlsignup.Controls.Add(Me.Label2)
        Me.pnlsignup.Controls.Add(Me.Label1)
        Me.pnlsignup.Controls.Add(Me.txtsstudnum)
        Me.pnlsignup.Controls.Add(Me.btnsignup)
        Me.pnlsignup.GradientBottomLeft = System.Drawing.Color.Navy
        Me.pnlsignup.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopRight = System.Drawing.Color.Violet
        Me.pnlsignup.Location = New System.Drawing.Point(-1, 0)
        Me.pnlsignup.Name = "pnlsignup"
        Me.pnlsignup.Quality = 10
        Me.pnlsignup.Size = New System.Drawing.Size(346, 529)
        Me.pnlsignup.TabIndex = 22
        Me.pnlsignup.Visible = False
        '
        'txtbox
        '
        Me.txtbox.Location = New System.Drawing.Point(290, 47)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(15, 20)
        Me.txtbox.TabIndex = 60
        Me.txtbox.Visible = False
        '
        'lblgen2
        '
        Me.lblgen2.AutoSize = True
        Me.lblgen2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblgen2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgen2.ForeColor = System.Drawing.Color.White
        Me.lblgen2.Location = New System.Drawing.Point(46, 348)
        Me.lblgen2.Name = "lblgen2"
        Me.lblgen2.Size = New System.Drawing.Size(46, 21)
        Me.lblgen2.TabIndex = 59
        Me.lblgen2.Text = "0000"
        '
        'rbpass
        '
        Me.rbpass.AutoSize = True
        Me.rbpass.Location = New System.Drawing.Point(23, 381)
        Me.rbpass.Name = "rbpass"
        Me.rbpass.Size = New System.Drawing.Size(14, 13)
        Me.rbpass.TabIndex = 58
        Me.rbpass.UseVisualStyleBackColor = True
        '
        'txtspass
        '
        Me.txtspass.BackColor = System.Drawing.Color.White
        Me.txtspass.BorderColor = System.Drawing.Color.White
        Me.txtspass.Enabled = False
        Me.txtspass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspass.ForeColor = System.Drawing.Color.Black
        Me.txtspass.Location = New System.Drawing.Point(42, 401)
        Me.txtspass.Name = "txtspass"
        Me.txtspass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtspass.Size = New System.Drawing.Size(263, 27)
        Me.txtspass.TabIndex = 51
        '
        'rbgen
        '
        Me.rbgen.AutoSize = True
        Me.rbgen.Checked = True
        Me.rbgen.Location = New System.Drawing.Point(23, 326)
        Me.rbgen.Name = "rbgen"
        Me.rbgen.Size = New System.Drawing.Size(14, 13)
        Me.rbgen.TabIndex = 57
        Me.rbgen.TabStop = True
        Me.rbgen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 21)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Generate Password"
        '
        'btnshowpass2
        '
        Me.btnshowpass2.BackColor = System.Drawing.Color.Transparent
        Me.btnshowpass2.ErrorImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnshowpass2.Image = Global.CSTGvotingsystem.My.Resources.Resources.showpass
        Me.btnshowpass2.ImageActive = Nothing
        Me.btnshowpass2.InitialImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnshowpass2.Location = New System.Drawing.Point(309, 402)
        Me.btnshowpass2.Name = "btnshowpass2"
        Me.btnshowpass2.Size = New System.Drawing.Size(28, 27)
        Me.btnshowpass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnshowpass2.TabIndex = 53
        Me.btnshowpass2.TabStop = False
        Me.btnshowpass2.Zoom = 10
        '
        'btngen
        '
        Me.btngen.ActiveBorderThickness = 1
        Me.btngen.ActiveCornerRadius = 20
        Me.btngen.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btngen.ActiveForecolor = System.Drawing.Color.White
        Me.btngen.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btngen.BackColor = System.Drawing.Color.Transparent
        Me.btngen.BackgroundImage = CType(resources.GetObject("btngen.BackgroundImage"), System.Drawing.Image)
        Me.btngen.ButtonText = "Generate"
        Me.btngen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngen.ForeColor = System.Drawing.Color.SeaGreen
        Me.btngen.IdleBorderThickness = 1
        Me.btngen.IdleCornerRadius = 20
        Me.btngen.IdleFillColor = System.Drawing.Color.White
        Me.btngen.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btngen.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btngen.Location = New System.Drawing.Point(209, 341)
        Me.btngen.Margin = New System.Windows.Forms.Padding(5)
        Me.btngen.Name = "btngen"
        Me.btngen.Size = New System.Drawing.Size(96, 36)
        Me.btngen.TabIndex = 55
        Me.btngen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btngen.Visible = False
        '
        'txtgen
        '
        Me.txtgen.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtgen.BorderColor = System.Drawing.Color.White
        Me.txtgen.Enabled = False
        Me.txtgen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgen.ForeColor = System.Drawing.Color.White
        Me.txtgen.Location = New System.Drawing.Point(42, 345)
        Me.txtgen.Name = "txtgen"
        Me.txtgen.Size = New System.Drawing.Size(161, 27)
        Me.txtgen.TabIndex = 54
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblgen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgen.ForeColor = System.Drawing.Color.White
        Me.lblgen.Location = New System.Drawing.Point(46, 346)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(0, 21)
        Me.lblgen.TabIndex = 41
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblyear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.ForeColor = System.Drawing.Color.White
        Me.lblyear.Location = New System.Drawing.Point(180, 276)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(0, 21)
        Me.lblyear.TabIndex = 40
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblcourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.ForeColor = System.Drawing.Color.White
        Me.lblcourse.Location = New System.Drawing.Point(46, 276)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(0, 21)
        Me.lblcourse.TabIndex = 39
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lbllname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.Color.White
        Me.lbllname.Location = New System.Drawing.Point(46, 217)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(0, 21)
        Me.lbllname.TabIndex = 38
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblfname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.White
        Me.lblfname.Location = New System.Drawing.Point(46, 158)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(0, 21)
        Me.lblfname.TabIndex = 37
        '
        'txtyear
        '
        Me.txtyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtyear.BorderColor = System.Drawing.Color.White
        Me.txtyear.Enabled = False
        Me.txtyear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.ForeColor = System.Drawing.Color.White
        Me.txtyear.Location = New System.Drawing.Point(175, 273)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(130, 27)
        Me.txtyear.TabIndex = 31
        Me.txtyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcourse
        '
        Me.txtcourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtcourse.BorderColor = System.Drawing.Color.White
        Me.txtcourse.Enabled = False
        Me.txtcourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourse.ForeColor = System.Drawing.Color.White
        Me.txtcourse.Location = New System.Drawing.Point(42, 273)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.Size = New System.Drawing.Size(126, 27)
        Me.txtcourse.TabIndex = 30
        Me.txtcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnverify
        '
        Me.btnverify.ActiveBorderThickness = 1
        Me.btnverify.ActiveCornerRadius = 20
        Me.btnverify.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnverify.ActiveForecolor = System.Drawing.Color.White
        Me.btnverify.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnverify.BackColor = System.Drawing.Color.Transparent
        Me.btnverify.BackgroundImage = CType(resources.GetObject("btnverify.BackgroundImage"), System.Drawing.Image)
        Me.btnverify.ButtonText = "Verify"
        Me.btnverify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverify.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverify.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnverify.IdleBorderThickness = 1
        Me.btnverify.IdleCornerRadius = 20
        Me.btnverify.IdleFillColor = System.Drawing.Color.White
        Me.btnverify.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnverify.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnverify.Location = New System.Drawing.Point(236, 93)
        Me.btnverify.Margin = New System.Windows.Forms.Padding(5)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(69, 36)
        Me.btnverify.TabIndex = 29
        Me.btnverify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsignin
        '
        Me.lblsignin.AutoSize = True
        Me.lblsignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblsignin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignin.ForeColor = System.Drawing.Color.White
        Me.lblsignin.Location = New System.Drawing.Point(147, 494)
        Me.lblsignin.Name = "lblsignin"
        Me.lblsignin.Size = New System.Drawing.Size(56, 18)
        Me.lblsignin.TabIndex = 21
        Me.lblsignin.Text = "Sign In"
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
        Me.btncancel.Location = New System.Drawing.Point(179, 440)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(126, 46)
        Me.btncancel.TabIndex = 22
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(171, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Name"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtlname.BorderColor = System.Drawing.Color.White
        Me.txtlname.Enabled = False
        Me.txtlname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.White
        Me.txtlname.Location = New System.Drawing.Point(42, 215)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(263, 27)
        Me.txtlname.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "First Name"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtfname.BorderColor = System.Drawing.Color.White
        Me.txtfname.Enabled = False
        Me.txtfname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.White
        Me.txtfname.Location = New System.Drawing.Point(42, 155)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(263, 27)
        Me.txtfname.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Student Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(127, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sign Up"
        '
        'txtsstudnum
        '
        Me.txtsstudnum.BackColor = System.Drawing.Color.White
        Me.txtsstudnum.BorderColor = System.Drawing.Color.White
        Me.txtsstudnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsstudnum.ForeColor = System.Drawing.Color.Black
        Me.txtsstudnum.Location = New System.Drawing.Point(42, 97)
        Me.txtsstudnum.Name = "txtsstudnum"
        Me.txtsstudnum.Size = New System.Drawing.Size(186, 27)
        Me.txtsstudnum.TabIndex = 5
        '
        'btnsignup
        '
        Me.btnsignup.ActiveBorderThickness = 1
        Me.btnsignup.ActiveCornerRadius = 20
        Me.btnsignup.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnsignup.ActiveForecolor = System.Drawing.Color.White
        Me.btnsignup.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnsignup.BackColor = System.Drawing.Color.Transparent
        Me.btnsignup.BackgroundImage = CType(resources.GetObject("btnsignup.BackgroundImage"), System.Drawing.Image)
        Me.btnsignup.ButtonText = "Sign Up"
        Me.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignup.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnsignup.IdleBorderThickness = 1
        Me.btnsignup.IdleCornerRadius = 20
        Me.btnsignup.IdleFillColor = System.Drawing.Color.White
        Me.btnsignup.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnsignup.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnsignup.Location = New System.Drawing.Point(42, 440)
        Me.btnsignup.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(126, 46)
        Me.btnsignup.TabIndex = 3
        Me.btnsignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtstudnum
        '
        Me.txtstudnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtstudnum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtstudnum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstudnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudnum.ForeColor = System.Drawing.Color.White
        Me.txtstudnum.Location = New System.Drawing.Point(83, 246)
        Me.txtstudnum.Name = "txtstudnum"
        Me.txtstudnum.Size = New System.Drawing.Size(198, 20)
        Me.txtstudnum.TabIndex = 25
        '
        'lblsignup
        '
        Me.lblsignup.AutoSize = True
        Me.lblsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblsignup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignup.ForeColor = System.Drawing.Color.White
        Me.lblsignup.Location = New System.Drawing.Point(81, 358)
        Me.lblsignup.Name = "lblsignup"
        Me.lblsignup.Size = New System.Drawing.Size(185, 16)
        Me.lblsignup.TabIndex = 20
        Me.lblsignup.Text = "Don't have an account yet?"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.ErrorImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnclose.Image = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.InitialImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnclose.Location = New System.Drawing.Point(310, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(31, 30)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 9
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(60, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Computerized Voting System"
        '
        'pblogo
        '
        Me.pblogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pblogo.Image = Global.CSTGvotingsystem.My.Resources.Resources.CSTG__2_
        Me.pblogo.Location = New System.Drawing.Point(100, 47)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(146, 136)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pblogo.TabIndex = 6
        Me.pblogo.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.White
        Me.txtpass.Location = New System.Drawing.Point(84, 313)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpass.Size = New System.Drawing.Size(198, 20)
        Me.txtpass.TabIndex = 4
        '
        'bunifu
        '
        Me.bunifu.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.bunifu.BackgroundImage = CType(resources.GetObject("bunifu.BackgroundImage"), System.Drawing.Image)
        Me.bunifu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifu.Enabled = False
        Me.bunifu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bunifu.Icon = CType(resources.GetObject("bunifu.Icon"), System.Drawing.Image)
        Me.bunifu.Location = New System.Drawing.Point(46, 302)
        Me.bunifu.Name = "bunifu"
        Me.bunifu.Size = New System.Drawing.Size(250, 42)
        Me.bunifu.TabIndex = 5
        Me.bunifu.text = ""
        '
        'asas
        '
        Me.asas.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.asas.BackgroundImage = CType(resources.GetObject("asas.BackgroundImage"), System.Drawing.Image)
        Me.asas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.asas.Enabled = False
        Me.asas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.asas.Icon = CType(resources.GetObject("asas.Icon"), System.Drawing.Image)
        Me.asas.Location = New System.Drawing.Point(46, 235)
        Me.asas.Name = "asas"
        Me.asas.Size = New System.Drawing.Size(250, 42)
        Me.asas.TabIndex = 4
        Me.asas.text = ""
        '
        'btnsignin
        '
        Me.btnsignin.ActiveBorderThickness = 1
        Me.btnsignin.ActiveCornerRadius = 20
        Me.btnsignin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnsignin.ActiveForecolor = System.Drawing.Color.White
        Me.btnsignin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnsignin.BackColor = System.Drawing.Color.Transparent
        Me.btnsignin.BackgroundImage = CType(resources.GetObject("btnsignin.BackgroundImage"), System.Drawing.Image)
        Me.btnsignin.ButtonText = "Sign In"
        Me.btnsignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnsignin.IdleBorderThickness = 1
        Me.btnsignin.IdleCornerRadius = 20
        Me.btnsignin.IdleFillColor = System.Drawing.Color.White
        Me.btnsignin.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnsignin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnsignin.Location = New System.Drawing.Point(46, 401)
        Me.btnsignin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(250, 59)
        Me.btnsignin.TabIndex = 3
        Me.btnsignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnshowpass
        '
        Me.btnshowpass.BackColor = System.Drawing.Color.Transparent
        Me.btnshowpass.ErrorImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnshowpass.Image = Global.CSTGvotingsystem.My.Resources.Resources.showpass
        Me.btnshowpass.ImageActive = Nothing
        Me.btnshowpass.InitialImage = Global.CSTGvotingsystem.My.Resources.Resources.close2
        Me.btnshowpass.Location = New System.Drawing.Point(301, 307)
        Me.btnshowpass.Name = "btnshowpass"
        Me.btnshowpass.Size = New System.Drawing.Size(31, 30)
        Me.btnshowpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnshowpass.TabIndex = 26
        Me.btnshowpass.TabStop = False
        Me.btnshowpass.Zoom = 10
        '
        'txtvpass
        '
        Me.txtvpass.BackColor = System.Drawing.Color.White
        Me.txtvpass.BorderColor = System.Drawing.Color.White
        Me.txtvpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvpass.ForeColor = System.Drawing.Color.Black
        Me.txtvpass.Location = New System.Drawing.Point(23, 23)
        Me.txtvpass.Name = "txtvpass"
        Me.txtvpass.Size = New System.Drawing.Size(23, 27)
        Me.txtvpass.TabIndex = 61
        Me.txtvpass.Visible = False
        '
        'txtstudstatus
        '
        Me.txtstudstatus.Location = New System.Drawing.Point(260, 14)
        Me.txtstudstatus.Name = "txtstudstatus"
        Me.txtstudstatus.Size = New System.Drawing.Size(62, 20)
        Me.txtstudstatus.TabIndex = 62
        Me.txtstudstatus.Visible = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 529)
        Me.Controls.Add(Me.pnlsignin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlsignin.ResumeLayout(False)
        Me.pnlsignin.PerformLayout()
        Me.pnlsignup.ResumeLayout(False)
        Me.pnlsignup.PerformLayout()
        CType(Me.btnshowpass2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnshowpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlsignin As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnsignin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents asas As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents bunifu As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtpass As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents pblogo As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblsignup As Label
    Friend WithEvents pnlsignup As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblsignin As Label
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsstudnum As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnsignup As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtstudnum As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnshowpass As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtyear As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtcourse As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnverify As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblgen As Label
    Friend WithEvents lblyear As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents lbllname As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents txtfname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents rbpass As RadioButton
    Friend WithEvents txtspass As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents rbgen As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnshowpass2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btngen As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtgen As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblgen2 As Label
    Friend WithEvents txtbox As TextBox
    Friend WithEvents txtvpass As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtstudstatus As TextBox
End Class
