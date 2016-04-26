<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.aa = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.aa.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(25, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "น้ำหนัก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(30, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ส่วนสูง"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Olive
        Me.Button1.Font = New System.Drawing.Font("Mistral", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(160, 229)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 80)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox3.Location = New System.Drawing.Point(110, 29)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 30)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(45, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เกณฑ์"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Location = New System.Drawing.Point(62, 74)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(209, 73)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 38)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Font = New System.Drawing.Font("Mistral", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(428, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "โปรแกรมคำนวณส่วนสูงมาตรฐานตามสูตร"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(61, 317)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(338, 198)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ผลการคำนวณ"
        '
        'aa
        '
        Me.aa.BackColor = System.Drawing.Color.GreenYellow
        Me.aa.Controls.Add(Me.NumericUpDown2)
        Me.aa.Controls.Add(Me.NumericUpDown1)
        Me.aa.Controls.Add(Me.Label6)
        Me.aa.Controls.Add(Me.Label5)
        Me.aa.Controls.Add(Me.Label2)
        Me.aa.Controls.Add(Me.Label1)
        Me.aa.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aa.ForeColor = System.Drawing.SystemColors.MenuText
        Me.aa.Location = New System.Drawing.Point(61, 59)
        Me.aa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.aa.Name = "aa"
        Me.aa.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.aa.Size = New System.Drawing.Size(334, 162)
        Me.aa.TabIndex = 11
        Me.aa.TabStop = False
        Me.aa.Text = "กรุณาใส่ส่วนสูงและน้ำหนักปัจจุบัน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(222, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "เซนติเมตร"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(222, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "กิโลกรัม"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(110, 42)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(106, 31)
        Me.NumericUpDown1.TabIndex = 6
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(108, 100)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(108, 31)
        Me.NumericUpDown2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mistral", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 26)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "นาย วีระศักดิ์  บุญนำ  Sec.03  รหัส 338"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(30, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(257, 26)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "นาย สุริยา  ทะรา Sec.03 รหัส 344"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(474, 523)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Mistral", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "คำนวณส่วนสูง"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.aa.ResumeLayout(False)
        Me.aa.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents aa As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
