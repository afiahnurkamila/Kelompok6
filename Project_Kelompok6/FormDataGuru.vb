Public Class FormDataGuru

    Private Sub GuruBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GuruBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub GuruBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuruBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GuruBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormDataGuru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.guru' table. You can move, or remove it, as needed.
        Me.GuruTableAdapter.Fill(Me.Project_kel6DataSet.guru)

    End Sub
End Class