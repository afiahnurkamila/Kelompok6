Public Class FormGuru

    Private Sub GuruBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GuruBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormGuru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.guru' table. You can move, or remove it, as needed.
        Me.GuruTableAdapter.Fill(Me.Project_kel6DataSet.guru)

    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
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
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = False
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
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
        ButtonHapus.Enabled = False
        ButtonKeluar.Enabled = True
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
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
    End Sub
End Class
