<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBunga
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
        components = New ComponentModel.Container()
        lblKode = New Label()
        lblNama = New Label()
        lblHarga = New Label()
        lblStok = New Label()
        lblSearch = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvBunga = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        btnBack = New Button()
        btnCari = New Button()
        PictureBox1 = New PictureBox()
        CType(dgvBunga, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(218, 79)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(143, 32)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Bunga"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(218, 141)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(152, 32)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Bunga"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(218, 209)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(77, 32)
        lblHarga.TabIndex = 2
        lblHarga.Text = "Harga"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(218, 277)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(60, 32)
        lblStok.TabIndex = 3
        lblStok.Text = "Stok"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(218, 343)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(111, 32)
        lblSearch.TabIndex = 4
        lblSearch.Text = "Cari Data"
        ' 
        ' txtKode
        ' 
        txtKode.CharacterCasing = CharacterCasing.Upper
        txtKode.Location = New Point(457, 79)
        txtKode.MaxLength = 5
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(240, 39)
        txtKode.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(457, 141)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(240, 39)
        txtNama.TabIndex = 6
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(457, 209)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(240, 39)
        txtHarga.TabIndex = 7
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(457, 277)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(240, 39)
        txtStok.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(457, 343)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(240, 39)
        txtSearch.TabIndex = 9
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Lavender
        btnSimpan.Location = New Point(28, 461)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 46)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Lavender
        btnUpdate.Location = New Point(212, 461)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(150, 46)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Lavender
        btnHapus.Location = New Point(398, 461)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Lavender
        btnBatal.Location = New Point(589, 461)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(150, 46)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvBunga
        ' 
        dgvBunga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBunga.BackgroundColor = Color.White
        dgvBunga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBunga.Location = New Point(218, 570)
        dgvBunga.MultiSelect = False
        dgvBunga.Name = "dgvBunga"
        dgvBunga.ReadOnly = True
        dgvBunga.RowHeadersWidth = 82
        dgvBunga.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBunga.Size = New Size(479, 317)
        dgvBunga.TabIndex = 14
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Lavender
        btnBack.Location = New Point(384, 915)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 46)
        btnBack.TabIndex = 15
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.Lavender
        btnCari.Location = New Point(769, 461)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(150, 46)
        btnCari.TabIndex = 16
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.download__1__removebg_preview
        PictureBox1.Location = New Point(703, 746)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(360, 341)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' FormBunga
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(931, 989)
        Controls.Add(PictureBox1)
        Controls.Add(btnCari)
        Controls.Add(btnBack)
        Controls.Add(dgvBunga)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(lblSearch)
        Controls.Add(lblStok)
        Controls.Add(lblHarga)
        Controls.Add(lblNama)
        Controls.Add(lblKode)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormBunga"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormBunga"
        CType(dgvBunga, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvBunga As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
