﻿Public Class FormLogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Close()
        MessageBox.Show("TERIMA KASIH !")
        End
    End Sub

    Private Sub ButtonMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMasuk.Click
        If TextBoxUsername.Text = "admin" Or
            TextBoxPassword.Text = "1234" Then
            Me.Hide()
            Mainform.Show()
            TextBoxUsername.Clear()
        Else
            MessageBox.Show("Username / Password salah !!!")
            TextBoxUsername.Clear()
            TextBoxPassword.Clear()
        End If
    End Sub

<<<<<<< HEAD
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

=======
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show(" -- Selamat Datang di Database SMP Bunga Nusantara -- ")
>>>>>>> 0093f04a6494706c2bcc57af5b30d82ac5a14c87
    End Sub
End Class