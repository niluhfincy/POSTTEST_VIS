Public Class FormKartu
    Public nama As String
    Public idAnggota As String
    Public komunitas As String
    Public telepon As String
    Public hobby As String
    Public fotoPath As String

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = namaGlobal
        lblID.Text = idGlobal
        lblKomunitas.Text = komunitasGlobal
        lblHobby.Text = hobbyGlobal

        If fotoGlobal IsNot Nothing Then
            picFoto.Image = fotoGlobal
        End If
    End Sub

    Public Sub TampilkanData(nama As String, idAnggota As String, komunitas As String,
                             kontak As String, hobby As String, fotoPath As String)

        lblNama.Text = "Nama : " & nama
        lblID.Text = "ID : " & idAnggota
        lblKomunitas.Text = "Komunitas : " & komunitas
        lblHobby.Text = "Hobby : " & hobby

        If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then
            picFoto.Image = Image.FromFile(fotoPath)
        End If

    End Sub

End Class