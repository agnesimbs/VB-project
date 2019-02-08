<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conn
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
        Me.txts_name = New System.Windows.Forms.TextBox()
        Me.txtu_name = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcatalog = New System.Windows.Forms.TextBox()
        Me.lblerr = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txts_name
        '
        Me.txts_name.Location = New System.Drawing.Point(132, 20)
        Me.txts_name.Name = "txts_name"
        Me.txts_name.Size = New System.Drawing.Size(311, 20)
        Me.txts_name.TabIndex = 1
        '
        'txtu_name
        '
        Me.txtu_name.Location = New System.Drawing.Point(132, 66)
        Me.txtu_name.Name = "txtu_name"
        Me.txtu_name.Size = New System.Drawing.Size(311, 20)
        Me.txtu_name.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(132, 112)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(311, 20)
        Me.txtpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtcatalog)
        Me.GroupBox1.Controls.Add(Me.lblerr)
        Me.GroupBox1.Controls.Add(Me.txtu_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txts_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 267)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Server Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Initial Catalog:"
        '
        'txtcatalog
        '
        Me.txtcatalog.Location = New System.Drawing.Point(132, 158)
        Me.txtcatalog.Name = "txtcatalog"
        Me.txtcatalog.Size = New System.Drawing.Size(311, 20)
        Me.txtcatalog.TabIndex = 9
        '
        'lblerr
        '
        Me.lblerr.AutoSize = True
        Me.lblerr.ForeColor = System.Drawing.Color.Red
        Me.lblerr.Location = New System.Drawing.Point(6, 226)
        Me.lblerr.Name = "lblerr"
        Me.lblerr.Size = New System.Drawing.Size(10, 13)
        Me.lblerr.TabIndex = 7
        Me.lblerr.Text = ":"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(334, 285)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(123, 24)
        Me.btnSet.TabIndex = 8
        Me.btnSet.Text = "Save settings"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'conn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 331)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "conn"
        Me.Text = "Server Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txts_name As System.Windows.Forms.TextBox
    Friend WithEvents txtu_name As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblerr As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcatalog As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
