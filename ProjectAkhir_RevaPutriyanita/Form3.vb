Imports MySql.Data.MySqlClient
Public Class Form3
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
        sql = "insert into tbjenjang values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
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
            da = New MySqlDataAdapter("select *from tbjenjang order by id_jenjang", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tbjenjang")
            Me.DataGridView1.DataSource = (ds.Tables("tbjenjang"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        simpan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Maaf datanya tidak ada yang diupdate")
        Else
            MsgBox("Anda akan mengupdate datanya ya")
            Dim edit As String
            edit = "update tbjenjang set id_jenjang ='" & TextBox1.Text & "', jenjang='" & TextBox2.Text & "'where id_jenjang='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(edit, Con)
            cmd.ExecuteNonQuery()
            tampil()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Jenjang yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan id_jenjang=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from tbjenjang where id_jenjang='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
            End If
        End If

    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tampil()
        Label8.Text = Format(Now, "dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class