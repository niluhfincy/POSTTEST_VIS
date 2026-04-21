Public Class FormTransaksi

    Sub Tampil()
        dgvTransaksi.DataSource = GetAllTransaksi()
    End Sub

    Sub Kosong()
        txtKode.Text = AutoKodeTransaksi()
        txtJumlah.Clear()
        txtHarga.Clear()
        txtTotal.Clear()
        cmbPelanggan.SelectedIndex = -1
        cmbBunga.SelectedIndex = -1
        dtpTanggal.Value = DateTime.Now
    End Sub

    Sub LoadCombo()
        ' ComboBox Pelanggan
        Dim dtP As DataTable = GetAllPelanggan()
        cmbPelanggan.DataSource = dtP
        cmbPelanggan.DisplayMember = "namaPelanggan"
        cmbPelanggan.ValueMember = "kodePelanggan"
        cmbPelanggan.SelectedIndex = -1

        ' ComboBox Bunga
        Dim dtB As DataTable = GetAllBunga()
        cmbBunga.DataSource = dtB
        cmbBunga.DisplayMember = "namaBunga"
        cmbBunga.ValueMember = "kodeBunga"
        cmbBunga.SelectedIndex = -1
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        Tampil()
        Kosong()
    End Sub

    ' Saat bunga dipilih, otomatis tampil harga
    Private Sub cmbBunga_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBunga.SelectedIndexChanged
        If cmbBunga.SelectedIndex >= 0 Then
            Dim dt As DataTable = CType(cmbBunga.DataSource, DataTable)
            Dim harga As Integer = Convert.ToInt32(dt.Rows(cmbBunga.SelectedIndex)("harga"))
            txtHarga.Text = harga.ToString()
            HitungTotal()
        End If
    End Sub

    ' Saat jumlah diubah, hitung total otomatis
    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    Sub HitungTotal()
        If txtHarga.Text <> "" AndAlso txtJumlah.Text <> "" Then
            Dim harga As Integer
            Dim jumlah As Integer
            If Integer.TryParse(txtHarga.Text, harga) AndAlso Integer.TryParse(txtJumlah.Text, jumlah) Then
                txtTotal.Text = (harga * jumlah).ToString()
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbPelanggan.SelectedIndex < 0 Or cmbBunga.SelectedIndex < 0 Or txtJumlah.Text = "" Then
            MessageBox.Show("Lengkapi semua data transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jumlah As Integer
        If Not Integer.TryParse(txtJumlah.Text, jumlah) OrElse jumlah <= 0 Then
            MessageBox.Show("Jumlah harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek stok cukup
        Dim dt As DataTable = CType(cmbBunga.DataSource, DataTable)
        Dim stok As Integer = Convert.ToInt32(dt.Rows(cmbBunga.SelectedIndex)("stok"))
        If jumlah > stok Then
            MessageBox.Show("Stok bunga tidak mencukupi! Stok tersedia: " & stok, "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanTransaksi(
            txtKode.Text,
            cmbPelanggan.SelectedValue.ToString(),
            cmbBunga.SelectedValue.ToString(),
            jumlah,
            Convert.ToInt32(txtTotal.Text),
            dtpTanggal.Value.ToString("yyyy-MM-dd")) Then
            MessageBox.Show("Transaksi berhasil disimpan!")
            LoadCombo()
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Or Not txtKode.Text.StartsWith("TRX") Then
            MessageBox.Show("Pilih data transaksi dari tabel terlebih dahulu!")
            Exit Sub
        End If
        If MessageBox.Show("Yakin ingin menghapus transaksi ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeleteTransaksi(txtKode.Text) Then
                MessageBox.Show("Transaksi berhasil dihapus!")
                LoadCombo()
                Tampil()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvTransaksi.Rows(e.RowIndex).Cells("kodeTransaksi").Value.ToString()
            txtTotal.Text = dgvTransaksi.Rows(e.RowIndex).Cells("totalHarga").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class