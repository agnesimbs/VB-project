<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminvoices_view
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
        Me.dg_invoices = New System.Windows.Forms.DataGridView()
        CType(Me.dg_invoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View_invoices"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dg_invoices
        '
        Me.dg_invoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_invoices.Location = New System.Drawing.Point(-4, 74)
        Me.dg_invoices.Name = "dg_invoices"
        Me.dg_invoices.Size = New System.Drawing.Size(503, 192)
        Me.dg_invoices.TabIndex = 1
        '
        'frminvoices_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 261)
        Me.Controls.Add(Me.dg_invoices)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frminvoices_view"
        Me.Text = "frminvoices_view"
        CType(Me.dg_invoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dg_invoices As System.Windows.Forms.DataGridView
End Class
