Imports MySql.Data.MySqlClient
Public Class Form9
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
    Sub nim()
        Call koneksi()
        cmd = New MySqlCommand("select nim from tbmahasiswa", Con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("nim"))
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = 0.1 * Val(TextBox3.Text)
        TextBox8.Text = 0.2 * Val(TextBox4.Text)
        TextBox9.Text = 0.3 * Val(TextBox5.Text)
        TextBox10.Text = 0.4 * Val(TextBox6.Text)
        TextBox11.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)

        Dim nilai As Integer = TextBox11.Text
        Select Case nilai
            Case 80 To 100
                TextBox12.Text = "A"
            Case 65 To 79
                TextBox12.Text = "B"
            Case 47 To 64
                TextBox12.Text = "C"
            Case 26 To 46
                TextBox12.Text = "D"
            Case Else
                TextBox12.Text = "E"
        End Select

        TextBox13.Text = (keterangan(nilai))
    End Sub

    Function keterangan(ByVal nilai As Integer)
        If nilai >= 55 Then
            keterangan = "LULUS"
        Else
            keterangan = "TIDAK LULUS"
        End If
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from tbmahasiswa where nim='" & ComboBox1.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item("nama")
            TextBox2.Text = dr.Item("progdi")
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nim()
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False

        Dim arr(4, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama "
        arr(1, 0) = "Jurusan"
        arr(1, 1) = "Nilai Absen"
        arr(2, 0) = "Nilai Tugas"
        arr(2, 1) = "Nilai UTS"
        arr(3, 0) = "Nilai UAS"
        arr(3, 1) = "Total Nilai"
        arr(4, 0) = "Grade"
        arr(4, 1) = "Keterangan"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 80)
            Next kolom
        Next baris
        ListView1.Columns.Add("Nilai Tugas", 75)
        ListView1.Columns.Add("Nilai UTS", 70)
        ListView1.Columns.Add("Nilai UAS", 70)
        ListView1.Columns.Add("Total Nilai", 70)
        ListView1.Columns.Add("Grade", 50)
        ListView1.Columns.Add("Keterangan", 100)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim arr(9) As String
        arr(0) = ComboBox1.Text
        arr(1) = TextBox1.Text
        arr(2) = TextBox2.Text
        arr(3) = TextBox3.Text
        arr(4) = TextBox4.Text
        arr(5) = TextBox5.Text
        arr(6) = TextBox6.Text
        arr(7) = TextBox11.Text
        arr(8) = TextBox12.Text
        arr(9) = TextBox13.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        list.SubItems.Add(arr(4))
        list.SubItems.Add(arr(5))
        list.SubItems.Add(arr(6))
        list.SubItems.Add(arr(7))
        list.SubItems.Add(arr(8))
        list.SubItems.Add(arr(9))
        ComboBox1.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
    End Sub

    Private Sub REFRESHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REFRESHToolStripMenuItem.Click
        If ListView1.Items.Count <> 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Else
            MsgBox("Data sudah kosong")
        End If

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBox("Apakah Anda Ingin Keluar??", MsgBoxStyle.YesNo, "EXIT!") = MsgBoxResult.Yes Then
            Form2.Show()
            Me.Hide()
        Else
        End If
    End Sub

    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        If e.Button =
                  Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub


End Class