<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_paymethods
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
        Me.lb_mpesano = New System.Windows.Forms.Label()
        Me.lb_equitelno = New System.Windows.Forms.Label()
        Me.lb_equityacc = New System.Windows.Forms.Label()
        Me.lb_coopacc = New System.Windows.Forms.Label()
        Me.txt_mpesano = New System.Windows.Forms.TextBox()
        Me.txt_equitelno = New System.Windows.Forms.TextBox()
        Me.txt_equityacc = New System.Windows.Forms.TextBox()
        Me.txt_coopacc = New System.Windows.Forms.TextBox()
        Me.lb_membercode = New System.Windows.Forms.Label()
        Me.txt_membercode = New System.Windows.Forms.TextBox()
        Me.btn_paymethods = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_mpesano
        '
        Me.lb_mpesano.AutoSize = True
        Me.lb_mpesano.Location = New System.Drawing.Point(44, 56)
        Me.lb_mpesano.Name = "lb_mpesano"
        Me.lb_mpesano.Size = New System.Drawing.Size(56, 13)
        Me.lb_mpesano.TabIndex = 0
        Me.lb_mpesano.Text = "Mpesa No"
        '
        'lb_equitelno
        '
        Me.lb_equitelno.AutoSize = True
        Me.lb_equitelno.Location = New System.Drawing.Point(44, 81)
        Me.lb_equitelno.Name = "lb_equitelno"
        Me.lb_equitelno.Size = New System.Drawing.Size(54, 13)
        Me.lb_equitelno.TabIndex = 1
        Me.lb_equitelno.Text = "Equitel no"
        '
        'lb_equityacc
        '
        Me.lb_equityacc.AutoSize = True
        Me.lb_equityacc.Location = New System.Drawing.Point(44, 110)
        Me.lb_equityacc.Name = "lb_equityacc"
        Me.lb_equityacc.Size = New System.Drawing.Size(60, 13)
        Me.lb_equityacc.TabIndex = 2
        Me.lb_equityacc.Text = "Equity ACC"
        '
        'lb_coopacc
        '
        Me.lb_coopacc.AutoSize = True
        Me.lb_coopacc.Location = New System.Drawing.Point(44, 142)
        Me.lb_coopacc.Name = "lb_coopacc"
        Me.lb_coopacc.Size = New System.Drawing.Size(54, 13)
        Me.lb_coopacc.TabIndex = 3
        Me.lb_coopacc.Text = "Coop Acc"
        '
        'txt_mpesano
        '
        Me.txt_mpesano.Location = New System.Drawing.Point(190, 13)
        Me.txt_mpesano.Name = "txt_mpesano"
        Me.txt_mpesano.Size = New System.Drawing.Size(100, 20)
        Me.txt_mpesano.TabIndex = 4
        '
        'txt_equitelno
        '
        Me.txt_equitelno.Location = New System.Drawing.Point(190, 56)
        Me.txt_equitelno.Name = "txt_equitelno"
        Me.txt_equitelno.Size = New System.Drawing.Size(100, 20)
        Me.txt_equitelno.TabIndex = 5
        '
        'txt_equityacc
        '
        Me.txt_equityacc.Location = New System.Drawing.Point(190, 110)
        Me.txt_equityacc.Name = "txt_equityacc"
        Me.txt_equityacc.Size = New System.Drawing.Size(100, 20)
        Me.txt_equityacc.TabIndex = 6
        '
        'txt_coopacc
        '
        Me.txt_coopacc.Location = New System.Drawing.Point(190, 142)
        Me.txt_coopacc.Name = "txt_coopacc"
        Me.txt_coopacc.Size = New System.Drawing.Size(100, 20)
        Me.txt_coopacc.TabIndex = 7
        '
        'lb_membercode
        '
        Me.lb_membercode.AutoSize = True
        Me.lb_membercode.Location = New System.Drawing.Point(47, 13)
        Me.lb_membercode.Name = "lb_membercode"
        Me.lb_membercode.Size = New System.Drawing.Size(72, 13)
        Me.lb_membercode.TabIndex = 8
        Me.lb_membercode.Text = "Member code"
        '
        'txt_membercode
        '
        Me.txt_membercode.Location = New System.Drawing.Point(190, 81)
        Me.txt_membercode.Name = "txt_membercode"
        Me.txt_membercode.Size = New System.Drawing.Size(100, 20)
        Me.txt_membercode.TabIndex = 9
        '
        'btn_paymethods
        '
        Me.btn_paymethods.Location = New System.Drawing.Point(410, 305)
        Me.btn_paymethods.Name = "btn_paymethods"
        Me.btn_paymethods.Size = New System.Drawing.Size(75, 23)
        Me.btn_paymethods.TabIndex = 10
        Me.btn_paymethods.Text = "Save"
        Me.btn_paymethods.UseVisualStyleBackColor = True
        '
        'frm_paymethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 425)
        Me.Controls.Add(Me.btn_paymethods)
        Me.Controls.Add(Me.txt_membercode)
        Me.Controls.Add(Me.lb_membercode)
        Me.Controls.Add(Me.txt_coopacc)
        Me.Controls.Add(Me.txt_equityacc)
        Me.Controls.Add(Me.txt_equitelno)
        Me.Controls.Add(Me.txt_mpesano)
        Me.Controls.Add(Me.lb_coopacc)
        Me.Controls.Add(Me.lb_equityacc)
        Me.Controls.Add(Me.lb_equitelno)
        Me.Controls.Add(Me.lb_mpesano)
        Me.Name = "frm_paymethods"
        Me.Text = "frm_paymethods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_mpesano As System.Windows.Forms.Label
    Friend WithEvents lb_equitelno As System.Windows.Forms.Label
    Friend WithEvents lb_equityacc As System.Windows.Forms.Label
    Friend WithEvents lb_coopacc As System.Windows.Forms.Label
    Friend WithEvents txt_mpesano As System.Windows.Forms.TextBox
    Friend WithEvents txt_equitelno As System.Windows.Forms.TextBox
    Friend WithEvents txt_equityacc As System.Windows.Forms.TextBox
    Friend WithEvents txt_coopacc As System.Windows.Forms.TextBox
    Friend WithEvents lb_membercode As System.Windows.Forms.Label
    Friend WithEvents txt_membercode As System.Windows.Forms.TextBox
    Friend WithEvents btn_paymethods As System.Windows.Forms.Button
End Class
