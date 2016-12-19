Public Class FormMataPelajaran

    Private Sub Mata_pelajaranBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Mata_pelajaranBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub Mata_pelajaranDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mata_pelajaranDataGridView.CellContentClick

    End Sub
End Class