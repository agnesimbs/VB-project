Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Public Class frmbank_view
    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim bank As String = "SELECT bank_name, bank_code "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn
    Private Sub frmbank_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub loadbank(Optional ByVal mem_class As String = "ALL")

        'If txt_name.Text = "Enter Name" Then
        '    MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbo_subgroup.Text = "Select Subgroup" Then
        '    MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
        '    Exit Sub
        'End If




        If mem_class = "ALL" Then
            Dim bankstring As String = "SELECT Bank_code as [Code], Bank_name as [Name]" ' WHERE Member_name='txt_name.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(bankstring, "MEMBERS", dg_bank)
        End If
        'Added Function
        If mem_class = "ALL" Then
            Dim memberstring As String = "SELECT Bank_code as [Code], Bank_name as [Name] FROM tbl_Mic_bank"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(memberstring, "BANK", dg_bank)
        End If

        Dim index As Integer = dg_bank.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dg_bank, action_button, index, "View Bank")

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view_member.Click
    '    loadbank("ALL")
    'End Sub

    'Private Sub rbname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbname.CheckedChanged
    '    activateinactivate()
    'End Sub

    'Sub pass_member_to_edit()
    '    Try
    '        If dgmembers.CurrentCell.OwningColumn.Name = "View Member" Then
    '            Cursor = Cursors.WaitCursor
    '            Dim memberform As New frm_members
    '            memberform.editmode = True
    '            memberform.membercode = dgmembers.CurrentRow.Cells(0).Value
    '            memberform.ShowDialog()
    '            Cursor = Cursors.Default
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error passing member identity " & ex.Message)
    '    End Try

    'End Sub
End Class