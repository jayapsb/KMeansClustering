<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txthargainput = New System.Windows.Forms.TextBox()
        Me.txtnamamenuinput = New System.Windows.Forms.TextBox()
        Me.txtkodeinput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btninput = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbkodeedit = New System.Windows.Forms.ComboBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.txthargaedit = New System.Windows.Forms.TextBox()
        Me.txtnamamenuedit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.txthargainput)
        Me.GroupBox1.Controls.Add(Me.txtnamamenuinput)
        Me.GroupBox1.Controls.Add(Me.txtkodeinput)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btninput)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Menu baru"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(10, 145)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(260, 23)
        Me.btnsimpan.TabIndex = 7
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txthargainput
        '
        Me.txthargainput.Location = New System.Drawing.Point(84, 119)
        Me.txthargainput.Name = "txthargainput"
        Me.txthargainput.Size = New System.Drawing.Size(81, 20)
        Me.txthargainput.TabIndex = 6
        '
        'txtnamamenuinput
        '
        Me.txtnamamenuinput.Location = New System.Drawing.Point(84, 85)
        Me.txtnamamenuinput.Name = "txtnamamenuinput"
        Me.txtnamamenuinput.Size = New System.Drawing.Size(186, 20)
        Me.txtnamamenuinput.TabIndex = 5
        '
        'txtkodeinput
        '
        Me.txtkodeinput.Location = New System.Drawing.Point(84, 51)
        Me.txtkodeinput.MaxLength = 4
        Me.txtkodeinput.Name = "txtkodeinput"
        Me.txtkodeinput.Size = New System.Drawing.Size(51, 20)
        Me.txtkodeinput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Harga :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Menu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode :"
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(10, 19)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(260, 23)
        Me.btninput.TabIndex = 0
        Me.btninput.Text = "INPUT"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbkodeedit)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnubah)
        Me.GroupBox2.Controls.Add(Me.txthargaedit)
        Me.GroupBox2.Controls.Add(Me.txtnamamenuedit)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit Menu"
        '
        'cbkodeedit
        '
        Me.cbkodeedit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbkodeedit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbkodeedit.FormattingEnabled = True
        Me.cbkodeedit.Location = New System.Drawing.Point(90, 51)
        Me.cbkodeedit.Name = "cbkodeedit"
        Me.cbkodeedit.Size = New System.Drawing.Size(51, 21)
        Me.cbkodeedit.TabIndex = 9
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(154, 145)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(116, 23)
        Me.btnhapus.TabIndex = 8
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(10, 145)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(116, 23)
        Me.btnubah.TabIndex = 7
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'txthargaedit
        '
        Me.txthargaedit.Location = New System.Drawing.Point(90, 116)
        Me.txthargaedit.Name = "txthargaedit"
        Me.txthargaedit.Size = New System.Drawing.Size(81, 20)
        Me.txthargaedit.TabIndex = 6
        '
        'txtnamamenuedit
        '
        Me.txtnamamenuedit.Location = New System.Drawing.Point(90, 85)
        Me.txtnamamenuedit.Name = "txtnamamenuedit"
        Me.txtnamamenuedit.Size = New System.Drawing.Size(180, 20)
        Me.txtnamamenuedit.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Harga :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama Menu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kode :"
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(10, 19)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(260, 23)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'FormDataMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 227)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txthargainput As System.Windows.Forms.TextBox
    Friend WithEvents txtnamamenuinput As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeinput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbkodeedit As System.Windows.Forms.ComboBox
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents txthargaedit As System.Windows.Forms.TextBox
    Friend WithEvents txtnamamenuedit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
End Class
