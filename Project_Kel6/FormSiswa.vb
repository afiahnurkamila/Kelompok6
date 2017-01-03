Public Class FormSiswa

    Private Sub SiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.siswa' table. You can move, or remove it, as needed.
        Me.SiswaTableAdapter.Fill(Me.Project_kel6DataSet.siswa)

    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        NISTextBox.Enabled = True
        NamaTextBox.Enabled = True
        Tempat_LahirTextBox.Enabled = True
        Tanggal_LahirDateTimePicker.Enabled = True
        JenkelTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        AgamaTextBox.Enabled = True
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Me.Hide()
    End Sub
End Class