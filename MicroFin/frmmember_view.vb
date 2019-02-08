Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing


Public Class frmmember_view

    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim members As String = "SELECT Member_name, Mem_id, Mem_subgroup,Mem_zone FROM tbl_Mic_members "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn


    Private Sub frmmember_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' activateinactivate()
        rbname.Checked = True
    End Sub

    Sub loadmembers(Optional ByVal mem_class As String = "ALL")

        If txt_name.Text = "Enter Name" Then
            MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cbo_subgroup.Text = "Select Subgroup" Then
            MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
            Exit Sub
        End If




        If mem_class = "ALL" Then
            Dim memberstring As String = "SELECT Member_code as [Code], Member_name as [Name], Mem_id as [ID], Mem_Mobile as [Mobile], Mem_address as [Address], Mem_subgroup as [Sub Group], Mem_zone as [Zone] FROM tbl_Mic_members WHERE Member_name='txt_name.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(memberstring, "MEMBERS", dgmembers)
        End If
        'Added Function
        If mem_class = "ALL" Then
            Dim memberstring As String = "SELECT Member_code as [Code], Member_name as [Name], Mem_id as [ID], Mem_Mobile as [Mobile], Mem_address as [Address], Mem_subgroup as [Sub Group], Mem_zone as [Zone] FROM tbl_Mic_members"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(memberstring, "MEMBERS", dgmembers)
        End If

        Dim index As Integer = dgmembers.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dgmembers, action_button, index, "View Member")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view_member.Click
        loadmembers("ALL")
    End Sub

    Private Sub rbname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbname.CheckedChanged
        activateinactivate()
    End Sub

    Sub pass_member_to_edit()
        Try
            If dgmembers.CurrentCell.OwningColumn.Name = "View Member" Then
                Cursor = Cursors.WaitCursor
                Dim memberform As New frm_members
                memberform.editmode = True
                memberform.membercode = dgmembers.CurrentRow.Cells(0).Value
                memberform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub

    Sub activateinactivate()
        '
        If rbname.Checked = True Then
            txt_name.Visible = True
            txt_name.Enabled = True
            txt_name.Text = ""
            cbo_subgroup.Text = "Enter Name"
            cbo_subgroup.Visible = False
            ' lbl_name.Text = "Enter Name"
        End If
        If rbsubgroup.Checked = True Then
            txt_name.Visible = False
            txt_name.Enabled = False
            cbo_subgroup.Text = "Select Subgroup"
            cbo_subgroup.Visible = True

            ' lbl_name.Text = "Select Subgroup"
        End If


    End Sub

    Private Sub rbsubgroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsubgroup.CheckedChanged
        activateinactivate()
    End Sub

    Private Sub dgmembers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgmembers.CellClick
        pass_member_to_edit()
    End Sub

  
    Private Sub cbo_subgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_subgroup.SelectedIndexChanged

    End Sub

    Private Sub dgmembers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgmembers.CellContentClick

    End Sub
End Class