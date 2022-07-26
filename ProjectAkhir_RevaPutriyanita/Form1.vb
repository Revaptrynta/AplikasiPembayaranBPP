Public Class Form1
    Private Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        'Username = admin dan passwordnya adalah = 1234'
        If txtusername.Text = "admin" And txtpassword.Text = "1234" Then
            MsgBox("Anda telah berhasil login", vbInformation, "Masuk")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Password yang anda masukan Salah!", vbCritical + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub txtcancel_Click(sender As Object, e As EventArgs) Handles txtcancel.Click
        Me.Close()
    End Sub
End Class
