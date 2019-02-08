<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_suppliers
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_saccount = New System.Windows.Forms.TextBox()
        Me.txt_semail = New System.Windows.Forms.TextBox()
        Me.txt_sphone = New System.Windows.Forms.TextBox()
        Me.txt_slocation = New System.Windows.Forms.TextBox()
        Me.txt_sname = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_saccount)
        Me.GroupBox1.Controls.Add(Me.txt_semail)
        Me.GroupBox1.Controls.Add(Me.txt_sphone)
        Me.GroupBox1.Controls.Add(Me.txt_slocation)
        Me.GroupBox1.Controls.Add(Me.txt_sname)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 360)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txt_saccount
        '
        Me.txt_saccount.Location = New System.Drawing.Point(187, 190)
        Me.txt_saccount.Name = "txt_saccount"
        Me.txt_saccount.Size = New System.Drawing.Size(100, 20)
        Me.txt_saccount.TabIndex = 11
        '
        'txt_semail
        '
        Me.txt_semail.Location = New System.Drawing.Point(187, 163)
        Me.txt_semail.Name = "txt_semail"
        Me.txt_semail.Size = New System.Drawing.Size(100, 20)
        Me.txt_semail.TabIndex = 10
        '
        'txt_sphone
        '
        Me.txt_sphone.Location = New System.Drawing.Point(187, 134)
        Me.txt_sphone.Name = "txt_sphone"
        Me.txt_sphone.Size = New System.Drawing.Size(100, 20)
        Me.txt_sphone.TabIndex = 9
        '
        'txt_slocation
        '
        Me.txt_slocation.Location = New System.Drawing.Point(187, 89)
        Me.txt_slocation.Name = "txt_slocation"
        Me.txt_slocation.Size = New System.Drawing.Size(100, 20)
        Me.txt_slocation.TabIndex = 8
        '
        'txt_sname
        '
        Me.txt_sname.Location = New System.Drawing.Point(187, 60)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.Size = New System.Drawing.Size(100, 20)
        Me.txt_sname.TabIndex = 7
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(187, 37)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Supplier Account "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Supplier Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supplier Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier Name"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(465, 333)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frm_suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 434)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_suppliers"
        Me.Text = "Suppliers Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_saccount As System.Windows.Forms.TextBox
    Friend WithEvents txt_semail As System.Windows.Forms.TextBox
    Friend WithEvents txt_sphone As System.Windows.Forms.TextBox
    Friend WithEvents txt_slocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_sname As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
