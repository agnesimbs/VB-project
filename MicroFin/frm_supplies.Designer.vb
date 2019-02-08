<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_supplies
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
        Me.txt_inputno = New System.Windows.Forms.TextBox()
        Me.txt_suppliername = New System.Windows.Forms.TextBox()
        Me.txt_batchno = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Batch _no"
        '
        'txt_inputno
        '
        Me.txt_inputno.Location = New System.Drawing.Point(274, 44)
        Me.txt_inputno.Name = "txt_inputno"
        Me.txt_inputno.Size = New System.Drawing.Size(100, 20)
        Me.txt_inputno.TabIndex = 3
        '
        'txt_suppliername
        '
        Me.txt_suppliername.Location = New System.Drawing.Point(274, 75)
        Me.txt_suppliername.Name = "txt_suppliername"
        Me.txt_suppliername.Size = New System.Drawing.Size(100, 20)
        Me.txt_suppliername.TabIndex = 4
        '
        'txt_batchno
        '
        Me.txt_batchno.Location = New System.Drawing.Point(274, 109)
        Me.txt_batchno.Name = "txt_batchno"
        Me.txt_batchno.Size = New System.Drawing.Size(100, 20)
        Me.txt_batchno.TabIndex = 5
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(519, 274)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frm_supplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 445)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_batchno)
        Me.Controls.Add(Me.txt_suppliername)
        Me.Controls.Add(Me.txt_inputno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_supplies"
        Me.Text = "Supplies Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_inputno As System.Windows.Forms.TextBox
    Friend WithEvents txt_suppliername As System.Windows.Forms.TextBox
    Friend WithEvents txt_batchno As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
