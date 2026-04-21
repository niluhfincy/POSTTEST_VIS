<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblAwal = New Label()
        lblAkhir = New Label()
        dtpAwal = New DateTimePicker()
        dtpAkhir = New DateTimePicker()
        btnTampil = New Button()
        dgvLaporan = New DataGridView()
        btnBack = New Button()
        lblTotal = New Label()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(236, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(443, 44)
        Label1.TabIndex = 0
        Label1.Text = "LAPORAN PENJUALAN"
        ' 
        ' lblAwal
        ' 
        lblAwal.AutoSize = True
        lblAwal.Location = New Point(205, 159)
        lblAwal.Name = "lblAwal"
        lblAwal.Size = New Size(153, 32)
        lblAwal.TabIndex = 1
        lblAwal.Text = "Tanggal Awal"
        ' 
        ' lblAkhir
        ' 
        lblAkhir.AutoSize = True
        lblAkhir.Location = New Point(205, 249)
        lblAkhir.Name = "lblAkhir"
        lblAkhir.Size = New Size(158, 32)
        lblAkhir.TabIndex = 2
        lblAkhir.Text = "Tanggal Akhir"
        ' 
        ' dtpAwal
        ' 
        dtpAwal.Format = DateTimePickerFormat.Short
        dtpAwal.Location = New Point(409, 159)
        dtpAwal.Name = "dtpAwal"
        dtpAwal.Size = New Size(286, 39)
        dtpAwal.TabIndex = 4
        ' 
        ' dtpAkhir
        ' 
        dtpAkhir.Format = DateTimePickerFormat.Short
        dtpAkhir.Location = New Point(409, 249)
        dtpAkhir.Name = "dtpAkhir"
        dtpAkhir.Size = New Size(286, 39)
        dtpAkhir.TabIndex = 5
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(372, 424)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(150, 46)
        btnTampil.TabIndex = 6
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.AllowUserToAddRows = False
        dgvLaporan.AllowUserToDeleteRows = False
        dgvLaporan.BackgroundColor = Color.White
        dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaporan.Location = New Point(205, 501)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.RowHeadersWidth = 82
        dgvLaporan.Size = New Size(490, 393)
        dgvLaporan.TabIndex = 7
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(372, 927)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 46)
        btnBack.TabIndex = 8
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(333, 344)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(257, 32)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total Pendapatan: Rp 0"
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(925, 1004)
        Controls.Add(lblTotal)
        Controls.Add(btnBack)
        Controls.Add(dgvLaporan)
        Controls.Add(btnTampil)
        Controls.Add(dtpAkhir)
        Controls.Add(dtpAwal)
        Controls.Add(lblAkhir)
        Controls.Add(lblAwal)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLaporan"
        Text = "FormLaporan"
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAwal As Label
    Friend WithEvents lblAkhir As Label
    Friend WithEvents dtpAwal As DateTimePicker
    Friend WithEvents dtpAkhir As DateTimePicker
    Friend WithEvents btnTampil As Button
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotal As Label
End Class
