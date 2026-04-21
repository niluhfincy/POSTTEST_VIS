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
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblPredikat = New Label()
        txtIPSemester = New TextBox()
        txtIPKumulatif = New TextBox()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(90, 378)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(334, 378)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 46)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 32)
        Label1.TabIndex = 2
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 32)
        Label2.TabIndex = 3
        Label2.Text = "IP Kumulatif"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(140, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 32)
        Label3.TabIndex = 4
        Label3.Text = "Predikat"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(317, 254)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 32)
        lblPredikat.TabIndex = 5
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.BackColor = Color.Gainsboro
        txtIPSemester.Location = New Point(317, 39)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(200, 39)
        txtIPSemester.TabIndex = 6
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.BackColor = Color.Gainsboro
        txtIPKumulatif.Location = New Point(317, 127)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.Size = New Size(200, 39)
        txtIPKumulatif.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(560, 480)
        Controls.Add(txtIPKumulatif)
        Controls.Add(txtIPSemester)
        Controls.Add(lblPredikat)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents txtIPKumulatif As TextBox

End Class
