<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfarminputs_view
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dg_farminputs = New System.Windows.Forms.DataGridView()
        CType(Me.dg_farminputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "VIEW FARMINPUTS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dg_farminputs
        '
        Me.dg_farminputs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_farminputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_farminputs.Location = New System.Drawing.Point(0, 122)
        Me.dg_farminputs.Name = "dg_farminputs"
        Me.dg_farminputs.Size = New System.Drawing.Size(634, 243)
        Me.dg_farminputs.TabIndex = 1
        '
        'frmfarminputs_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(633, 389)
        Me.Controls.Add(Me.dg_farminputs)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmfarminputs_view"
        Me.Text = "frmfarminputs_view"
        CType(Me.dg_farminputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dg_farminputs As System.Windows.Forms.DataGridView
End Class
