<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnu010501000000 = New System.Windows.Forms.ToolStripMenuItem
        Me.SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNewSession = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CariDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu010503000000 = New System.Windows.Forms.ToolStripMenuItem
        Me.InputRegistriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditRegistriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu010501000000, Me.mnu010503000000, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu010501000000
        '
        Me.mnu010501000000.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SessionToolStripMenuItem, Me.CariDataToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnu010501000000.Name = "mnu010501000000"
        Me.mnu010501000000.Size = New System.Drawing.Size(35, 20)
        Me.mnu010501000000.Text = "&File"
        '
        'SessionToolStripMenuItem
        '
        Me.SessionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewSession, Me.DaftarSessionToolStripMenuItem})
        Me.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem"
        Me.SessionToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SessionToolStripMenuItem.Text = "Season"
        '
        'mnuNewSession
        '
        Me.mnuNewSession.Name = "mnuNewSession"
        Me.mnuNewSession.Size = New System.Drawing.Size(145, 22)
        Me.mnuNewSession.Text = "New Season"
        '
        'DaftarSessionToolStripMenuItem
        '
        Me.DaftarSessionToolStripMenuItem.Name = "DaftarSessionToolStripMenuItem"
        Me.DaftarSessionToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DaftarSessionToolStripMenuItem.Text = "Daftar Season"
        '
        'CariDataToolStripMenuItem
        '
        Me.CariDataToolStripMenuItem.Name = "CariDataToolStripMenuItem"
        Me.CariDataToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CariDataToolStripMenuItem.Text = "&Cari Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'mnu010503000000
        '
        Me.mnu010503000000.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputRegistriToolStripMenuItem, Me.EditRegistriToolStripMenuItem})
        Me.mnu010503000000.Name = "mnu010503000000"
        Me.mnu010503000000.Size = New System.Drawing.Size(47, 20)
        Me.mnu010503000000.Text = "&Setup"
        '
        'InputRegistriToolStripMenuItem
        '
        Me.InputRegistriToolStripMenuItem.Name = "InputRegistriToolStripMenuItem"
        Me.InputRegistriToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.InputRegistriToolStripMenuItem.Text = "Tim"
        '
        'EditRegistriToolStripMenuItem
        '
        Me.EditRegistriToolStripMenuItem.Name = "EditRegistriToolStripMenuItem"
        Me.EditRegistriToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditRegistriToolStripMenuItem.Text = "Wasit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(804, 532)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu010501000000 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu010503000000 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputRegistriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRegistriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewSession As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CariDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
