<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudentview
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtadmission_no = New System.Windows.Forms.TextBox()
        Me.rbadmission_no = New System.Windows.Forms.RadioButton()
        Me.rbclass = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbostream = New System.Windows.Forms.ComboBox()
        Me.cboform = New System.Windows.Forms.ComboBox()
        Me.dgstudents = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboreportoptions = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(105, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "View Students"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtadmission_no
        '
        Me.txtadmission_no.Location = New System.Drawing.Point(105, 116)
        Me.txtadmission_no.Name = "txtadmission_no"
        Me.txtadmission_no.Size = New System.Drawing.Size(219, 20)
        Me.txtadmission_no.TabIndex = 7
        '
        'rbadmission_no
        '
        Me.rbadmission_no.AutoSize = True
        Me.rbadmission_no.Location = New System.Drawing.Point(10, 118)
        Me.rbadmission_no.Name = "rbadmission_no"
        Me.rbadmission_no.Size = New System.Drawing.Size(89, 17)
        Me.rbadmission_no.TabIndex = 6
        Me.rbadmission_no.TabStop = True
        Me.rbadmission_no.Text = "Admission No"
        Me.rbadmission_no.UseVisualStyleBackColor = True
        '
        'rbclass
        '
        Me.rbclass.AutoSize = True
        Me.rbclass.Location = New System.Drawing.Point(10, 22)
        Me.rbclass.Name = "rbclass"
        Me.rbclass.Size = New System.Drawing.Size(50, 17)
        Me.rbclass.TabIndex = 5
        Me.rbclass.TabStop = True
        Me.rbclass.Text = "Class"
        Me.rbclass.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stream"
        '
        'cbostream
        '
        Me.cbostream.FormattingEnabled = True
        Me.cbostream.Location = New System.Drawing.Point(107, 64)
        Me.cbostream.Name = "cbostream"
        Me.cbostream.Size = New System.Drawing.Size(217, 21)
        Me.cbostream.TabIndex = 2
        '
        'cboform
        '
        Me.cboform.FormattingEnabled = True
        Me.cboform.Items.AddRange(New Object() {"PP1", "PP2", "STD 1", "STD 2", "STD 3", "STD 4", "STD 5", "STD 6", "STD 7", "STD 8"})
        Me.cboform.Location = New System.Drawing.Point(107, 20)
        Me.cboform.Name = "cboform"
        Me.cboform.Size = New System.Drawing.Size(217, 21)
        Me.cboform.TabIndex = 1
        '
        'dgstudents
        '
        Me.dgstudents.AllowUserToAddRows = False
        Me.dgstudents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgstudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgstudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgstudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgstudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgstudents.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgstudents.Location = New System.Drawing.Point(351, 334)
        Me.dgstudents.Name = "dgstudents"
        Me.dgstudents.ReadOnly = True
        Me.dgstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgstudents.Size = New System.Drawing.Size(734, 171)
        Me.dgstudents.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboreportoptions)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtadmission_no)
        Me.GroupBox1.Controls.Add(Me.cboform)
        Me.GroupBox1.Controls.Add(Me.rbadmission_no)
        Me.GroupBox1.Controls.Add(Me.cbostream)
        Me.GroupBox1.Controls.Add(Me.rbclass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 498)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Student"
        '
        'cboreportoptions
        '
        Me.cboreportoptions.FormattingEnabled = True
        Me.cboreportoptions.Items.AddRange(New Object() {"Print Report", "Export Report", "View Report"})
        Me.cboreportoptions.Location = New System.Drawing.Point(105, 223)
        Me.cboreportoptions.Name = "cboreportoptions"
        Me.cboreportoptions.Size = New System.Drawing.Size(219, 21)
        Me.cboreportoptions.TabIndex = 57
        Me.cboreportoptions.Text = "Print Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Report Options"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(180, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 33)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Print/export Photo-register"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(6, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 33)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Print/export classlist"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmstudentview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1085, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgstudents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmstudentview"
        Me.Text = "Students"
        CType(Me.dgstudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtadmission_no As System.Windows.Forms.TextBox
    Friend WithEvents rbadmission_no As System.Windows.Forms.RadioButton
    Friend WithEvents rbclass As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbostream As System.Windows.Forms.ComboBox
    Friend WithEvents cboform As System.Windows.Forms.ComboBox
    Friend WithEvents dgstudents As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboreportoptions As System.Windows.Forms.ComboBox
End Class
