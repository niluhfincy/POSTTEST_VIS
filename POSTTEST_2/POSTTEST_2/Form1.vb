Public Class Form1

    Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If judulBuku(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next
        Return -1
    End Function

    Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        judulBuku(jumlahBuku) = judul
        genreBuku(jumlahBuku) = genre
        jumlahBuku += 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBuku.Columns.Add("colJudul", "Judul Buku")
        dgvBuku.Columns.Add("colGenre", "Genre")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Data harus diisi")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)
        dgvBuku.Rows.Add(txtJudul.Text, txtGenre.Text)

        txtJudul.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim index As Integer = CariBuku(txtHapus.Text)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
        Else
            For i As Integer = index To jumlahBuku - 2
                judulBuku(i) = judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next

            jumlahBuku -= 1
            dgvBuku.Rows.RemoveAt(index)

            MessageBox.Show("Buku berhasil dihapus")
        End If

        txtHapus.Clear()
    End Sub

End Class