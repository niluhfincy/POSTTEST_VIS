Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim buka As New OpenFileDialog
        buka.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If buka.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(buka.FileName)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Foto belum dipilih")
            Exit Sub
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        Dim jk As String = ""

        If rbLaki.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If

        Dim hobby As String = ""
        Dim cek As Boolean = False

        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)

                If cb.Checked Then
                    hobby &= cb.Text & ", "
                    cek = True
                End If
            End If
        Next

        If cek = False Then
            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub
        End If

        Form2.lblNama.Text = txtNama.Text
        Form2.lblUmur.Text = txtUmur.Text
        Form2.lblTanggal.Text = DateTimePicker1.Value.ToShortDateString
        Form2.lblKelamin.Text = jk
        Form2.lblTelepon.Text = txtTelepon.Text
        Form2.lblHobby.Text = hobby
        Form2.lblAlamat.Text = txtAlamat.Text

        Form2.PictureBox1.Image = PictureBox1.Image

        Form2.Show()

    End Sub

End Class