Public Class FormDataSiswa

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_kel6DataSet)

    End Sub

    Private Sub FormDataSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project_kel6DataSet.siswa' table. You can move, or remove it, as needed.
        Me.SiswaTableAdapter.Fill(Me.Project_kel6DataSet.siswa)

    End Sub
End Class