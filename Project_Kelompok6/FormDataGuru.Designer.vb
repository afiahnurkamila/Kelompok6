<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataGuru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataGuru))
        Me.Project_kel6DataSet = New Project_Kelompok6.project_kel6DataSet()
        Me.GuruBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuruTableAdapter = New Project_Kelompok6.project_kel6DataSetTableAdapters.guruTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.GuruBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.GuruBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuruBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuruBindingSource
        '
        Me.GuruBindingSource.DataMember = "guru"
        Me.GuruBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'GuruTableAdapter
        '
        Me.GuruTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.guruTableAdapter = Me.GuruTableAdapter
        Me.TableAdapterManager.kelasTableAdapter = Nothing
        Me.TableAdapterManager.mata_pelajaranTableAdapter = Nothing
        Me.TableAdapterManager.siswaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GuruBindingNavigator
        '
        Me.GuruBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GuruBindingNavigator.BindingSource = Me.GuruBindingSource
        Me.GuruBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GuruBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GuruBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GuruBindingNavigatorSaveItem})
        Me.GuruBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GuruBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GuruBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GuruBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GuruBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GuruBindingNavigator.Name = "GuruBindingNavigator"
        Me.GuruBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GuruBindingNavigator.Size = New System.Drawing.Size(109, 25)
        Me.GuruBindingNavigator.TabIndex = 0
        Me.GuruBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'GuruBindingNavigatorSaveItem
        '
        Me.GuruBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuruBindingNavigatorSaveItem.Image = CType(resources.GetObject("GuruBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GuruBindingNavigatorSaveItem.Name = "GuruBindingNavigatorSaveItem"
        Me.GuruBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.GuruBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FormDataGuru
        '
        Me.ClientSize = New System.Drawing.Size(697, 353)
        Me.Controls.Add(Me.GuruBindingNavigator)
        Me.Name = "FormDataGuru"
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuruBindingNavigator.ResumeLayout(False)
        Me.GuruBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

