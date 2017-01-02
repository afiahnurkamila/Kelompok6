Public Class FormKelas

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        KelasBindingSource.AddNew()

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NISTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NISTextBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.KelasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet1)
        MessageBox.Show("Data anda telah tersimpan !!!")

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NISTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        KelasBindingSource.RemoveCurrent()
        MessageBox.Show("Data anda telah terhapus !!!")

        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NISTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ID_KelasTextBox.Enabled = True
        KelasTextBox.Enabled = True
        NIP_GuruTextBox.Enabled = True
        NISTextBox.Enabled = True

        ButtonTambah.Enabled = True
        ButtonEdit.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = False
        ButtonRefresh.Enabled = True
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        FormMenuUtama.Show()
    End Sub
End Class