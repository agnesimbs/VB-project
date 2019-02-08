Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading




Public Class frm_paymethods


    Public testednetworkconnector As String = frm_members.testednetworkconnector

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = True  ' checks the value to be processed during execution

    'Public membercode As String

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

   
    Sub infererclass()

        Dim conn As New SqlConnection
        Dim sConnString As String = testednetworkconnector
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        'Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False

        Try
            Cursor = Cursors.WaitCursor


            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO tbl_Mic_paymethods(Member_code, Mpesa_no, Equitel_no, Equity_acc, Coop_acc) VALUES(@Member_code, @Mpesa_no, @Equitel_no, @Equity_acc, @Coop_acc)"

            cmd.Parameters.Add("@Member_code", SqlDbType.NVarChar).Value = txt_membercode.Text
            cmd.Parameters.Add("@Mpesa_no", SqlDbType.NVarChar).Value = txt_mpesano.Text
            cmd.Parameters.Add("@Equitel_no", SqlDbType.NVarChar).Value = txt_equitelno.Text
            cmd.Parameters.Add("@Equity_acc", SqlDbType.NVarChar).Value = txt_equityacc.Text
            cmd.Parameters.Add("@Coop_acc", SqlDbType.NVarChar).Value = txt_coopacc.Text



            cmd.ExecuteNonQuery()

            MsgBox("ADDED Paymethods", MsgBoxStyle.Information, "mICROfIN")

            'ElseIf editmode = True Then

            ''If Not IsNothing(Me.picpassport.Image) Then
            ''    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
            ''    arrImage = myMs.GetBuffer
            ''Else
            ''arrImage = Nothing
            ''End If

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE  tbl_Mic_paymethods SET Member_code=@Member_code, Mpesa_no=@Mpesa_no, Equitel_no=@EQUITEL_no, Equity_acc=@Equity_acc, Coop_acc=@Coop_acc"

            cmd.Parameters.Add("@Member_code", SqlDbType.NVarChar).Value = txt_membercode.Text
            cmd.Parameters.Add("@Mpesa_no", SqlDbType.NVarChar).Value = txt_mpesano.Text
            cmd.Parameters.Add("@Equitel_no", SqlDbType.NVarChar).Value = txt_equitelno.Text
            cmd.Parameters.Add("@Equity_acc", SqlDbType.NVarChar).Value = txt_equityacc.Text
            cmd.Parameters.Add("@Coop_acc", SqlDbType.NVarChar).Value = txt_coopacc.Text


            ' cmd.ExecuteNonQuery()

            MsgBox("Member updated successfully", MsgBoxStyle.Information, "MicroFin")

            'End If
            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error creating farmer" & ex.ToString)

        Finally
            conn.Close()

            'Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            'Schoolparentmdi.editmode = False

            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub
    Private Sub frm_paymethods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_paymethods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paymethods.Click
        infererclass()
    End Sub
End Class