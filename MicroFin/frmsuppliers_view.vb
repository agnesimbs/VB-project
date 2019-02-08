Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing



Public Class frmsuppliers_view
    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim suppliers As String = "SELECT Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email FROM tbl_Mic_Suppliers "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn


    Sub loadsuppliers(Optional ByVal suppliers_class As String = "ALL")

        'If txt_name.Text = "Enter Name" Then
        '    MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbo_subgroup.Text = "Select Subgroup" Then
        '    MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
        '    Exit Sub
        'End If




        If suppliers_class = "ALL" Then
            Dim inputsstring As String = "SELECT Supp_id as [Id], Supp_name as [Name], Supp_location as [Location], Supp_phone as [Phone], Supp_acc as [Acc], Supp_email as [Email] FROM tbl_Mic_suppliers WHERE Supp_id='txt_id.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "SUPPLIERS", dg_suppliers)
        End If
        'Added Function
        If suppliers_class = "ALL" Then
            Dim inputsstring As String = "SELECT Supp_id as [Id], Supp_name as [Name], Supp_location as [Location], Supp_phone as [Phone], Supp_acc as [Acc], Supp_email as [Email] FROM tbl_Mic_suppliers"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "SUPPLIERS", dg_suppliers)
        End If

        Dim index As Integer = dg_suppliers.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dg_suppliers, action_button, index, "View Suppliers")

    End Sub
    Sub pass_suppliers_to_edit()
        Try
            If dg_suppliers.CurrentCell.OwningColumn.Name = "View Suppliers" Then
                Cursor = Cursors.WaitCursor
                Dim suppliersform As New frm_suppliers
                suppliersform.editmode = True
                suppliersform.suppliescode = dg_suppliers.CurrentRow.Cells(0).Value
                suppliersform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub
    Private Sub frmsuppliers_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_viewsupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viewsupp.Click
        loadsuppliers("ALL")
    End Sub
    Private Sub dg_farminputs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_suppliers.CellClick
        pass_suppliers_to_edit()
    End Sub
    Private Sub dg_suppliers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_suppliers.CellContentClick

    End Sub
End Class