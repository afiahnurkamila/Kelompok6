<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatpel
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
        Dim ID_Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim Nama_Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim KKMLabel As System.Windows.Forms.Label
        Dim NIP_GuruLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMatpel))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ID_Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.Mata_pelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_kel6DataSet = New Project_Kel6.project_kel6DataSet()
        Me.Nama_Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.KKMTextBox = New System.Windows.Forms.TextBox()
        Me.NIP_GuruTextBox = New System.Windows.Forms.TextBox()
        Me.Mata_pelajaranTableAdapter = New Project_Kel6.project_kel6DataSetTableAdapters.mata_pelajaranTableAdapter()
        Me.TableAdapterManager = New Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager()
        Me.Mata_pelajaranDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_Mata_PelajaranLabel = New System.Windows.Forms.Label()
        Nama_Mata_PelajaranLabel = New System.Windows.Forms.Label()
        KKMLabel = New System.Windows.Forms.Label()
        NIP_GuruLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Mata_pelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_Mata_PelajaranLabel
        '
        ID_Mata_PelajaranLabel.AutoSize = True
        ID_Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 16)
        ID_Mata_PelajaranLabel.Name = "ID_Mata_PelajaranLabel"
        ID_Mata_PelajaranLabel.Size = New System.Drawing.Size(95, 13)
        ID_Mata_PelajaranLabel.TabIndex = 0
        ID_Mata_PelajaranLabel.Text = "ID Mata Pelajaran:"
        '
        'Nama_Mata_PelajaranLabel
        '
        Nama_Mata_PelajaranLabel.AutoSize = True
        Nama_Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 42)
        Nama_Mata_PelajaranLabel.Name = "Nama_Mata_PelajaranLabel"
        Nama_Mata_PelajaranLabel.Size = New System.Drawing.Size(112, 13)
        Nama_Mata_PelajaranLabel.TabIndex = 2
        Nama_Mata_PelajaranLabel.Text = "Nama Mata Pelajaran:"
        '
        'KKMLabel
        '
        KKMLabel.AutoSize = True
        KKMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KKMLabel.Location = New System.Drawing.Point(6, 68)
        KKMLabel.Name = "KKMLabel"
        KKMLabel.Size = New System.Drawing.Size(33, 13)
        KKMLabel.TabIndex = 4
        KKMLabel.Text = "KKM:"
        '
        'NIP_GuruLabel
        '
        NIP_GuruLabel.AutoSize = True
        NIP_GuruLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIP_GuruLabel.Location = New System.Drawing.Point(6, 94)
        NIP_GuruLabel.Name = "NIP_GuruLabel"
        NIP_GuruLabel.Size = New System.Drawing.Size(54, 13)
        NIP_GuruLabel.TabIndex = 6
        NIP_GuruLabel.Text = "NIP Guru:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 28)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Data Mata Pelajaran"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(ID_Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.ID_Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(Nama_Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(KKMLabel)
        Me.GroupBox1.Controls.Add(Me.KKMTextBox)
        Me.GroupBox1.Controls.Add(NIP_GuruLabel)
        Me.GroupBox1.Controls.Add(Me.NIP_GuruTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 179)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Isikan Data :"
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(110, 146)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 49
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(29, 146)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 48
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(191, 117)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 47
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(110, 117)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 46
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(29, 117)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 45
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ID_Mata_PelajaranTextBox
        '
        Me.ID_Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "ID_Mata_Pelajaran", True))
        Me.ID_Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Mata_PelajaranTextBox.Location = New System.Drawing.Point(144, 13)
        Me.ID_Mata_PelajaranTextBox.Name = "ID_Mata_PelajaranTextBox"
        Me.ID_Mata_PelajaranTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ID_Mata_PelajaranTextBox.TabIndex = 1
        '
        'Mata_pelajaranBindingSource
        '
        Me.Mata_pelajaranBindingSource.DataMember = "mata_pelajaran"
        Me.Mata_pelajaranBindingSource.DataSource = Me.Project_kel6DataSet
        '
        'Project_kel6DataSet
        '
        Me.Project_kel6DataSet.DataSetName = "project_kel6DataSet"
        Me.Project_kel6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_Mata_PelajaranTextBox
        '
        Me.Nama_Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "Nama_Mata_Pelajaran", True))
        Me.Nama_Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_Mata_PelajaranTextBox.Location = New System.Drawing.Point(144, 39)
        Me.Nama_Mata_PelajaranTextBox.Name = "Nama_Mata_PelajaranTextBox"
        Me.Nama_Mata_PelajaranTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Nama_Mata_PelajaranTextBox.TabIndex = 3
        '
        'KKMTextBox
        '
        Me.KKMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "KKM", True))
        Me.KKMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KKMTextBox.Location = New System.Drawing.Point(144, 65)
        Me.KKMTextBox.Name = "KKMTextBox"
        Me.KKMTextBox.Size = New System.Drawing.Size(165, 20)
        Me.KKMTextBox.TabIndex = 5
        '
        'NIP_GuruTextBox
        '
        Me.NIP_GuruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "NIP_Guru", True))
        Me.NIP_GuruTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIP_GuruTextBox.Location = New System.Drawing.Point(144, 91)
        Me.NIP_GuruTextBox.Name = "NIP_GuruTextBox"
        Me.NIP_GuruTextBox.Size = New System.Drawing.Size(165, 20)
        Me.NIP_GuruTextBox.TabIndex = 7
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
        Me.TableAdapterManager.UpdateOrder = Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mata_pelajaranDataGridView
        '
        Me.Mata_pelajaranDataGridView.AutoGenerateColumns = False
        Me.Mata_pelajaranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mata_pelajaranDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Mata_pelajaranDataGridView.DataSource = Me.Mata_pelajaranBindingSource
        Me.Mata_pelajaranDataGridView.Location = New System.Drawing.Point(329, 62)
        Me.Mata_pelajaranDataGridView.Name = "Mata_pelajaranDataGridView"
        Me.Mata_pelajaranDataGridView.Size = New System.Drawing.Size(443, 176)
        Me.Mata_pelajaranDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Mata_Pelajaran"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KKM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "KKM"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NIP_Guru"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIP_Guru"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FormMatpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 246)
        Me.Controls.Add(Me.Mata_pelajaranDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMatpel"
        Me.Text = "Data Mata Pelajaran SMP Bunga Nusantara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Mata_pelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Project_kel6DataSet As Project_Kel6.project_kel6DataSet
    Friend WithEvents Mata_pelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mata_pelajaranTableAdapter As Project_Kel6.project_kel6DataSetTableAdapters.mata_pelajaranTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kel6.project_kel6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_Mata_PelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_Mata_PelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KKMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIP_GuruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Mata_pelajaranDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
