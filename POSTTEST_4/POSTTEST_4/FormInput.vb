Public Class FormInput

    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong")
            Return False
        End If

        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "ID tidak boleh kosong")
            Return False
        End If

        If cmbKomunitas.Text = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Pilih komunitas")
            Return False
        End If

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "No HP tidak valid")
            Return False
        End If

        If txtEmail.Text = "" Then
            ErrorProvider1.SetError(txtEmail, "Email tidak boleh kosong")
            Return False
        End If

        If txtAlamat.Text = "" Then
            ErrorProvider1.SetError(txtAlamat, "Alamat tidak boleh kosong")
            Return False
        End If

        Return True
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If ValidasiInput() = False Then Exit Sub
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then

            Dim jk As String = ""
            If rbLaki.Checked Then jk = "Laki-laki"
            If rbPerempuan.Checked Then jk = "Perempuan"
            Dim hobby As String = ""
            For Each ctrl As Control In GroupBoxHobby.Controls
                If TypeOf ctrl Is CheckBox Then
                    If CType(ctrl, CheckBox).Checked Then
                        hobby &= ctrl.Text & ", "
                    End If
                End If
            Next

            namaGlobal = txtNama.Text
            idGlobal = txtID.Text
            komunitasGlobal = cmbKomunitas.Text
            teleponGlobal = mtbTelepon.Text
            emailGlobal = txtEmail.Text
            alamatGlobal = txtAlamat.Text
            hobbyGlobal = hobby
            fotoGlobal = picFoto.Image

            FormKartu.Show()
        End If
    End Sub

    Private Sub btnSimpanFile_Click(sender As Object, e As EventArgs) Handles btnSimpanFile.Click
        SaveFileDialog1.Filter = "Text File|*.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim data As String =
                namaGlobal & vbCrLf &
                idGlobal & vbCrLf &
                komunitasGlobal

            IO.File.WriteAllText(SaveFileDialog1.FileName, data)
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

End Class