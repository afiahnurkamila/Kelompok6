﻿Public Class FormKelas

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        KelasBindingSource.AddNew()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        KelasBindingSource.RemoveCurrent()
        MessageBox.Show("Data Telah Terhapus !!!")
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Me.Validate()
        Me.KelasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)
        MessageBox.Show("Data Telah Tersimpan !!!")
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click

    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        KelasBindingSource.CancelEdit()
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        End
    End Sub
End Class