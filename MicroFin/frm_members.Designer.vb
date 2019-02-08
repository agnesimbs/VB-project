<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_members
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
        Me.group_details = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmember = New System.Windows.Forms.CheckBox()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.cbfarmer = New System.Windows.Forms.CheckBox()
        Me.txt_membername = New System.Windows.Forms.TextBox()
        Me.txt_member_plotnum = New System.Windows.Forms.TextBox()
        Me.txt_memberadress = New System.Windows.Forms.TextBox()
        Me.txt_membermobile = New System.Windows.Forms.TextBox()
        Me.txt_memberid = New System.Windows.Forms.TextBox()
        Me.txt_member_code = New System.Windows.Forms.TextBox()
        Me.label_plotnumber = New System.Windows.Forms.Label()
        Me.label_adress = New System.Windows.Forms.Label()
        Me.label_mobile = New System.Windows.Forms.Label()
        Me.label_idnum = New System.Windows.Forms.Label()
        Me.label_name = New System.Windows.Forms.Label()
        Me.label_member_code = New System.Windows.Forms.Label()
        Me.group_Kin_Details = New System.Windows.Forms.GroupBox()
        Me.txt_kinrelation = New System.Windows.Forms.TextBox()
        Me.txt_kincontact = New System.Windows.Forms.TextBox()
        Me.txt_kinname = New System.Windows.Forms.TextBox()
        Me.label_kinrelation = New System.Windows.Forms.Label()
        Me.label_kincontact = New System.Windows.Forms.Label()
        Me.label_kinname = New System.Windows.Forms.Label()
        Me.label_nextkin = New System.Windows.Forms.Label()
        Me.group_photo = New System.Windows.Forms.GroupBox()
        Me.combo_zone = New System.Windows.Forms.ComboBox()
        Me.combo_subgroup = New System.Windows.Forms.ComboBox()
        Me.label_zone = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_photo = New System.Windows.Forms.Label()
        Me.SB_Main = New System.Windows.Forms.StatusBar()
        Me.SBP1_Status = New System.Windows.Forms.StatusBarPanel()
        Me.SBP2_Today = New System.Windows.Forms.StatusBarPanel()
        Me.SBP3_Date = New System.Windows.Forms.StatusBarPanel()
        Me.SBP4_Time = New System.Windows.Forms.StatusBarPanel()
        Me.server = New System.Windows.Forms.StatusBarPanel()
        Me.sbinternet = New System.Windows.Forms.StatusBarPanel()
        Me.serverconnection = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picpassport = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lbleditmode = New System.Windows.Forms.Label()
        Me.gbpayment = New System.Windows.Forms.GroupBox()
        Me.txt_equitel = New System.Windows.Forms.TextBox()
        Me.txt_mpesa = New System.Windows.Forms.TextBox()
        Me.lb_equitel = New System.Windows.Forms.Label()
        Me.lb_mpesa = New System.Windows.Forms.Label()
        Me.btn_payments = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btn_paymethods = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btn_suppliers = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_supplies = New System.Windows.Forms.Button()
        Me.btn_viewsupplies = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btn_farmproduce = New System.Windows.Forms.Button()
        Me.group_details.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.group_Kin_Details.SuspendLayout()
        Me.group_photo.SuspendLayout()
        CType(Me.SBP1_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBP2_Today, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBP3_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBP4_Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.server, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbinternet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpassport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_details
        '
        Me.group_details.Controls.Add(Me.GroupBox1)
        Me.group_details.Controls.Add(Me.txt_membername)
        Me.group_details.Controls.Add(Me.txt_member_plotnum)
        Me.group_details.Controls.Add(Me.txt_memberadress)
        Me.group_details.Controls.Add(Me.txt_membermobile)
        Me.group_details.Controls.Add(Me.txt_memberid)
        Me.group_details.Controls.Add(Me.txt_member_code)
        Me.group_details.Controls.Add(Me.label_plotnumber)
        Me.group_details.Controls.Add(Me.label_adress)
        Me.group_details.Controls.Add(Me.label_mobile)
        Me.group_details.Controls.Add(Me.label_idnum)
        Me.group_details.Controls.Add(Me.label_name)
        Me.group_details.Controls.Add(Me.label_member_code)
        Me.group_details.Location = New System.Drawing.Point(23, 13)
        Me.group_details.Name = "group_details"
        Me.group_details.Size = New System.Drawing.Size(341, 278)
        Me.group_details.TabIndex = 0
        Me.group_details.TabStop = False
        Me.group_details.Text = "Member Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmember)
        Me.GroupBox1.Controls.Add(Me.lbstatus)
        Me.GroupBox1.Controls.Add(Me.cbfarmer)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 77)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'cbmember
        '
        Me.cbmember.AutoSize = True
        Me.cbmember.Location = New System.Drawing.Point(94, 37)
        Me.cbmember.Name = "cbmember"
        Me.cbmember.Size = New System.Drawing.Size(64, 17)
        Me.cbmember.TabIndex = 15
        Me.cbmember.Text = "Member"
        Me.cbmember.UseVisualStyleBackColor = True
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Location = New System.Drawing.Point(6, 18)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(37, 13)
        Me.lbstatus.TabIndex = 13
        Me.lbstatus.Text = "Status"
        '
        'cbfarmer
        '
        Me.cbfarmer.AutoSize = True
        Me.cbfarmer.Location = New System.Drawing.Point(94, 14)
        Me.cbfarmer.Name = "cbfarmer"
        Me.cbfarmer.Size = New System.Drawing.Size(58, 17)
        Me.cbfarmer.TabIndex = 14
        Me.cbfarmer.Text = "Farmer"
        Me.cbfarmer.UseVisualStyleBackColor = True
        '
        'txt_membername
        '
        Me.txt_membername.Location = New System.Drawing.Point(155, 130)
        Me.txt_membername.Name = "txt_membername"
        Me.txt_membername.Size = New System.Drawing.Size(100, 20)
        Me.txt_membername.TabIndex = 12
        '
        'txt_member_plotnum
        '
        Me.txt_member_plotnum.Location = New System.Drawing.Point(155, 246)
        Me.txt_member_plotnum.Name = "txt_member_plotnum"
        Me.txt_member_plotnum.Size = New System.Drawing.Size(100, 20)
        Me.txt_member_plotnum.TabIndex = 11
        '
        'txt_memberadress
        '
        Me.txt_memberadress.Location = New System.Drawing.Point(155, 220)
        Me.txt_memberadress.Name = "txt_memberadress"
        Me.txt_memberadress.Size = New System.Drawing.Size(100, 20)
        Me.txt_memberadress.TabIndex = 10
        '
        'txt_membermobile
        '
        Me.txt_membermobile.Location = New System.Drawing.Point(155, 187)
        Me.txt_membermobile.Name = "txt_membermobile"
        Me.txt_membermobile.Size = New System.Drawing.Size(100, 20)
        Me.txt_membermobile.TabIndex = 9
        '
        'txt_memberid
        '
        Me.txt_memberid.Location = New System.Drawing.Point(155, 161)
        Me.txt_memberid.Name = "txt_memberid"
        Me.txt_memberid.Size = New System.Drawing.Size(100, 20)
        Me.txt_memberid.TabIndex = 8
        '
        'txt_member_code
        '
        Me.txt_member_code.Location = New System.Drawing.Point(155, 99)
        Me.txt_member_code.Name = "txt_member_code"
        Me.txt_member_code.Size = New System.Drawing.Size(100, 20)
        Me.txt_member_code.TabIndex = 6
        '
        'label_plotnumber
        '
        Me.label_plotnumber.AutoSize = True
        Me.label_plotnumber.Location = New System.Drawing.Point(26, 254)
        Me.label_plotnumber.Name = "label_plotnumber"
        Me.label_plotnumber.Size = New System.Drawing.Size(65, 13)
        Me.label_plotnumber.TabIndex = 5
        Me.label_plotnumber.Text = "Plot Number"
        '
        'label_adress
        '
        Me.label_adress.AutoSize = True
        Me.label_adress.Location = New System.Drawing.Point(26, 220)
        Me.label_adress.Name = "label_adress"
        Me.label_adress.Size = New System.Drawing.Size(39, 13)
        Me.label_adress.TabIndex = 4
        Me.label_adress.Text = "Adress"
        '
        'label_mobile
        '
        Me.label_mobile.AutoSize = True
        Me.label_mobile.Location = New System.Drawing.Point(26, 190)
        Me.label_mobile.Name = "label_mobile"
        Me.label_mobile.Size = New System.Drawing.Size(38, 13)
        Me.label_mobile.TabIndex = 3
        Me.label_mobile.Text = "Mobile"
        '
        'label_idnum
        '
        Me.label_idnum.AutoSize = True
        Me.label_idnum.Location = New System.Drawing.Point(26, 161)
        Me.label_idnum.Name = "label_idnum"
        Me.label_idnum.Size = New System.Drawing.Size(58, 13)
        Me.label_idnum.TabIndex = 2
        Me.label_idnum.Text = "ID Number"
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.Location = New System.Drawing.Point(26, 130)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(35, 13)
        Me.label_name.TabIndex = 1
        Me.label_name.Text = "Name"
        '
        'label_member_code
        '
        Me.label_member_code.AutoSize = True
        Me.label_member_code.Location = New System.Drawing.Point(26, 102)
        Me.label_member_code.Name = "label_member_code"
        Me.label_member_code.Size = New System.Drawing.Size(73, 13)
        Me.label_member_code.TabIndex = 0
        Me.label_member_code.Text = "Member Code"
        '
        'group_Kin_Details
        '
        Me.group_Kin_Details.Controls.Add(Me.txt_kinrelation)
        Me.group_Kin_Details.Controls.Add(Me.txt_kincontact)
        Me.group_Kin_Details.Controls.Add(Me.txt_kinname)
        Me.group_Kin_Details.Controls.Add(Me.label_kinrelation)
        Me.group_Kin_Details.Controls.Add(Me.label_kincontact)
        Me.group_Kin_Details.Controls.Add(Me.label_kinname)
        Me.group_Kin_Details.Controls.Add(Me.label_nextkin)
        Me.group_Kin_Details.Location = New System.Drawing.Point(431, 29)
        Me.group_Kin_Details.Name = "group_Kin_Details"
        Me.group_Kin_Details.Size = New System.Drawing.Size(240, 159)
        Me.group_Kin_Details.TabIndex = 1
        Me.group_Kin_Details.TabStop = False
        Me.group_Kin_Details.Text = "Kin Details"
        '
        'txt_kinrelation
        '
        Me.txt_kinrelation.Location = New System.Drawing.Point(133, 120)
        Me.txt_kinrelation.Name = "txt_kinrelation"
        Me.txt_kinrelation.Size = New System.Drawing.Size(100, 20)
        Me.txt_kinrelation.TabIndex = 6
        '
        'txt_kincontact
        '
        Me.txt_kincontact.Location = New System.Drawing.Point(133, 86)
        Me.txt_kincontact.Name = "txt_kincontact"
        Me.txt_kincontact.Size = New System.Drawing.Size(100, 20)
        Me.txt_kincontact.TabIndex = 5
        '
        'txt_kinname
        '
        Me.txt_kinname.Location = New System.Drawing.Point(133, 51)
        Me.txt_kinname.Name = "txt_kinname"
        Me.txt_kinname.Size = New System.Drawing.Size(100, 20)
        Me.txt_kinname.TabIndex = 4
        '
        'label_kinrelation
        '
        Me.label_kinrelation.AutoSize = True
        Me.label_kinrelation.Location = New System.Drawing.Point(70, 123)
        Me.label_kinrelation.Name = "label_kinrelation"
        Me.label_kinrelation.Size = New System.Drawing.Size(64, 13)
        Me.label_kinrelation.TabIndex = 3
        Me.label_kinrelation.Text = "Kin Relation"
        '
        'label_kincontact
        '
        Me.label_kincontact.AutoSize = True
        Me.label_kincontact.Location = New System.Drawing.Point(67, 86)
        Me.label_kincontact.Name = "label_kincontact"
        Me.label_kincontact.Size = New System.Drawing.Size(62, 13)
        Me.label_kincontact.TabIndex = 2
        Me.label_kincontact.Text = "Kin Contact"
        '
        'label_kinname
        '
        Me.label_kinname.AutoSize = True
        Me.label_kinname.Location = New System.Drawing.Point(67, 51)
        Me.label_kinname.Name = "label_kinname"
        Me.label_kinname.Size = New System.Drawing.Size(53, 13)
        Me.label_kinname.TabIndex = 1
        Me.label_kinname.Text = "Kin Name"
        '
        'label_nextkin
        '
        Me.label_nextkin.AutoSize = True
        Me.label_nextkin.Location = New System.Drawing.Point(23, 28)
        Me.label_nextkin.Name = "label_nextkin"
        Me.label_nextkin.Size = New System.Drawing.Size(59, 13)
        Me.label_nextkin.TabIndex = 0
        Me.label_nextkin.Text = "Next of Kin"
        '
        'group_photo
        '
        Me.group_photo.Controls.Add(Me.combo_zone)
        Me.group_photo.Controls.Add(Me.combo_subgroup)
        Me.group_photo.Controls.Add(Me.label_zone)
        Me.group_photo.Controls.Add(Me.Label1)
        Me.group_photo.Location = New System.Drawing.Point(408, 203)
        Me.group_photo.Name = "group_photo"
        Me.group_photo.Size = New System.Drawing.Size(284, 104)
        Me.group_photo.TabIndex = 2
        Me.group_photo.TabStop = False
        '
        'combo_zone
        '
        Me.combo_zone.FormattingEnabled = True
        Me.combo_zone.Items.AddRange(New Object() {"Karima", "Nyeri"})
        Me.combo_zone.Location = New System.Drawing.Point(133, 58)
        Me.combo_zone.Name = "combo_zone"
        Me.combo_zone.Size = New System.Drawing.Size(121, 21)
        Me.combo_zone.TabIndex = 4
        '
        'combo_subgroup
        '
        Me.combo_subgroup.FormattingEnabled = True
        Me.combo_subgroup.Location = New System.Drawing.Point(130, 26)
        Me.combo_subgroup.Name = "combo_subgroup"
        Me.combo_subgroup.Size = New System.Drawing.Size(121, 21)
        Me.combo_subgroup.TabIndex = 69
        '
        'label_zone
        '
        Me.label_zone.AutoSize = True
        Me.label_zone.Location = New System.Drawing.Point(26, 58)
        Me.label_zone.Name = "label_zone"
        Me.label_zone.Size = New System.Drawing.Size(32, 13)
        Me.label_zone.TabIndex = 0
        Me.label_zone.Text = "Zone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Subgroup"
        '
        'label_photo
        '
        Me.label_photo.AutoSize = True
        Me.label_photo.Location = New System.Drawing.Point(746, 259)
        Me.label_photo.Name = "label_photo"
        Me.label_photo.Size = New System.Drawing.Size(35, 13)
        Me.label_photo.TabIndex = 1
        Me.label_photo.Text = "Photo"
        '
        'SB_Main
        '
        Me.SB_Main.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_Main.Location = New System.Drawing.Point(0, 577)
        Me.SB_Main.Name = "SB_Main"
        Me.SB_Main.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.SBP1_Status, Me.SBP2_Today, Me.SBP3_Date, Me.SBP4_Time, Me.server, Me.sbinternet})
        Me.SB_Main.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SB_Main.ShowPanels = True
        Me.SB_Main.Size = New System.Drawing.Size(987, 20)
        Me.SB_Main.TabIndex = 60
        '
        'SBP1_Status
        '
        Me.SBP1_Status.Name = "SBP1_Status"
        Me.SBP1_Status.Text = "Status : "
        Me.SBP1_Status.Width = 400
        '
        'SBP2_Today
        '
        Me.SBP2_Today.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SBP2_Today.Name = "SBP2_Today"
        Me.SBP2_Today.Text = "Today"
        Me.SBP2_Today.Width = 70
        '
        'SBP3_Date
        '
        Me.SBP3_Date.Name = "SBP3_Date"
        Me.SBP3_Date.Width = 70
        '
        'SBP4_Time
        '
        Me.SBP4_Time.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SBP4_Time.Name = "SBP4_Time"
        Me.SBP4_Time.Text = "Time"
        '
        'server
        '
        Me.server.Name = "server"
        Me.server.Text = "Server Connection:"
        Me.server.Width = 200
        '
        'sbinternet
        '
        Me.sbinternet.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.sbinternet.MinWidth = 15
        Me.sbinternet.Name = "sbinternet"
        Me.sbinternet.Text = "Internet"
        Me.sbinternet.Width = 71
        '
        'serverconnection
        '
        Me.serverconnection.AutoSize = True
        Me.serverconnection.Location = New System.Drawing.Point(450, 13)
        Me.serverconnection.Name = "serverconnection"
        Me.serverconnection.Size = New System.Drawing.Size(10, 13)
        Me.serverconnection.TabIndex = 61
        Me.serverconnection.Text = ":"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(805, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Save Member"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picpassport
        '
        Me.picpassport.Location = New System.Drawing.Point(749, 13)
        Me.picpassport.Name = "picpassport"
        Me.picpassport.Size = New System.Drawing.Size(208, 224)
        Me.picpassport.TabIndex = 63
        Me.picpassport.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(805, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 23)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "dbase connector"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(805, 495)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 23)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "CONNECTION TESTER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(805, 466)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 23)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "LOAD USERS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(805, 386)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 23)
        Me.Button5.TabIndex = 70
        Me.Button5.Text = "LOAD MEMBERS VIEW"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbleditmode
        '
        Me.lbleditmode.AutoSize = True
        Me.lbleditmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleditmode.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbleditmode.Location = New System.Drawing.Point(656, 13)
        Me.lbleditmode.Name = "lbleditmode"
        Me.lbleditmode.Size = New System.Drawing.Size(11, 16)
        Me.lbleditmode.TabIndex = 7
        Me.lbleditmode.Text = ":"
        '
        'gbpayment
        '
        Me.gbpayment.Controls.Add(Me.txt_equitel)
        Me.gbpayment.Controls.Add(Me.txt_mpesa)
        Me.gbpayment.Controls.Add(Me.lb_equitel)
        Me.gbpayment.Controls.Add(Me.lb_mpesa)
        Me.gbpayment.Location = New System.Drawing.Point(23, 297)
        Me.gbpayment.Name = "gbpayment"
        Me.gbpayment.Size = New System.Drawing.Size(315, 160)
        Me.gbpayment.TabIndex = 71
        Me.gbpayment.TabStop = False
        Me.gbpayment.Text = "Payment Details"
        '
        'txt_equitel
        '
        Me.txt_equitel.Location = New System.Drawing.Point(155, 69)
        Me.txt_equitel.Name = "txt_equitel"
        Me.txt_equitel.Size = New System.Drawing.Size(100, 20)
        Me.txt_equitel.TabIndex = 3
        '
        'txt_mpesa
        '
        Me.txt_mpesa.Location = New System.Drawing.Point(155, 31)
        Me.txt_mpesa.Name = "txt_mpesa"
        Me.txt_mpesa.Size = New System.Drawing.Size(100, 20)
        Me.txt_mpesa.TabIndex = 2
        '
        'lb_equitel
        '
        Me.lb_equitel.AutoSize = True
        Me.lb_equitel.Location = New System.Drawing.Point(26, 70)
        Me.lb_equitel.Name = "lb_equitel"
        Me.lb_equitel.Size = New System.Drawing.Size(77, 13)
        Me.lb_equitel.TabIndex = 1
        Me.lb_equitel.Text = "Equitel number"
        '
        'lb_mpesa
        '
        Me.lb_mpesa.AutoSize = True
        Me.lb_mpesa.Location = New System.Drawing.Point(26, 34)
        Me.lb_mpesa.Name = "lb_mpesa"
        Me.lb_mpesa.Size = New System.Drawing.Size(92, 13)
        Me.lb_mpesa.TabIndex = 0
        Me.lb_mpesa.Text = "Verified Mpesa no"
        '
        'btn_payments
        '
        Me.btn_payments.Location = New System.Drawing.Point(594, 396)
        Me.btn_payments.Name = "btn_payments"
        Me.btn_payments.Size = New System.Drawing.Size(142, 23)
        Me.btn_payments.TabIndex = 72
        Me.btn_payments.Text = "Load Payments"
        Me.btn_payments.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(594, 425)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 23)
        Me.Button6.TabIndex = 73
        Me.Button6.Text = "Load Bank"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btn_paymethods
        '
        Me.btn_paymethods.Location = New System.Drawing.Point(594, 454)
        Me.btn_paymethods.Name = "btn_paymethods"
        Me.btn_paymethods.Size = New System.Drawing.Size(142, 23)
        Me.btn_paymethods.TabIndex = 74
        Me.btn_paymethods.Text = "Load Paymethods"
        Me.btn_paymethods.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(594, 483)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 23)
        Me.Button7.TabIndex = 75
        Me.Button7.Text = "Load FarmInputs"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(594, 367)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(142, 23)
        Me.Button8.TabIndex = 76
        Me.Button8.Text = "Load FarmInputView"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btn_suppliers
        '
        Me.btn_suppliers.Location = New System.Drawing.Point(596, 512)
        Me.btn_suppliers.Name = "btn_suppliers"
        Me.btn_suppliers.Size = New System.Drawing.Size(140, 23)
        Me.btn_suppliers.TabIndex = 77
        Me.btn_suppliers.Text = "Load Suppliers"
        Me.btn_suppliers.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(594, 542)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(142, 23)
        Me.Button9.TabIndex = 78
        Me.Button9.Text = "Supplies View"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btn_supplies
        '
        Me.btn_supplies.Location = New System.Drawing.Point(805, 299)
        Me.btn_supplies.Name = "btn_supplies"
        Me.btn_supplies.Size = New System.Drawing.Size(139, 23)
        Me.btn_supplies.TabIndex = 79
        Me.btn_supplies.Text = "Load Supplies"
        Me.btn_supplies.UseVisualStyleBackColor = True
        '
        'btn_viewsupplies
        '
        Me.btn_viewsupplies.Location = New System.Drawing.Point(805, 328)
        Me.btn_viewsupplies.Name = "btn_viewsupplies"
        Me.btn_viewsupplies.Size = New System.Drawing.Size(139, 23)
        Me.btn_viewsupplies.TabIndex = 80
        Me.btn_viewsupplies.Text = "View Supplies"
        Me.btn_viewsupplies.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(594, 320)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(149, 23)
        Me.Button10.TabIndex = 81
        Me.Button10.Text = "Load Inovices"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(596, 338)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(147, 23)
        Me.Button11.TabIndex = 82
        Me.Button11.Text = "View Invoices"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'btn_farmproduce
        '
        Me.btn_farmproduce.Location = New System.Drawing.Point(431, 494)
        Me.btn_farmproduce.Name = "btn_farmproduce"
        Me.btn_farmproduce.Size = New System.Drawing.Size(120, 23)
        Me.btn_farmproduce.TabIndex = 83
        Me.btn_farmproduce.Text = "Load Farmproduce"
        Me.btn_farmproduce.UseVisualStyleBackColor = True
        '
        'frm_members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(987, 597)
        Me.Controls.Add(Me.btn_farmproduce)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.btn_viewsupplies)
        Me.Controls.Add(Me.btn_supplies)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.btn_suppliers)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btn_paymethods)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btn_payments)
        Me.Controls.Add(Me.gbpayment)
        Me.Controls.Add(Me.lbleditmode)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.label_photo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.picpassport)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.serverconnection)
        Me.Controls.Add(Me.SB_Main)
        Me.Controls.Add(Me.group_photo)
        Me.Controls.Add(Me.group_Kin_Details)
        Me.Controls.Add(Me.group_details)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_members"
        Me.Text = "s"
        Me.group_details.ResumeLayout(False)
        Me.group_details.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.group_Kin_Details.ResumeLayout(False)
        Me.group_Kin_Details.PerformLayout()
        Me.group_photo.ResumeLayout(False)
        Me.group_photo.PerformLayout()
        CType(Me.SBP1_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBP2_Today, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBP3_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBP4_Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.server, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbinternet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpassport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpayment.ResumeLayout(False)
        Me.gbpayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents group_details As System.Windows.Forms.GroupBox
    Friend WithEvents label_mobile As System.Windows.Forms.Label
    Friend WithEvents label_idnum As System.Windows.Forms.Label
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents label_member_code As System.Windows.Forms.Label
    Friend WithEvents label_plotnumber As System.Windows.Forms.Label
    Friend WithEvents label_adress As System.Windows.Forms.Label
    Friend WithEvents group_Kin_Details As System.Windows.Forms.GroupBox
    Friend WithEvents label_kinrelation As System.Windows.Forms.Label
    Friend WithEvents label_kincontact As System.Windows.Forms.Label
    Friend WithEvents label_kinname As System.Windows.Forms.Label
    Friend WithEvents label_nextkin As System.Windows.Forms.Label
    Friend WithEvents group_photo As System.Windows.Forms.GroupBox
    Friend WithEvents label_photo As System.Windows.Forms.Label
    Friend WithEvents label_zone As System.Windows.Forms.Label
    Friend WithEvents txt_member_plotnum As System.Windows.Forms.TextBox
    Friend WithEvents txt_memberadress As System.Windows.Forms.TextBox
    Friend WithEvents txt_membermobile As System.Windows.Forms.TextBox
    Friend WithEvents txt_memberid As System.Windows.Forms.TextBox
    Friend WithEvents txt_member_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_kinrelation As System.Windows.Forms.TextBox
    Friend WithEvents txt_kincontact As System.Windows.Forms.TextBox
    Friend WithEvents txt_kinname As System.Windows.Forms.TextBox
    Friend WithEvents SB_Main As System.Windows.Forms.StatusBar
    Friend WithEvents SBP1_Status As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SBP2_Today As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SBP3_Date As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SBP4_Time As System.Windows.Forms.StatusBarPanel
    Friend WithEvents server As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbinternet As System.Windows.Forms.StatusBarPanel
    Friend WithEvents serverconnection As System.Windows.Forms.Label
    Friend WithEvents txt_membername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picpassport As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents combo_zone As System.Windows.Forms.ComboBox
    Friend WithEvents combo_subgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cbfarmer As System.Windows.Forms.CheckBox
    Friend WithEvents lbstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbmember As System.Windows.Forms.CheckBox
    Friend WithEvents lbleditmode As System.Windows.Forms.Label
    Friend WithEvents gbpayment As System.Windows.Forms.GroupBox
    Friend WithEvents txt_equitel As System.Windows.Forms.TextBox
    Friend WithEvents txt_mpesa As System.Windows.Forms.TextBox
    Friend WithEvents lb_equitel As System.Windows.Forms.Label
    Friend WithEvents lb_mpesa As System.Windows.Forms.Label
    Friend WithEvents btn_payments As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_paymethods As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btn_suppliers As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btn_supplies As System.Windows.Forms.Button
    Friend WithEvents btn_viewsupplies As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents btn_farmproduce As System.Windows.Forms.Button

End Class
