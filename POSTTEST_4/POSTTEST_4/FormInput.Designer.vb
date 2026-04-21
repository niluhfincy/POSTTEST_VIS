<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        components = New ComponentModel.Container()
        btnNext2 = New Button()
        Label7 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        mtbTelepon = New MaskedTextBox()
        Label5 = New Label()
        btnNext = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        Label4 = New Label()
        cmbKomunitas = New ComboBox()
        txtAlamat = New TextBox()
        rbPerempuan = New RadioButton()
        GroupBoxJK = New GroupBox()
        rbLaki = New RadioButton()
        dtpTanggal = New DateTimePicker()
        Label3 = New Label()
        txtID = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        lblJudul = New Label()
        txtNama = New TextBox()
        tabData = New TabPage()
        tabKontak = New TabPage()
        tabProfil = New TabPage()
        btnCetak = New Button()
        btnSimpanFile = New Button()
        GroupBoxHobby = New GroupBox()
        cb8 = New CheckBox()
        cb7 = New CheckBox()
        cb6 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        GroupBoxPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        TabControl1 = New TabControl()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxJK.SuspendLayout()
        tabData.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        GroupBoxPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNext2
        ' 
        btnNext2.Location = New Point(744, 490)
        btnNext2.Name = "btnNext2"
        btnNext2.Size = New Size(150, 46)
        btnNext2.TabIndex = 7
        btnNext2.Text = "Next>"
        btnNext2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(241, 284)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 32)
        Label7.TabIndex = 5
        Label7.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(418, 204)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(251, 39)
        txtEmail.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(241, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 32)
        Label6.TabIndex = 3
        Label6.Text = "E-mail"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(418, 127)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(251, 39)
        mtbTelepon.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(241, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 32)
        Label5.TabIndex = 1
        Label5.Text = "No Telepon"
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(742, 488)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(150, 46)
        btnNext.TabIndex = 10
        btnNext.Text = "Next>"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(161, 399)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 32)
        Label4.TabIndex = 9
        Label4.Text = "Komunitas"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Florist", "", "Dekorasi", "", "Bouquet Artist", "", "Event Organizer", "", "Flower Designer"})
        cmbKomunitas.Location = New Point(359, 396)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(426, 40)
        cmbKomunitas.TabIndex = 8
        cmbKomunitas.Text = "Pilih Komunitas"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(418, 281)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(251, 103)
        txtAlamat.TabIndex = 6
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(353, 28)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(166, 36)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxJK
        ' 
        GroupBoxJK.Controls.Add(rbPerempuan)
        GroupBoxJK.Controls.Add(rbLaki)
        GroupBoxJK.Location = New Point(158, 261)
        GroupBoxJK.Name = "GroupBoxJK"
        GroupBoxJK.Size = New Size(627, 104)
        GroupBoxJK.TabIndex = 7
        GroupBoxJK.TabStop = False
        GroupBoxJK.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(118, 28)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(132, 36)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(359, 193)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(275, 39)
        dtpTanggal.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(161, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 32)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(359, 112)
        txtID.Name = "txtID"
        txtID.Size = New Size(429, 39)
        txtID.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 32)
        Label2.TabIndex = 3
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(185, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(582, 78)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Form Data Anggota"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(359, 36)
        txtNama.MaxLength = 150
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(426, 39)
        txtNama.TabIndex = 0
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(btnNext)
        tabData.Controls.Add(Label4)
        tabData.Controls.Add(cmbKomunitas)
        tabData.Controls.Add(GroupBoxJK)
        tabData.Controls.Add(dtpTanggal)
        tabData.Controls.Add(Label3)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(Label2)
        tabData.Controls.Add(Label1)
        tabData.Controls.Add(txtNama)
        tabData.Location = New Point(8, 46)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(918, 577)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' tabKontak
        ' 
        tabKontak.Controls.Add(btnNext2)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(Label7)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(Label6)
        tabKontak.Controls.Add(mtbTelepon)
        tabKontak.Controls.Add(Label5)
        tabKontak.Location = New Point(8, 46)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(918, 577)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(btnCetak)
        tabProfil.Controls.Add(btnSimpanFile)
        tabProfil.Controls.Add(GroupBoxHobby)
        tabProfil.Controls.Add(GroupBoxPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(8, 46)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(918, 577)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(730, 514)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(150, 46)
        btnCetak.TabIndex = 5
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanFile
        ' 
        btnSimpanFile.Location = New Point(534, 514)
        btnSimpanFile.Name = "btnSimpanFile"
        btnSimpanFile.Size = New Size(170, 46)
        btnSimpanFile.TabIndex = 4
        btnSimpanFile.Text = "Simpan Data"
        btnSimpanFile.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(cb8)
        GroupBoxHobby.Controls.Add(cb7)
        GroupBoxHobby.Controls.Add(cb6)
        GroupBoxHobby.Controls.Add(cb5)
        GroupBoxHobby.Controls.Add(cb4)
        GroupBoxHobby.Controls.Add(cb3)
        GroupBoxHobby.Controls.Add(cb2)
        GroupBoxHobby.Controls.Add(cb1)
        GroupBoxHobby.Location = New Point(361, 174)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(510, 274)
        GroupBoxHobby.TabIndex = 3
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby / Aktivitas"
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(39, 213)
        cb8.Name = "cb8"
        cb8.Size = New Size(181, 36)
        cb8.TabIndex = 7
        cb8.Text = "Bisnis Bunga"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(320, 162)
        cb7.Name = "cb7"
        cb7.Size = New Size(110, 36)
        cb7.TabIndex = 6
        cb7.Text = "Musik"
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(320, 112)
        cb6.Name = "cb6"
        cb6.Size = New Size(142, 36)
        cb6.TabIndex = 5
        cb6.Text = "Traveling"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(320, 59)
        cb5.Name = "cb5"
        cb5.Size = New Size(118, 36)
        cb5.TabIndex = 4
        cb5.Text = "Desain"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(320, 213)
        cb4.Name = "cb4"
        cb4.Size = New Size(131, 36)
        cb4.TabIndex = 3
        cb4.Text = "Menulis"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(39, 162)
        cb3.Name = "cb3"
        cb3.Size = New Size(142, 36)
        cb3.TabIndex = 2
        cb3.Text = "Fotografi"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(39, 112)
        cb2.Name = "cb2"
        cb2.Size = New Size(204, 36)
        cb2.TabIndex = 1
        cb2.Text = "Dekorasi Event"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(39, 59)
        cb1.Name = "cb1"
        cb1.Size = New Size(234, 36)
        cb1.TabIndex = 0
        cb1.Text = "Merangkai Bunga"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxPeran
        ' 
        GroupBoxPeran.Controls.Add(rbAnggota)
        GroupBoxPeran.Controls.Add(rbAdmin)
        GroupBoxPeran.Controls.Add(rbKetua)
        GroupBoxPeran.Location = New Point(361, 50)
        GroupBoxPeran.Name = "GroupBoxPeran"
        GroupBoxPeran.Size = New Size(510, 108)
        GroupBoxPeran.TabIndex = 2
        GroupBoxPeran.TabStop = False
        GroupBoxPeran.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(340, 48)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(136, 36)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(191, 48)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(115, 36)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(39, 48)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(106, 36)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(68, 402)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(193, 46)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Upload Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(41, 50)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(249, 324)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(tabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Location = New Point(12, 119)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(934, 631)
        TabControl1.TabIndex = 2
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(960, 762)
        Controls.Add(lblJudul)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "FormInput"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxJK.ResumeLayout(False)
        GroupBoxJK.PerformLayout()
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        GroupBoxHobby.ResumeLayout(False)
        GroupBoxHobby.PerformLayout()
        GroupBoxPeran.ResumeLayout(False)
        GroupBoxPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblJudul As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents GroupBoxJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents GroupBoxPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpanFile As Button
End Class
