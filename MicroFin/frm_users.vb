Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Frm_users
    Public testednetworkconnector As String

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False 'checks the value to be processed during execution

    Public userId As String

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

            Dim retrievedconnector As String

            retrievedconnector = conn.serverconstring

            Using sqlconnector As New SqlConnection(retrievedconnector)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then

                    With lbl_User_status
                        .Text = "Server Connected"
                        .ForeColor = Color.FloralWhite
                    End With

                    server.Text = "Server Connected"
                    conncheck = True
                    testednetworkconnector = retrievedconnector

                Else
                    conncheck = False

                    With lbl_User_status
                        .Text = "Server Not Connected"
                        .ForeColor = Color.Red
                    End With
                    server.Text = "Server Not Connected"
                End If

            End Using

        Catch ex As Exception
            conncheck = False
            server.Text = "Server Not Connected"
            lbl_User_status.Text = "Server Not Connected"
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

                        With lbl_User_status
                            .Text = "Server Connected"
                            .ForeColor = Color.FloralWhite
                        End With

                        server.Text = "Server Connected"
                        conncheck = True
                        testednetworkconnector = retrievedconnector

                    Else
                        conncheck = False

                        With lbl_User_status
                            .Text = "Server Not Connected"
                            .ForeColor = Color.Red
                        End With
                        server.Text = "Server Not Connected"
                    End If

                End Using

                'Thread.Sleep(900000)

            Catch ex As Exception
                conncheck = False
                server.Text = "Server Not Connected"
                lbl_User_status.Text = "Server Not Connected"
            Finally
                sqlconnector.Close()
            End Try

        Loop

    End Sub

    Private Sub Frm_users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim date_Today As Date = Today.ToString
        lbl_User_Date.Text = date_Today
        Dim time_Now As String = Now.ToLongTimeString
        lbl_User_Time.Text = time_Now
        lbl_User_status.Text = "Connected"

        If editmode = True Then
            load_user_details(userId)
            lbl_editUser.Text = "Editing Record for: " & userId
        ElseIf editmode = False Then
            MsgBox("starting")
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Dim constr As String = testednetworkconnector

    Private Sub btn_User_SaveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User_SaveData.Click

        Dim conn As New SqlConnection
        Dim sConnString As String = frm_members.testednetworkconnector
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False

        Try
            Cursor = Cursors.WaitCursor

            If editmode = False Then


                If Not IsNothing(Me.pctr_UserPhoto.Image) Then
                    Me.pctr_UserPhoto.Image.Save(myMs, Me.pctr_UserPhoto.Image.RawFormat)
                    arrImage = myMs.GetBuffer
                Else
                    arrImage = Nothing
                End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "INSERT INTO tbl_Mic_users(MUser_id,Muser_name,Muser_class,user_phone,user_email,Muser_password,Muser_status) VALUES(@User_id,@user_name,@user_class,@user_phone,@user_email,@user_password,@user_status)"


                cmd.Parameters.Add("@User_id", SqlDbType.NVarChar).Value = Me.txt_UserId.Text
                cmd.Parameters.Add("@user_name", SqlDbType.NVarChar).Value = Me.txt_UserName.Text
                ' cmd.Parameters.Add("@User_image", SqlDbType.Image).Value = arrImage
                cmd.Parameters.Add("@user_class", SqlDbType.NVarChar).Value = Me.combobox_UserClass.Text
                cmd.Parameters.Add("@user_phone", SqlDbType.NVarChar).Value = Me.txt_UserPhone.Text
                cmd.Parameters.Add("@user_email", SqlDbType.NVarChar).Value = Me.txt_UserEmail.Text
                cmd.Parameters.Add("@user_password", SqlDbType.NVarChar).Value = Me.txt_UserPassWrd.Text
                cmd.Parameters.Add("@user_status", SqlDbType.NVarChar).Value = "Active"

                cmd.ExecuteNonQuery()


                MsgBox("USER ADDED", MsgBoxStyle.Information, "mICROFIN")
               

            ElseIf editmode = True Then

                If Not IsNothing(Me.pctr_UserPhoto.Image) Then
                    Me.pctr_UserPhoto.Image.Save(myMs, Me.pctr_UserPhoto.Image.RawFormat)
                    arrImage = myMs.GetBuffer
                Else
                    arrImage = Nothing
                End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text


                cmd.CommandText = "UPDATE tbl_Mic_users SET MUser_id = @User_id,Muser_name=@user_name,User_image= @User_image, Muser_class= @user_class, user_phone=@user_phone, user_email=@user_email, Muser_password=@user_password, Muser_status=@user_status WHERE Admission_no = @admno"

                cmd.Parameters.Add("@User_id", SqlDbType.NVarChar).Value = Me.txt_UserId.Text
                cmd.Parameters.Add("@user_name", SqlDbType.NVarChar).Value = Me.txt_UserName.Text
                cmd.Parameters.Add("@User_image", SqlDbType.Binary).Value = arrImage
                cmd.Parameters.Add("@user_class", SqlDbType.NVarChar).Value = Me.combobox_UserClass.Text
                cmd.Parameters.Add("@user_phone", SqlDbType.Date).Value = Me.txt_UserPhone.Text
                cmd.Parameters.Add("@user_email", SqlDbType.NVarChar).Value = Me.txt_UserEmail.Text
                cmd.Parameters.Add("@user_password", SqlDbType.NVarChar).Value = txt_UserPassWrd.Text
                cmd.Parameters.Add("@user_status", SqlDbType.NVarChar).Value = "Active"

                cmd.ExecuteNonQuery()

                MsgBox("Student Bio-Data updated successfully", MsgBoxStyle.Information, "Schools Systems")

            End If
            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox(ErrorToString)

        Finally
            conn.Close()

            'Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            'Schoolparentmdi.editmode = False

            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try
    End Sub

    Private Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(comstr)

        com = New SqlCommand(comstr, con)

    End Sub

    Sub load_user_details(ByVal userId As String)

        Try
            lbl_User_status.Text = "Loading"

            Dim u_Details As String

            Dim userdetails As String = "SELECT MUser_id,Muser_name,Muser_class,user_phone,user_email,Muser_password,Muser_status FROM  tbl_Mic_users WHERE MUser_id  = " + "'" + userId + "'" + ""

            ' Dim newuser As String = "SELECT * FROM  dbo.tbl_Mic_users"
            dbConnect(userdetails)

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()
                u_Details = "User Id:" & CType(insert_DR.GetValue(0).ToString(), String) & "Username: " & CType(insert_DR.GetValue(1).ToString(), String)
                txt_UserId.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_UserName.Text = CType(insert_DR.GetValue(1).ToString(), String)
                combobox_UserClass.Items.Add(CType(insert_DR.GetValue(2).ToString(), String))
                txt_UserPhone.Text = CType(insert_DR.GetValue(3).ToString(), String)
                txt_UserEmail.Text = CType(insert_DR.GetValue(4).ToString(), String)
                txt_UserPassWrd.Text = CType(insert_DR.GetValue(5).ToString(), String)

            End While

            insert_DR.Close()

            con.Close()
            lbl_User_status.Text = "Completed loading for: " & u_Details

        Catch ex As Exception
            MsgBox("Error Member details " & ex.Message)
        End Try

    End Sub

    Private Sub btn_userLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_userLoad.Click
        Dim frm_userLoad As New frm_UserView
        frm_userLoad.ShowDialog()
    End Sub

    Private Sub lbl_User_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_User_Date.Click

    End Sub
End Class