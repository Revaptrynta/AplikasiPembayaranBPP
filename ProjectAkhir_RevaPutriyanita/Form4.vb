Imports MySql.Data.MySqlClient
Public Class Form4
    Dim Con As MySqlConnection
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim db As String
    Dim jk As Object
    Dim lhr As Object
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tampil()
        tampiljenjang()
        nomorotomatis()
        Label17.Text = Format(Now, "dd-MMMM-yyyy")
        With Me.ComboBox1
            ComboBox1.Items.Add("Teknologi Informasi")
            ComboBox1.Items.Add("Sistem Informasi")
            ComboBox1.Items.Add("Teknik Industri")
            ComboBox1.Items.Add("Teknik Elektro")
            ComboBox1.Items.Add("Teknik Mesin")
        End With
        With Me.ComboBox4
            .Items.Add("Islam")
            .Items.Add("Kristen Protestan")
            .Items.Add("Kristen Katholik")
            .Items.Add("Hindu")
            .Items.Add("Budha")
            .Items.Add("Kong Hu Cu")
        End With
    End Sub
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=project"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim jk As New TextBox
        If (RadioButton1.Checked) Then
            jk.Text = "Laki-laki"
        Else
            jk.Text = "Perempuan"
        End If
        Dim sql As String
        sql = "insert into tbmahasiswa values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & jk.Text & "','" & ComboBox4.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & TextBox5.Text & "')"
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
            da = New MySqlDataAdapter("select *from tbmahasiswa order by nim", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tbmahasiswa")
            Me.DataGridView1.DataSource = (ds.Tables("tbmahasiswa"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Sub tampiljenjang()
        Call koneksi()
        cmd = New MySqlCommand("select jenjang from tbjenjang", Con)
        dr = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item("jenjang"))
        Loop
    End Sub
    Sub nomorotomatis()
        koneksi()
        cmd = New MySqlCommand("select nim from tbmahasiswa order by nim desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "20192301"
        Else
            TextBox1.Text = Format(Microsoft.VisualBasic.Right(dr.Item("nim"), 8) + 1, "00000000")
        End If
        TextBox1.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call nomorotomatis()
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox4.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox1.Text = ""
        TextBox3.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbjenjang where jenjang='" & ComboBox2.Text & "'", Con)
        dr = cmd.ExecuteReader
        While dr.Read()
            Console.WriteLine(dr.GetString(0))
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        simpan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        koneksi()
        If Me.TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Maaf datanya tidak ada yang diupdate")
        Else
            Dim jk As New TextBox
            If (RadioButton1.Checked) Then
                jk.Text = "Laki-laki"
            Else
                jk.Text = "Perempuan"
            End If
            MsgBox("Anda akan mengupdate datanya ya")
            Dim edit As String
            edit = "update tbmahasiswa set nim ='" & TextBox1.Text & "', nama='" & TextBox2.Text & "', Alamat='" & TextBox4.Text & "', Tempat_Tanggal_Lahir='" & DateTimePicker1.Text & "', Jenis_Kelamin='" & jk.Text & "', Agama='" & ComboBox4.Text & "', progdi='" & ComboBox1.Text & "', kelas='" & TextBox3.Text & "', jenjang='" & ComboBox2.Text & "', No_Telp='" & TextBox5.Text & "'where nim='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(edit, Con)
            cmd.ExecuteNonQuery()
            tampil()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Mahasiswa yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan nim=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from tbmahasiswa where nim='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim jk As New TextBox
        If (RadioButton1.Checked) Then
            jk.Text = "Laki-laki"
        Else
            jk.Text = "Perempuan"
        End If
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        jk.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        ComboBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
    End Sub



    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown, GroupBox1.MouseDown
        If e.Button =
                  Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        koneksi()
        da = New MySqlDataAdapter("select *from tbmahasiswa where nim like '%" & TextBox6.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "tbmahasiswa")
        DataGridView1.DataSource = (ds.Tables("tbmahasiswa"))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label16.Text = DateTime.Now.ToString("hh:mm:ss tt")
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
End Class