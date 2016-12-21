Public Class FormGuru

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        GuruBindingSource.AddNew()

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
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
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        No_TelponTextBox.Enabled = True
        StatusTextBox.Enabled = True
        PendidikanTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_Mata_PelajaranTextBox.Enabled = True
        Mata_PelajaranTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.GuruBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet1)
        MessageBox.Show("Data anda telah tersimpan !!!")

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
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
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        GuruBindingSource.RemoveCurrent()
        MessageBox.Show("Data anda telah terhapus !!!")

        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
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
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        NIP_GuruTextBox.Enabled = True
        NamaTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
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
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Hide()
        FormMenuUtama.Show()
    End Sub
End Class