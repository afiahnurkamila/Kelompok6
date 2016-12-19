Public Class FormLogin

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = 1234 And TextBox2.Text = 5678 Then
            Me.Hide()
            FormMenuUtama.Show()
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MessageBox.Show("Password Salah")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

End Class
