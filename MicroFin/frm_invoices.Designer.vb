<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoices
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_salesno = New System.Windows.Forms.TextBox()
        Me.txt_buyerid = New System.Windows.Forms.TextBox()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.txt_units = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_userid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp_invoices = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buyer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date sold"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Units"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Price per unit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "User ID"
        '
        'txt_salesno
        '
        Me.txt_salesno.Location = New System.Drawing.Point(257, 68)
        Me.txt_salesno.Name = "txt_salesno"
        Me.txt_salesno.Size = New System.Drawing.Size(100, 20)
        Me.txt_salesno.TabIndex = 8
        '
        'txt_buyerid
        '
        Me.txt_buyerid.Location = New System.Drawing.Point(257, 92)
        Me.txt_buyerid.Name = "txt_buyerid"
        Me.txt_buyerid.Size = New System.Drawing.Size(100, 20)
        Me.txt_buyerid.TabIndex = 9
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(257, 122)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.Size = New System.Drawing.Size(100, 20)
        Me.txt_productid.TabIndex = 10
        '
        'txt_mobile
        '
        Me.txt_mobile.Location = New System.Drawing.Point(257, 149)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(100, 20)
        Me.txt_mobile.TabIndex = 11
        '
        'txt_units
        '
        Me.txt_units.Location = New System.Drawing.Point(257, 220)
        Me.txt_units.Name = "txt_units"
        Me.txt_units.Size = New System.Drawing.Size(100, 20)
        Me.txt_units.TabIndex = 13
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(257, 250)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 14
        '
        'txt_userid
        '
        Me.txt_userid.Location = New System.Drawing.Point(257, 283)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Size = New System.Drawing.Size(100, 20)
        Me.txt_userid.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp_invoices
        '
        Me.dtp_invoices.CustomFormat = "dd-MM-yyyy"
        Me.dtp_invoices.Location = New System.Drawing.Point(257, 184)
        Me.dtp_invoices.Name = "dtp_invoices"
        Me.dtp_invoices.Size = New System.Drawing.Size(200, 20)
        Me.dtp_invoices.TabIndex = 17
        Me.dtp_invoices.Value = New Date(2019, 2, 4, 0, 0, 0, 0)
        '
        'frm_invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 396)
        Me.Controls.Add(Me.dtp_invoices)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_userid)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_units)
        Me.Controls.Add(Me.txt_mobile)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.txt_buyerid)
        Me.Controls.Add(Me.txt_salesno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_invoices"
        Me.Text = "frm_invoices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_salesno As System.Windows.Forms.TextBox
    Friend WithEvents txt_buyerid As System.Windows.Forms.TextBox
    Friend WithEvents txt_productid As System.Windows.Forms.TextBox
    Friend WithEvents txt_mobile As System.Windows.Forms.TextBox
    Friend WithEvents txt_units As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_userid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtp_invoices As System.Windows.Forms.DateTimePicker
End Class
