Public Class Form8
    Sub cetakuangkampus()
        Label47.Text = Form7.TextBox1.Text
        Label25.Text = Form7.TextBox5.Text
        Label24.Text = Form7.Label18.Text
        Label33.Text = Form7.ComboBox1.Text
        Label32.Text = Form7.TextBox2.Text
        Label31.Text = Form7.TextBox3.Text
        Label30.Text = Form7.TextBox6.Text
        Label29.Text = Form7.TextBox4.Text
        Label28.Text = Form7.Label12.Text
        Label27.Text = Form7.TextBox7.Text
        Label26.Text = Form7.TextBox8.Text
    End Sub
    Sub cetaksks()
        Label46.Text = Form6.TextBox1.Text
        Label20.Text = Form6.TextBox4.Text
        Label21.Text = Form6.Label17.Text
        Label12.Text = Form6.ComboBox2.Text
        Label13.Text = Form6.TextBox2.Text
        Label14.Text = Form6.TextBox6.Text
        Label15.Text = Form6.TextBox5.Text
        Label16.Text = Form6.TextBox3.Text
        Label17.Text = Form6.Label13.Text
        Label18.Text = Form6.TextBox7.Text
        Label19.Text = Form6.TextBox8.Text
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Call cetakuangkampus()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cetakuangkampus()
        Call cetaksks()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Call cetaksks()
    End Sub
End Class