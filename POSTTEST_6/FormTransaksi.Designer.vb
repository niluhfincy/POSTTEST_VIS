<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        lblPelanggan = New Label()
        lblBunga = New Label()
        lblJumlah = New Label()
        lblHarga = New Label()
        lblTotal = New Label()
        lblTanggal = New Label()
        cmbPelanggan = New ComboBox()
        cmbBunga = New ComboBox()
        txtKode = New TextBox()
        txtJumlah = New TextBox()
        txtHarga = New TextBox()
        txtTotal = New TextBox()
        dtpTanggal = New DateTimePicker()
        dgvTransaksi = New DataGridView()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnBack = New Button()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(198, 44)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(170, 32)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Transaksi"
        ' 
        ' lblPelanggan
        ' 
        lblPelanggan.AutoSize = True
        lblPelanggan.Location = New Point(198, 105)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Size = New Size(125, 32)
        lblPelanggan.TabIndex = 1
        lblPelanggan.Text = "Pelanggan"
        ' 
        ' lblBunga
        ' 
        lblBunga.AutoSize = True
        lblBunga.Location = New Point(198, 172)
        lblBunga.Name = "lblBunga"
        lblBunga.Size = New Size(82, 32)
        lblBunga.TabIndex = 2
        lblBunga.Text = "Bunga"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(198, 243)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(90, 32)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(198, 316)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(157, 32)
        lblHarga.TabIndex = 4
        lblHarga.Text = "Harga Satuan"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(198, 389)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(135, 32)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Total Harga"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(198, 468)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(96, 32)
        lblTanggal.TabIndex = 6
        lblTanggal.Text = "Tanggal"
        ' 
        ' cmbPelanggan
        ' 
        cmbPelanggan.FormattingEnabled = True
        cmbPelanggan.Location = New Point(423, 105)
        cmbPelanggan.Name = "cmbPelanggan"
        cmbPelanggan.Size = New Size(348, 40)
        cmbPelanggan.TabIndex = 7
        ' 
        ' cmbBunga
        ' 
        cmbBunga.FormattingEnabled = True
        cmbBunga.Location = New Point(423, 172)
        cmbBunga.Name = "cmbBunga"
        cmbBunga.Size = New Size(348, 40)
        cmbBunga.TabIndex = 8
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(423, 44)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(348, 39)
        txtKode.TabIndex = 9
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(423, 243)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(348, 39)
        txtJumlah.TabIndex = 10
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(423, 316)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(348, 39)
        txtHarga.TabIndex = 11
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(423, 389)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(348, 39)
        txtTotal.TabIndex = 12
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(423, 468)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(348, 39)
        dtpTanggal.TabIndex = 13
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.BackgroundColor = Color.White
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaksi.Location = New Point(198, 704)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.RowHeadersWidth = 82
        dgvTransaksi.Size = New Size(573, 300)
        dgvTransaksi.TabIndex = 14
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Lavender
        btnSimpan.Location = New Point(198, 586)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 46)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Lavender
        btnHapus.Location = New Point(413, 586)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Lavender
        btnBatal.Location = New Point(621, 586)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(150, 46)
        btnBatal.TabIndex = 17
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Lavender
        btnBack.Location = New Point(413, 1050)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 46)
        btnBack.TabIndex = 18
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(990, 1130)
        Controls.Add(btnBack)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(dgvTransaksi)
        Controls.Add(dtpTanggal)
        Controls.Add(txtTotal)
        Controls.Add(txtHarga)
        Controls.Add(txtJumlah)
        Controls.Add(txtKode)
        Controls.Add(cmbBunga)
        Controls.Add(cmbPelanggan)
        Controls.Add(lblTanggal)
        Controls.Add(lblTotal)
        Controls.Add(lblHarga)
        Controls.Add(lblJumlah)
        Controls.Add(lblBunga)
        Controls.Add(lblPelanggan)
        Controls.Add(lblKode)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormTransaksi"
        Text = "FormTransaksi"
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents lblPelanggan As Label
    Friend WithEvents lblBunga As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents cmbPelanggan As ComboBox
    Friend WithEvents cmbBunga As ComboBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnBack As Button
End Class
