<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelas
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
        Dim Id_kelasLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKelas))
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Project_kel6DataSet = New Project_Kelompok6.project_kel6DataSet()
        Me.KelasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelasTableAdapter = New Project_Kelompok6.project_kel6DataSetTableAdapters.kelasTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.KelasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_kelasTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Id_kelasLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_kelasLabel
        '
        Id_kelasLabel.AutoSize = True
        Id_kelasLabel.Location = New System.Drawing.Point(25, 120)
        Id_kelasLabel.Name = "Id_kelasLabel"
        Id_kelasLabel.Size = New System.Drawing.Size(46, 13)
        Id_kelasLabel.TabIndex = 43
        Id_kelasLabel.Text = "id kelas:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(25, 146)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(35, 13)
        KelasLabel.TabIndex = 45
        KelasLabel.Text = "kelas:"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 211)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 39
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(175, 211)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 38
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(12, 211)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 37
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(175, 182)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 36
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(94, 182)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 35
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 182)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 34
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 43)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 43)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Data Kelas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KelasBindingSource
        '
        Me.KelasBindingSource.DataMember = "kelas"
        Me.KelasBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'KelasTableAdapter
        '
        Me.KelasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.guruTableAdapter = Nothing
        Me.TableAdapterManager.kelasTableAdapter = Me.KelasTableAdapter
        Me.TableAdapterManager.mata_pelajaranTableAdapter = Nothing
        Me.TableAdapterManager.siswaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KelasDataGridView
        '
        Me.KelasDataGridView.AutoGenerateColumns = False
        Me.KelasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KelasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.KelasDataGridView.DataSource = Me.KelasBindingSource
        Me.KelasDataGridView.Location = New System.Drawing.Point(267, 108)
        Me.KelasDataGridView.Name = "KelasDataGridView"
        Me.KelasDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.KelasDataGridView.TabIndex = 43
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_kelas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_kelas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "kelas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Id_kelasTextBox
        '
        Me.Id_kelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "id_kelas", True))
        Me.Id_kelasTextBox.Location = New System.Drawing.Point(77, 117)
        Me.Id_kelasTextBox.Name = "Id_kelasTextBox"
        Me.Id_kelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_kelasTextBox.TabIndex = 44
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KelasBindingSource, "kelas", True))
        Me.KelasTextBox.Location = New System.Drawing.Point(77, 143)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KelasTextBox.TabIndex = 46
        '
        'FormKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 506)
        Me.Controls.Add(Id_kelasLabel)
        Me.Controls.Add(Me.Id_kelasTextBox)
        Me.Controls.Add(KelasLabel)
        Me.Controls.Add(Me.KelasTextBox)
        Me.Controls.Add(Me.KelasDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Name = "FormKelas"
        Me.Text = "FormKelas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Project_kel6DataSet As Project_Kelompok6.project_kel6DataSet
    Friend WithEvents KelasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KelasTableAdapter As Project_Kelompok6.project_kel6DataSetTableAdapters.kelasTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents KelasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_kelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
End Class
