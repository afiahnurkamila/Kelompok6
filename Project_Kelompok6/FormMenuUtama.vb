Public Class FormMenuUtama

    Private Sub MATAPELAJARANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATAPELAJARANToolStripMenuItem.Click
        Me.Hide()
        FormMataPelajaran.Show()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelasToolStripMenuItem.Click
        Me.Hide()
        FormKelas.Show()
    End Sub

    Private Sub DATASISWAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATASISWAToolStripMenuItem.Click
        Me.Hide()
        FormDataSiswa.Show()
    End Sub

    Private Sub DATAGURUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAGURUToolStripMenuItem.Click
        Me.Hide()
        FormDataGuru.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        End
    End Sub

End Class