<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        MenuToolStripMenuItem = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        picLogo = New PictureBox()
        lblJudul = New Label()
        MenuToolStripMenuItem.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.ImageScalingSize = New Size(32, 32)
        MenuToolStripMenuItem.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, LihatKartuToolStripMenuItem, KeluarToolStripMenuItem})
        MenuToolStripMenuItem.Location = New Point(0, 0)
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(729, 40)
        MenuToolStripMenuItem.TabIndex = 0
        MenuToolStripMenuItem.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(146, 38)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(170, 38)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(142, 38)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(148, 38)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(101, 38)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = My.Resources.Resources._2cdcfea374b4cdfeaa379201442f0389_removebg_preview
        picLogo.Location = New Point(106, 210)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(492, 484)
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("SimSun-ExtB", 22.125F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(32, 99)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(676, 59)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Fresh Flower Comunity"
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(729, 808)
        Controls.Add(lblJudul)
        Controls.Add(picLogo)
        Controls.Add(MenuToolStripMenuItem)
        MainMenuStrip = MenuToolStripMenuItem
        Name = "FormMenu"
        Text = "Menu"
        MenuToolStripMenuItem.ResumeLayout(False)
        MenuToolStripMenuItem.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuToolStripMenuItem As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblJudul As Label

End Class
