Public Class Form2
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub IsiTingkatJenjangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IsiTingkatJenjangToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub IsiDataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IsiDataMahasiswaToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
        Form3.Hide()
    End Sub

    Private Sub IsiDataBiayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IsiDataBiayaToolStripMenuItem.Click
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub TransaksiKRSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiKRSToolStripMenuItem.Click
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub TrasaksiUangKampusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrasaksiUangKampusToolStripMenuItem.Click
        Form7.MdiParent = Me
        Form7.Show()
    End Sub

    Private Sub MenghitungNilaiMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenghitungNilaiMahasiswaToolStripMenuItem.Click
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If MsgBox("Apakah Anda Ingin Keluar??", MsgBoxStyle.YesNo, "EXIT!") = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub BerandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerandaToolStripMenuItem.Click
        Me.Show()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
        Form9.Hide()
    End Sub
End Class