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
End Class