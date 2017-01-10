Public Class Mainform

    Private Sub GuruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuruToolStripMenuItem.Click
        Me.Hide()
        FormGuru.Show()
    End Sub

    Private Sub SiswaSiswiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiswaSiswiToolStripMenuItem.Click
        Me.Hide()
        FormSiswa.Show()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelasToolStripMenuItem.Click
        Me.Hide()
        FormKelas.Show()
    End Sub

    Private Sub MataPelajaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MataPelajaranToolStripMenuItem.Click
        Me.Hide()
        FormMatpel.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MessageBox.Show("<<<<  T E R I M A  K A S I H  >>>>")
        End
    End Sub
End Class