<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        dgvBuku = New DataGridView()
        grpTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        lblGenre = New Label()
        lblJudul = New Label()
        grpHapus = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        lblJudulHapus = New Label()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 0
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.BackgroundColor = SystemColors.ButtonHighlight
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(230, 356)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 82
        dgvBuku.Size = New Size(480, 300)
        dgvBuku.TabIndex = 8
        ' 
        ' grpTambah
        ' 
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Controls.Add(lblJudul)
        grpTambah.Location = New Point(40, 34)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(408, 252)
        grpTambah.TabIndex = 9
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(122, 190)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(168, 122)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(226, 39)
        txtGenre.TabIndex = 10
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(168, 54)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(226, 39)
        txtJudul.TabIndex = 9
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(19, 122)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(78, 32)
        lblGenre.TabIndex = 8
        lblGenre.Text = "Genre"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(19, 54)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(132, 32)
        lblJudul.TabIndex = 7
        lblJudul.Text = "Judul Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Location = New Point(477, 34)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(400, 252)
        grpHapus.TabIndex = 10
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(128, 190)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(160, 98)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(219, 39)
        txtHapus.TabIndex = 9
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Location = New Point(22, 98)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(132, 32)
        lblJudulHapus.TabIndex = 8
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(952, 686)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Controls.Add(dgvBuku)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button

End Class
