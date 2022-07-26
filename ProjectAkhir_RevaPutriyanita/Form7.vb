Imports MySql.Data.MySqlClient
Public Class Form7
    Dim Con As MySqlConnection
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim db As String
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=project"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String
        sql = "insert into tbuangkampus values('" & TextBox1.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "','" & Label12.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data berhasil", vbInformation, "INFORMASI")
            tampil()
        Catch ex As Exception
            MsgBox("Menyimpan data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        Try
            koneksi()
            da = New MySqlDataAdapter("select *from tbuangkampus order by nomor_transaksi", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tbuangkampus")
            Me.DataGridView1.DataSource = (ds.Tables("tbuangkampus"))
        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Sub nomorotomatis()
        koneksi()
        cmd = New MySqlCommand("select nomor_transaksi from tbuangkampus order by nomor_transaksi desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "00001"
        Else
            TextBox1.Text = Format(Microsoft.VisualBasic.Right(dr.Item("nomor_transaksi"), 5) + 1, "00000")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub nim()
        Call koneksi()
        cmd = New MySqlCommand("select nim from tbmahasiswa", Con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("nim"))
        Loop
    End Sub
    Sub id_biaya()
        Call koneksi()
        cmd = New MySqlCommand("select id_biaya from tbbiaya", Con)
        dr = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item("id_biaya"))
        Loop
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tampil()
        nomorotomatis()
        nim()
        id_biaya()
        Label12.Text = "0"
        TextBox5.Text = Format(Now, "dd-MMMM-yyyy")
        GroupBox6.Visible = False
        Label17.Visible = False
        TextBox4.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbmahasiswa where nim='" & ComboBox1.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item("nama")
            TextBox3.Text = dr.Item("jenjang")
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbbiaya where id_biaya='" & ComboBox2.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox4.Text = dr.Item("total_biaya")
            TextBox6.Text = dr.Item("Jumlah_cicilan")
            Label12.Text = dr.Item("Biaya_cicilan")
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call nomorotomatis()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ListBox1.Items.Clear()
        ComboBox1.Focus()
        CheckBox1.Checked = False
        GroupBox6.Visible = False
        Label17.Visible = False
        Label12.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data yang dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan nomor_transaksi=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from tbuangkampus where nomor_transaksi='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call nomorotomatis()
    End Sub
    Sub bayartagihan()
        Dim kembalian As Integer
        kembalian = Val(TextBox7.Text - Label12.Text)
        TextBox8.Text = Format(kembalian, "Rp ###,###")
        ListBox1.Items.Add("Atas Nama: " & TextBox2.Text)
        ListBox1.Items.Add("Jumlah Tagihan: " & Label12.Text)
        ListBox1.Items.Add("*Biaya Administrasi 2.500")
        ListBox1.Items.Add("Uang Anda: " & TextBox7.Text)
        ListBox1.Items.Add("Jumlah Kembalian: " & TextBox8.Text)
        ListBox1.Items.Add("---------------------------------------------------------------------------")
        ListBox1.Items.Add("    PEMBAYARAN BERHASIL!!          ")
        ListBox1.Items.Add("---------------------------------------------------------------------------")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox7.Text = "" Then
            MsgBox(" Masukkan uang anda ", vbOKOnly, "Perhatian")
        ElseIf Val(TextBox7.Text) < Label12.Text Then
            MsgBox("Uang Anda Kurang!")
            TextBox7.Focus()
        Else
            Call bayartagihan()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim total As Long
        Label17.Visible = True
        GroupBox6.Visible = True
        total = Val(Label12.Text + 2500)
        Label12.Text = Format(total, "###,###")
        TextBox7.Focus()
    End Sub

    Private Sub REFRESHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REFRESHToolStripMenuItem.Click
        tampil()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBox("Apakah Anda Ingin Keluar??", MsgBoxStyle.YesNo, "EXIT!") = MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()
        Else
        End If
    End Sub

    Private Sub Form7_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, GroupBox1.MouseDown, DataGridView1.MouseDown
        If e.Button =
                         Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label18.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form8.Show()
        Form8.TabControl1.SelectedIndex = 1
    End Sub
End Class