<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_users
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_userLoad = New System.Windows.Forms.Button()
        Me.txt_UserEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combobox_UserClass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_User_SaveData = New System.Windows.Forms.Button()
        Me.txt_UserPassWrd = New System.Windows.Forms.TextBox()
        Me.txt_UserPhone = New System.Windows.Forms.TextBox()
        Me.pctr_UserPhoto = New System.Windows.Forms.PictureBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.txt_UserId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_User_status = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_User_Date = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_User_Time = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.server = New System.Windows.Forms.Label()
        Me.lbl_editUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctr_UserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btn_userLoad)
        Me.GroupBox1.Controls.Add(Me.txt_UserEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.combobox_UserClass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_User_SaveData)
        Me.GroupBox1.Controls.Add(Me.txt_UserPassWrd)
        Me.GroupBox1.Controls.Add(Me.txt_UserPhone)
        Me.GroupBox1.Controls.Add(Me.pctr_UserPhoto)
        Me.GroupBox1.Controls.Add(Me.txt_UserName)
        Me.GroupBox1.Controls.Add(Me.txt_UserId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 447)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users"
        '
        'btn_userLoad
        '
        Me.btn_userLoad.Location = New System.Drawing.Point(342, 406)
        Me.btn_userLoad.Name = "btn_userLoad"
        Me.btn_userLoad.Size = New System.Drawing.Size(75, 23)
        Me.btn_userLoad.TabIndex = 22
        Me.btn_userLoad.Text = "Load User"
        Me.btn_userLoad.UseVisualStyleBackColor = True
        '
        'txt_UserEmail
        '
        Me.txt_UserEmail.Location = New System.Drawing.Point(178, 290)
        Me.txt_UserEmail.Name = "txt_UserEmail"
        Me.txt_UserEmail.Size = New System.Drawing.Size(216, 20)
        Me.txt_UserEmail.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email"
        '
        'combobox_UserClass
        '
        Me.combobox_UserClass.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Teller", "Signitory"})
        Me.combobox_UserClass.FormattingEnabled = True
        Me.combobox_UserClass.Items.AddRange(New Object() {"Admin", "Teller", "Signitory"})
        Me.combobox_UserClass.Location = New System.Drawing.Point(178, 139)
        Me.combobox_UserClass.Name = "combobox_UserClass"
        Me.combobox_UserClass.Size = New System.Drawing.Size(146, 21)
        Me.combobox_UserClass.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Class"
        '
        'btn_User_SaveData
        '
        Me.btn_User_SaveData.Location = New System.Drawing.Point(221, 406)
        Me.btn_User_SaveData.Name = "btn_User_SaveData"
        Me.btn_User_SaveData.Size = New System.Drawing.Size(75, 23)
        Me.btn_User_SaveData.TabIndex = 17
        Me.btn_User_SaveData.Text = "Save"
        Me.btn_User_SaveData.UseVisualStyleBackColor = True
        '
        'txt_UserPassWrd
        '
        Me.txt_UserPassWrd.Location = New System.Drawing.Point(178, 340)
        Me.txt_UserPassWrd.Name = "txt_UserPassWrd"
        Me.txt_UserPassWrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_UserPassWrd.Size = New System.Drawing.Size(146, 20)
        Me.txt_UserPassWrd.TabIndex = 14
        '
        'txt_UserPhone
        '
        Me.txt_UserPhone.Location = New System.Drawing.Point(178, 200)
        Me.txt_UserPhone.Name = "txt_UserPhone"
        Me.txt_UserPhone.Size = New System.Drawing.Size(146, 20)
        Me.txt_UserPhone.TabIndex = 13
        '
        'pctr_UserPhoto
        '
        Me.pctr_UserPhoto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pctr_UserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctr_UserPhoto.Location = New System.Drawing.Point(342, 37)
        Me.pctr_UserPhoto.Name = "pctr_UserPhoto"
        Me.pctr_UserPhoto.Size = New System.Drawing.Size(195, 226)
        Me.pctr_UserPhoto.TabIndex = 9
        Me.pctr_UserPhoto.TabStop = False
        Me.pctr_UserPhoto.Tag = ""
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(178, 90)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(146, 20)
        Me.txt_UserName.TabIndex = 8
        '
        'txt_UserId
        '
        Me.txt_UserId.Location = New System.Drawing.Point(178, 34)
        Me.txt_UserId.Name = "txt_UserId"
        Me.txt_UserId.Size = New System.Drawing.Size(146, 20)
        Me.txt_UserId.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Status:"
        '
        'lbl_User_status
        '
        Me.lbl_User_status.AutoSize = True
        Me.lbl_User_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_User_status.Location = New System.Drawing.Point(56, 13)
        Me.lbl_User_status.MinimumSize = New System.Drawing.Size(70, 18)
        Me.lbl_User_status.Name = "lbl_User_status"
        Me.lbl_User_status.Size = New System.Drawing.Size(70, 18)
        Me.lbl_User_status.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(143, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Date:"
        '
        'lbl_User_Date
        '
        Me.lbl_User_Date.AutoSize = True
        Me.lbl_User_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_User_Date.Location = New System.Drawing.Point(188, 14)
        Me.lbl_User_Date.MinimumSize = New System.Drawing.Size(80, 18)
        Me.lbl_User_Date.Name = "lbl_User_Date"
        Me.lbl_User_Date.Size = New System.Drawing.Size(80, 18)
        Me.lbl_User_Date.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(306, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Time:"
        '
        'lbl_User_Time
        '
        Me.lbl_User_Time.AutoSize = True
        Me.lbl_User_Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_User_Time.Location = New System.Drawing.Point(353, 13)
        Me.lbl_User_Time.MinimumSize = New System.Drawing.Size(80, 18)
        Me.lbl_User_Time.Name = "lbl_User_Time"
        Me.lbl_User_Time.Size = New System.Drawing.Size(80, 18)
        Me.lbl_User_Time.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.server)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lbl_User_Time)
        Me.GroupBox3.Controls.Add(Me.lbl_User_status)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lbl_User_Date)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 483)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 33)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'server
        '
        Me.server.AutoSize = True
        Me.server.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.server.Location = New System.Drawing.Point(452, 12)
        Me.server.MinimumSize = New System.Drawing.Size(130, 20)
        Me.server.Name = "server"
        Me.server.Size = New System.Drawing.Size(130, 20)
        Me.server.TabIndex = 7
        Me.server.Text = "Status Connection"
        Me.server.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbl_editUser
        '
        Me.lbl_editUser.AutoSize = True
        Me.lbl_editUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_editUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editUser.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_editUser.Location = New System.Drawing.Point(354, 24)
        Me.lbl_editUser.Name = "lbl_editUser"
        Me.lbl_editUser.Size = New System.Drawing.Size(2, 17)
        Me.lbl_editUser.TabIndex = 8
        '
        'Frm_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(597, 521)
        Me.Controls.Add(Me.lbl_editUser)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_users"
        Me.Text = "Frm_users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctr_UserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pctr_UserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txt_UserName As System.Windows.Forms.TextBox
    Friend WithEvents txt_UserId As System.Windows.Forms.TextBox
    Friend WithEvents txt_UserPassWrd As System.Windows.Forms.TextBox
    Friend WithEvents txt_UserPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_User_status As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_User_Date As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_User_Time As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_User_SaveData As System.Windows.Forms.Button
    Friend WithEvents combobox_UserClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_UserEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents server As System.Windows.Forms.Label
    Friend WithEvents lbl_editUser As System.Windows.Forms.Label
    Friend WithEvents btn_userLoad As System.Windows.Forms.Button
End Class
