Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Public Class frmsupplies_view
    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim supplies As String = "SELECT Input_no, Supplier_name,Batch_no FROM tbl_Mic_Supplies "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn

    Sub loadsupplies(Optional ByVal supplies_class As String = "ALL")

        'If txt_name.Text = "Enter Name" Then
        '    MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbo_subgroup.Text = "Select Subgroup" Then
        '    MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
        '    Exit Sub
        'End If




        If supplies_class = "ALL" Then
            Dim inputsstring As String = "SELECT Input_no as[No], Supplier_name as [Name],Batch_no as[Batch]  FROM tbl_Mic_supplies WHERE Input_no='txt_inputno.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "SUPPLIES", dg_supplies)
        End If
        'Added Function
        If supplies_class = "ALL" Then
            Dim inputsstring As String = "SELECT Input_no as[No], Supplier_name as [Name],Batch_no as[Batch]  FROM tbl_Mic_supplies"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "SUPPLIES", dg_supplies)
        End If

        Dim index As Integer = dg_supplies.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dg_supplies, action_button, index, "View Supplies")

    End Sub
    Sub pass_supplies_to_edit()
        Try
            If dg_supplies.CurrentCell.OwningColumn.Name = "View Supplies" Then
                Cursor = Cursors.WaitCursor
                Dim suppliesform As New frm_supplies
                suppliesform.editmode = True
                suppliesform.suppliescode = dg_supplies.CurrentRow.Cells(0).Value
                suppliesform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub
    Private Sub frmsupplies_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dg_supplies_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_supplies.CellContentClick
        pass_supplies_to_edit()
    End Sub

    Private Sub btn_viewsupplies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viewsupplies.Click
        loadsupplies("ALL")
    End Sub
End Class