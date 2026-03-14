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
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        lblNameText = New Label()
        lblUmurText = New Label()
        lblTanggalText = New Label()
        lblTeleponText = New Label()
        lblAlamatText = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        PictureBox2 = New PictureBox()
        GroupBoxKelamin = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        GroupBoxHobby = New GroupBox()
        cbCoding = New CheckBox()
        cbTraveling = New CheckBox()
        cbGaming = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenggambar = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbMembaca = New CheckBox()
        btnCetak = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxKelamin.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(20, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(250, 300)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(96, 363)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(100, 45)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' lblNameText
        ' 
        lblNameText.AutoSize = True
        lblNameText.ForeColor = SystemColors.ButtonHighlight
        lblNameText.Location = New Point(304, 30)
        lblNameText.Name = "lblNameText"
        lblNameText.Size = New Size(77, 32)
        lblNameText.TabIndex = 2
        lblNameText.Text = "Nama"
        ' 
        ' lblUmurText
        ' 
        lblUmurText.AutoSize = True
        lblUmurText.ForeColor = SystemColors.ButtonHighlight
        lblUmurText.Location = New Point(304, 89)
        lblUmurText.Name = "lblUmurText"
        lblUmurText.Size = New Size(73, 32)
        lblUmurText.TabIndex = 3
        lblUmurText.Text = "Umur"
        ' 
        ' lblTanggalText
        ' 
        lblTanggalText.AutoSize = True
        lblTanggalText.ForeColor = SystemColors.ButtonHighlight
        lblTanggalText.Location = New Point(304, 155)
        lblTanggalText.Name = "lblTanggalText"
        lblTanggalText.Size = New Size(154, 32)
        lblTanggalText.TabIndex = 4
        lblTanggalText.Text = "Tanggal Lahir"
        ' 
        ' lblTeleponText
        ' 
        lblTeleponText.AutoSize = True
        lblTeleponText.ForeColor = SystemColors.ButtonHighlight
        lblTeleponText.Location = New Point(304, 223)
        lblTeleponText.Name = "lblTeleponText"
        lblTeleponText.Size = New Size(138, 32)
        lblTeleponText.TabIndex = 5
        lblTeleponText.Text = "No Telepon"
        ' 
        ' lblAlamatText
        ' 
        lblAlamatText.AutoSize = True
        lblAlamatText.ForeColor = SystemColors.ButtonHighlight
        lblAlamatText.Location = New Point(304, 287)
        lblAlamatText.Name = "lblAlamatText"
        lblAlamatText.Size = New Size(88, 32)
        lblAlamatText.TabIndex = 6
        lblAlamatText.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(498, 30)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(313, 39)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(498, 89)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(313, 39)
        txtUmur.TabIndex = 8
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(498, 223)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(313, 39)
        txtTelepon.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(498, 287)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(313, 39)
        txtAlamat.TabIndex = 10
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(498, 155)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(313, 39)
        DateTimePicker1.TabIndex = 11
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = My.Resources.Resources._35f1ba75663b8c5ae6ba900e42e95033_removebg_preview
        PictureBox2.Location = New Point(817, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(400, 287)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' GroupBoxKelamin
        ' 
        GroupBoxKelamin.Controls.Add(rbLaki)
        GroupBoxKelamin.Controls.Add(rbPerempuan)
        GroupBoxKelamin.ForeColor = SystemColors.ButtonHighlight
        GroupBoxKelamin.Location = New Point(304, 363)
        GroupBoxKelamin.Name = "GroupBoxKelamin"
        GroupBoxKelamin.Size = New Size(400, 248)
        GroupBoxKelamin.TabIndex = 13
        GroupBoxKelamin.TabStop = False
        GroupBoxKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(135, 72)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(132, 36)
        rbLaki.TabIndex = 14
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(135, 142)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(166, 36)
        rbPerempuan.TabIndex = 15
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(cbCoding)
        GroupBoxHobby.Controls.Add(cbTraveling)
        GroupBoxHobby.Controls.Add(cbGaming)
        GroupBoxHobby.Controls.Add(cbOlahraga)
        GroupBoxHobby.Controls.Add(cbMemancing)
        GroupBoxHobby.Controls.Add(cbMenggambar)
        GroupBoxHobby.Controls.Add(cbMenulis)
        GroupBoxHobby.Controls.Add(cbMenari)
        GroupBoxHobby.Controls.Add(cbMenyanyi)
        GroupBoxHobby.Controls.Add(cbMembaca)
        GroupBoxHobby.ForeColor = SystemColors.ButtonHighlight
        GroupBoxHobby.Location = New Point(719, 363)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(421, 248)
        GroupBoxHobby.TabIndex = 0
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby"
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(17, 27)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(123, 36)
        cbCoding.TabIndex = 14
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(17, 68)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(142, 36)
        cbTraveling.TabIndex = 15
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(17, 110)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(129, 36)
        cbGaming.TabIndex = 16
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(17, 154)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(142, 36)
        cbOlahraga.TabIndex = 17
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(17, 198)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(139, 36)
        cbMemancing.TabIndex = 18
        cbMemancing.Text = "Mancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(218, 27)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(190, 36)
        cbMenggambar.TabIndex = 19
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(218, 68)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(131, 36)
        cbMenulis.TabIndex = 20
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(218, 110)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(121, 36)
        cbMenari.TabIndex = 21
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(218, 154)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(151, 36)
        cbMenyanyi.TabIndex = 22
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(218, 198)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(151, 36)
        cbMembaca.TabIndex = 23
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(304, 638)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(836, 46)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(1189, 707)
        Controls.Add(btnCetak)
        Controls.Add(GroupBoxHobby)
        Controls.Add(GroupBoxKelamin)
        Controls.Add(PictureBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAlamatText)
        Controls.Add(lblTeleponText)
        Controls.Add(lblTanggalText)
        Controls.Add(lblUmurText)
        Controls.Add(lblNameText)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Cetak Kartu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxKelamin.ResumeLayout(False)
        GroupBoxKelamin.PerformLayout()
        GroupBoxHobby.ResumeLayout(False)
        GroupBoxHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNameText As Label
    Friend WithEvents lblUmurText As Label
    Friend WithEvents lblTanggalText As Label
    Friend WithEvents lblTeleponText As Label
    Friend WithEvents lblAlamatText As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBoxKelamin As GroupBox
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents btnCetak As Button

End Class
