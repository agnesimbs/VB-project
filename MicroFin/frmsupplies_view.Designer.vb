<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupplies_view
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
        Me.btn_viewsupplies = New System.Windows.Forms.Button()
        Me.dg_supplies = New System.Windows.Forms.DataGridView()
        CType(Me.dg_supplies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_viewsupplies
        '
        Me.btn_viewsupplies.Location = New System.Drawing.Point(90, 38)
        Me.btn_viewsupplies.Name = "btn_viewsupplies"
        Me.btn_viewsupplies.Size = New System.Drawing.Size(119, 23)
        Me.btn_viewsupplies.TabIndex = 0
        Me.btn_viewsupplies.Text = "View Supplies"
        Me.btn_viewsupplies.UseVisualStyleBackColor = True
        '
        'dg_supplies
        '
        Me.dg_supplies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_supplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_supplies.Location = New System.Drawing.Point(-2, 119)
        Me.dg_supplies.Name = "dg_supplies"
        Me.dg_supplies.Size = New System.Drawing.Size(629, 213)
        Me.dg_supplies.TabIndex = 1
        '
        'frmsupplies_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 333)
        Me.Controls.Add(Me.dg_supplies)
        Me.Controls.Add(Me.btn_viewsupplies)
        Me.Name = "frmsupplies_view"
        Me.Text = "frmsupplies_view"
        CType(Me.dg_supplies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_viewsupplies As System.Windows.Forms.Button
    Friend WithEvents dg_supplies As System.Windows.Forms.DataGridView
End Class
