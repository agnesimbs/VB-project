Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Public Class frminvoices_view
    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim invoices As String = "SELECT  Sales_no, Buyer_id, Product_id, Mobile, Date, Units, User_id, Price FROM tbl_Mic_invoices"

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn
    Sub loadinvoices(Optional ByVal invoices_class As String = "ALL")

        'If txt_name.Text = "Enter Name" Then
        '    MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbo_subgroup.Text = "Select Subgroup" Then
        '    MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
        '    Exit Sub
        'End If




        If invoices_class = "ALL" Then
            Dim inputsstring As String = "SELECT Sales_no as[Salesno], Buyer_id as [BuyerId], Product_id as [ProductId], Mobile as[Mobile], Date as[date], Units as [Units], User_id as [Units], Price as [Price] FROM tbl_Mic_invoices WHERE Sales_no='txt_salesno.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "INVOICES", dg_invoices)
        End If
        'Added Function
        If invoices_class = "ALL" Then
            Dim inputsstring As String = "SELECT Sales_no as[Salesno], Buyer_id as [BuyerId], Product_id as [ProductId], Mobile as[Mobile], Date as[date], Units as [Units], User_id as [Units], Price as [Price] FROM tbl_Mic_invoices"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "INVOICES", dg_invoices)
        End If

        Dim index As Integer = dg_invoices.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dg_invoices, action_button, index, "View Invoices")

    End Sub
    Sub pass_invoices_to_edit()
        Try
            If dg_invoices.CurrentCell.OwningColumn.Name = "View Invoices" Then
                Cursor = Cursors.WaitCursor
                Dim invoicesform As New frm_invoices
                invoicesform.editmode = True
                invoicesform.invoicescode = dg_invoices.CurrentRow.Cells(0).Value
                invoicesform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub
    Private Sub frminvoices_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dg_invoices_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_invoices.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadinvoices("ALL")
    End Sub
    Private Sub dg_invoices_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_invoices.CellClick
        pass_invoices_to_edit()
    End Sub
End Class