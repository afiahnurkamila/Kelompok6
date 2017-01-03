Public Class FormMataPelajaran

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Mata_pelajaranBindingSource.AddNew()

        ID_Mata_PelajaranTextBox.Enabled = True
        Nama_Mata_PelajaranTextBox.Enabled = True
        KKMTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        ID_Mata_PelajaranTextBox.Enabled = True
        Nama_Mata_PelajaranTextBox.Enabled = True
        KKMTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.Mata_pelajaranBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet1)
        MessageBox.Show("Data anda telah tersimpan !!!")

        ID_Mata_PelajaranTextBox.Enabled = True
        Nama_Mata_PelajaranTextBox.Enabled = True
        KKMTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Mata_pelajaranBindingSource.RemoveCurrent()
        MessageBox.Show("Data anda telah terhapus !!!")

        ID_Mata_PelajaranTextBox.Enabled = True
        Nama_Mata_PelajaranTextBox.Enabled = True
        KKMTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Hide()
        FormMenuUtama.Show()
    End Sub
End Class