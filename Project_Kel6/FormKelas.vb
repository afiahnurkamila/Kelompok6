Public Class FormKelas

    Private Sub KelasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KelasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormKelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.kelas' table. You can move, or remove it, as needed.
        Me.KelasTableAdapter.Fill(Me.Project_kel6DataSet.kelas)

    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
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
    End Sub
End Class