<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHitungMix
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbkode = New System.Windows.Forms.ComboBox()
        Me.txtnamamenu = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtnilai = New System.Windows.Forms.TextBox()
        Me.txttotalqty = New System.Windows.Forms.TextBox()
        Me.txttotalnilai = New System.Windows.Forms.TextBox()
        Me.btnhitungmix = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtmenumix = New System.Windows.Forms.TextBox()
        Me.txtsalesmix = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Menu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Qty :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Menu Mix :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sales Mix :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(366, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Qty :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Nilai :"
        '
        'cbkode
        '
        Me.cbkode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbkode.FormattingEnabled = True
        Me.cbkode.Location = New System.Drawing.Point(95, 49)
        Me.cbkode.Name = "cbkode"
        Me.cbkode.Size = New System.Drawing.Size(51, 21)
        Me.cbkode.TabIndex = 10
        '
        'txtnamamenu
        '
        Me.txtnamamenu.Enabled = False
        Me.txtnamamenu.Location = New System.Drawing.Point(95, 77)
        Me.txtnamamenu.Name = "txtnamamenu"
        Me.txtnamamenu.Size = New System.Drawing.Size(248, 20)
        Me.txtnamamenu.TabIndex = 11
        '
        'txtqty
        '
        Me.txtqty.Enabled = False
        Me.txtqty.Location = New System.Drawing.Point(95, 104)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(84, 20)
        Me.txtqty.TabIndex = 12
        '
        'txtnilai
        '
        Me.txtnilai.Enabled = False
        Me.txtnilai.Location = New System.Drawing.Point(95, 130)
        Me.txtnilai.Name = "txtnilai"
        Me.txtnilai.Size = New System.Drawing.Size(84, 20)
        Me.txtnilai.TabIndex = 13
        '
        'txttotalqty
        '
        Me.txttotalqty.Enabled = False
        Me.txttotalqty.Location = New System.Drawing.Point(425, 22)
        Me.txttotalqty.Name = "txttotalqty"
        Me.txttotalqty.Size = New System.Drawing.Size(100, 20)
        Me.txttotalqty.TabIndex = 14
        '
        'txttotalnilai
        '
        Me.txttotalnilai.Enabled = False
        Me.txttotalnilai.Location = New System.Drawing.Point(425, 50)
        Me.txttotalnilai.Name = "txttotalnilai"
        Me.txttotalnilai.Size = New System.Drawing.Size(100, 20)
        Me.txttotalnilai.TabIndex = 15
        '
        'btnhitungmix
        '
        Me.btnhitungmix.Location = New System.Drawing.Point(357, 129)
        Me.btnhitungmix.Name = "btnhitungmix"
        Me.btnhitungmix.Size = New System.Drawing.Size(87, 23)
        Me.btnhitungmix.TabIndex = 16
        Me.btnhitungmix.Text = "HITUNG MIX"
        Me.btnhitungmix.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(450, 129)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 17
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtmenumix
        '
        Me.txtmenumix.Enabled = False
        Me.txtmenumix.Location = New System.Drawing.Point(154, 177)
        Me.txtmenumix.Name = "txtmenumix"
        Me.txtmenumix.Size = New System.Drawing.Size(100, 20)
        Me.txtmenumix.TabIndex = 18
        '
        'txtsalesmix
        '
        Me.txtsalesmix.Enabled = False
        Me.txtsalesmix.Location = New System.Drawing.Point(342, 177)
        Me.txtsalesmix.Name = "txtsalesmix"
        Me.txtsalesmix.Size = New System.Drawing.Size(100, 20)
        Me.txtsalesmix.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 460)
        Me.DataGridView1.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'FormHitungMix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 685)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtsalesmix)
        Me.Controls.Add(Me.txtmenumix)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhitungmix)
        Me.Controls.Add(Me.txttotalnilai)
        Me.Controls.Add(Me.txttotalqty)
        Me.Controls.Add(Me.txtnilai)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtnamamenu)
        Me.Controls.Add(Me.cbkode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHitungMix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hitung Mix"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbkode As System.Windows.Forms.ComboBox
    Friend WithEvents txtnamamenu As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtnilai As System.Windows.Forms.TextBox
    Friend WithEvents txttotalqty As System.Windows.Forms.TextBox
    Friend WithEvents txttotalnilai As System.Windows.Forms.TextBox
    Friend WithEvents btnhitungmix As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtmenumix As System.Windows.Forms.TextBox
    Friend WithEvents txtsalesmix As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
