Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading



Public Class frm_farminputs
    Public testednetworkconnector As String '= frm_members.testednetworkconnector

    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False   ' checks the value to be processed during execution

    Public inputcode As String

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
    Sub load_input_details(ByVal membercode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim farminputs As String = " SELECT Input_no, Input_name, Batch,Units,Stock_input,Unit_price,Date,Seed_input,Locked FROM tbl_Mic_farminputs  WHERE Input_no  = " + "'" + inputcode + "'"

            dbConnect(farminputs) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()

                txt_inputno.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_inputname.Text = CType(insert_DR.GetValue(1).ToString(), String)
                txt_batch.Text = CType(insert_DR.GetValue(2).ToString(), String)
                txt_units.Text = CType(insert_DR.GetValue(3).ToString(), String)
                txt_stockinput.Text = CType(insert_DR.GetValue(4).ToString(), String)
                txt_unitprice.Text = CType(insert_DR.GetValue(5).ToString(), String)
                dtp_date.Text = CType(insert_DR.GetValue(6).ToString(), String)
                txt_seedinput.Text = CType(insert_DR.GetValue(7).ToString(), String)
                txt_locked.Text = CType(insert_DR.GetValue(8).ToString(), String)
               

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

                cmd.CommandText = "INSERT INTO tbl_Mic_farminputs(Input_no, Input_name, Batch, Units, Stock_input, Unit_price, Date, Seed_input, Locked) VALUES( @Input_no, @Input_name, @Batch, @Units, @Stock_input, @Unit_price, @Date, @Seed_input, @Locked)"

                cmd.Parameters.Add("@Input_no", SqlDbType.NVarChar).Value = txt_inputno.Text
                cmd.Parameters.Add("@Input_name", SqlDbType.NVarChar).Value = txt_inputname.Text
                cmd.Parameters.Add("@Batch", SqlDbType.NVarChar).Value = txt_batch.Text
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar).Value = txt_batch.Text
                cmd.Parameters.Add("@Stock_input", SqlDbType.NVarChar).Value = txt_stockinput.Text
                cmd.Parameters.Add("@Unit_price", SqlDbType.NVarChar).Value = txt_unitprice.Text
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_date.Value
                cmd.Parameters.Add("@Seed_input", SqlDbType.NVarChar).Value = txt_seedinput.Text
                cmd.Parameters.Add("@Locked", SqlDbType.NVarChar).Value = txt_locked.Text

                cmd.ExecuteNonQuery()

                MsgBox("ADDED Farm Inputs", MsgBoxStyle.Information, "mICROfIN")

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

                cmd.CommandText = "UPDATE  tbl_Mic_farminputs SET Input_no=@Input_no, Input_name=@Input_name, Batch=@Batch, Units=@Units, Stock_input=@Stock_input, Unit_price=@unit_price, Date=@Date, Seed_input=@Seed_input, Locked=@Locked  WHERE Input_no = @Input_no"


                cmd.Parameters.Add("@Input_no", SqlDbType.NVarChar).Value = txt_inputno.Text
                cmd.Parameters.Add("@Input_name", SqlDbType.NVarChar).Value = txt_inputname.Text
                cmd.Parameters.Add("@Batch", SqlDbType.NVarChar).Value = txt_batch.Text
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar).Value = txt_batch.Text
                cmd.Parameters.Add("@Stock_input", SqlDbType.NVarChar).Value = txt_stockinput.Text
                cmd.Parameters.Add("@Unit_price", SqlDbType.NVarChar).Value = txt_unitprice.Text
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_date.Value
                cmd.Parameters.Add("@Seed_input", SqlDbType.NVarChar).Value = txt_seedinput.Text
                cmd.Parameters.Add("@Locked", SqlDbType.NVarChar).Value = txt_locked.Text




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
    Private Sub frm_farminputs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        testednetworkconnector = frm_members.testednetworkconnector

        If editmode = True Then
            load_input_details(inputcode)
            'lbleditmode.Text = "Editing Record for: " & inputcode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        infererclass()
    End Sub
End Class