Imports MySql.Data.MySqlClient
Public Class Form5
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
        sql = "insert into tbbiaya values('" & TextBox1.Text & "','" & TextBox6.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox5.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "')"
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
            da = New MySqlDataAdapter("select *from tbbiaya order by id_biaya", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tbbiaya")
            Me.DataGridView1.DataSource = (ds.Tables("tbbiaya"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Sub idbiayaotomatis()
        koneksi()
        cmd = New MySqlCommand("select id_biaya from tbbiaya order by id_biaya desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "IB" + "001"
        Else
            TextBox1.Text = "IB" + Format(Microsoft.VisualBasic.Right(dr.Item("id_biaya"), 2) + 1, "000")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub jenjang()
        Call koneksi()
        cmd = New MySqlCommand("select id_jenjang from tbjenjang", Con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("id_jenjang"))
        Loop
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tampil()
        idbiayaotomatis()
        jenjang()
        Label16.Text = Format(Now, "dd-MMMM-yyyy")
        TextBox5.Text = "150000"
        TextBox5.Enabled = False
        TextBox4.Text = "150000"
        TextBox4.Enabled = False
        TextBox3.Text = "1200000"
        TextBox3.Enabled = False
        TextBox7.Enabled = False
        TextBox2.Text = "350000"
        TextBox2.Enabled = False
        TextBox8.Enabled = False
        GroupBox5.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox6.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"
        TextBox10.Text = "0"
        GroupBox5.Enabled = False
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbjenjang where id_jenjang='" & ComboBox1.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox6.Text = dr.Item("jenjang")
        Else
            MsgBox("ID Jenjang tidak ada")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Biaya yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan id_biaya=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from tbbiaya where id_biaya='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox9.Text = CInt(TextBox2.Text) + CInt(TextBox3.Text) + CInt(TextBox4.Text) + CInt(TextBox5.Text) + CInt(TextBox7.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call idbiayaotomatis()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox10.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub



    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim textjenjang As String = TextBox6.Text
        Select Case textjenjang
            Case "D3"
                TextBox7.Text = 3750000
            Case "S1"
                TextBox7.Text = 4750000
            Case "S2"
                TextBox7.Text = 6000000
        End Select
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox10.Text = CInt(TextBox9.Text) / CInt(TextBox8.Text)
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        koneksi()
        da = New MySqlDataAdapter("select *from tbbiaya where id_biaya like '%" & TextBox11.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "tbbiaya")
        DataGridView1.DataSource = (ds.Tables("tbbiaya"))
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox8.Text = 2
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox8.Text = 4
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox8.Text = 6
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        GroupBox5.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox8.Text = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

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
    Private Sub Form5_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, GroupBox1.MouseDown, DataGridView1.MouseDown
        If e.Button =
                         Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub
End Class