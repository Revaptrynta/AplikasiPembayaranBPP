<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtcancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtpassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtusername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtcancel)
        Me.Panel1.Controls.Add(Me.txtlogin)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Location = New System.Drawing.Point(36, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 246)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(264, 115)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(264, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'txtcancel
        '
        Me.txtcancel.ActiveBorderThickness = 1
        Me.txtcancel.ActiveCornerRadius = 20
        Me.txtcancel.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.txtcancel.ActiveForecolor = System.Drawing.Color.White
        Me.txtcancel.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.txtcancel.BackColor = System.Drawing.Color.SteelBlue
        Me.txtcancel.BackgroundImage = CType(resources.GetObject("txtcancel.BackgroundImage"), System.Drawing.Image)
        Me.txtcancel.ButtonText = "CANCEL"
        Me.txtcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtcancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtcancel.IdleBorderThickness = 1
        Me.txtcancel.IdleCornerRadius = 20
        Me.txtcancel.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.txtcancel.IdleForecolor = System.Drawing.Color.White
        Me.txtcancel.IdleLineColor = System.Drawing.Color.SkyBlue
        Me.txtcancel.Location = New System.Drawing.Point(194, 180)
        Me.txtcancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcancel.Name = "txtcancel"
        Me.txtcancel.Size = New System.Drawing.Size(104, 42)
        Me.txtcancel.TabIndex = 3
        Me.txtcancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtlogin
        '
        Me.txtlogin.ActiveBorderThickness = 1
        Me.txtlogin.ActiveCornerRadius = 20
        Me.txtlogin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.txtlogin.ActiveForecolor = System.Drawing.Color.White
        Me.txtlogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.txtlogin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtlogin.BackgroundImage = CType(resources.GetObject("txtlogin.BackgroundImage"), System.Drawing.Image)
        Me.txtlogin.ButtonText = "LOGIN"
        Me.txtlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtlogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtlogin.IdleBorderThickness = 1
        Me.txtlogin.IdleCornerRadius = 20
        Me.txtlogin.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.txtlogin.IdleForecolor = System.Drawing.Color.White
        Me.txtlogin.IdleLineColor = System.Drawing.Color.SkyBlue
        Me.txtlogin.Location = New System.Drawing.Point(36, 180)
        Me.txtlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(104, 42)
        Me.txtlogin.TabIndex = 2
        Me.txtlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtpassword.HintText = "Type Your Password"
        Me.txtpassword.isPassword = False
        Me.txtpassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtpassword.LineIdleColor = System.Drawing.Color.Blue
        Me.txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtpassword.LineThickness = 4
        Me.txtpassword.Location = New System.Drawing.Point(36, 106)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(262, 41)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtusername
        '
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.HintForeColor = System.Drawing.Color.Black
        Me.txtusername.HintText = "Type Your Username"
        Me.txtusername.isPassword = False
        Me.txtusername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtusername.LineIdleColor = System.Drawing.Color.Blue
        Me.txtusername.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtusername.LineThickness = 4
        Me.txtusername.Location = New System.Drawing.Point(36, 31)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(262, 41)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(114, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 416)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtcancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtpassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
End Class
