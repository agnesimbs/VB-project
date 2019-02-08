<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbank_view
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
        Me.dg_bank = New System.Windows.Forms.DataGridView()
        Me.btn_bank = New System.Windows.Forms.Button()
        CType(Me.dg_bank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_bank
        '
        Me.dg_bank.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bank.Location = New System.Drawing.Point(214, 12)
        Me.dg_bank.Name = "dg_bank"
        Me.dg_bank.Size = New System.Drawing.Size(312, 243)
        Me.dg_bank.TabIndex = 0
        '
        'btn_bank
        '
        Me.btn_bank.Location = New System.Drawing.Point(43, 43)
        Me.btn_bank.Name = "btn_bank"
        Me.btn_bank.Size = New System.Drawing.Size(75, 23)
        Me.btn_bank.TabIndex = 1
        Me.btn_bank.Text = "View Bank"
        Me.btn_bank.UseVisualStyleBackColor = True
        '
        'frmbank_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 422)
        Me.Controls.Add(Me.btn_bank)
        Me.Controls.Add(Me.dg_bank)
        Me.Name = "frmbank_view"
        Me.Text = "frmbank_view"
        CType(Me.dg_bank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_bank As System.Windows.Forms.DataGridView
    Friend WithEvents btn_bank As System.Windows.Forms.Button
End Class
