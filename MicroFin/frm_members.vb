Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_members

    Public testednetworkconnector As String

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False ' checks the value to be processed during execution

    Public membercode As String

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

 
    Sub initialnetworktester()

        Try
            conn.setconnector()

            Dim retrievedconnector As String = conn.serverconstring

            Using sqlconnector As New SqlConnection(retrievedconnector)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then

                    With serverconnection
                        .Text = "Server Connected"
                        .ForeColor = Color.DarkGreen
                    End With

                    server.Text = "Server Connected"
                    conncheck = True
                    testednetworkconnector = retrievedconnector

                Else
                    conncheck = False

                    With serverconnection
                        .Text = "Server Not Connected"
                        .ForeColor = Color.Red
                    End With
                    server.Text = "Server Not Connected"
                End If

            End Using

        Catch ex As Exception
            conncheck = False
            server.Text = "Server Not Connected"
            serverconnection.Text = "Server Not Connected"
        Finally
            sqlconnector.Close()
        End Try

    End Sub
    Sub set_networkconnection()

        Do While True
            Try
                conn.setconnector()

                Dim retrievedconnector As String

                retrievedconnector = conn.serverconstring

                Using sqlconnector As New SqlConnection(retrievedconnector)

                    sqlconnector.Open()
                    Dim connectionstatestate As String = sqlconnector.State.ToString
                    If connectionstatestate = "Open" Then

                        With serverconnection
                            .Text = "Server Connected"
                            .ForeColor = Color.DarkGreen
                        End With

                        server.Text = "Server Connected"
                        conncheck = True
                        testednetworkconnector = retrievedconnector

                    Else
                        conncheck = False

                        With serverconnection
                            .Text = "Server Not Connected"
                            .ForeColor = Color.Red
                        End With
                        server.Text = "Server Not Connected"
                    End If

                End Using

                Thread.Sleep(900000)

            Catch ex As Exception
                conncheck = False
                server.Text = "Server Not Connected"
                serverconnection.Text = "Server Not Connected"
            Finally
                sqlconnector.Close()
            End Try

        Loop

    End Sub

    Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub

    Sub load_member_details(ByVal membercode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim memberdetails As String = " SELECT Member_code, Member_name, Mem_id, Mem_Mobile, Mem_address, Mem_Plot, Mem_kin_name, Mem_kin_contact, Mem_kin_relation, Mem_subgroup, Mem_zone FROM   tbl_Mic_members WHERE Member_code  = " + "'" + membercode + "'"

            dbConnect(memberdetails) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()

                txt_member_code.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_membername.Text = CType(insert_DR.GetValue(1).ToString(), String)
                txt_memberid.Text = CType(insert_DR.GetValue(2).ToString(), String)
                txt_memberadress.Text = CType(insert_DR.GetValue(3).ToString(), String)
                txt_membermobile.Text = CType(insert_DR.GetValue(4).ToString(), String)
                txt_member_plotnum.Text = CType(insert_DR.GetValue(5).ToString(), String)
                txt_kinname.Text = CType(insert_DR.GetValue(6).ToString(), String)
                txt_kincontact.Text = CType(insert_DR.GetValue(7).ToString(), String)
                txt_kinrelation.Text = CType(insert_DR.GetValue(8).ToString(), String)
                combo_subgroup.Text = CType(insert_DR.GetValue(9).ToString(), String)
                combo_zone.Text = CType(insert_DR.GetValue(10).ToString(), String)
               
                Dim n As Integer = 0

                Do While n < 8
                    combo_subgroup.Items.Add(CType(insert_DR.GetValue(n).ToString(), String))

                    n = n + 1
                Loop

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
        Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False

        Try
            Cursor = Cursors.WaitCursor

            If editmode = False Then


                If Not IsNothing(Me.picpassport.Image) Then
                    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
                    arrImage = myMs.GetBuffer
                Else
                    arrImage = Nothing
                End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "INSERT INTO tbl_Mic_members(Member_code,Member_name,Mem_id,Mem_mobile,Mem_address,Mem_Plot,Mem_kin_name,Mem_kin_contact,Mem_kin_relation,Mem_subgroup,Mem_zone) VALUES(@Member_code,@Member_name,@Mem_id,@Mem_mobile,@Mem_adress,@Mem_Plot,@Mem_kin_name,@Mem_kin_contact,@Mem_kin_relation,@Mem_subgroup,@Mem_zone)"

                cmd.Parameters.Add("@Member_code", SqlDbType.NVarChar).Value = txt_member_code.Text
                cmd.Parameters.Add("@Member_name", SqlDbType.NVarChar).Value = txt_membername.Text
                cmd.Parameters.Add("@Mem_id", SqlDbType.NVarChar).Value = txt_memberid.Text
                cmd.Parameters.Add("@Mem_mobile", SqlDbType.NVarChar).Value = txt_membermobile.Text
                cmd.Parameters.Add("@Mem_adress", SqlDbType.NVarChar).Value = txt_memberadress.Text
                cmd.Parameters.Add("@Mem_Plot", SqlDbType.NVarChar).Value = txt_member_plotnum.Text
                cmd.Parameters.Add("@Mem_kin_name", SqlDbType.NVarChar).Value = txt_kinname.Text
                cmd.Parameters.Add("@Mem_kin_contact", SqlDbType.NVarChar).Value = txt_kincontact.Text
                cmd.Parameters.Add("@Mem_kin_relation", SqlDbType.NVarChar).Value = txt_kinrelation.Text
                cmd.Parameters.Add("@Mem_subgroup", SqlDbType.NVarChar).Value = combo_zone.Text
                cmd.Parameters.Add("@Mem_zone", SqlDbType.NVarChar).Value = combo_zone.Text
                ' cmd.Parameters.Add("@Mem_photo", SqlDbType.Image).Value = arrImage

                

                cmd.ExecuteNonQuery()

                MsgBox("ADDED", MsgBoxStyle.Information, "mICROfIN")

            ElseIf editmode = True Then

                If Not IsNothing(Me.picpassport.Image) Then
                    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
                    arrImage = myMs.GetBuffer
                Else
                    arrImage = Nothing
                End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "UPDATE tbl_Mic_members SET Member_name=@Member_name,Mem_id=@Mem_id,Mem_mobile=@Mem_mobile, Mem_address=@Mem_adress,Mem_kin_contact=@Mem_kin_contact, Mem_kin_relation=@Mem_kin_relation,Mem_kin_name=@Mem_kin_name,Mem_subgroup=@Mem_subgroup, Mem_zone=@Mem_zone WHERE Member_code = @Mem_code"


                cmd.Parameters.Add("@Mem_code", SqlDbType.NVarChar).Value = txt_member_code.Text
                cmd.Parameters.Add("@Member_name", SqlDbType.NVarChar).Value = txt_membername.Text
                cmd.Parameters.Add("@Mem_id", SqlDbType.NVarChar).Value = txt_memberid.Text
                cmd.Parameters.Add("@Mem_mobile", SqlDbType.NVarChar).Value = txt_membermobile.Text
                cmd.Parameters.Add("@Mem_adress", SqlDbType.NVarChar).Value = txt_memberadress.Text
                cmd.Parameters.Add("@Mem_kin_contact", SqlDbType.NVarChar).Value = txt_kincontact.Text
                cmd.Parameters.Add("@Mem_kin_relation", SqlDbType.NVarChar).Value = txt_kinrelation.Text
                cmd.Parameters.Add("@Mem_kin_name", SqlDbType.NVarChar).Value = txt_kinname.Text
                cmd.Parameters.Add("@Mem_subgroup", SqlDbType.NVarChar).Value = combo_subgroup.Text
                cmd.Parameters.Add("@Mem_zone", SqlDbType.NVarChar).Value = combo_zone.Text
                'cmd.Parameters.Add("@Mem_photo", SqlDbType.Image).Value = arrImage

                cmd.ExecuteNonQuery()

                MsgBox("Member updated successfully", MsgBoxStyle.Information, "MicroFin")

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        infererclass()
    End Sub

    Private Sub frm_members_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialnetworktester()

        If editmode = True Then
            load_member_details(membercode)
            lbleditmode.Text = "Editing Record for: " & membercode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objconnector As New conn

        objconnector.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        initialnetworktester()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objconnector As New frm_User_view
        objconnector.ShowDialog()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim objfrmmember_view As New frmmember_view

        objfrmmember_view.ShowDialog()
    End Sub

    Private Sub group_photo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_photo.Enter

    End Sub

    Private Sub combo_subgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_subgroup.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbpayment.Enter

    End Sub

    Private Sub txt_member_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_member_code.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payments.Click
        Dim objconnector As New frm_payments
        objconnector.ShowDialog()

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim objconnector As New frm_bank
        objconnector.ShowDialog()

    End Sub

    Private Sub btn_paymethods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paymethods.Click
        Dim objconnector As New frm_paymethods
        objconnector.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim objconnector As New frm_farminputs
        objconnector.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim objconnector As New frmfarminputs_view
        objconnector.ShowDialog()
    End Sub

    Private Sub group_Kin_Details_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group_Kin_Details.Enter

    End Sub

    Private Sub btn_supplies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_suppliers.Click
        Dim objconnector As New frm_suppliers
        objconnector.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim objconnector As New frmsuppliers_view
        objconnector.ShowDialog()
    End Sub

    Private Sub btn_supplies_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supplies.Click
        Dim objconnector As New frm_supplies
        objconnector.ShowDialog()
    End Sub

    Private Sub btn_viewsupplies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viewsupplies.Click
        Dim objconnector As New frmsupplies_view
        objconnector.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim objconnector As New frm_invoices
        objconnector.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim objconnector As New frminvoices_view
        objconnector.ShowDialog()
    End Sub

    Private Sub btn_farmproduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_farmproduce.Click
        Dim objconnector As New frm_farmproduce
        objconnector.ShowDialog()
    End Sub
End Class
