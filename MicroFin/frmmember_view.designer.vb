<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmember_view
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
        Me.cb_members = New System.Windows.Forms.GroupBox()
        Me.rbname = New System.Windows.Forms.RadioButton()
        Me.rbsubgroup = New System.Windows.Forms.RadioButton()
        Me.cbo_subgroup = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cmd_view_member = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dg_members = New System.Windows.Forms.DataGridView()
        Me.dgmembers = New System.Windows.Forms.DataGridView()
        Me.cb_members.SuspendLayout()
        CType(Me.dg_members, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_members
        '
        Me.cb_members.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cb_members.Controls.Add(Me.rbname)
        Me.cb_members.Controls.Add(Me.rbsubgroup)
        Me.cb_members.Controls.Add(Me.cbo_subgroup)
        Me.cb_members.Controls.Add(Me.txt_name)
        Me.cb_members.Controls.Add(Me.cmd_view_member)
        Me.cb_members.Dock = System.Windows.Forms.DockStyle.Top
        Me.cb_members.Location = New System.Drawing.Point(0, 0)
        Me.cb_members.Name = "cb_members"
        Me.cb_members.Size = New System.Drawing.Size(835, 72)
        Me.cb_members.TabIndex = 0
        Me.cb_members.TabStop = False
        Me.cb_members.Text = "Search"
        '
        'rbname
        '
        Me.rbname.AutoSize = True
        Me.rbname.Location = New System.Drawing.Point(42, 12)
        Me.rbname.Name = "rbname"
        Me.rbname.Size = New System.Drawing.Size(53, 17)
        Me.rbname.TabIndex = 5
        Me.rbname.TabStop = True
        Me.rbname.Text = "Name"
        Me.rbname.UseVisualStyleBackColor = True
        '
        'rbsubgroup
        '
        Me.rbsubgroup.AutoSize = True
        Me.rbsubgroup.Location = New System.Drawing.Point(201, 15)
        Me.rbsubgroup.Name = "rbsubgroup"
        Me.rbsubgroup.Size = New System.Drawing.Size(71, 17)
        Me.rbsubgroup.TabIndex = 6
        Me.rbsubgroup.TabStop = True
        Me.rbsubgroup.Text = "Subgroup"
        Me.rbsubgroup.UseVisualStyleBackColor = True
        '
        'cbo_subgroup
        '
        Me.cbo_subgroup.FormattingEnabled = True
        Me.cbo_subgroup.Location = New System.Drawing.Point(22, 38)
        Me.cbo_subgroup.Name = "cbo_subgroup"
        Me.cbo_subgroup.Size = New System.Drawing.Size(263, 21)
        Me.cbo_subgroup.TabIndex = 6
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(22, 38)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(263, 20)
        Me.txt_name.TabIndex = 2
        '
        'cmd_view_member
        '
        Me.cmd_view_member.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_view_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_view_member.ForeColor = System.Drawing.Color.White
        Me.cmd_view_member.Location = New System.Drawing.Point(367, 15)
        Me.cmd_view_member.Name = "cmd_view_member"
        Me.cmd_view_member.Size = New System.Drawing.Size(464, 51)
        Me.cmd_view_member.TabIndex = 4
        Me.cmd_view_member.Text = "View Member"
        Me.cmd_view_member.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'dg_members
        '
        Me.dg_members.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_members.Location = New System.Drawing.Point(336, 30)
        Me.dg_members.Name = "dg_members"
        Me.dg_members.Size = New System.Drawing.Size(366, 267)
        Me.dg_members.TabIndex = 1
        '
        'dgmembers
        '
        Me.dgmembers.AllowUserToAddRows = False
        Me.dgmembers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgmembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgmembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgmembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgmembers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgmembers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgmembers.Location = New System.Drawing.Point(0, 78)
        Me.dgmembers.Name = "dgmembers"
        Me.dgmembers.ReadOnly = True
        Me.dgmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgmembers.Size = New System.Drawing.Size(835, 289)
        Me.dgmembers.TabIndex = 2
        '
        'frmmember_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(835, 367)
        Me.Controls.Add(Me.dgmembers)
        Me.Controls.Add(Me.cb_members)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmember_view"
        Me.Text = "Members"
        Me.cb_members.ResumeLayout(False)
        Me.cb_members.PerformLayout()
        CType(Me.dg_members, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_members As System.Windows.Forms.GroupBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cmd_view_member As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dg_members As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_subgroup As System.Windows.Forms.ComboBox
    Friend WithEvents rbname As System.Windows.Forms.RadioButton
    Friend WithEvents rbsubgroup As System.Windows.Forms.RadioButton
    Friend WithEvents dgmembers As System.Windows.Forms.DataGridView
End Class
