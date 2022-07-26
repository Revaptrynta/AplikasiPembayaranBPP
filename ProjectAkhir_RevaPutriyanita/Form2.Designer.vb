<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsiTingkatJenjangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsiDataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsiDataBiayaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiKRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrasaksiUangKampusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenghitungNilaiMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.DataMahasiswaToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.NilaiMahasiswaToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 34)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.BerandaToolStripMenuItem})
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(101, 30)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(180, 30)
        Me.BerandaToolStripMenuItem.Text = "Beranda"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IsiTingkatJenjangToolStripMenuItem, Me.IsiDataMahasiswaToolStripMenuItem, Me.IsiDataBiayaToolStripMenuItem})
        Me.DataMahasiswaToolStripMenuItem.Image = CType(resources.GetObject("DataMahasiswaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(169, 30)
        Me.DataMahasiswaToolStripMenuItem.Text = "Master Data"
        '
        'IsiTingkatJenjangToolStripMenuItem
        '
        Me.IsiTingkatJenjangToolStripMenuItem.Name = "IsiTingkatJenjangToolStripMenuItem"
        Me.IsiTingkatJenjangToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.IsiTingkatJenjangToolStripMenuItem.Text = "Isi Tingkat Jenjang"
        '
        'IsiDataMahasiswaToolStripMenuItem
        '
        Me.IsiDataMahasiswaToolStripMenuItem.Name = "IsiDataMahasiswaToolStripMenuItem"
        Me.IsiDataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.IsiDataMahasiswaToolStripMenuItem.Text = "Isi Data Mahasiswa"
        '
        'IsiDataBiayaToolStripMenuItem
        '
        Me.IsiDataBiayaToolStripMenuItem.Name = "IsiDataBiayaToolStripMenuItem"
        Me.IsiDataBiayaToolStripMenuItem.Size = New System.Drawing.Size(284, 30)
        Me.IsiDataBiayaToolStripMenuItem.Text = "Isi Data Biaya"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiKRSToolStripMenuItem, Me.TrasaksiUangKampusToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(139, 30)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'TransaksiKRSToolStripMenuItem
        '
        Me.TransaksiKRSToolStripMenuItem.Name = "TransaksiKRSToolStripMenuItem"
        Me.TransaksiKRSToolStripMenuItem.Size = New System.Drawing.Size(321, 30)
        Me.TransaksiKRSToolStripMenuItem.Text = "Transaksi KRS"
        '
        'TrasaksiUangKampusToolStripMenuItem
        '
        Me.TrasaksiUangKampusToolStripMenuItem.Name = "TrasaksiUangKampusToolStripMenuItem"
        Me.TrasaksiUangKampusToolStripMenuItem.Size = New System.Drawing.Size(321, 30)
        Me.TrasaksiUangKampusToolStripMenuItem.Text = "Trasaksi Uang Kampus"
        '
        'NilaiMahasiswaToolStripMenuItem
        '
        Me.NilaiMahasiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenghitungNilaiMahasiswaToolStripMenuItem})
        Me.NilaiMahasiswaToolStripMenuItem.Image = CType(resources.GetObject("NilaiMahasiswaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NilaiMahasiswaToolStripMenuItem.Name = "NilaiMahasiswaToolStripMenuItem"
        Me.NilaiMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.NilaiMahasiswaToolStripMenuItem.Text = "Nilai Mahasiswa"
        '
        'MenghitungNilaiMahasiswaToolStripMenuItem
        '
        Me.MenghitungNilaiMahasiswaToolStripMenuItem.Name = "MenghitungNilaiMahasiswaToolStripMenuItem"
        Me.MenghitungNilaiMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(385, 30)
        Me.MenghitungNilaiMahasiswaToolStripMenuItem.Text = "Menghitung Nilai Mahasiswa"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(96, 30)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form2"
        Me.Text = "FormBeranda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BerandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IsiTingkatJenjangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IsiDataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IsiDataBiayaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiKRSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrasaksiUangKampusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NilaiMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenghitungNilaiMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
