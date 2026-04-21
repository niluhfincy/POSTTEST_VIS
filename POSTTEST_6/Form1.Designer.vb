<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        btnBunga = New Button()
        btnKeluar = New Button()
        PictureBox1 = New PictureBox()
        btnPelanggan = New Button()
        btnTransaksi = New Button()
        btnLaporan = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(85, 40)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(1043, 78)
        lblJudul.TabIndex = 0
        lblJudul.Text = "SISTEM PENJUALAN FRESH FLOWER"
        ' 
        ' btnBunga
        ' 
        btnBunga.BackColor = Color.Lavender
        btnBunga.Location = New Point(85, 179)
        btnBunga.Name = "btnBunga"
        btnBunga.Size = New Size(156, 46)
        btnBunga.TabIndex = 1
        btnBunga.Text = "Data Bunga"
        btnBunga.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.Lavender
        btnKeluar.Location = New Point(854, 179)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(150, 46)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._2cdcfea374b4cdfeaa379201442f0389_removebg_preview
        PictureBox1.Location = New Point(1021, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(422, 396)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnPelanggan
        ' 
        btnPelanggan.Location = New Point(266, 179)
        btnPelanggan.Name = "btnPelanggan"
        btnPelanggan.Size = New Size(195, 46)
        btnPelanggan.TabIndex = 4
        btnPelanggan.Text = "Data Pelanggan"
        btnPelanggan.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.BackColor = Color.Lavender
        btnTransaksi.Location = New Point(493, 179)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Size = New Size(150, 46)
        btnTransaksi.TabIndex = 0
        btnTransaksi.Text = "Transaksi"
        btnTransaksi.UseVisualStyleBackColor = False
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Location = New Point(680, 179)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(150, 46)
        btnLaporan.TabIndex = 5
        btnLaporan.Text = "Laporan"
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(1205, 305)
        Controls.Add(btnLaporan)
        Controls.Add(btnTransaksi)
        Controls.Add(btnPelanggan)
        Controls.Add(PictureBox1)
        Controls.Add(btnKeluar)
        Controls.Add(btnBunga)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnBunga As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnLaporan As Button

End Class
