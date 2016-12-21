<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuru
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
        Dim NIP_GuruLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Tempat_LahirLabel As System.Windows.Forms.Label
        Dim Tanggal_LahirLabel As System.Windows.Forms.Label
        Dim JenkelLabel As System.Windows.Forms.Label
        Dim No_TelponLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PendidikanLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Dim ID_Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGuru))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlamatRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NIP_GuruTextBox = New System.Windows.Forms.TextBox()
        Me.GuruBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_kel6DataSet1 = New Project_Kelompok6.project_kel6DataSet1()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tempat_LahirTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_LahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JenkelTextBox = New System.Windows.Forms.TextBox()
        Me.No_TelponTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PendidikanTextBox = New System.Windows.Forms.TextBox()
        Me.AgamaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.GuruTableAdapter = New Project_Kelompok6.project_kel6DataSet1TableAdapters.guruTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NIP_GuruLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Tempat_LahirLabel = New System.Windows.Forms.Label()
        Tanggal_LahirLabel = New System.Windows.Forms.Label()
        JenkelLabel = New System.Windows.Forms.Label()
        No_TelponLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PendidikanLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        ID_Mata_PelajaranLabel = New System.Windows.Forms.Label()
        Mata_PelajaranLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIP_GuruLabel
        '
        NIP_GuruLabel.AutoSize = True
        NIP_GuruLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIP_GuruLabel.Location = New System.Drawing.Point(6, 21)
        NIP_GuruLabel.Name = "NIP_GuruLabel"
        NIP_GuruLabel.Size = New System.Drawing.Size(54, 13)
        NIP_GuruLabel.TabIndex = 6
        NIP_GuruLabel.Text = "NIP Guru:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLabel.Location = New System.Drawing.Point(6, 47)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 8
        NamaLabel.Text = "Nama:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.Location = New System.Drawing.Point(6, 73)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 10
        AlamatLabel.Text = "Alamat:"
        '
        'Tempat_LahirLabel
        '
        Tempat_LahirLabel.AutoSize = True
        Tempat_LahirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tempat_LahirLabel.Location = New System.Drawing.Point(6, 158)
        Tempat_LahirLabel.Name = "Tempat_LahirLabel"
        Tempat_LahirLabel.Size = New System.Drawing.Size(72, 13)
        Tempat_LahirLabel.TabIndex = 12
        Tempat_LahirLabel.Text = "Tempat Lahir:"
        '
        'Tanggal_LahirLabel
        '
        Tanggal_LahirLabel.AutoSize = True
        Tanggal_LahirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tanggal_LahirLabel.Location = New System.Drawing.Point(6, 185)
        Tanggal_LahirLabel.Name = "Tanggal_LahirLabel"
        Tanggal_LahirLabel.Size = New System.Drawing.Size(75, 13)
        Tanggal_LahirLabel.TabIndex = 14
        Tanggal_LahirLabel.Text = "Tanggal Lahir:"
        '
        'JenkelLabel
        '
        JenkelLabel.AutoSize = True
        JenkelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JenkelLabel.Location = New System.Drawing.Point(6, 210)
        JenkelLabel.Name = "JenkelLabel"
        JenkelLabel.Size = New System.Drawing.Size(41, 13)
        JenkelLabel.TabIndex = 16
        JenkelLabel.Text = "Jenkel:"
        '
        'No_TelponLabel
        '
        No_TelponLabel.AutoSize = True
        No_TelponLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_TelponLabel.Location = New System.Drawing.Point(6, 236)
        No_TelponLabel.Name = "No_TelponLabel"
        No_TelponLabel.Size = New System.Drawing.Size(60, 13)
        No_TelponLabel.TabIndex = 18
        No_TelponLabel.Text = "No Telpon:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(6, 262)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 20
        StatusLabel.Text = "Status:"
        '
        'PendidikanLabel
        '
        PendidikanLabel.AutoSize = True
        PendidikanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PendidikanLabel.Location = New System.Drawing.Point(6, 288)
        PendidikanLabel.Name = "PendidikanLabel"
        PendidikanLabel.Size = New System.Drawing.Size(63, 13)
        PendidikanLabel.TabIndex = 22
        PendidikanLabel.Text = "Pendidikan:"
        '
        'AgamaLabel
        '
        AgamaLabel.AutoSize = True
        AgamaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgamaLabel.Location = New System.Drawing.Point(6, 314)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(43, 13)
        AgamaLabel.TabIndex = 24
        AgamaLabel.Text = "Agama:"
        '
        'ID_Mata_PelajaranLabel
        '
        ID_Mata_PelajaranLabel.AutoSize = True
        ID_Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 340)
        ID_Mata_PelajaranLabel.Name = "ID_Mata_PelajaranLabel"
        ID_Mata_PelajaranLabel.Size = New System.Drawing.Size(95, 13)
        ID_Mata_PelajaranLabel.TabIndex = 26
        ID_Mata_PelajaranLabel.Text = "ID Mata Pelajaran:"
        '
        'Mata_PelajaranLabel
        '
        Mata_PelajaranLabel.AutoSize = True
        Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 366)
        Mata_PelajaranLabel.Name = "Mata_PelajaranLabel"
        Mata_PelajaranLabel.Size = New System.Drawing.Size(81, 13)
        Mata_PelajaranLabel.TabIndex = 28
        Mata_PelajaranLabel.Text = "Mata Pelajaran:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Guru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlamatRichTextBox)
        Me.GroupBox1.Controls.Add(NIP_GuruLabel)
        Me.GroupBox1.Controls.Add(Me.NIP_GuruTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Tempat_LahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tempat_LahirTextBox)
        Me.GroupBox1.Controls.Add(Tanggal_LahirLabel)
        Me.GroupBox1.Controls.Add(Me.Tanggal_LahirDateTimePicker)
        Me.GroupBox1.Controls.Add(JenkelLabel)
        Me.GroupBox1.Controls.Add(Me.JenkelTextBox)
        Me.GroupBox1.Controls.Add(No_TelponLabel)
        Me.GroupBox1.Controls.Add(Me.No_TelponTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(PendidikanLabel)
        Me.GroupBox1.Controls.Add(Me.PendidikanTextBox)
        Me.GroupBox1.Controls.Add(AgamaLabel)
        Me.GroupBox1.Controls.Add(Me.AgamaTextBox)
        Me.GroupBox1.Controls.Add(ID_Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.ID_Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 451)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mohon Isi Data"
        '
        'AlamatRichTextBox
        '
        Me.AlamatRichTextBox.Location = New System.Drawing.Point(105, 70)
        Me.AlamatRichTextBox.Name = "AlamatRichTextBox"
        Me.AlamatRichTextBox.Size = New System.Drawing.Size(200, 79)
        Me.AlamatRichTextBox.TabIndex = 30
        Me.AlamatRichTextBox.Text = ""
        '
        'NIP_GuruTextBox
        '
        Me.NIP_GuruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "NIP_Guru", True))
        Me.NIP_GuruTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIP_GuruTextBox.Location = New System.Drawing.Point(105, 18)
        Me.NIP_GuruTextBox.Name = "NIP_GuruTextBox"
        Me.NIP_GuruTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIP_GuruTextBox.TabIndex = 7
        '
        'GuruBindingSource
        '
        Me.GuruBindingSource.DataMember = "guru"
        Me.GuruBindingSource.DataSource = Me.Project_kel6DataSet1
        '
        'Project_kel6DataSet1
        '
        Me.Project_kel6DataSet1.DataSetName = "project_kel6DataSet1"
        Me.Project_kel6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Nama", True))
        Me.NamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTextBox.Location = New System.Drawing.Point(105, 44)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaTextBox.TabIndex = 9
        '
        'Tempat_LahirTextBox
        '
        Me.Tempat_LahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Tempat_Lahir", True))
        Me.Tempat_LahirTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tempat_LahirTextBox.Location = New System.Drawing.Point(105, 155)
        Me.Tempat_LahirTextBox.Name = "Tempat_LahirTextBox"
        Me.Tempat_LahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tempat_LahirTextBox.TabIndex = 13
        '
        'Tanggal_LahirDateTimePicker
        '
        Me.Tanggal_LahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GuruBindingSource, "Tanggal_Lahir", True))
        Me.Tanggal_LahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal_LahirDateTimePicker.Location = New System.Drawing.Point(105, 181)
        Me.Tanggal_LahirDateTimePicker.Name = "Tanggal_LahirDateTimePicker"
        Me.Tanggal_LahirDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal_LahirDateTimePicker.TabIndex = 15
        '
        'JenkelTextBox
        '
        Me.JenkelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Jenkel", True))
        Me.JenkelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenkelTextBox.Location = New System.Drawing.Point(105, 207)
        Me.JenkelTextBox.Name = "JenkelTextBox"
        Me.JenkelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JenkelTextBox.TabIndex = 17
        '
        'No_TelponTextBox
        '
        Me.No_TelponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "No_Telpon", True))
        Me.No_TelponTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_TelponTextBox.Location = New System.Drawing.Point(105, 233)
        Me.No_TelponTextBox.Name = "No_TelponTextBox"
        Me.No_TelponTextBox.Size = New System.Drawing.Size(200, 20)
        Me.No_TelponTextBox.TabIndex = 19
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(105, 259)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 21
        '
        'PendidikanTextBox
        '
        Me.PendidikanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Pendidikan", True))
        Me.PendidikanTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendidikanTextBox.Location = New System.Drawing.Point(105, 285)
        Me.PendidikanTextBox.Name = "PendidikanTextBox"
        Me.PendidikanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PendidikanTextBox.TabIndex = 23
        '
        'AgamaTextBox
        '
        Me.AgamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Agama", True))
        Me.AgamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgamaTextBox.Location = New System.Drawing.Point(105, 311)
        Me.AgamaTextBox.Name = "AgamaTextBox"
        Me.AgamaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgamaTextBox.TabIndex = 25
        '
        'ID_Mata_PelajaranTextBox
        '
        Me.ID_Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "ID_Mata_Pelajaran", True))
        Me.ID_Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Mata_PelajaranTextBox.Location = New System.Drawing.Point(105, 337)
        Me.ID_Mata_PelajaranTextBox.Name = "ID_Mata_PelajaranTextBox"
        Me.ID_Mata_PelajaranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_Mata_PelajaranTextBox.TabIndex = 27
        '
        'Mata_PelajaranTextBox
        '
        Me.Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuruBindingSource, "Mata_Pelajaran", True))
        Me.Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mata_PelajaranTextBox.Location = New System.Drawing.Point(105, 363)
        Me.Mata_PelajaranTextBox.Name = "Mata_PelajaranTextBox"
        Me.Mata_PelajaranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mata_PelajaranTextBox.TabIndex = 29
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeluar.Location = New System.Drawing.Point(206, 420)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(86, 23)
        Me.ButtonKeluar.TabIndex = 5
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(114, 420)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(86, 23)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Location = New System.Drawing.Point(22, 420)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(86, 23)
        Me.ButtonHapus.TabIndex = 3
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Location = New System.Drawing.Point(206, 391)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(86, 23)
        Me.ButtonSimpan.TabIndex = 2
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(114, 391)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(86, 23)
        Me.ButtonEdit.TabIndex = 1
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(22, 391)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(86, 23)
        Me.ButtonTambah.TabIndex = 0
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GuruDataGridView
        '
        Me.GuruDataGridView.AutoGenerateColumns = False
        Me.GuruDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GuruDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.GuruDataGridView.DataSource = Me.GuruBindingSource
        Me.GuruDataGridView.Location = New System.Drawing.Point(329, 83)
        Me.GuruDataGridView.Name = "GuruDataGridView"
        Me.GuruDataGridView.Size = New System.Drawing.Size(622, 445)
        Me.GuruDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIP_Guru"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIP_Guru"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tempat_Lahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tempat_Lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tanggal_Lahir"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Jenkel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Jenkel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "No_Telpon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "No_Telpon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Pendidikan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Pendidikan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Agama"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Agama"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'FormGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 540)
        Me.Controls.Add(Me.GuruDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormGuru"
        Me.Text = "Form Guru SMP Bunga Nusantara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Project_kel6DataSet1 As Project_Kelompok6.project_kel6DataSet1
    Friend WithEvents GuruBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuruTableAdapter As Project_Kelompok6.project_kel6DataSet1TableAdapters.guruTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AlamatRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NIP_GuruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tempat_LahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_LahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JenkelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_TelponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PendidikanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_Mata_PelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mata_PelajaranTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
