<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAntarMuka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAntarMuka))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HitungMixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesClusterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUserToolStripMenuItem, Me.DataMenuToolStripMenuItem, Me.UpdateDataPenjualanToolStripMenuItem, Me.HitungMixToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'DataMenuToolStripMenuItem
        '
        Me.DataMenuToolStripMenuItem.Name = "DataMenuToolStripMenuItem"
        Me.DataMenuToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DataMenuToolStripMenuItem.Text = "Data Menu"
        '
        'UpdateDataPenjualanToolStripMenuItem
        '
        Me.UpdateDataPenjualanToolStripMenuItem.Name = "UpdateDataPenjualanToolStripMenuItem"
        Me.UpdateDataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.UpdateDataPenjualanToolStripMenuItem.Text = "Update Data Penjualan"
        '
        'HitungMixToolStripMenuItem
        '
        Me.HitungMixToolStripMenuItem.Name = "HitungMixToolStripMenuItem"
        Me.HitungMixToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.HitungMixToolStripMenuItem.Text = "Hitung Mix"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesClusterToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'ProsesClusterToolStripMenuItem
        '
        Me.ProsesClusterToolStripMenuItem.Name = "ProsesClusterToolStripMenuItem"
        Me.ProsesClusterToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ProsesClusterToolStripMenuItem.Text = "Proses Cluster"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FormAntarMuka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 346)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormAntarMuka"
        Me.Text = "K-Means Clustering"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HitungMixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesClusterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
