<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagement))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMembersMgnt = New System.Windows.Forms.Button()
        Me.btnEventsMgnt = New System.Windows.Forms.Button()
        Me.btnResultsMgnt = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlMembers = New System.Windows.Forms.Panel()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.btnDeleteMember = New System.Windows.Forms.Button()
        Me.btnNewMember = New System.Windows.Forms.Button()
        Me.pnlEvents = New System.Windows.Forms.Panel()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlMembers.SuspendLayout()
        Me.pnlEvents.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnMembersMgnt
        '
        Me.btnMembersMgnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnMembersMgnt.Location = New System.Drawing.Point(202, 12)
        Me.btnMembersMgnt.Name = "btnMembersMgnt"
        Me.btnMembersMgnt.Size = New System.Drawing.Size(180, 56)
        Me.btnMembersMgnt.TabIndex = 2
        Me.btnMembersMgnt.Text = "&Members"
        Me.btnMembersMgnt.UseVisualStyleBackColor = True
        '
        'btnEventsMgnt
        '
        Me.btnEventsMgnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnEventsMgnt.Location = New System.Drawing.Point(388, 12)
        Me.btnEventsMgnt.Name = "btnEventsMgnt"
        Me.btnEventsMgnt.Size = New System.Drawing.Size(180, 56)
        Me.btnEventsMgnt.TabIndex = 3
        Me.btnEventsMgnt.Text = "&Events"
        Me.btnEventsMgnt.UseVisualStyleBackColor = True
        '
        'btnResultsMgnt
        '
        Me.btnResultsMgnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnResultsMgnt.Location = New System.Drawing.Point(574, 12)
        Me.btnResultsMgnt.Name = "btnResultsMgnt"
        Me.btnResultsMgnt.Size = New System.Drawing.Size(180, 56)
        Me.btnResultsMgnt.TabIndex = 4
        Me.btnResultsMgnt.Text = "&Results"
        Me.btnResultsMgnt.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(844, 284)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(116, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.BackColor = System.Drawing.Color.ForestGreen
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "L&OGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed
        Me.EXITToolStripMenuItem.Checked = True
        Me.EXITToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "E&XIT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 284)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(960, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 17)
        Me.ToolStripStatusLabel2.Text = "Road Warriors Athletic Club"
        '
        'pnlMembers
        '
        Me.pnlMembers.Controls.Add(Me.lstMembers)
        Me.pnlMembers.Controls.Add(Me.btnDeleteMember)
        Me.pnlMembers.Controls.Add(Me.btnNewMember)
        Me.pnlMembers.Location = New System.Drawing.Point(198, 89)
        Me.pnlMembers.Name = "pnlMembers"
        Me.pnlMembers.Size = New System.Drawing.Size(750, 178)
        Me.pnlMembers.TabIndex = 28
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.Location = New System.Drawing.Point(3, 3)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(552, 173)
        Me.lstMembers.TabIndex = 32
        '
        'btnDeleteMember
        '
        Me.btnDeleteMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnDeleteMember.Location = New System.Drawing.Point(561, 95)
        Me.btnDeleteMember.Name = "btnDeleteMember"
        Me.btnDeleteMember.Size = New System.Drawing.Size(180, 80)
        Me.btnDeleteMember.TabIndex = 30
        Me.btnDeleteMember.Text = "&Delete Member"
        Me.btnDeleteMember.UseVisualStyleBackColor = True
        '
        'btnNewMember
        '
        Me.btnNewMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnNewMember.Location = New System.Drawing.Point(561, 12)
        Me.btnNewMember.Name = "btnNewMember"
        Me.btnNewMember.Size = New System.Drawing.Size(180, 80)
        Me.btnNewMember.TabIndex = 29
        Me.btnNewMember.Text = "&New Member"
        Me.btnNewMember.UseVisualStyleBackColor = True
        '
        'pnlEvents
        '
        Me.pnlEvents.Controls.Add(Me.lstEvents)
        Me.pnlEvents.Location = New System.Drawing.Point(197, 89)
        Me.pnlEvents.Name = "pnlEvents"
        Me.pnlEvents.Size = New System.Drawing.Size(751, 178)
        Me.pnlEvents.TabIndex = 31
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.Location = New System.Drawing.Point(4, 2)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(552, 173)
        Me.lstEvents.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!)
        Me.TextBox1.Location = New System.Drawing.Point(202, 106)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(552, 124)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Please make a selection from the options above"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 306)
        Me.Controls.Add(Me.pnlEvents)
        Me.Controls.Add(Me.pnlMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnResultsMgnt)
        Me.Controls.Add(Me.btnEventsMgnt)
        Me.Controls.Add(Me.btnMembersMgnt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManagement"
        Me.Text = "Road Warriors Athletic Club"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlMembers.ResumeLayout(False)
        Me.pnlEvents.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMembersMgnt As System.Windows.Forms.Button
    Friend WithEvents btnEventsMgnt As System.Windows.Forms.Button
    Friend WithEvents btnResultsMgnt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlMembers As System.Windows.Forms.Panel
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents btnNewMember As System.Windows.Forms.Button
    Friend WithEvents btnDeleteMember As System.Windows.Forms.Button
    Friend WithEvents pnlEvents As System.Windows.Forms.Panel
    Friend WithEvents lstEvents As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
