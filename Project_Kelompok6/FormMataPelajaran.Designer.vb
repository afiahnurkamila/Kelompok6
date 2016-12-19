<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMataPelajaran
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
        Dim Id_mata_pelajaranLabel As System.Windows.Forms.Label
        Dim Nama_mata_pelajaranLabel As System.Windows.Forms.Label
        Dim KkmLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMataPelajaran))
        Me.Project_kel6DataSet = New Project_Kelompok6.project_kel6DataSet()
        Me.Mata_pelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mata_pelajaranTableAdapter = New Project_Kelompok6.project_kel6DataSetTableAdapters.mata_pelajaranTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.Mata_pelajaranDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_mata_pelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_mata_pelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.KkmTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Id_mata_pelajaranLabel = New System.Windows.Forms.Label()
        Nama_mata_pelajaranLabel = New System.Windows.Forms.Label()
        KkmLabel = New System.Windows.Forms.Label()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_pelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_mata_pelajaranLabel
        '
        Id_mata_pelajaranLabel.AutoSize = True
        Id_mata_pelajaranLabel.Location = New System.Drawing.Point(8, 103)
        Id_mata_pelajaranLabel.Name = "Id_mata_pelajaranLabel"
        Id_mata_pelajaranLabel.Size = New System.Drawing.Size(90, 13)
        Id_mata_pelajaranLabel.TabIndex = 1
        Id_mata_pelajaranLabel.Text = "id mata pelajaran:"
        '
        'Nama_mata_pelajaranLabel
        '
        Nama_mata_pelajaranLabel.AutoSize = True
        Nama_mata_pelajaranLabel.Location = New System.Drawing.Point(8, 129)
        Nama_mata_pelajaranLabel.Name = "Nama_mata_pelajaranLabel"
        Nama_mata_pelajaranLabel.Size = New System.Drawing.Size(108, 13)
        Nama_mata_pelajaranLabel.TabIndex = 3
        Nama_mata_pelajaranLabel.Text = "nama mata pelajaran:"
        '
        'KkmLabel
        '
        KkmLabel.AutoSize = True
        KkmLabel.Location = New System.Drawing.Point(8, 155)
        KkmLabel.Name = "KkmLabel"
        KkmLabel.Size = New System.Drawing.Size(30, 13)
        KkmLabel.TabIndex = 5
        KkmLabel.Text = "kkm:"
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mata_pelajaranBindingSource
        '
        Me.Mata_pelajaranBindingSource.DataMember = "mata_pelajaran"
        Me.Mata_pelajaranBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'Mata_pelajaranTableAdapter
        '
        Me.Mata_pelajaranTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.guruTableAdapter = Nothing
        Me.TableAdapterManager.kelasTableAdapter = Nothing
        Me.TableAdapterManager.mata_pelajaranTableAdapter = Me.Mata_pelajaranTableAdapter
        Me.TableAdapterManager.siswaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mata_pelajaranDataGridView
        '
        Me.Mata_pelajaranDataGridView.AutoGenerateColumns = False
        Me.Mata_pelajaranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mata_pelajaranDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Mata_pelajaranDataGridView.DataSource = Me.Mata_pelajaranBindingSource
        Me.Mata_pelajaranDataGridView.Location = New System.Drawing.Point(271, 100)
        Me.Mata_pelajaranDataGridView.Name = "Mata_pelajaranDataGridView"
        Me.Mata_pelajaranDataGridView.Size = New System.Drawing.Size(343, 142)
        Me.Mata_pelajaranDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_mata_pelajaran"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_mata_pelajaran"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_mata_pelajaran"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_mata_pelajaran"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kkm"
        Me.DataGridViewTextBoxColumn3.HeaderText = "kkm"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Id_mata_pelajaranTextBox
        '
        Me.Id_mata_pelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "id_mata_pelajaran", True))
        Me.Id_mata_pelajaranTextBox.Location = New System.Drawing.Point(122, 100)
        Me.Id_mata_pelajaranTextBox.Name = "Id_mata_pelajaranTextBox"
        Me.Id_mata_pelajaranTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Id_mata_pelajaranTextBox.TabIndex = 2
        '
        'Nama_mata_pelajaranTextBox
        '
        Me.Nama_mata_pelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "nama_mata_pelajaran", True))
        Me.Nama_mata_pelajaranTextBox.Location = New System.Drawing.Point(122, 126)
        Me.Nama_mata_pelajaranTextBox.Name = "Nama_mata_pelajaranTextBox"
        Me.Nama_mata_pelajaranTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Nama_mata_pelajaranTextBox.TabIndex = 4
        '
        'KkmTextBox
        '
        Me.KkmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "kkm", True))
        Me.KkmTextBox.Location = New System.Drawing.Point(122, 152)
        Me.KkmTextBox.Name = "KkmTextBox"
        Me.KkmTextBox.Size = New System.Drawing.Size(143, 20)
        Me.KkmTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 43)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Data Mata Pelajaran"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 219)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 39
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(175, 219)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 38
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(12, 219)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 37
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(175, 190)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 36
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(94, 190)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 35
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 190)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 34
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'FormMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 253)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Id_mata_pelajaranLabel)
        Me.Controls.Add(Me.Id_mata_pelajaranTextBox)
        Me.Controls.Add(Nama_mata_pelajaranLabel)
        Me.Controls.Add(Me.Nama_mata_pelajaranTextBox)
        Me.Controls.Add(KkmLabel)
        Me.Controls.Add(Me.KkmTextBox)
        Me.Controls.Add(Me.Mata_pelajaranDataGridView)
        Me.Name = "FormMataPelajaran"
        Me.Text = "FormMataPelajaran"
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_pelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Project_kel6DataSet As Project_Kelompok6.project_kel6DataSet
    Friend WithEvents Mata_pelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mata_pelajaranTableAdapter As Project_Kelompok6.project_kel6DataSetTableAdapters.mata_pelajaranTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mata_pelajaranDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_mata_pelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_mata_pelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KkmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
End Class
