Public Class FormMenuUtama

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        MessageBox.Show("T E R I M A   K A S I H !")
        End
    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DATAGURUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAGURUToolStripMenuItem.Click
        Me.Hide()
        FormGuru.Show()
    End Sub

    Private Sub DATASISWAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATASISWAToolStripMenuItem.Click
        Me.Hide()
        FormSiswa.Show()
    End Sub

    Private Sub MATAPELAJARANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATAPELAJARANToolStripMenuItem.Click
        Me.Hide()
        FormMataPelajaran.Show()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelasToolStripMenuItem.Click
        Me.Hide()
        FormKelas.Show()
    End Sub
End Class