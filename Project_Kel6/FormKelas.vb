Public Class FormKelas

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        KelasBindingSource.AddNew()

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NIP_SiswaTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NIP_SiswaTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.KelasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)
        MessageBox.Show("Data anda Tersimpan !!!")

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NIP_SiswaTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        KelasBindingSource.RemoveCurrent()
        MessageBox.Show("Data anda Terhapus !!!")

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NIP_SiswaTextBox.Enabled = True

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
End Class