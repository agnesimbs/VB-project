<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bank
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
        Me.gb_bank = New System.Windows.Forms.GroupBox()
        Me.txt_bankcode = New System.Windows.Forms.TextBox()
        Me.txt_bankname = New System.Windows.Forms.TextBox()
        Me.lb_bank = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb_bank.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Name"
        '
        'gb_bank
        '
        Me.gb_bank.Controls.Add(Me.txt_bankcode)
        Me.gb_bank.Controls.Add(Me.txt_bankname)
        Me.gb_bank.Controls.Add(Me.lb_bank)
        Me.gb_bank.Controls.Add(Me.Label1)
        Me.gb_bank.Location = New System.Drawing.Point(48, 31)
        Me.gb_bank.Name = "gb_bank"
        Me.gb_bank.Size = New System.Drawing.Size(318, 304)
        Me.gb_bank.TabIndex = 1
        Me.gb_bank.TabStop = False
        Me.gb_bank.Text = "Bank Details"
        '
        'txt_bankcode
        '
        Me.txt_bankcode.Location = New System.Drawing.Point(136, 70)
        Me.txt_bankcode.Name = "txt_bankcode"
        Me.txt_bankcode.Size = New System.Drawing.Size(100, 20)
        Me.txt_bankcode.TabIndex = 3
        '
        'txt_bankname
        '
        Me.txt_bankname.Location = New System.Drawing.Point(136, 38)
        Me.txt_bankname.Name = "txt_bankname"
        Me.txt_bankname.Size = New System.Drawing.Size(100, 20)
        Me.txt_bankname.TabIndex = 2
        '
        'lb_bank
        '
        Me.lb_bank.AutoSize = True
        Me.lb_bank.Location = New System.Drawing.Point(22, 70)
        Me.lb_bank.Name = "lb_bank"
        Me.lb_bank.Size = New System.Drawing.Size(60, 13)
        Me.lb_bank.TabIndex = 1
        Me.lb_bank.Text = "Bank Code"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb_bank)
        Me.Name = "frm_bank"
        Me.Text = "frm_bank"
        Me.gb_bank.ResumeLayout(False)
        Me.gb_bank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_bank As System.Windows.Forms.GroupBox
    Friend WithEvents txt_bankcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_bankname As System.Windows.Forms.TextBox
    Friend WithEvents lb_bank As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
