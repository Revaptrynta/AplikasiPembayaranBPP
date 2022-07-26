Imports MySql.Data.MySqlClient
Public Class Form6
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
        sql = "insert into tbspp values('" & TextBox1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "','" & Label13.Text & "')"
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
            da = New MySqlDataAdapter("select *from tbspp order by no_transaksi_KRS	", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tbspp")
            Me.DataGridView1.DataSource = (ds.Tables("tbspp"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Sub nomorotomatis()
        koneksi()
        cmd = New MySqlCommand("select no_transaksi_KRS	from tbspp order by no_transaksi_KRS desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "S" + "01"
        Else
            TextBox1.Text = "S" + Format(Microsoft.VisualBasic.Right(dr.Item("no_transaksi_KRS"), 2) + 1, "00")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub nim()
        Call koneksi()
        cmd = New MySqlCommand("select nim from tbmahasiswa", Con)
        dr = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item("nim"))
        Loop
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbmahasiswa where nim='" & ComboBox2.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item("nama")
            TextBox6.Text = dr.Item("kelas")
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tampil()
        nomorotomatis()
        nim()
        TextBox3.Text = "0"
        TextBox3.Enabled = False
        Label13.Text = "0"
        TextBox4.Text = Format(Now, "dd-MMMM-yyyy")
        Label11.Visible = False
        GroupBox5.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call nomorotomatis()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Label13.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call nomorotomatis()
        TextBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = "0"
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ListBox1.Items.Clear()
        ComboBox2.Focus()
        CheckBox1.Checked = False
        GroupBox5.Visible = False
        Label11.Visible = False
        Label13.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data KRS yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan no_transaksi_KRS=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from tbspp where no_transaksi_KRS='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim total As Long
        If e.KeyChar = Chr(13) Then
            total = CInt(TextBox5.Text) * CInt(TextBox3.Text)
            Label13.Text = Format(total, "###,###")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "Reguler" Then
            TextBox3.Text = 150000
        ElseIf TextBox6.Text = "Karyawan" Then
            TextBox3.Text = 175000
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim total As Long
        total = Val(Label13.Text + 2500)
        Label13.Text = Format(total, "###,###")
        Label11.Visible = True
        GroupBox5.Visible = True
        TextBox7.Focus()
    End Sub
    Sub bayartagihan()
        Dim kembalian As Integer
        kembalian = Val(TextBox7.Text - Label13.Text)
        TextBox8.Text = Format(kembalian, "Rp ###,###")
        ListBox1.Items.Add("Atas Nama: " & TextBox2.Text)
        ListBox1.Items.Add("Jumlah Tagihan: " & Label13.Text)
        ListBox1.Items.Add("*Biaya Administrasi 2.500")
        ListBox1.Items.Add("Uang Anda: " & TextBox7.Text)
        ListBox1.Items.Add("Jumlah Kembalian: " & TextBox8.Text)
        ListBox1.Items.Add("---------------------------------------------------------------------------")
        ListBox1.Items.Add("   PEMBAYARAN BERHASIL!!          ")
        ListBox1.Items.Add("---------------------------------------------------------------------------")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox7.Text = "" Then
            MsgBox(" Masukkan uang anda ", vbOKOnly, "Perhatian")
        ElseIf Val(TextBox7.Text) < Label13.Text Then
            MsgBox("Uang Anda Kurang!")
            TextBox7.Focus()
        Else
            Call bayartagihan()
        End If
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

    Private Sub Form6_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, DataGridView1.MouseDown, GroupBox1.MouseDown
        If e.Button =
                         Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form8.Show()
        Form8.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label17.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class