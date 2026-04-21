<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        lblKode = New Label()
        lblNama = New Label()
        lblTelp = New Label()
        lblAlamat = New Label()
        lblSearch = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnCari = New Button()
        dgvPelanggan = New DataGridView()
        btnBack = New Button()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(217, 43)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(186, 32)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Pelanggan"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(217, 103)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(195, 32)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Pelanggan"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Location = New Point(217, 163)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(143, 32)
        lblTelp.TabIndex = 2
        lblTelp.Text = "No. Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(217, 220)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(88, 32)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(217, 280)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(111, 32)
        lblSearch.TabIndex = 4
        lblSearch.Text = "Cari Data"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(471, 43)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(328, 39)
        txtKode.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(471, 103)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(328, 39)
        txtNama.TabIndex = 6
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(471, 163)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(328, 39)
        txtTelp.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(471, 220)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(328, 39)
        txtAlamat.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(471, 280)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(328, 39)
        txtSearch.TabIndex = 9
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(57, 384)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 46)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(246, 384)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(150, 46)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(436, 384)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(624, 384)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(150, 46)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(810, 384)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(150, 46)
        btnCari.TabIndex = 14
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.AllowUserToAddRows = False
        dgvPelanggan.AllowUserToDeleteRows = False
        dgvPelanggan.BackgroundColor = Color.White
        dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPelanggan.Location = New Point(217, 498)
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.RowHeadersWidth = 82
        dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelanggan.Size = New Size(582, 364)
        dgvPelanggan.TabIndex = 15
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(436, 886)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 46)
        btnBack.TabIndex = 16
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' FormPelanggan
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(1023, 959)
        Controls.Add(btnBack)
        Controls.Add(dgvPelanggan)
        Controls.Add(btnCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(lblSearch)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelp)
        Controls.Add(lblNama)
        Controls.Add(lblKode)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPelanggan"
        Text = "FormPelanggan"
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents btnBack As Button
End Class
