Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing




Public Class frmfarminputs_view
    Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim inputs As String = "SELECT Input_no, Input_name, Batch,Units FROM tbl_Mic_farminputs "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn

    Private Sub frmfarminputs_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub loadinputs(Optional ByVal input_class As String = "ALL")

        'If txt_name.Text = "Enter Name" Then
        '    MsgBox("Kindly input a valid  Name", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If cbo_subgroup.Text = "Select Subgroup" Then
        '    MsgBox("Kindly input a valid  Subgroup", MsgBoxStyle.Information)
        '    Exit Sub
        'End If




        If input_class = "ALL" Then
            Dim inputsstring As String = "SELECT Input_no as [No], Input_name as [Name], Batch as [Batch], Units as [Units], Stock_input as [Stock], Unit_price as [Unit price], Date as [Date],Seed_input as[Seed input], Locked as[Locked] FROM tbl_Mic_farminputs WHERE Input_no='txt_inputno.TXT'"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "INPUTS", dg_farminputs)
        End If
        'Added Function
        If input_class = "ALL" Then
            Dim inputsstring As String = "SELECT Input_no as [No], Input_name as [Name], Batch as [Batch], Units as [Units], Stock_input as [Stock], Unit_price as [Unit price], Date as [Date],Seed_input as[Seed input], Locked as[Locked] FROM tbl_Mic_farminputs"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(inputsstring, "INPUTS", dg_farminputs)
        End If

        Dim index As Integer = dg_farminputs.ColumnCount
        Dim mic_functions As New mic_functions

        mic_functions.create_button_controls(dg_farminputs, action_button, index, "View Inputs")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadinputs("ALL")
    End Sub

    Sub pass_member_to_edit()
        Try
            If dg_farminputs.CurrentCell.OwningColumn.Name = "View Inputs" Then
                Cursor = Cursors.WaitCursor
                Dim inputsform As New frm_farminputs
                inputsform.editmode = True
                inputsform.inputcode = dg_farminputs.CurrentRow.Cells(0).Value
                inputsform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub

    Private Sub dg_farminputs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_farminputs.CellClick
        pass_member_to_edit()
    End Sub
    Private Sub dg_farminputs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_farminputs.CellContentClick

    End Sub
End Class