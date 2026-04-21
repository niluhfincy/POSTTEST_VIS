Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIPKumulatif.ReadOnly = True
        txtIPKumulatif.Text = "0.00"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then

            totalIP += ipSemester
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester

            txtIPKumulatif.Text = ipk.ToString("0.00")

            ' menentukan predikat
            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "Kurang"
            End If

            txtIPSemester.Clear()
            txtIPSemester.Focus()

        Else
            MessageBox.Show("Masukkan IP Semester yang valid!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPKumulatif.Text = "0.00"
        lblPredikat.Text = ""

        txtIPSemester.Clear()
        txtIPSemester.Focus()

    End Sub

End Class