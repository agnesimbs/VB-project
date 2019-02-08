Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
'Imports CrystalDecisions.Shared
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Public Class frm_UserView

    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim action_button As New DataGridViewButtonColumn

    Dim users As String = "SELECT MUser_id, Muser_name, user_phone, user_email FROM tbl_Mic_users"

    Dim reptype As String


    Sub colorcodereport(ByVal dggridtocolor As Windows.Forms.DataGridView)
        For Each receiptrow As DataGridViewRow In dggridtocolor.Rows

            If IsDBNull(receiptrow.Cells("Status").Value) = False Then
                If receiptrow.Cells("Status").Value = "Inactive" Then
                    receiptrow.DefaultCellStyle.BackColor = Color.OrangeRed
                    receiptrow.DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Next

        ' SETS THE SORTMODE FOR THE COLUMNS IN THE GRIDVIEW

        For Each COLUMN As DataGridViewColumn In dggridtocolor.Columns
            COLUMN.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Sub create_controls(ByVal dg As Windows.Forms.DataGridView)

        Dim insertposition As Integer = 0

        If dg.Columns.Contains("Action") = True Then
            dg.Columns.Remove("Action")
        End If

        insertposition = dg.Columns.Count

        action_button.Name = "Action"

        action_button.HeaderText = "Action"

        action_button.Text = "Edit User"

        action_button.UseColumnTextForButtonValue = True

        action_button.FlatStyle = FlatStyle.Flat

        dg.Columns.Insert(insertposition, action_button)

    End Sub

    Sub loadusers(Optional ByVal user_class As String = "ALL")
        Try
            Dim user_string As String = "SELECT MUser_id as [userid], Muser_name as [username], user_phone as [phone], user_email as [email] FROM tbl_Mic_users WHERE MUser_id  = " + "'" + user_class + "'" + ""

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(user_string, "MEMBERS", dg_users)


            Dim index As Integer = dg_users.ColumnCount

            Dim user_mic_functions As New mic_functions

            user_mic_functions.create_button_controls(dg_users, action_button, index, "View User")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GETSTREAMSandROUTES(ByVal cbostreams As Windows.Forms.ComboBox, ByVal cboroutess As Windows.Forms.ComboBox)

        Try
            '        routecost.Clear()

            '        Dim streamgetter As String = "SELECT distinct stream_name as [STREAM] from streams "
            '        Dim routegetter As String = "SELECT route_id, route_name,route_cost  from routes "

            '        cbostreams.Items.Clear()
            '        cboroutess.Items.Clear()
            '        routenameid.Clear()

            '        dbConnect(streamgetter)

            '        con.Open()

            '        insert_DR = com.ExecuteReader

            '        While insert_DR.Read()

            '            Dim NewItem As String

            '            NewItem = insert_DR.GetValue(0).ToString()

            '            cbostreams.Items.Add(NewItem)

            '        End While

            '        'getting the routes now.

            '        ' cboroutess.Items.Add("None")
            '        ' cboroutess.Text = "None"

            '        insert_DR.Close()

            '        con.Close()

            '        dbConnect(routegetter)

            '        con.Open()

            '        insert_DR = com.ExecuteReader

            '        While insert_DR.Read()

            '            Dim Newroute As String
            '            Dim routeid As Integer
            '            Dim rcost As Integer

            '            routeid = insert_DR.GetValue(0).ToString()
            '            Newroute = insert_DR.GetValue(1).ToString()
            '            rcost = insert_DR.GetValue(2).ToString()

            '            'If routenameid.ContainsKey(routeid) = False Then
            '            '    routenameid.Add(routeid, Newroute)
            '            'End If

            '            cboroutess.Items.Add(Newroute)

            '            If routecost.ContainsKey(Newroute) = False Then
            '                routecost.Add(Newroute, rcost)
            '            End If

            '        End While

            '        insert_DR.Close()
            '        con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub


    Private Sub frm_UserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'insert code for combobox
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadusers("ALL")
        
    End Sub



    'Public Sub PRINTREPORTS(ByVal rptdocument As CrystalDecisions.CrystalReports.Engine.ReportDocument)
    '    Dim printsetts As New PrintDialog
    '    printsetts.PrinterSettings = New PrinterSettings()
    '    printsetts.AllowPrintToFile = False
    '    printsetts.AllowSomePages = True
    '    printsetts.UseEXDialog = True
    '    DialogResult = printsetts.ShowDialog()

    '    If DialogResult = DialogResult.OK Then
    '        rptdocument.PrintOptions.PrinterName = printsetts.PrinterSettings.PrinterName
    '        rptdocument.PrintToPrinter(printsetts.PrinterSettings.Copies, False, 0, 0)
    '    End If
    'End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            '    If cbo_user_class.Text = "" Then
            '        MsgBox("Kindly select a class to proceed", MsgBoxStyle.Information)
            '        cbo_user_class.Focus()
            '    End If

            '    Cursor = Cursors.WaitCursor

            '    reptype = "classlist"

            '    fill_bIodata(reptype, cbo_user_class.Text)

            '    Dim yeardate As Integer = CType(Date.Now.Year, String)
            '    Dim classnow As String = cbo_user_class.Text


            '    Dim classlist As New classlist
            '    classlist.Refresh()
            '    classlist.SetDataSource(DSREPORT)

            '    classlist.SetParameterValue("class", classnow)
            '    classlist.SetParameterValue("stream", streamnow)
            '    classlist.SetParameterValue("yeardate", yeardate)
            '    classlist.SetParameterValue("ID", 1)

            '    Dim whattosay As String

            '    If cboreportoptions.Text = "Print Report" Then
            '        'classlist.PrintToPrinter(1, False, 0, 0)
            '        PRINTREPORTS(classlist)
            '        whattosay = "Userlist Printed successfully"
            '        MsgBox(classnow & " " & streamnow & " " & whattosay)
            '    ElseIf cboreportoptions.Text = "Export Report" Then
            '        Dim SFD As New SaveFileDialog()
            '        SFD.FilterIndex = 2
            '        SFD.RestoreDirectory = True
            '        SFD.FileName = classnow & "_" & streamnow & "_" & yeardate & " classlist.pdf"
            '        If SFD.ShowDialog() = DialogResult.OK Then
            '            CType(classlist, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName)
            '        End If
            '        whattosay = "Userlist Exported successfully"
            '        MsgBox(classnow & " " & streamnow & " " & whattosay)
            '    ElseIf cboreportoptions.Text = "View Report" Then
            '        Dim REPORTTSHOW2 As New frmreports
            '        REPORTTSHOW2.CrystalReportViewer1.ReportSource = classlist
            '        REPORTTSHOW2.ShowDialog()
            '    End If

            '    Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dg_users_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_users.CellClick
        pass_user_to_edit()
    End Sub

    Sub pass_user_to_edit()

        If dg_users.CurrentCell.OwningColumn.Name = "View User" Then

            Cursor = Cursors.WaitCursor
            Dim userForm As New Frm_users
            userForm.editmode = True
            userForm.userId = dg_users.CurrentRow.Cells(0).Value
            userForm.ShowDialog()
            Cursor = Cursors.Default
        End If
    End Sub
End Class
