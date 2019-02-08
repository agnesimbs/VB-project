Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_payments
    Public testednetworkconnector As String=frm_members.testednetworkconnector 

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    'Public editmode As Boolean = False ' checks the value to be processed during execution

    'Public membercode As String

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

    ' 



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

            'If editmode = False Then


            '    If Not IsNothing(Me.picpassport.Image) Then
            '        Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
            '        arrImage = myMs.GetBuffer
            '    Else
            '        arrImage = Nothing
            '    End If

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO tbl_Mic_Payments(Member_code, Bank_code, Account_no,Preferred) VALUES(@Member_code,@Bank_code,@Account_no,@Preferred)"

            cmd.Parameters.Add("@Member_code", SqlDbType.NVarChar).Value = txt_membercode.Text
            cmd.Parameters.Add("@Bank_code", SqlDbType.NVarChar).Value = txt_bankcode.Text
            cmd.Parameters.Add("@Account_no", SqlDbType.NVarChar).Value = txt_accountno.Text
            cmd.Parameters.Add("@Preferred", SqlDbType.NVarChar).Value = cbo_preferred.Text

            'cmd.Parameters.Add("@Mpesa_no", SqlDbType.NVarChar).Value = txt_mpesano.Text
            'cmd.Parameters.Add("@Mpesa_preferred", SqlDbType.NVarChar).Value = ch_mpesapreferred.Text
            'cmd.Parameters.Add("@Bank_preferred", SqlDbType.NVarChar).Value = ch_bankpreferred.Text
           


            cmd.ExecuteNonQuery()

            MsgBox("ADDED Payments", MsgBoxStyle.Information, "mICROfIN")

            'ElseIf editmode = True Then

            'If Not IsNothing(Me.picpassport.Image) Then
            '    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
            '    arrImage = myMs.GetBuffer
            'Else
            'arrImage = Nothing
            'End If

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE  tbl_Mic_Payments SET Member_code=@Mem_code, Bank_code=@Mem_n, Account_no, Mpesa_no,Preferred WHERE Member_code = @Mem_code"


            cmd.Parameters.Add("@Member_code", SqlDbType.NVarChar).Value = txt_membercode.Text
            cmd.Parameters.Add("@Bank_code", SqlDbType.NVarChar).Value = txt_bankcode.Text
            cmd.Parameters.Add("@Account_no", SqlDbType.NVarChar).Value = txt_accountno.Text
            cmd.Parameters.Add("@Preferred", SqlDbType.NVarChar).Value = cbo_preferred.Text
            'cmd.Parameters.Add("@Mpesa_no", SqlDbType.NVarChar).Value = txt_mpesano.Text
            'cmd.Parameters.Add("@Mpesa_preferred", SqlDbType.NVarChar).Value = ch_mpesapreferred.Text
            'cmd.Parameters.Add("@Bank_preferred", SqlDbType.NVarChar).Value = ch_bankpreferred.Text


            cmd.ExecuteNonQuery()

            MsgBox("Member updated successfully", MsgBoxStyle.Information, "MicroFin")

            'End If
            '    Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error creating farmer" & ex.ToString)

            'Finally
            '    conn.Close()

            '    'Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            '    'Schoolparentmdi.editmode = False

            '    Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub



    

    Private Sub frm_payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objconnector As New conn

        objconnector.ShowDialog()

    End Sub

    Private Sub b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        infererclass()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class