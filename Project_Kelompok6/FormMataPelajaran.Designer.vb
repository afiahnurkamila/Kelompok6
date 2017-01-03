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
        Dim ID_Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim Nama_Mata_PelajaranLabel As System.Windows.Forms.Label
        Dim KKMLabel As System.Windows.Forms.Label
        Dim NIP_GuruLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMataPelajaran))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.Mata_pelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_kel6DataSet1 = New Project_Kelompok6.project_kel6DataSet1()
        Me.Nama_Mata_PelajaranTextBox = New System.Windows.Forms.TextBox()
        Me.KKMTextBox = New System.Windows.Forms.TextBox()
        Me.NIP_GuruTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Mata_pelajaranTableAdapter = New Project_Kelompok6.project_kel6DataSet1TableAdapters.mata_pelajaranTableAdapter()
        Me.TableAdapterManager = New Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager()
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
        CType(Me.Project_kel6DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_Mata_PelajaranLabel
        '
        ID_Mata_PelajaranLabel.AutoSize = True
        ID_Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 25)
        ID_Mata_PelajaranLabel.Name = "ID_Mata_PelajaranLabel"
        ID_Mata_PelajaranLabel.Size = New System.Drawing.Size(95, 13)
        ID_Mata_PelajaranLabel.TabIndex = 11
        ID_Mata_PelajaranLabel.Text = "ID Mata Pelajaran:"
        '
        'Nama_Mata_PelajaranLabel
        '
        Nama_Mata_PelajaranLabel.AutoSize = True
        Nama_Mata_PelajaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_Mata_PelajaranLabel.Location = New System.Drawing.Point(6, 51)
        Nama_Mata_PelajaranLabel.Name = "Nama_Mata_PelajaranLabel"
        Nama_Mata_PelajaranLabel.Size = New System.Drawing.Size(112, 13)
        Nama_Mata_PelajaranLabel.TabIndex = 13
        Nama_Mata_PelajaranLabel.Text = "Nama Mata Pelajaran:"
        '
        'KKMLabel
        '
        KKMLabel.AutoSize = True
        KKMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KKMLabel.Location = New System.Drawing.Point(6, 77)
        KKMLabel.Name = "KKMLabel"
        KKMLabel.Size = New System.Drawing.Size(33, 13)
        KKMLabel.TabIndex = 15
        KKMLabel.Text = "KKM:"
        '
        'NIP_GuruLabel
        '
        NIP_GuruLabel.AutoSize = True
        NIP_GuruLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIP_GuruLabel.Location = New System.Drawing.Point(6, 103)
        NIP_GuruLabel.Name = "NIP_GuruLabel"
        NIP_GuruLabel.Size = New System.Drawing.Size(54, 13)
        NIP_GuruLabel.TabIndex = 17
        NIP_GuruLabel.Text = "NIP Guru:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 36)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SMP Bunga Nusantara"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Mata Pelajaran"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ID_Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.ID_Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(Nama_Mata_PelajaranLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_Mata_PelajaranTextBox)
        Me.GroupBox1.Controls.Add(KKMLabel)
        Me.GroupBox1.Controls.Add(Me.KKMTextBox)
        Me.GroupBox1.Controls.Add(NIP_GuruLabel)
        Me.GroupBox1.Controls.Add(Me.NIP_GuruTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonKeluar)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 187)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mohon Isi Data"
        '
        'ID_Mata_PelajaranTextBox
        '
        Me.ID_Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "ID_Mata_Pelajaran", True))
        Me.ID_Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Mata_PelajaranTextBox.Location = New System.Drawing.Point(144, 22)
        Me.ID_Mata_PelajaranTextBox.Name = "ID_Mata_PelajaranTextBox"
        Me.ID_Mata_PelajaranTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ID_Mata_PelajaranTextBox.TabIndex = 12
        '
        'Mata_pelajaranBindingSource
        '
        Me.Mata_pelajaranBindingSource.DataMember = "mata_pelajaran"
        Me.Mata_pelajaranBindingSource.DataSource = Me.Project_kel6DataSet1
        '
        'Project_kel6DataSet1
        '
        Me.Project_kel6DataSet1.DataSetName = "project_kel6DataSet1"
        Me.Project_kel6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_Mata_PelajaranTextBox
        '
        Me.Nama_Mata_PelajaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "Nama_Mata_Pelajaran", True))
        Me.Nama_Mata_PelajaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_Mata_PelajaranTextBox.Location = New System.Drawing.Point(144, 48)
        Me.Nama_Mata_PelajaranTextBox.Name = "Nama_Mata_PelajaranTextBox"
        Me.Nama_Mata_PelajaranTextBox.Size = New System.Drawing.Size(134, 20)
        Me.Nama_Mata_PelajaranTextBox.TabIndex = 14
        '
        'KKMTextBox
        '
        Me.KKMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "KKM", True))
        Me.KKMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KKMTextBox.Location = New System.Drawing.Point(144, 74)
        Me.KKMTextBox.Name = "KKMTextBox"
        Me.KKMTextBox.Size = New System.Drawing.Size(134, 20)
        Me.KKMTextBox.TabIndex = 16
        '
        'NIP_GuruTextBox
        '
        Me.NIP_GuruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_pelajaranBindingSource, "NIP_Guru", True))
        Me.NIP_GuruTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIP_GuruTextBox.Location = New System.Drawing.Point(144, 100)
        Me.NIP_GuruTextBox.Name = "NIP_GuruTextBox"
        Me.NIP_GuruTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NIP_GuruTextBox.TabIndex = 18
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKeluar.Location = New System.Drawing.Point(192, 126)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(86, 50)
        Me.ButtonKeluar.TabIndex = 11
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Location = New System.Drawing.Point(8, 153)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(86, 23)
        Me.ButtonHapus.TabIndex = 9
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Location = New System.Drawing.Point(100, 153)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(86, 23)
        Me.ButtonSimpan.TabIndex = 8
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(100, 124)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(86, 23)
        Me.ButtonEdit.TabIndex = 7
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(8, 124)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(86, 23)
        Me.ButtonTambah.TabIndex = 6
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.UpdateOrder = Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mata_pelajaranDataGridView
        '
        Me.Mata_pelajaranDataGridView.AutoGenerateColumns = False
        Me.Mata_pelajaranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mata_pelajaranDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Mata_pelajaranDataGridView.DataSource = Me.Mata_pelajaranBindingSource
        Me.Mata_pelajaranDataGridView.Location = New System.Drawing.Point(303, 82)
        Me.Mata_pelajaranDataGridView.Name = "Mata_pelajaranDataGridView"
        Me.Mata_pelajaranDataGridView.Size = New System.Drawing.Size(443, 182)
        Me.Mata_pelajaranDataGridView.TabIndex = 10
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
        'FormMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 269)
        Me.Controls.Add(Me.Mata_pelajaranDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormMataPelajaran"
        Me.Text = "Form Mata Pelajaran SMP Bunga Nusantara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Mata_pelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_kel6DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_pelajaranDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Project_kel6DataSet1 As Project_Kelompok6.project_kel6DataSet1
    Friend WithEvents Mata_pelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mata_pelajaranTableAdapter As Project_Kelompok6.project_kel6DataSet1TableAdapters.mata_pelajaranTableAdapter
    Friend WithEvents TableAdapterManager As Project_Kelompok6.project_kel6DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ID_Mata_PelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_Mata_PelajaranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KKMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIP_GuruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mata_pelajaranDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
