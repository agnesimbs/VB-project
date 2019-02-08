Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_supplies
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

    Sub load_supplies_details(ByVal suppliescode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim supplies As String = " SELECT Input_no, Supplier_name, Batch_no FROM tbl_Mic_supplies WHERE Input_no  = " + "'" + suppliescode + "'"

            dbConnect(supplies) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()

                txt_inputno.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_suppliername.Text = CType(insert_DR.GetValue(1).ToString(), String)
                txt_batchno.Text = CType(insert_DR.GetValue(2).ToString(), String)



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

                cmd.CommandText = "INSERT INTO tbl_Mic_supplies(Input_no, Supplier_name,Batch_no) VALUES(@Input_no, @Supplier_name, @Batch_no)"

                cmd.Parameters.Add("@Input_no", SqlDbType.NVarChar).Value = txt_inputno.Text
                cmd.Parameters.Add("@Supplier_name", SqlDbType.NVarChar).Value = txt_suppliername.Text
                cmd.Parameters.Add("@Batch_no", SqlDbType.NVarChar).Value = txt_batchno.Text


                cmd.ExecuteNonQuery()

                MsgBox("ADDED Supplies", MsgBoxStyle.Information, "mICROfIN")
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

                cmd.CommandText = "UPDATE  tbl_Mic_suppliers SET Input_no=@Input_no, Supplier_name=@Supplier_name, Batch_no=@Batch_no WHERE Input_no=@Input_no"


                cmd.Parameters.Add("@Input_no", SqlDbType.NVarChar).Value = txt_inputno.Text
                cmd.Parameters.Add("@Supplier_name", SqlDbType.NVarChar).Value = txt_suppliername.Text
                cmd.Parameters.Add("@Batch_no", SqlDbType.NVarChar).Value = txt_batchno.Text




                cmd.ExecuteNonQuery()

                MsgBox("Supplies updated successfully", MsgBoxStyle.Information, "MicroFin")

            End If
            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error creating Supplies" & ex.ToString)

        Finally
            conn.Close()

            'Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            'Schoolparentmdi.editmode = False

            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub


    Private Sub frm_supplies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        testednetworkconnector = frm_members.testednetworkconnector

        If editmode = True Then
            load_supplies_details(suppliescode)
            'lbleditmode.Text = "Editing Record for: " & inputcode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        infererclass()
    End Sub

    Private Sub txt_suppliername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_suppliername.TextChanged

    End Sub
End Class