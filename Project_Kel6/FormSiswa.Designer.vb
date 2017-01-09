<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiswa
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
        Dim NISLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Tempat_LahirLabel As System.Windows.Forms.Label
        Dim Tanggal_LahirLabel As System.Windows.Forms.Label
        Dim JenkelLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Dim ID_KelasLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiswa))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_kel6DataSet = New Project_Kel6.project_kel6DataSet()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_LahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_LahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JenkelTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_KelasTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.SiswaTableAdapter = New Project_Kel6.project_kel6DataSetTableAdapters.siswaTableAdapter()
        Me.TableAdapterManager = New Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.SiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Tempat_LahirLabel = New System.Windows.Forms.Label()
        Tanggal_LahirLabel = New System.Windows.Forms.Label()
        JenkelLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        ID_KelasLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NISLabel.Location = New System.Drawing.Point(8, 16)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 0
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(8, 42)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'Tempat_LahirLabel
        '
        Tempat_LahirLabel.AutoSize = True
        Tempat_LahirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tempat_LahirLabel.Location = New System.Drawing.Point(8, 68)
        Tempat_LahirLabel.Name = "Tempat_LahirLabel"
        Tempat_LahirLabel.Size = New System.Drawing.Size(72, 13)
        Tempat_LahirLabel.TabIndex = 4
        Tempat_LahirLabel.Text = "Tempat Lahir:"
        '
        'Tanggal_LahirLabel
        '
        Tanggal_LahirLabel.AutoSize = True
        Tanggal_LahirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tanggal_LahirLabel.Location = New System.Drawing.Point(8, 95)
        Tanggal_LahirLabel.Name = "Tanggal_LahirLabel"
        Tanggal_LahirLabel.Size = New System.Drawing.Size(75, 13)
        Tanggal_LahirLabel.TabIndex = 6
        Tanggal_LahirLabel.Text = "Tanggal Lahir:"
        '
        'JenkelLabel
        '
        JenkelLabel.AutoSize = True
        JenkelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JenkelLabel.Location = New System.Drawing.Point(8, 120)
        JenkelLabel.Name = "JenkelLabel"
        JenkelLabel.Size = New System.Drawing.Size(41, 13)
        JenkelLabel.TabIndex = 8
        JenkelLabel.Text = "Jenkel:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.Location = New System.Drawing.Point(8, 146)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 10
        AlamatLabel.Text = "Alamat:"
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgamaLabel.Location = New System.Drawing.Point(8, 172)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(43, 13)
        AgamaLabel.TabIndex = 12
        AgamaLabel.Text = "Agama:"
        '
        'ID_KelasLabel
        '
        ID_KelasLabel.AutoSize = True
        ID_KelasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_KelasLabel.Location = New System.Drawing.Point(8, 198)
        ID_KelasLabel.Name = "ID_KelasLabel"
        ID_KelasLabel.Size = New System.Drawing.Size(50, 13)
        ID_KelasLabel.TabIndex = 14
        ID_KelasLabel.Text = "ID Kelas:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KelasLabel.Location = New System.Drawing.Point(8, 224)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 16
        KelasLabel.Text = "Kelas:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 28)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 28)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Data Siswa dan Siswi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(NISLabel)
        Me.GroupBox1.Controls.Add(Me.NISTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(Tempat_LahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tempat_LahirTextBox)
        Me.GroupBox1.Controls.Add(Tanggal_LahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tanggal_LahirDateTimePicker)
        Me.GroupBox1.Controls.Add(JenkelLabel)
        Me.GroupBox1.Controls.Add(Me.JenkelTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(AgamaLabel)
        Me.GroupBox1.Controls.Add(Me.AgamaTextBox)
        Me.GroupBox1.Controls.Add(ID_KelasLabel)
        Me.GroupBox1.Controls.Add(Me.ID_KelasTextBox)
        Me.GroupBox1.Controls.Add(KelasLabel)
        Me.GroupBox1.Controls.Add(Me.KelasTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 285)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Isikan Data :"
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonKeluar.Location = New System.Drawing.Point(334, 251)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 34
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonHapus.Location = New System.Drawing.Point(253, 251)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 33
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSimpan.Location = New System.Drawing.Point(172, 250)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 32
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonEdit.Location = New System.Drawing.Point(91, 251)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 31
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonTambah.Location = New System.Drawing.Point(10, 251)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 30
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "NIS", True))
        Me.NISTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NISTextBox.Location = New System.Drawing.Point(103, 13)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(312, 20)
        Me.NISTextBox.TabIndex = 1
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataMember = "siswa"
        Me.SiswaBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Nama", True))
        Me.NamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTextBox.Location = New System.Drawing.Point(103, 39)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(312, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'Tempat_LahirTextBox
        '
        Me.Tempat_LahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Tempat_Lahir", True))
        Me.Tempat_LahirTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tempat_LahirTextBox.Location = New System.Drawing.Point(103, 65)
        Me.Tempat_LahirTextBox.Name = "Tempat_LahirTextBox"
        Me.Tempat_LahirTextBox.Size = New System.Drawing.Size(312, 20)
        Me.Tempat_LahirTextBox.TabIndex = 5
        '
        'Tanggal_LahirDateTimePicker
        '
        Me.Tanggal_LahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SiswaBindingSource, "Tanggal_Lahir", True))
        Me.Tanggal_LahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal_LahirDateTimePicker.Location = New System.Drawing.Point(103, 91)
        Me.Tanggal_LahirDateTimePicker.Name = "Tanggal_LahirDateTimePicker"
        Me.Tanggal_LahirDateTimePicker.Size = New System.Drawing.Size(312, 20)
        Me.Tanggal_LahirDateTimePicker.TabIndex = 7
        '
        'JenkelTextBox
        '
        Me.JenkelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Jenkel", True))
        Me.JenkelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenkelTextBox.Location = New System.Drawing.Point(103, 117)
        Me.JenkelTextBox.Name = "JenkelTextBox"
        Me.JenkelTextBox.Size = New System.Drawing.Size(312, 20)
        Me.JenkelTextBox.TabIndex = 9
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Alamat", True))
        Me.AlamatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(103, 143)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(312, 20)
        Me.AlamatTextBox.TabIndex = 11
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Agama", True))
        Me.AgamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgamaTextBox.Location = New System.Drawing.Point(103, 169)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(312, 20)
        Me.AgamaTextBox.TabIndex = 13
        '
        'ID_KelasTextBox
        '
        Me.ID_KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "ID_Kelas", True))
        Me.ID_KelasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_KelasTextBox.Location = New System.Drawing.Point(103, 195)
        Me.ID_KelasTextBox.Name = "ID_KelasTextBox"
        Me.ID_KelasTextBox.Size = New System.Drawing.Size(312, 20)
        Me.ID_KelasTextBox.TabIndex = 15
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource, "Kelas", True))
        Me.KelasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KelasTextBox.Location = New System.Drawing.Point(103, 221)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(312, 20)
        Me.KelasTextBox.TabIndex = 17
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
        Me.TableAdapterManager.UpdateOrder = Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SiswaDataGridView
        '
        Me.SiswaDataGridView.AutoGenerateColumns = False
        Me.SiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.SiswaDataGridView.DataSource = Me.SiswaBindingSource
        Me.SiswaDataGridView.Location = New System.Drawing.Point(430, 61)
        Me.SiswaDataGridView.Name = "SiswaDataGridView"
        Me.SiswaDataGridView.Size = New System.Drawing.Size(511, 285)
        Me.SiswaDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tempat_Lahir"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tempat_Lahir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Jenkel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Jenkel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Agama"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Agama"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Kelas"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID_Kelas"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Kelas"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 359)
        Me.Controls.Add(Me.SiswaDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSiswa"
        Me.Text = "Data Siswa dan Siswi SMP Bunga Nusanatara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Project_kel6DataSet As Project_Kel6.project_kel6DataSet
    Friend WithEvents SiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiswaTableAdapter As Project_Kel6.project_kel6DataSetTableAdapters.siswaTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_LahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_LahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenkelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents SiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
