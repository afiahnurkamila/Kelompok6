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
        Dim Nip_guruLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataGuru))
        Dim Nip_guruLabel1 As System.Windows.Forms.Label
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
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Nip_guruTextBox1 = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_lahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_lahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JenkelTextBox = New System.Windows.Forms.TextBox()
        Me.No_telponTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PendidikanTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Nip_guruLabel = New System.Windows.Forms.Label()
        Nip_guruLabel1 = New System.Windows.Forms.Label()
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
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nip_guruLabel
        '
        Nip_guruLabel.AutoSize = True
        Nip_guruLabel.Location = New System.Drawing.Point(1, -16)
        Nip_guruLabel.Name = "Nip_guruLabel"
        Nip_guruLabel.Size = New System.Drawing.Size(48, 13)
        Nip_guruLabel.TabIndex = 7
        Nip_guruLabel.Text = "nip guru:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 43)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Guru"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
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
        'GuruDataGridView
        '
        Me.GuruDataGridView.AutoGenerateColumns = False
        Me.GuruDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GuruDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.GuruDataGridView.DataSource = Me.GuruBindingSource
        Me.GuruDataGridView.Location = New System.Drawing.Point(317, 97)
        Me.GuruDataGridView.Name = "GuruDataGridView"
        Me.GuruDataGridView.Size = New System.Drawing.Size(619, 361)
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
        'Nip_guruTextBox
        '
        Me.Nip_guruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "nip_guru", True))
        Me.Nip_guruTextBox.Location = New System.Drawing.Point(74, -19)
        Me.Nip_guruTextBox.Name = "Nip_guruTextBox"
        Me.Nip_guruTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nip_guruTextBox.TabIndex = 8
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(111, 353)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 39
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(193, 353)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 38
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(30, 353)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 37
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(193, 324)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 36
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(112, 324)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 35
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(30, 324)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 34
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Nip_guruLabel1)
        Me.GroupBox1.Controls.Add(Me.Nip_guruTextBox1)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Tempat_lahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tempat_lahirTextBox)
        Me.GroupBox1.Controls.Add(Tanggal_lahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tanggal_lahirDateTimePicker)
        Me.GroupBox1.Controls.Add(JenkelLabel)
        Me.GroupBox1.Controls.Add(Me.JenkelTextBox)
        Me.GroupBox1.Controls.Add(No_telponLabel)
        Me.GroupBox1.Controls.Add(Me.No_telponTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(PendidikanLabel)
        Me.GroupBox1.Controls.Add(Me.PendidikanTextBox)
        Me.GroupBox1.Controls.Add(AgamaLabel)
        Me.GroupBox1.Controls.Add(Me.AgamaTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(Nip_guruLabel)
        Me.GroupBox1.Controls.Add(Me.Nip_guruTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 382)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Isi Data"
        '
        'Nip_guruLabel1
        '
        Nip_guruLabel1.AutoSize = True
        Nip_guruLabel1.Location = New System.Drawing.Point(9, 21)
        Nip_guruLabel1.Name = "Nip_guruLabel1"
        Nip_guruLabel1.Size = New System.Drawing.Size(57, 13)
        Nip_guruLabel1.TabIndex = 39
        Nip_guruLabel1.Text = "NIP Guru :"
        '
        'Nip_guruTextBox1
        '
        Me.Nip_guruTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "nip_guru", True))
        Me.Nip_guruTextBox1.Location = New System.Drawing.Point(89, 18)
        Me.Nip_guruTextBox1.Name = "Nip_guruTextBox1"
        Me.Nip_guruTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Nip_guruTextBox1.TabIndex = 40
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(9, 47)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(41, 13)
        NamaLabel.TabIndex = 41
        NamaLabel.Text = "Nama :"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(89, 44)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 42
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(9, 75)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(45, 13)
        AlamatLabel.TabIndex = 43
        AlamatLabel.Text = "Alamat :"
        '
        'Tempat_lahirLabel
        '
        Tempat_lahirLabel.AutoSize = True
        Tempat_lahirLabel.Location = New System.Drawing.Point(7, 145)
        Tempat_lahirLabel.Name = "Tempat_lahirLabel"
        Tempat_lahirLabel.Size = New System.Drawing.Size(75, 13)
        Tempat_lahirLabel.TabIndex = 45
        Tempat_lahirLabel.Text = "Tempat Lahir :"
        '
        'Tempat_lahirTextBox
        '
        Me.Tempat_lahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "tempat_lahir", True))
        Me.Tempat_lahirTextBox.Location = New System.Drawing.Point(87, 142)
        Me.Tempat_lahirTextBox.Name = "Tempat_lahirTextBox"
        Me.Tempat_lahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tempat_lahirTextBox.TabIndex = 46
        '
        'Tanggal_lahirLabel
        '
        Tanggal_lahirLabel.AutoSize = True
        Tanggal_lahirLabel.Location = New System.Drawing.Point(7, 172)
        Tanggal_lahirLabel.Name = "Tanggal_lahirLabel"
        Tanggal_lahirLabel.Size = New System.Drawing.Size(78, 13)
        Tanggal_lahirLabel.TabIndex = 47
        Tanggal_lahirLabel.Text = "Tanggal Lahir :"
        '
        'Tanggal_lahirDateTimePicker
        '
        Me.Tanggal_lahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GuruBindingSource, "tanggal_lahir", True))
        Me.Tanggal_lahirDateTimePicker.Location = New System.Drawing.Point(87, 168)
        Me.Tanggal_lahirDateTimePicker.Name = "Tanggal_lahirDateTimePicker"
        Me.Tanggal_lahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_lahirDateTimePicker.TabIndex = 48
        '
        'JenkelLabel
        '
        JenkelLabel.AutoSize = True
        JenkelLabel.Location = New System.Drawing.Point(9, 194)
        JenkelLabel.Name = "JenkelLabel"
        JenkelLabel.Size = New System.Drawing.Size(44, 13)
        JenkelLabel.TabIndex = 49
        JenkelLabel.Text = "Jenkel :"
        '
        'JenkelTextBox
        '
        Me.JenkelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "jenkel", True))
        Me.JenkelTextBox.Location = New System.Drawing.Point(87, 194)
        Me.JenkelTextBox.Name = "JenkelTextBox"
        Me.JenkelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JenkelTextBox.TabIndex = 50
        '
        'No_telponLabel
        '
        No_telponLabel.AutoSize = True
        No_telponLabel.Location = New System.Drawing.Point(7, 223)
        No_telponLabel.Name = "No_telponLabel"
        No_telponLabel.Size = New System.Drawing.Size(66, 13)
        No_telponLabel.TabIndex = 51
        No_telponLabel.Text = "No. Telpon :"
        '
        'No_telponTextBox
        '
        Me.No_telponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "no_telpon", True))
        Me.No_telponTextBox.Location = New System.Drawing.Point(87, 220)
        Me.No_telponTextBox.Name = "No_telponTextBox"
        Me.No_telponTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_telponTextBox.TabIndex = 52
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(7, 246)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(43, 13)
        StatusLabel.TabIndex = 53
        StatusLabel.Text = "Status :"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(87, 246)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 54
        '
        'PendidikanLabel
        '
        PendidikanLabel.AutoSize = True
        PendidikanLabel.Location = New System.Drawing.Point(7, 275)
        PendidikanLabel.Name = "PendidikanLabel"
        PendidikanLabel.Size = New System.Drawing.Size(63, 13)
        PendidikanLabel.TabIndex = 55
        PendidikanLabel.Text = "Pendidikan:"
        '
        'PendidikanTextBox
        '
        Me.PendidikanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "pendidikan", True))
        Me.PendidikanTextBox.Location = New System.Drawing.Point(87, 272)
        Me.PendidikanTextBox.Name = "PendidikanTextBox"
        Me.PendidikanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PendidikanTextBox.TabIndex = 56
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Location = New System.Drawing.Point(7, 301)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(46, 13)
        AgamaLabel.TabIndex = 57
        AgamaLabel.Text = "Agama :"
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "agama", True))
        Me.AgamaTextBox.Location = New System.Drawing.Point(87, 298)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgamaTextBox.TabIndex = 58
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(87, 72)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 62)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = ""
        '
        'FormDataGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 477)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GuruDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormDataGuru"
        Me.Text = "Data Guru SMP Bunga Nusantara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Nip_guruTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_lahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_lahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenkelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PendidikanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
