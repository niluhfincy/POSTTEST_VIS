Public Class FormPelanggan

    Sub Tampil()
        dgvPelanggan.DataSource = GetAllPelanggan()
    End Sub

    Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtTelp.Clear()
        txtAlamat.Clear()
        txtKode.Focus()
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If SimpanPelanggan(txtKode.Text, txtNama.Text, txtTelp.Text, txtAlamat.Text) Then
            MessageBox.Show("Data pelanggan berhasil disimpan!")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu!")
            Exit Sub
        End If
        If UpdatePelanggan(txtKode.Text, txtNama.Text, txtTelp.Text, txtAlamat.Text) Then
            MessageBox.Show("Data pelanggan berhasil diupdate!")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu!")
            Exit Sub
        End If
        If MessageBox.Show("Yakin ingin menghapus pelanggan ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeletePelanggan(txtKode.Text) Then
                MessageBox.Show("Data pelanggan berhasil dihapus!")
                Tampil()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        Tampil()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvPelanggan.DataSource = SearchPelanggan(txtSearch.Text)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvPelanggan.DataSource = SearchPelanggan(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvPelanggan.Rows(e.RowIndex).Cells("kodePelanggan").Value.ToString()
            txtNama.Text = dgvPelanggan.Rows(e.RowIndex).Cells("namaPelanggan").Value.ToString()
            txtTelp.Text = dgvPelanggan.Rows(e.RowIndex).Cells("noTelp").Value.ToString()
            txtAlamat.Text = dgvPelanggan.Rows(e.RowIndex).Cells("alamat").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class