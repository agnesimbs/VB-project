
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing

Public Class frm_memberview

    Dim constr As String = Schoolparentmdi.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet1

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim students As String = "SELECT Admission_no, First_name, Middle_name, last_name, Gender FROM students"

    Dim reptype As String

#Region "functions"

    Sub activateinactivate()
        If rbadmission_no.Checked = False Then
            txtadmission_no.Enabled = False
            txtadmission_no.Text = ""
        ElseIf rbadmission_no.Checked = True Then
            txtadmission_no.Enabled = True
        End If


        If rbclass.Checked = False Then
            cboform.Text = ""
            cboform.Enabled = False
            cbostream.Text = ""
            cbostream.Enabled = False

        ElseIf rbclass.Checked = True Then
            cboform.Enabled = True
            cbostream.Enabled = True
        End If

    End Sub
    Public Sub fill_reg_data(ByVal reg_no As String)

        Try
            Dim cn As SqlConnection = New SqlConnection(constr)
            cn.Open()

            '   DA = New SqlDataAdapter("SELECT Admission_no, Stud_name, Bcert_no, DOB, Gender, Religion, Admin_Date, School_status, Year_now, Class_now, stream_now, student_photo, Student_type, Route_id, rcost, lunch_include FROM  students WHERE Admission_no = " + "'" + reg_no + "'" + "", cn)
            DA = New SqlDataAdapter("SELECT dbo.students.Admission_no, dbo.students.Stud_name, dbo.students.Bcert_no, dbo.students.DOB, dbo.students.Gender, dbo.students.Religion, dbo.students.Admin_Date, dbo.students.School_status, dbo.students.Year_now, dbo.students.Class_now, dbo.students.stream_now, dbo.students.student_photo, dbo.students.invoiced, dbo.students.Student_type,dbo.students.marked, dbo.students.Route_id, dbo.students.rcost, dbo.guardians.First_name, dbo.guardians.mothers_name, dbo.guardians.Relation, dbo.guardians.occupation,dbo.guardians.mothers_occupation, dbo.guardians.mobile_no, dbo.guardians.mothers_mobile_no, dbo.guardians.Postal_box, dbo.guardians.postal_code, dbo.guardians.Town, dbo.guardians.email,dbo.guardians.regdate, dbo.guardians.parental_status, dbo.Medical_info.Medical_condition, dbo.Medical_info.condition_description, dbo.Medical_info.physical_impairment,dbo.Medical_info.Impairment_description, dbo.tbl_academicinfo.kcpe_index, dbo.tbl_academicinfo.kcpe_mark, dbo.tbl_academicinfo.previus_school, dbo.tbl_academicinfo.kcpe_year FROM  dbo.Medical_info INNER JOIN dbo.guardians ON dbo.Medical_info.Admission_no = dbo.guardians.Admission_no INNER JOIN dbo.tbl_academicinfo ON dbo.Medical_info.Admission_no = dbo.tbl_academicinfo.admission_no RIGHT OUTER JOIN  dbo.students ON dbo.guardians.Admission_no = dbo.students.Admission_no WHERE dbo.students.Admission_no = " + "'" + reg_no + "'" + "", cn)

            DA.Fill(DSREPORT.stud_reg_report)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub fill_guardianinfo(ByVal reg_no As String)
        Try
            Dim cn As SqlConnection = New SqlConnection(constr)
            cn.Open()
            DA = New SqlDataAdapter("SELECT nameid, Admission_no, First_name, mothers_name, Relation, occupation, mothers_occupation, mobile_no, mothers_mobile_no, Postal_box, postal_code, Town, email, regdate,parental_status FROM guardians WHERE Admission_no = " + "'" + reg_no + "'" + "", cn)
            DA.Fill(DSREPORT.guardian_report)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub fill_medicalreport(ByVal reg_no As String)
        Try
            Dim cn As SqlConnection = New SqlConnection(constr)
            cn.Open()
            DA = New SqlDataAdapter("SELECT Admission_no, Medical_condition, condition_description, physical_impairment, Impairment_description, date_recorded FROM Medical_info WHERE Admission_no = " + "'" + reg_no + "'" + "", cn)
            DA.Fill(DSREPORT.medical_report)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub fill_academicinfo(ByVal reg_no As String)

        Try
            Dim cn As SqlConnection = New SqlConnection(constr)
            cn.Open()
            DA = New SqlDataAdapter("SELECT admission_no, kcpe_index, kcpe_mark, previus_school, kcpe_year FROM tbl_academicinfo WHERE Admission_no = " + "'" + reg_no + "'" + "", cn)
            DA.Fill(DSREPORT.academic_info)
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub fillschooldetails()

        Try
            Dim cn As SqlConnection = New SqlConnection(constr)
            cn.Open()

            DA = New SqlDataAdapter(" SELECT id,school_name,school_logo,school_box,school_moto FROM school_details", cn)

            DA.Fill(DSREPORT.School_details)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub fill_bIodata(ByVal reporttype As String, ByVal classform As String, ByVal streamclass As String)

        Try
            Dim cn As SqlConnection = New SqlConnection(constr)

            cn.Open()

            If reporttype = "photoreg" Then

                DA = New SqlDataAdapter(" Select Admission_no, stud_name, Year_now, Class_now, stream_now, student_photo FROM students WHERE Class_now = " + "'" + classform + "'" + " and stream_now = " + "'" + streamclass + "'" + " ORDER BY Admission_no Asc", cn)
                DA.Fill(DSREPORT.biodata)

            ElseIf reporttype = "classlist" Then

                ' DA = New SqlDataAdapter("SELECT students.Admission_no, students.Stud_name, students.Year_now, students.Class_now, students.stream_now, guardians.mobile_no FROM  students INNER JOIN guardians ON students.Admission_no = guardians.Admission_no WHERE  students.Class_now = " + "'" + classform + "'" + " and students.stream_now = " + "'" + streamclass + "'" + " ORDER BY students.Admission_no Asc", cn)
                DA = New SqlDataAdapter(" Select Admission_no, stud_name, Year_now, Class_now, stream_now, mobile_no FROM students_mobile_view WHERE  Class_now = " + "'" + classform + "'" + " and stream_now = " + "'" + streamclass + "'" + " ORDER BY Admission_no Asc", cn)
                DA.Fill(DSREPORT.biodata)

            End If

            DA = New SqlDataAdapter(" SELECT id,school_name,school_logo,school_box,school_moto FROM school_details", cn)

            DA.Fill(DSREPORT.School_details)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

    Private Sub rbclass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbclass.CheckedChanged

        activateinactivate()

    End Sub

    Private Sub rbadmission_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbadmission_no.CheckedChanged
        activateinactivate()
    End Sub

    Private Sub frmstudentview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        activateinactivate()
        frmregister.GETSTREAMS(cbostream)
    End Sub

    Sub colorcodereport()
        'GIVES THE COLOR CODES FOR BALANCE AND THE REQUIRED COLUMN

        For Each receiptrow As DataGridViewRow In dgstudents.Rows

            If IsDBNull(receiptrow.Cells("Status").Value) = False Then
                If receiptrow.Cells("Status").Value = "Inactive" Then
                    receiptrow.DefaultCellStyle.BackColor = Color.OrangeRed
                    receiptrow.DefaultCellStyle.ForeColor = Color.White
                End If
            End If

        Next

        ' SETS THE SORTMODE FOR THE COLUMNS IN THE GRIDVIEW

        For Each COLUMN As DataGridViewColumn In dgstudents.Columns
            COLUMN.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Sub create_controls(ByVal dg As Windows.Forms.DataGridView)

        Dim insertposition As Integer = 0

        If dg.Columns.Contains("Action") = True Then
            dg.Columns.Remove("Action")
        End If

        insertposition = dg.Columns.Count

        actions.Name = "Action"

        actions.HeaderText = "Action"

        actions.Text = "Edit Student"

        actions.UseColumnTextForButtonValue = True

        actions.FlatStyle = FlatStyle.Flat

        dg.Columns.Insert(insertposition, actions)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim CURRYEAR As String = Date.Now.Year

        Dim students As String

        If rbclass.Checked = True Then

            If cbostream.Text <> "" And cboform.Text <> "" Then
                students = "SELECT Admission_no as [Admission No], Stud_name as [Student Name], Gender as [Gender],class_now as [Class],stream_now as [Stream],student_type as [Student Type], school_status as [Status] FROM students WHERE Class_now = " + "'" + cboform.Text + "'" + " and year_now = " + CURRYEAR + " and stream_now= " + "'" + cbostream.Text + "'" + " ORDER BY Admission_no ASC"
            ElseIf cbostream.Text = "" And cboform.Text <> "" Then
                students = "SELECT Admission_no as [Admission No], Stud_name as [Student Name], Gender as [Gender],class_now as [Class],stream_now as [Stream],student_type as [Student Type], school_status as [Status] FROM students WHERE Class_now = " + "'" + cboform.Text + "'" + " and year_now = " + CURRYEAR + " ORDER BY  Admission_no ASC "
            End If

        ElseIf rbadmission_no.Checked = True And txtadmission_no.Text <> "" Then

            students = "SELECT Admission_no as [Admission No],Stud_name as [Student Name], Gender as [Gender], class_now as [Class],stream_now as [Stream] ,student_type as [Student Type], school_status as [Status] FROM students WHERE admission_no= " + "'" + txtadmission_no.Text + "'"
        ElseIf rbclass.Checked = True And cboform.Text = "" Then

            MsgBox("Kindly select the class to continue.")
            Return

        ElseIf rbadmission_no.Checked = True And txtadmission_no.Text = "" Then

            MsgBox("Kindly fill in the admission number to continue.")
            Return

        End If

        frmSubjects.fill_dgrid_view(students, "students", dgstudents)

        create_controls(dgstudents)

        colorcodereport()

    End Sub

    Private Sub dgstudents_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstudents.CellContentClick
        If dgstudents.CurrentCell.OwningColumn.Name = "Action" Then

            Cursor = Cursors.WaitCursor
            Dim frmMembers As New frmregistrationholder
            frmMembers.txtadmission.Text = dgstudents.CurrentRow.Cells(0).Value
            frmMembers.editmode = True
            Schoolparentmdi.Loadform(frmMembers)
            Cursor = Cursors.Default

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            If cbostream.Text = "" Then
                MsgBox("Kindly select a stream to proceed", MsgBoxStyle.Information)
                cbostream.Focus()
            End If

            Cursor = Cursors.WaitCursor

            reptype = "classlist"

            fill_bIodata(reptype, cboform.Text, cbostream.Text)

            Dim yeardate As Integer = CType(Date.Now.Year, String)
            Dim classnow As String = cboform.Text
            Dim streamnow As String = cbostream.Text


            Dim classlist As New classlist
            classlist.Refresh()
            classlist.SetDataSource(DSREPORT)

            classlist.SetParameterValue("class", classnow)
            classlist.SetParameterValue("stream", streamnow)
            classlist.SetParameterValue("yeardate", yeardate)
            classlist.SetParameterValue("ID", 1)

            Dim whattosay As String

            If cboreportoptions.Text = "Print Report" Then
                'classlist.PrintToPrinter(1, False, 0, 0)
                PRINTREPORTS(classlist)
                whattosay = "Classlist Printed successfully"
                MsgBox(classnow & " " & streamnow & " " & whattosay)
            ElseIf cboreportoptions.Text = "Export Report" Then
                Dim SFD As New SaveFileDialog()
                SFD.FilterIndex = 2
                SFD.RestoreDirectory = True
                SFD.FileName = classnow & "_" & streamnow & "_" & yeardate & " classlist.pdf"
                If SFD.ShowDialog() = DialogResult.OK Then
                    CType(classlist, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName)
                End If
                whattosay = "Classlist Exported successfully"
                MsgBox(classnow & " " & streamnow & " " & whattosay)
            ElseIf cboreportoptions.Text = "View Report" Then
                Dim REPORTTSHOW2 As New frmreports
                REPORTTSHOW2.CrystalReportViewer1.ReportSource = classlist
                REPORTTSHOW2.ShowDialog()
            End If

            Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Sub PRINTREPORTS(ByVal rptdocument As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim printsetts As New PrintDialog
        printsetts.PrinterSettings = New PrinterSettings()
        printsetts.AllowPrintToFile = False
        printsetts.AllowSomePages = True
        printsetts.UseEXDialog = True
        DialogResult = printsetts.ShowDialog()

        If DialogResult = DialogResult.OK Then
            rptdocument.PrintOptions.PrinterName = printsetts.PrinterSettings.PrinterName
            rptdocument.PrintToPrinter(printsetts.PrinterSettings.Copies, False, 0, 0)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try

            Cursor = Cursors.WaitCursor
            reptype = "photoreg"
            fill_bIodata(reptype, cboform.Text, cbostream.Text)
            Dim yeardate As Integer = CType(Date.Now.Year, String)
            Dim classnow As String = cboform.Text
            Dim streamnow As String = cbostream.Text
            Dim classlist As New photoregister
            classlist.Refresh()
            classlist.SetDataSource(DSREPORT)

            classlist.SetParameterValue("FORM", classnow)
            classlist.SetParameterValue("STREAM", streamnow)
            classlist.SetParameterValue("REGYEAR", yeardate)
            ' classlist.SetParameterValue("ID", 1)

            Dim whattosay As String

            If cboreportoptions.Text = "Print Report" Then

                classlist.PrintToPrinter(1, False, 0, 0)
                whattosay = "Classlist Printed successfully"
                MsgBox(classnow & " " & streamnow & " " & whattosay)

            ElseIf cboreportoptions.Text = "Export Report" Then

                Dim SFD As New SaveFileDialog()
                SFD.FilterIndex = 2
                SFD.RestoreDirectory = True
                SFD.FileName = classnow & "_" & streamnow & "_" & yeardate & " classlist.pdf"
                If SFD.ShowDialog() = DialogResult.OK Then
                    CType(classlist, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName)
                End If
                whattosay = "Photo register Exported successfully"
                MsgBox(classnow & " " & streamnow & " " & whattosay)

            ElseIf cboreportoptions.Text = "View Report" Then

                Dim REPORTTSHOW2 As New frmreports
                REPORTTSHOW2.CrystalReportViewer1.ReportSource = classlist
                REPORTTSHOW2.ShowDialog()

            End If

            MsgBox(classnow & " " & streamnow & " " & whattosay)
            Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Report Error " & ex.Message)
        End Try

    End Sub

    Private Sub cboform_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboform.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class