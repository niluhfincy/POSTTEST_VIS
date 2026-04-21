Public Class FormLaporan

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAwal.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpAkhir.Value = DateTime.Now
        TampilLaporan()
    End Sub

    Sub TampilLaporan()
        Dim tglAwal As String = dtpAwal.Value.ToString("yyyy-MM-dd")
        Dim tglAkhir As String = dtpAkhir.Value.ToString("yyyy-MM-dd")

        Dim dt As DataTable = GetLaporanTransaksi(tglAwal, tglAkhir)
        dgvLaporan.DataSource = dt

        Dim grandTotal As Long = 0
        For Each row As DataRow In dt.Rows
            grandTotal += Convert.ToInt64(row("totalHarga"))
        Next

        lblTotal.Text = "Total Pendapatan: Rp " & grandTotal.ToString("N0")
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        If dtpAwal.Value > dtpAkhir.Value Then
            MessageBox.Show("Tanggal awal tidak boleh lebih dari tanggal akhir!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        TampilLaporan()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class