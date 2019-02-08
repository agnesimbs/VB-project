Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_suppliers

    Public testednetworkconnector As String = frm_members.testednetworkconnector

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False   ' checks the value to be processed during execution

    Public suppliescode As String

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
    Sub load_suppliers_details(ByVal membercode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim suppliers As String = " SELECT Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email FROM tbl_Mic_suppliers  WHERE Supp_id  = " + "'" + suppliescode + "'"

            dbConnect(suppliers) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()

                txt_id.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_sname.Text = CType(insert_DR.GetValue(1).ToString(), String)
                txt_slocation.Text = CType(insert_DR.GetValue(2).ToString(), String)
                txt_sphone.Text = CType(insert_DR.GetValue(3).ToString(), String)
                txt_saccount.Text = CType(insert_DR.GetValue(4).ToString(), String)
                txt_semail.Text = CType(insert_DR.GetValue(5).ToString(), String)



                '    Dim n As Integer = 0

                '    Do While n < 8
                '        combo_subgroup.Items.Add(CType(insert_DR.GetValue(n).ToString(), String))

                '        n = n + 1
                '    Loop
            End While

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
        'Dim bSaveImage As Boolean = False

        Try
            Cursor = Cursors.WaitCursor

            If editmode = False Then

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "INSERT INTO tbl_Mic_suppliers(Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email) VALUES(@Supp_id, @Supp_name, @Supp_location, @Supp_phone, @Supp_acc, @Supp_email)"

                cmd.Parameters.Add("@Supp_id", SqlDbType.NVarChar).Value = txt_id.Text
                cmd.Parameters.Add("@Supp_name", SqlDbType.NVarChar).Value = txt_sname.Text
                cmd.Parameters.Add("@Supp_location", SqlDbType.NVarChar).Value = txt_slocation.Text
                cmd.Parameters.Add("@Supp_phone", SqlDbType.NVarChar).Value = txt_sphone.Text
                cmd.Parameters.Add("@Supp_acc", SqlDbType.NVarChar).Value = txt_saccount.Text
                cmd.Parameters.Add("@Supp_email", SqlDbType.NVarChar).Value = txt_semail.Text


                cmd.ExecuteNonQuery()

                MsgBox("ADDED Suppliers", MsgBoxStyle.Information, "mICROfIN")
            ElseIf editmode = True Then

                'If Not IsNothing(Me.picpassport.Image) Then
                '    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
                '    arrImage = myMs.GetBuffer
                'Else
                '    arrImage = Nothing
                'End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "UPDATE  tbl_Mic_suppliers SET Supp_id=@Supp_id, Supp_name=@Supp_name, Supp_location=@Supp_location, Supp_phone=@Supp_phone, Supp_acc=@Supp_acc,Supp_email=@Supp_email WHERE Supp_id=@Supp_id"


                cmd.Parameters.Add("@Supp_id", SqlDbType.NVarChar).Value = txt_id.Text
                cmd.Parameters.Add("@Supp_name", SqlDbType.NVarChar).Value = txt_sname.Text
                cmd.Parameters.Add("@Supp_location", SqlDbType.NVarChar).Value = txt_slocation.Text
                cmd.Parameters.Add("@Supp_phone", SqlDbType.NVarChar).Value = txt_sphone.Text
                cmd.Parameters.Add("@Supp_acc", SqlDbType.NVarChar).Value = txt_saccount.Text
                cmd.Parameters.Add("@Supp_email", SqlDbType.NVarChar).Value = txt_semail.Text



                cmd.ExecuteNonQuery()

                MsgBox("Supplier updated successfully", MsgBoxStyle.Information, "MicroFin")

            End If
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
    Private Sub frm_suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        testednetworkconnector = frm_members.testednetworkconnector

        If editmode = True Then
            load_suppliers_details(suppliescode)
            'lbleditmode.Text = "Editing Record for: " & inputcode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        infererclass()

    End Sub
End Class