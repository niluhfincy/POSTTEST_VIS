Imports MySqlConnector

Module DataModule

    Public Function GetAllBunga() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM tb_bunga ORDER BY kodeBunga ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil bunga: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchBunga(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM tb_bunga WHERE kodeBunga LIKE @k OR namaBunga LIKE @k", conn)
                    da.SelectCommand.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cari bunga: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanBunga(kode As String, nama As String, harga As Integer, stok As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tb_bunga VALUES (@k,@n,@h,@s)", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", stok)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan bunga: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateBunga(kode As String, nama As String, harga As Integer, stok As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_bunga SET namaBunga=@n, harga=@h, stok=@s WHERE kodeBunga=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal update bunga: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteBunga(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tb_bunga WHERE kodeBunga=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus bunga: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM tb_pelanggan ORDER BY kodePelanggan ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil pelanggan: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchPelanggan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM tb_pelanggan WHERE kodePelanggan LIKE @k OR namaPelanggan LIKE @k", conn)
                    da.SelectCommand.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cari pelanggan: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanPelanggan(kode As String, nama As String, telp As String, alamat As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tb_pelanggan VALUES (@k,@n,@t,@a)", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@t", telp)
                    cmd.Parameters.AddWithValue("@a", alamat)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan pelanggan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdatePelanggan(kode As String, nama As String, telp As String, alamat As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_pelanggan SET namaPelanggan=@n, noTelp=@t, alamat=@a WHERE kodePelanggan=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@n", nama)
                    cmd.Parameters.AddWithValue("@t", telp)
                    cmd.Parameters.AddWithValue("@a", alamat)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal update pelanggan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeletePelanggan(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tb_pelanggan WHERE kodePelanggan=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus pelanggan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetAllTransaksi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.kodeTransaksi, p.namaPelanggan, b.namaBunga, " &
                "t.jumlah, t.totalHarga, t.tanggal " &
                "FROM tb_transaksi t " &
                "JOIN tb_pelanggan p ON t.kodePelanggan = p.kodePelanggan " &
                "JOIN tb_bunga b ON t.kodeBunga = b.kodeBunga " &
                "ORDER BY t.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil transaksi: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetLaporanTransaksi(tglAwal As String, tglAkhir As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.kodeTransaksi, p.namaPelanggan, b.namaBunga, " &
                "t.jumlah, t.totalHarga, t.tanggal " &
                "FROM tb_transaksi t " &
                "JOIN tb_pelanggan p ON t.kodePelanggan = p.kodePelanggan " &
                "JOIN tb_bunga b ON t.kodeBunga = b.kodeBunga " &
                "WHERE t.tanggal BETWEEN @awal AND @akhir " &
                "ORDER BY t.tanggal ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@awal", tglAwal)
                    da.SelectCommand.Parameters.AddWithValue("@akhir", tglAkhir)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil laporan: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function AutoKodeTransaksi() As String
        Dim kode As String = "TRX001"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT kodeTransaksi FROM tb_transaksi ORDER BY kodeTransaksi DESC LIMIT 1", conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Dim angka As Integer = Integer.Parse(result.ToString().Substring(3)) + 1
                        kode = "TRX" & angka.ToString("D3")
                    End If
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return kode
    End Function

    Public Function SimpanTransaksi(kodeT As String, kodeP As String, kodeB As String,
                                     jumlah As Integer, total As Integer, tanggal As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                ' Simpan transaksi
                Using cmd As New MySqlCommand(
                    "INSERT INTO tb_transaksi VALUES (@kt,@kp,@kb,@j,@tot,@tgl)", conn)
                    cmd.Parameters.AddWithValue("@kt", kodeT)
                    cmd.Parameters.AddWithValue("@kp", kodeP)
                    cmd.Parameters.AddWithValue("@kb", kodeB)
                    cmd.Parameters.AddWithValue("@j", jumlah)
                    cmd.Parameters.AddWithValue("@tot", total)
                    cmd.Parameters.AddWithValue("@tgl", tanggal)
                    cmd.ExecuteNonQuery()
                End Using
                ' Kurangi stok bunga otomatis
                Using cmd2 As New MySqlCommand(
                    "UPDATE tb_bunga SET stok = stok - @j WHERE kodeBunga = @kb", conn)
                    cmd2.Parameters.AddWithValue("@j", jumlah)
                    cmd2.Parameters.AddWithValue("@kb", kodeB)
                    cmd2.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteTransaksi(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tb_transaksi WHERE kodeTransaksi=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus transaksi: " & ex.Message)
            Return False
        End Try
    End Function

End Module