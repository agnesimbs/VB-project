Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frmSubjects

    Dim constr As String = Schoolparentmdi.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Dim DS As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim comstrfam As String = "select family_code as [Family code],family_name as [Family Name] from family_register"

    Dim family As String = "SELECT distinct Family_name from family_register"

    Dim subjects As String = "SELECT Subject_code as [Subject Code], Subject_name  as [Subject Name], compulsory as [Compulsory]  FROM tblsubjects"

    Public sub_code As String

    Public sub_family As String

    Dim totsub As Integer = 0

    Dim subject As String
    Private Sub frmSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor

            familycollector(family, cbofamily)

            fill_dgrid_view(comstrfam, "family_register", dgridfamilies)

            fill_dgrid_view(subjects, "tblsubjects", dgridsubjects)

            Cursor = Cursors.Default

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub fill_dgrid_view(ByVal comstr As String, ByVal datatable As String, ByVal dgrid As Windows.Forms.DataGridView)

        Dim da As New SqlDataAdapter(comstr, constr)

        Dim ds As New DataSet

        Dim cmb As New SqlCommandBuilder(da)

        da.Fill(ds, datatable)

        dgrid.DataSource = ds.Tables(datatable)

    End Sub

    Public Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(constr)

        com = New SqlCommand(comstr, con)

    End Sub
    Sub codegenerator(ByVal dbaseconnection As String, ByVal stringtouse As String, ByVal boxenter As System.Windows.Forms.TextBox, ByVal cutaddno As Boolean)

        If cutaddno = True Then

            Dim r0, rf As String

            dbConnect(dbaseconnection)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read

                r0 = insert_DR(0)

            End While

            con.Close()

            rf = r0 + 1

            insert_DR.Close()
            If stringtouse <> "" Then
                boxenter.Text = stringtouse.Substring(0, 3) + "-" + rf
            End If
        ElseIf cutaddno = False Then

            If stringtouse.Length >= 3 Then
                boxenter.Text = stringtouse.Substring(0, 3)
            End If

        End If
    End Sub


    Public Sub familycollector(ByVal dbaseconnection As String, ByVal boxenter As System.Windows.Forms.ComboBox)

        boxenter.Items.Clear()
        dbConnect(dbaseconnection)
        con.Open()
        insert_DR = com.ExecuteReader
        While insert_DR.Read()
            Dim NewItem As String
            NewItem = insert_DR.GetValue(0).ToString()
            boxenter.Items.Add(NewItem)
        End While
        insert_DR.Close()
        con.Close()

    End Sub

    Public Sub subjectcounter()

        Dim dbaseconnection As String = "SELECT COUNT(*) FROM TBLSUBJECTS"

        dbConnect(dbaseconnection)

        con.Open()

        insert_DR = com.ExecuteReader

        While insert_DR.Read()

            Dim NewItem As String

            NewItem = insert_DR.GetValue(0).ToString()

            totsub = NewItem + 1

            subject = "SUB" + CType(totsub, String)

        End While

        insert_DR.Close()

        con.Close()

    End Sub



    Private Sub txtfname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfname.Click
        txtfname.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False


        Try
            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO family_register(family_name,family_code) VALUES(@fname,@fcode)"

            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = Me.txtfname.Text
            cmd.Parameters.Add("@fcode", SqlDbType.NVarChar).Value = Me.txtfcode.Text

            cmd.ExecuteNonQuery()

            MsgBox("Subject Family Added", MsgBoxStyle.Information, "Schools Systems")


            Me.DataTablefamilyregister.fill(Me.SchooldbaseDataSet.familyregister)

            fill_dgrid_view(comstrfam, "family_register", dgridfamilies)

            familycollector(family, cbofamily)

            txtfname.Text = "Enter family name"

            txtfcode.Text = ""

        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

            conn.Close()

        End Try

    End Sub

    Sub addto_marksheet(ByVal subname As String)

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand

        Try
                  conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "ALTER TABLE stdmark_sheet ADD " + subname + "  nvarchar(50)"

            cmd.ExecuteNonQuery()

            frmmarksheet.cbosubject.Items.Add(subname)

            MsgBox("Subject Added to marksheet", MsgBoxStyle.Information, "Schools Systems")


        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

            conn.Close()

        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand

        Try
            subjectcounter()

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO tblsubjects(subject_code,subcode,subject_name,subject_family,compulsory) VALUES(@scode,@subject,@sname,@sfamily,@compuls)"

            cmd.Parameters.Add("@scode", SqlDbType.NVarChar).Value = Me.txtsubjectcode.Text
            cmd.Parameters.Add("@subject", SqlDbType.NChar).Value = subject
            cmd.Parameters.Add("@sname", SqlDbType.NVarChar).Value = Me.txtsubject.Text
            cmd.Parameters.Add("@sfamily", SqlDbType.NVarChar).Value = Me.cbofamily.Text
            cmd.Parameters.Add("@compuls", SqlDbType.Bit).Value = Me.chkcompulsory.Checked

            cmd.ExecuteNonQuery()

            'addto_marksheet(txtsubject.Text)

            fill_dgrid_view(subjects, "tblsubjects", dgridsubjects)

            MsgBox("Subject Created and Intergrated to system.", MsgBoxStyle.Information, "Schools Systems")

        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

            conn.Close()

        End Try



    End Sub

    Private Sub cbofamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofamily.SelectedIndexChanged
        codegenerator("SELECT COUNT (*) FROM tblsubjects where subject_family=" + "'" + cbofamily.Text + "'" + "", cbofamily.Text, txtsubjectcode, True)
    End Sub

    Private Sub txtsubject_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubject.Click
        txtsubject.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DataTablefamilyregister.fill(Me.SchooldbaseDataSet.familyregister)
    End Sub

    Private Sub cbofamily_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbofamily.TextChanged
        codegenerator("SELECT COUNT (*) FROM tblsubjects where subject_family=" + "'" + cbofamily.Text + "'" + "", cbofamily.Text, txtsubjectcode, True)
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged
        codegenerator("", txtfname.Text, txtfcode, False)
    End Sub

    Private Sub frmSubjects_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class