<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSiswa
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
        Dim NisLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Tempat_lahirLabel As System.Windows.Forms.Label
        Dim Tanggal_lahirLabel As System.Windows.Forms.Label
        Dim JenkelLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataSiswa))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Project_kel6DataSet = New Project_Kelompok6.project_kel6DataSet()
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswaTableAdapter = New Project_Kelompok6.project_kel6DataSetTableAdapters.siswaTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.SiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NisTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_lahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JenkelTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        NisLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Tempat_lahirLabel = New System.Windows.Forms.Label()
        Tanggal_lahirLabel = New System.Windows.Forms.Label()
        JenkelLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NisLabel
        '
        NisLabel.AutoSize = True
        NisLabel.Location = New System.Drawing.Point(15, 26)
        NisLabel.Name = "NisLabel"
        NisLabel.Size = New System.Drawing.Size(31, 13)
        NisLabel.TabIndex = 5
        NisLabel.Text = "NIS :"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(15, 52)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 7
        NamaLabel.Text = "Nama:"
        '
        'Tempat_lahirLabel
        '
        Tempat_lahirLabel.AutoSize = True
        Tempat_lahirLabel.Location = New System.Drawing.Point(15, 78)
        Tempat_lahirLabel.Name = "Tempat_lahirLabel"
        Tempat_lahirLabel.Size = New System.Drawing.Size(75, 13)
        Tempat_lahirLabel.TabIndex = 9
        Tempat_lahirLabel.Text = "Tempat Lahir :"
        '
        'Tanggal_lahirLabel
        '
        Tanggal_lahirLabel.AutoSize = True
        Tanggal_lahirLabel.Location = New System.Drawing.Point(15, 105)
        Tanggal_lahirLabel.Name = "Tanggal_lahirLabel"
        Tanggal_lahirLabel.Size = New System.Drawing.Size(78, 13)
        Tanggal_lahirLabel.TabIndex = 11
        Tanggal_lahirLabel.Text = "Tanggal Lahir :"
        '
        'JenkelLabel
        '
        JenkelLabel.AutoSize = True
        JenkelLabel.Location = New System.Drawing.Point(15, 130)
        JenkelLabel.Name = "JenkelLabel"
        JenkelLabel.Size = New System.Drawing.Size(44, 13)
        JenkelLabel.TabIndex = 13
        JenkelLabel.Text = "Jenkel :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(15, 156)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(45, 13)
        AlamatLabel.TabIndex = 15
        AlamatLabel.Text = "Alamat :"
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Location = New System.Drawing.Point(15, 233)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(46, 13)
        AgamaLabel.TabIndex = 17
        AgamaLabel.Text = "Agama :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Siswa dan Siswi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataMember = "siswa"
        Me.SiswaBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'SiswaTableAdapter
        '
        Me.SiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.guruTableAdapter = Nothing
        Me.TableAdapterManager.kelasTableAdapter = Nothing
        Me.TableAdapterManager.mata_pelajaranTableAdapter = Nothing
        Me.TableAdapterManager.siswaTableAdapter = Me.SiswaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SiswaDataGridView
        '
        Me.SiswaDataGridView.AutoGenerateColumns = False
        Me.SiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SiswaDataGridView.DataSource = Me.SiswaBindingSource
        Me.SiswaDataGridView.Location = New System.Drawing.Point(328, 100)
        Me.SiswaDataGridView.Name = "SiswaDataGridView"
        Me.SiswaDataGridView.Size = New System.Drawing.Size(543, 323)
        Me.SiswaDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nis"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nis"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tempat_lahir"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tempat_lahir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tanggal_lahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tanggal_lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "jenkel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "jenkel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn6.HeaderText = "alamat"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "agama"
        Me.DataGridViewTextBoxColumn7.HeaderText = "agama"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'NisTextBox
        '
        Me.NisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "nis", True))
        Me.NisTextBox.Location = New System.Drawing.Point(100, 23)
        Me.NisTextBox.Name = "NisTextBox"
        Me.NisTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NisTextBox.TabIndex = 6
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(100, 49)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 8
        '
        'Tempat_lahirTextBox
        '
        Me.Tempat_lahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "tempat_lahir", True))
        Me.Tempat_lahirTextBox.Location = New System.Drawing.Point(100, 75)
        Me.Tempat_lahirTextBox.Name = "Tempat_lahirTextBox"
        Me.Tempat_lahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tempat_lahirTextBox.TabIndex = 10
        '
        'Tanggal_lahirDateTimePicker
        '
        Me.Tanggal_lahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SiswaBindingSource, "tanggal_lahir", True))
        Me.Tanggal_lahirDateTimePicker.Location = New System.Drawing.Point(100, 101)
        Me.Tanggal_lahirDateTimePicker.Name = "Tanggal_lahirDateTimePicker"
        Me.Tanggal_lahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_lahirDateTimePicker.TabIndex = 12
        '
        'JenkelTextBox
        '
        Me.JenkelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "jenkel", True))
        Me.JenkelTextBox.Location = New System.Drawing.Point(100, 127)
        Me.JenkelTextBox.Name = "JenkelTextBox"
        Me.JenkelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JenkelTextBox.TabIndex = 14
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "agama", True))
        Me.AgamaTextBox.Location = New System.Drawing.Point(100, 230)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgamaTextBox.TabIndex = 18
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(38, 261)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 19
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(120, 261)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 20
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(201, 261)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 21
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(38, 290)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 22
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(201, 290)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 23
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(119, 290)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 33
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(100, 153)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 62)
        Me.RichTextBox1.TabIndex = 42
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.AgamaTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(AgamaLabel)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.JenkelTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(JenkelLabel)
        Me.GroupBox1.Controls.Add(Me.Tanggal_lahirDateTimePicker)
        Me.GroupBox1.Controls.Add(Tanggal_lahirLabel)
        Me.GroupBox1.Controls.Add(NisLabel)
        Me.GroupBox1.Controls.Add(Me.Tempat_lahirTextBox)
        Me.GroupBox1.Controls.Add(Me.NisTextBox)
        Me.GroupBox1.Controls.Add(Tempat_lahirLabel)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 328)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Isi Data"
        '
        'FormDataSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 430)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SiswaDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormDataSiswa"
        Me.Text = "Data Siswa/i SMP Bunga Nusantara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Project_kel6DataSet As Project_Kelompok6.project_kel6DataSet
    Friend WithEvents SiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiswaTableAdapter As Project_Kelompok6.project_kel6DataSetTableAdapters.siswaTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_lahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_lahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenkelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
