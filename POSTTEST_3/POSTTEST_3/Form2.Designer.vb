<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        lblKelamin = New Label()
        lblTelepon = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(30, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(255, 25)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(0, 32)
        lblNama.TabIndex = 1
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(255, 82)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(0, 32)
        lblUmur.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(255, 133)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(0, 32)
        lblTanggal.TabIndex = 3
        ' 
        ' lblKelamin
        ' 
        lblKelamin.AutoSize = True
        lblKelamin.Location = New Point(255, 188)
        lblKelamin.Name = "lblKelamin"
        lblKelamin.Size = New Size(0, 32)
        lblKelamin.TabIndex = 4
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(255, 243)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(0, 32)
        lblTelepon.TabIndex = 5
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(255, 298)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(0, 32)
        lblHobby.TabIndex = 6
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(255, 355)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(0, 32)
        lblAlamat.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(674, 429)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblTelepon)
        Controls.Add(lblKelamin)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil Kartu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblKelamin As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
End Class
