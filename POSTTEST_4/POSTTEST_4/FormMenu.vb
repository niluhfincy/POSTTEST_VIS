Public Class FormMenu

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblJudul.Text = "Fresh Flower Community 🌸"
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class