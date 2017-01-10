Public Class FormGuru

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        GuruBindingSource.AddNew()

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        No_TelponTextBox.Enabled = True
        StatusTextBox.Enabled = True
        PendidikanTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_Mata_PelajaranTextBox.Enabled = True
        Mata_PelajaranTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        No_TelponTextBox.Enabled = True
        StatusTextBox.Enabled = True
        PendidikanTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_Mata_PelajaranTextBox.Enabled = True
        Mata_PelajaranTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.GuruBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)
        MessageBox.Show("Data anda Tersimpan !!!")

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        No_TelponTextBox.Enabled = True
        StatusTextBox.Enabled = True
        PendidikanTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_Mata_PelajaranTextBox.Enabled = True
        Mata_PelajaranTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        GuruBindingSource.RemoveCurrent()
        MessageBox.Show("Data Telah Terhapus !!!")

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        No_TelponTextBox.Enabled = True
        StatusTextBox.Enabled = True
        PendidikanTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_Mata_PelajaranTextBox.Enabled = True
        Mata_PelajaranTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
