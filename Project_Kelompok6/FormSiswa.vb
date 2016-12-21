Public Class FormSiswa

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        SiswaBindingSource.AddNew()

        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.SiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet1)
        MessageBox.Show("Data anda telah tersimpan !!!")

        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        SiswaBindingSource.RemoveCurrent()
        MessageBox.Show("Data anda telah terhapus !!!")

        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatRichTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

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