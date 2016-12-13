Public Class FormMataPelajaran

    Private Sub Mata_pelajaranBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Mata_pelajaranBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormMataPelajaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.mata_pelajaran' table. You can move, or remove it, as needed.
        Me.Mata_pelajaranTableAdapter.Fill(Me.Project_kel6DataSet.mata_pelajaran)

    End Sub

    Private Sub Mata_pelajaranDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mata_pelajaranDataGridView.CellContentClick

    End Sub
End Class