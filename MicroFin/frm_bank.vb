Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading




Public Class frm_bank
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
    Sub load_bank_details(ByVal membercode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim memberdetails As String = " SELECT Member_code, Member_name, Mem_id, Mem_Mobile, Mem_address, Mem_Plot, Mem_kin_name, Mem_kin_contact, Mem_kin_relation, Mem_subgroup, Mem_zone FROM   tbl_Mic_members WHERE Member_code  = " + "'" + membercode + "'"

            'dbConnect(bankdetails) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            'While insert_DR.Read()

            '    txt_member_code.Text = CType(insert_DR.GetValue(0).ToString(), String)
            '    txt_membername.Text = CType(insert_DR.GetValue(1).ToString(), String)
            '    txt_memberid.Text = CType(insert_DR.GetValue(2).ToString(), String)
            '    txt_memberadress.Text = CType(insert_DR.GetValue(3).ToString(), String)
            '    txt_membermobile.Text = CType(insert_DR.GetValue(4).ToString(), String)
            '    txt_member_plotnum.Text = CType(insert_DR.GetValue(5).ToString(), String)
            '    txt_kinname.Text = CType(insert_DR.GetValue(6).ToString(), String)f
            '    txt_kincontact.Text = CType(insert_DR.GetValue(7).ToString(), String)
            '    txt_kinrelation.Text = CType(insert_DR.GetValue(8).ToString(), String)
            '    combo_subgroup.Text = CType(insert_DR.GetValue(9).ToString(), String)
            '    combo_zone.Text = CType(insert_DR.GetValue(10).ToString(), String)

            '    Dim n As Integer = 0

            '    Do While n < 8
            '        combo_subgroup.Items.Add(CType(insert_DR.GetValue(n).ToString(), String))

            '        n = n + 1
            '    Loop

            'End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            MsgBox("Error fetching Member details " & ex.Message)
        End Try

    End Sub
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

            cmd.CommandText = "INSERT INTO tbl_Mic_bank(Bank_code, Bank_name) VALUES(@Bank_code,@Bank_name)"

            cmd.Parameters.Add("@Bank_code", SqlDbType.NVarChar).Value = txt_bankcode.Text
            cmd.Parameters.Add("@Bank_name", SqlDbType.NVarChar).Value = txt_bankname.Text
           

            cmd.ExecuteNonQuery()

            MsgBox("ADDED Bank", MsgBoxStyle.Information, "mICROfIN")

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

            cmd.CommandText = "UPDATE  tbl_Mic_bank SET Bank_code=@Bank_code, Bank_name=@Bank_name, WHERE Bank_code = @Bank_code"


            cmd.Parameters.Add("@Bank_code", SqlDbType.NVarChar).Value = txt_bankcode.Text
            cmd.Parameters.Add("@Bank_name", SqlDbType.NVarChar).Value = txt_bankname.Text
           


            'cmd.ExecuteNonQuery()

            'MsgBox("Member updated successfully", MsgBoxStyle.Information, "MicroFin")

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


    Private Sub frm_bank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If editmode = True Then
        '    load_bank_details(membercode)
        '    'lbleditmode.Text = "Editing Record for: " & membercode
        'ElseIf editmode = False Then
        '    MsgBox("starting")
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        infererclass()
    End Sub
End Class