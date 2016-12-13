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
        Dim Nip_guruLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Tempat_lahirLabel As System.Windows.Forms.Label
        Dim Tanggal_lahirLabel As System.Windows.Forms.Label
        Dim JenkelLabel As System.Windows.Forms.Label
        Dim No_telponLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PendidikanLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.GuruDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nip_guruTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_lahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JenkelTextBox = New System.Windows.Forms.TextBox()
        Me.No_telponTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PendidikanTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Nip_guruLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Tempat_lahirLabel = New System.Windows.Forms.Label()
        Tanggal_lahirLabel = New System.Windows.Forms.Label()
        JenkelLabel = New System.Windows.Forms.Label()
        No_telponLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PendidikanLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuruBindingNavigator.SuspendLayout()
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 43)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Guru"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
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
        Me.GuruBindingNavigator.Size = New System.Drawing.Size(1367, 25)
        Me.GuruBindingNavigator.TabIndex = 7
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'GuruBindingNavigatorSaveItem
        '
        Me.GuruBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuruBindingNavigatorSaveItem.Image = CType(resources.GetObject("GuruBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GuruBindingNavigatorSaveItem.Name = "GuruBindingNavigatorSaveItem"
        Me.GuruBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GuruBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GuruDataGridView
        '
        Me.GuruDataGridView.AutoGenerateColumns = False
        Me.GuruDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GuruDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.GuruDataGridView.DataSource = Me.GuruBindingSource
        Me.GuruDataGridView.Location = New System.Drawing.Point(301, 103)
        Me.GuruDataGridView.Name = "GuruDataGridView"
        Me.GuruDataGridView.Size = New System.Drawing.Size(1043, 260)
        Me.GuruDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nip_guru"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nip_guru"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tempat_lahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tempat_lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tanggal_lahir"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tanggal_lahir"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "jenkel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "jenkel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "no_telpon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "no_telpon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "pendidikan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "pendidikan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "agama"
        Me.DataGridViewTextBoxColumn10.HeaderText = "agama"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Nip_guruLabel
        '
        Nip_guruLabel.AutoSize = True
        Nip_guruLabel.Location = New System.Drawing.Point(10, 106)
        Nip_guruLabel.Name = "Nip_guruLabel"
        Nip_guruLabel.Size = New System.Drawing.Size(48, 13)
        Nip_guruLabel.TabIndex = 7
        Nip_guruLabel.Text = "nip guru:"
        '
        'Nip_guruTextBox
        '
        Me.Nip_guruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "nip_guru", True))
        Me.Nip_guruTextBox.Location = New System.Drawing.Point(83, 103)
        Me.Nip_guruTextBox.Name = "Nip_guruTextBox"
        Me.Nip_guruTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nip_guruTextBox.TabIndex = 8
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(10, 132)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 9
        NamaLabel.Text = "nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(83, 129)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 10
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(10, 158)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(41, 13)
        AlamatLabel.TabIndex = 11
        AlamatLabel.Text = "alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(83, 155)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AlamatTextBox.TabIndex = 12
        '
        'Tempat_lahirLabel
        '
        Tempat_lahirLabel.AutoSize = True
        Tempat_lahirLabel.Location = New System.Drawing.Point(10, 184)
        Tempat_lahirLabel.Name = "Tempat_lahirLabel"
        Tempat_lahirLabel.Size = New System.Drawing.Size(64, 13)
        Tempat_lahirLabel.TabIndex = 13
        Tempat_lahirLabel.Text = "tempat lahir:"
        '
        'Tempat_lahirTextBox
        '
        Me.Tempat_lahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "tempat_lahir", True))
        Me.Tempat_lahirTextBox.Location = New System.Drawing.Point(83, 181)
        Me.Tempat_lahirTextBox.Name = "Tempat_lahirTextBox"
        Me.Tempat_lahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tempat_lahirTextBox.TabIndex = 14
        '
        'Tanggal_lahirLabel
        '
        Tanggal_lahirLabel.AutoSize = True
        Tanggal_lahirLabel.Location = New System.Drawing.Point(10, 211)
        Tanggal_lahirLabel.Name = "Tanggal_lahirLabel"
        Tanggal_lahirLabel.Size = New System.Drawing.Size(67, 13)
        Tanggal_lahirLabel.TabIndex = 15
        Tanggal_lahirLabel.Text = "tanggal lahir:"
        '
        'Tanggal_lahirDateTimePicker
        '
        Me.Tanggal_lahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GuruBindingSource, "tanggal_lahir", True))
        Me.Tanggal_lahirDateTimePicker.Location = New System.Drawing.Point(83, 207)
        Me.Tanggal_lahirDateTimePicker.Name = "Tanggal_lahirDateTimePicker"
        Me.Tanggal_lahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_lahirDateTimePicker.TabIndex = 16
        '
        'JenkelLabel
        '
        JenkelLabel.AutoSize = True
        JenkelLabel.Location = New System.Drawing.Point(10, 236)
        JenkelLabel.Name = "JenkelLabel"
        JenkelLabel.Size = New System.Drawing.Size(38, 13)
        JenkelLabel.TabIndex = 17
        JenkelLabel.Text = "jenkel:"
        '
        'JenkelTextBox
        '
        Me.JenkelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "jenkel", True))
        Me.JenkelTextBox.Location = New System.Drawing.Point(83, 233)
        Me.JenkelTextBox.Name = "JenkelTextBox"
        Me.JenkelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JenkelTextBox.TabIndex = 18
        '
        'No_telponLabel
        '
        No_telponLabel.AutoSize = True
        No_telponLabel.Location = New System.Drawing.Point(10, 262)
        No_telponLabel.Name = "No_telponLabel"
        No_telponLabel.Size = New System.Drawing.Size(54, 13)
        No_telponLabel.TabIndex = 19
        No_telponLabel.Text = "no telpon:"
        '
        'No_telponTextBox
        '
        Me.No_telponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "no_telpon", True))
        Me.No_telponTextBox.Location = New System.Drawing.Point(83, 259)
        Me.No_telponTextBox.Name = "No_telponTextBox"
        Me.No_telponTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_telponTextBox.TabIndex = 20
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(10, 288)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(38, 13)
        StatusLabel.TabIndex = 21
        StatusLabel.Text = "status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(83, 285)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 22
        '
        'PendidikanLabel
        '
        PendidikanLabel.AutoSize = True
        PendidikanLabel.Location = New System.Drawing.Point(10, 314)
        PendidikanLabel.Name = "PendidikanLabel"
        PendidikanLabel.Size = New System.Drawing.Size(62, 13)
        PendidikanLabel.TabIndex = 23
        PendidikanLabel.Text = "pendidikan:"
        '
        'PendidikanTextBox
        '
        Me.PendidikanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "pendidikan", True))
        Me.PendidikanTextBox.Location = New System.Drawing.Point(83, 311)
        Me.PendidikanTextBox.Name = "PendidikanTextBox"
        Me.PendidikanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PendidikanTextBox.TabIndex = 24
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Location = New System.Drawing.Point(10, 340)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(42, 13)
        AgamaLabel.TabIndex = 25
        AgamaLabel.Text = "agama:"
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "agama", True))
        Me.AgamaTextBox.Location = New System.Drawing.Point(83, 337)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgamaTextBox.TabIndex = 26
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(176, 402)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 31
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(13, 402)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 30
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(176, 373)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 29
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(94, 373)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 28
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(13, 373)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 27
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(94, 402)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 32
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'FormDataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 514)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Nip_guruLabel)
        Me.Controls.Add(Me.Nip_guruTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(Tempat_lahirLabel)
        Me.Controls.Add(Me.Tempat_lahirTextBox)
        Me.Controls.Add(Tanggal_lahirLabel)
        Me.Controls.Add(Me.Tanggal_lahirDateTimePicker)
        Me.Controls.Add(JenkelLabel)
        Me.Controls.Add(Me.JenkelTextBox)
        Me.Controls.Add(No_telponLabel)
        Me.Controls.Add(Me.No_telponTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(PendidikanLabel)
        Me.Controls.Add(Me.PendidikanTextBox)
        Me.Controls.Add(AgamaLabel)
        Me.Controls.Add(Me.AgamaTextBox)
        Me.Controls.Add(Me.GuruDataGridView)
        Me.Controls.Add(Me.GuruBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormDataGuru"
        Me.Text = "FormDataGuru"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuruBindingNavigator.ResumeLayout(False)
        Me.GuruBindingNavigator.PerformLayout()
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Project_kel6DataSet As Project_Kelompok6.project_kel6DataSet
    Friend WithEvents GuruBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuruTableAdapter As Project_Kelompok6.project_kel6DataSetTableAdapters.guruTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GuruBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuruBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuruDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nip_guruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_lahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_lahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenkelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PendidikanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
End Class
