<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuppliers_view
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
        Me.btn_viewsupp = New System.Windows.Forms.Button()
        Me.dg_suppliers = New System.Windows.Forms.DataGridView()
        CType(Me.dg_suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_viewsupp
        '
        Me.btn_viewsupp.Location = New System.Drawing.Point(59, 36)
        Me.btn_viewsupp.Name = "btn_viewsupp"
        Me.btn_viewsupp.Size = New System.Drawing.Size(144, 23)
        Me.btn_viewsupp.TabIndex = 0
        Me.btn_viewsupp.Text = "View Suppliers"
        Me.btn_viewsupp.UseVisualStyleBackColor = True
        '
        'dg_suppliers
        '
        Me.dg_suppliers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_suppliers.Location = New System.Drawing.Point(1, 65)
        Me.dg_suppliers.Name = "dg_suppliers"
        Me.dg_suppliers.Size = New System.Drawing.Size(664, 282)
        Me.dg_suppliers.TabIndex = 1
        '
        'frmsuppliers_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 401)
        Me.Controls.Add(Me.dg_suppliers)
        Me.Controls.Add(Me.btn_viewsupp)
        Me.Name = "frmsuppliers_view"
        Me.Text = "Suppliers view"
        CType(Me.dg_suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_viewsupp As System.Windows.Forms.Button
    Friend WithEvents dg_suppliers As System.Windows.Forms.DataGridView
End Class
