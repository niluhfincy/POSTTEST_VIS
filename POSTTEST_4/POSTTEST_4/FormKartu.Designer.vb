<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        lblJudul = New Label()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblHobby = New Label()
        picFoto = New PictureBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(26, 31)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(898, 78)
        lblJudul.TabIndex = 0
        lblJudul.Text = "KARTU ANGGOTA KOMUNITAS"
        lblJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(423, 172)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(106, 32)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama : -"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(423, 231)
        lblID.Name = "lblID"
        lblID.Size = New Size(66, 32)
        lblID.TabIndex = 2
        lblID.Text = "ID : -"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(423, 291)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(155, 32)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Komunitas : -"
        ' 
        ' lblHobby
        ' 
        lblHobby.Location = New Point(423, 350)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(166, 64)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Hobby : -"
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(99, 172)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(249, 324)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 6
        picFoto.TabStop = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(958, 585)
        Controls.Add(picFoto)
        Controls.Add(lblHobby)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(lblJudul)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents picFoto As PictureBox
End Class
