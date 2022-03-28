<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddvoters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaddvoters))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlsignup = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.cbcourse = New System.Windows.Forms.ComboBox()
        Me.btnback = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtstudnum = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btncancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlsignup.SuspendLayout()
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
        Me.pnlsignup.Controls.Add(Me.cbyear)
        Me.pnlsignup.Controls.Add(Me.Label4)
        Me.pnlsignup.Controls.Add(Me.Label2)
        Me.pnlsignup.Controls.Add(Me.txtlname)
        Me.pnlsignup.Controls.Add(Me.cbcourse)
        Me.pnlsignup.Controls.Add(Me.btnback)
        Me.pnlsignup.Controls.Add(Me.Label6)
        Me.pnlsignup.Controls.Add(Me.Label8)
        Me.pnlsignup.Controls.Add(Me.txtfname)
        Me.pnlsignup.Controls.Add(Me.Label9)
        Me.pnlsignup.Controls.Add(Me.txtstudnum)
        Me.pnlsignup.Controls.Add(Me.btncancel)
        Me.pnlsignup.Controls.Add(Me.Label1)
        Me.pnlsignup.Controls.Add(Me.btnsave)
        Me.pnlsignup.GradientBottomLeft = System.Drawing.Color.Navy
        Me.pnlsignup.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.pnlsignup.GradientTopRight = System.Drawing.Color.Violet
        Me.pnlsignup.Location = New System.Drawing.Point(0, 0)
        Me.pnlsignup.Name = "pnlsignup"
        Me.pnlsignup.Quality = 10
        Me.pnlsignup.Size = New System.Drawing.Size(347, 451)
        Me.pnlsignup.TabIndex = 26
        '
        'cbyear
        '
        Me.cbyear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbyear.Location = New System.Drawing.Point(185, 294)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(120, 28)
        Me.cbyear.TabIndex = 45
        Me.cbyear.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(181, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Lastname"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtlname.BorderColor = System.Drawing.Color.White
        Me.txtlname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.White
        Me.txtlname.Location = New System.Drawing.Point(42, 232)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(263, 27)
        Me.txtlname.TabIndex = 41
        '
        'cbcourse
        '
        Me.cbcourse.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcourse.FormattingEnabled = True
        Me.cbcourse.Items.AddRange(New Object() {"BSCS", "BSCT"})
        Me.cbcourse.Location = New System.Drawing.Point(42, 294)
        Me.cbcourse.Name = "cbcourse"
        Me.cbcourse.Size = New System.Drawing.Size(136, 28)
        Me.cbcourse.TabIndex = 40
        Me.cbcourse.Text = "BSCS"
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
        Me.Label6.Location = New System.Drawing.Point(38, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Course"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Firstname"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtfname.BorderColor = System.Drawing.Color.White
        Me.txtfname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.White
        Me.txtfname.Location = New System.Drawing.Point(42, 173)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(263, 27)
        Me.txtfname.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(38, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Student Number"
        '
        'txtstudnum
        '
        Me.txtstudnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txtstudnum.BorderColor = System.Drawing.Color.White
        Me.txtstudnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudnum.ForeColor = System.Drawing.Color.White
        Me.txtstudnum.Location = New System.Drawing.Point(42, 105)
        Me.txtstudnum.Name = "txtstudnum"
        Me.txtstudnum.Size = New System.Drawing.Size(263, 27)
        Me.txtstudnum.TabIndex = 25
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
        Me.btncancel.Location = New System.Drawing.Point(179, 363)
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
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Add Voters"
        '
        'btnsave
        '
        Me.btnsave.ActiveBorderThickness = 1
        Me.btnsave.ActiveCornerRadius = 20
        Me.btnsave.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnsave.ActiveForecolor = System.Drawing.Color.White
        Me.btnsave.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.ButtonText = "Save"
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnsave.IdleBorderThickness = 1
        Me.btnsave.IdleCornerRadius = 20
        Me.btnsave.IdleFillColor = System.Drawing.Color.White
        Me.btnsave.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnsave.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnsave.Location = New System.Drawing.Point(42, 363)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(126, 46)
        Me.btnsave.TabIndex = 3
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmaddvoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 450)
        Me.Controls.Add(Me.pnlsignup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmaddvoters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmaddvoters"
        Me.pnlsignup.ResumeLayout(False)
        Me.pnlsignup.PerformLayout()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlsignup As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents cbcourse As ComboBox
    Friend WithEvents btnback As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents txtfname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As Label
    Public WithEvents txtstudnum As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cbyear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txtlname As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
