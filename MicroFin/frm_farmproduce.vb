Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading


Public Class frm_farmproduce
    Public testednetworkconnector As String = frm_members.testednetworkconnector

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False   ' checks the value to be processed during execution

    Public invoicescode As String

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader
    Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub
    Private Sub frm_farmproduce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class