Public Class Form1
    Private Sub btnBunga_Click(sender As Object, e As EventArgs) Handles btnBunga.Click
        FormBunga.Show()
        Me.Hide()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        FormPelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        FormTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        FormLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class