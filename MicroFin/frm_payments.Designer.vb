<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payments
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
        Me.cbo_preferred = New System.Windows.Forms.CheckBox()
        Me.txt_accountno = New System.Windows.Forms.TextBox()
        Me.txt_bankcode = New System.Windows.Forms.TextBox()
        Me.txt_membercode = New System.Windows.Forms.TextBox()
        Me.lb_accountno = New System.Windows.Forms.Label()
        Me.lb_bankcode = New System.Windows.Forms.Label()
        Me.lb_membercode = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_preferred)
        Me.GroupBox1.Controls.Add(Me.txt_accountno)
        Me.GroupBox1.Controls.Add(Me.txt_bankcode)
        Me.GroupBox1.Controls.Add(Me.txt_membercode)
        Me.GroupBox1.Controls.Add(Me.lb_accountno)
        Me.GroupBox1.Controls.Add(Me.lb_bankcode)
        Me.GroupBox1.Controls.Add(Me.lb_membercode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 335)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cbo_preferred
        '
        Me.cbo_preferred.AutoSize = True
        Me.cbo_preferred.Location = New System.Drawing.Point(14, 172)
        Me.cbo_preferred.Name = "cbo_preferred"
        Me.cbo_preferred.Size = New System.Drawing.Size(69, 17)
        Me.cbo_preferred.TabIndex = 21
        Me.cbo_preferred.Text = "Preferred"
        Me.cbo_preferred.UseVisualStyleBackColor = True
        '
        'txt_accountno
        '
        Me.txt_accountno.Location = New System.Drawing.Point(145, 130)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(100, 20)
        Me.txt_accountno.TabIndex = 20
        '
        'txt_bankcode
        '
        Me.txt_bankcode.Location = New System.Drawing.Point(145, 104)
        Me.txt_bankcode.Name = "txt_bankcode"
        Me.txt_bankcode.Size = New System.Drawing.Size(100, 20)
        Me.txt_bankcode.TabIndex = 19
        '
        'txt_membercode
        '
        Me.txt_membercode.Location = New System.Drawing.Point(145, 75)
        Me.txt_membercode.Name = "txt_membercode"
        Me.txt_membercode.Size = New System.Drawing.Size(100, 20)
        Me.txt_membercode.TabIndex = 18
        '
        'lb_accountno
        '
        Me.lb_accountno.AutoSize = True
        Me.lb_accountno.Location = New System.Drawing.Point(11, 130)
        Me.lb_accountno.Name = "lb_accountno"
        Me.lb_accountno.Size = New System.Drawing.Size(87, 13)
        Me.lb_accountno.TabIndex = 14
        Me.lb_accountno.Text = "Account Number"
        '
        'lb_bankcode
        '
        Me.lb_bankcode.AutoSize = True
        Me.lb_bankcode.Location = New System.Drawing.Point(11, 104)
        Me.lb_bankcode.Name = "lb_bankcode"
        Me.lb_bankcode.Size = New System.Drawing.Size(60, 13)
        Me.lb_bankcode.TabIndex = 13
        Me.lb_bankcode.Text = "Bank Code"
        '
        'lb_membercode
        '
        Me.lb_membercode.AutoSize = True
        Me.lb_membercode.Location = New System.Drawing.Point(11, 75)
        Me.lb_membercode.Name = "lb_membercode"
        Me.lb_membercode.Size = New System.Drawing.Size(73, 13)
        Me.lb_membercode.TabIndex = 12
        Me.lb_membercode.Text = "Member Code"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(478, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(629, 419)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_payments"
        Me.Text = "Payment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_accountno As System.Windows.Forms.TextBox
    Friend WithEvents txt_bankcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_membercode As System.Windows.Forms.TextBox
    Friend WithEvents lb_accountno As System.Windows.Forms.Label
    Friend WithEvents lb_bankcode As System.Windows.Forms.Label
    Friend WithEvents lb_membercode As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbo_preferred As System.Windows.Forms.CheckBox
End Class
