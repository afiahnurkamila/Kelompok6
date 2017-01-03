<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(403, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiswaToolStripMenuItem, Me.DataGuruToolStripMenuItem, Me.DataMataPelajaranToolStripMenuItem, Me.DataKelasToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SiswaToolStripMenuItem
        '
        Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
        Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'DataGuruToolStripMenuItem
        '
        Me.DataGuruToolStripMenuItem.Name = "DataGuruToolStripMenuItem"
        Me.DataGuruToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataGuruToolStripMenuItem.Text = "Data Guru"
        '
        'DataMataPelajaranToolStripMenuItem
        '
        Me.DataMataPelajaranToolStripMenuItem.Name = "DataMataPelajaranToolStripMenuItem"
        Me.DataMataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataMataPelajaranToolStripMenuItem.Text = "Data Mata Pelajaran"
        '
        'DataKelasToolStripMenuItem
        '
        Me.DataKelasToolStripMenuItem.Name = "DataKelasToolStripMenuItem"
        Me.DataKelasToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataKelasToolStripMenuItem.Text = "Data Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " "
        '
        'Timer1
        '
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Mainform"
        Me.Text = "Mainform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGuruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMataPelajaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
