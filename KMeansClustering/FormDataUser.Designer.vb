<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusernameinput = New System.Windows.Forms.TextBox()
        Me.txtpasswordinput = New System.Windows.Forms.TextBox()
        Me.txtulangipassinput = New System.Windows.Forms.TextBox()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpasswordhapus = New System.Windows.Forms.TextBox()
        Me.txtulangipasshapus = New System.Windows.Forms.TextBox()
        Me.btnhapus2 = New System.Windows.Forms.Button()
        Me.Cbusernamehapus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtusernameinput
        '
        resources.ApplyResources(Me.txtusernameinput, "txtusernameinput")
        Me.txtusernameinput.Name = "txtusernameinput"
        '
        'txtpasswordinput
        '
        resources.ApplyResources(Me.txtpasswordinput, "txtpasswordinput")
        Me.txtpasswordinput.Name = "txtpasswordinput"
        '
        'txtulangipassinput
        '
        resources.ApplyResources(Me.txtulangipassinput, "txtulangipassinput")
        Me.txtulangipassinput.Name = "txtulangipassinput"
        '
        'btninput
        '
        resources.ApplyResources(Me.btninput, "btninput")
        Me.btninput.Name = "btninput"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        resources.ApplyResources(Me.btnsimpan, "btnsimpan")
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus1
        '
        resources.ApplyResources(Me.btnhapus1, "btnhapus1")
        Me.btnhapus1.Name = "btnhapus1"
        Me.btnhapus1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtpasswordhapus
        '
        resources.ApplyResources(Me.txtpasswordhapus, "txtpasswordhapus")
        Me.txtpasswordhapus.Name = "txtpasswordhapus"
        '
        'txtulangipasshapus
        '
        resources.ApplyResources(Me.txtulangipasshapus, "txtulangipasshapus")
        Me.txtulangipasshapus.Name = "txtulangipasshapus"
        '
        'btnhapus2
        '
        resources.ApplyResources(Me.btnhapus2, "btnhapus2")
        Me.btnhapus2.Name = "btnhapus2"
        Me.btnhapus2.UseVisualStyleBackColor = True
        '
        'Cbusernamehapus
        '
        Me.Cbusernamehapus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbusernamehapus.FormattingEnabled = True
        resources.ApplyResources(Me.Cbusernamehapus, "Cbusernamehapus")
        Me.Cbusernamehapus.Name = "Cbusernamehapus"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'FormDataUser
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Cbusernamehapus)
        Me.Controls.Add(Me.btnhapus2)
        Me.Controls.Add(Me.txtulangipasshapus)
        Me.Controls.Add(Me.txtpasswordhapus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnhapus1)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.txtulangipassinput)
        Me.Controls.Add(Me.txtpasswordinput)
        Me.Controls.Add(Me.txtusernameinput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusernameinput As System.Windows.Forms.TextBox
    Friend WithEvents txtpasswordinput As System.Windows.Forms.TextBox
    Friend WithEvents txtulangipassinput As System.Windows.Forms.TextBox
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpasswordhapus As System.Windows.Forms.TextBox
    Friend WithEvents txtulangipasshapus As System.Windows.Forms.TextBox
    Friend WithEvents btnhapus2 As System.Windows.Forms.Button
    Friend WithEvents Cbusernamehapus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
