Imports MySqlConnector

Public Class FormBunga

    Sub Tampil()
        dgvBunga.DataSource = GetAllBunga()
    End Sub

    Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtKode.Focus()
    End Sub

    Private Sub FormBunga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong")
            Exit Sub
        End If

        If SimpanBunga(txtKode.Text, txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Data berhasil disimpan")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If UpdateBunga(txtKode.Text, txtNama.Text, txtHarga.Text, txtStok.Text) Then
            MessageBox.Show("Data berhasil diupdate")
            Tampil()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        If MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If DeleteBunga(txtKode.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                Tampil()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        Tampil()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Tampil()
        Else
            dgvBunga.DataSource = SearchBunga(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvBunga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBunga.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvBunga.Rows(e.RowIndex).Cells("kodeBunga").Value.ToString()
            txtNama.Text = dgvBunga.Rows(e.RowIndex).Cells("namaBunga").Value.ToString()
            txtHarga.Text = dgvBunga.Rows(e.RowIndex).Cells("harga").Value.ToString()
            txtStok.Text = dgvBunga.Rows(e.RowIndex).Cells("stok").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter("SELECT * FROM tb_bunga WHERE namaBunga LIKE '%" & txtSearch.Text & "%'", conn)
        Dim ds As New DataSet

        da.Fill(ds, "tb_bunga")
        dgvBunga.DataSource = ds.Tables("tb_bunga")

        conn.Close()
    End Sub
End Class