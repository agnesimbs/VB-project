Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_invoices

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
    Sub load_invoices_details(ByVal invoicescode As String) 'loads the members details from db when editing member button is clicked

        Try

            Dim invoices As String = " Sales_no, Buyer_id, Product_id, Mobile, Date, Units, User_id, Price FROM tbl_Mic_invoices  WHERE Sales_no  = " + "'" + invoicescode + "'"

            dbConnect(invoices) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            While insert_DR.Read()

                txt_salesno.Text = CType(insert_DR.GetValue(0).ToString(), String)
                txt_buyerid.Text = CType(insert_DR.GetValue(1).ToString(), String)
                txt_productid.Text = CType(insert_DR.GetValue(2).ToString(), String)
                txt_mobile.Text = CType(insert_DR.GetValue(3).ToString(), String)
                dtp_invoices.Text = CType(insert_DR.GetValue(4).ToString(), String)
                txt_units.Text = CType(insert_DR.GetValue(5).ToString(), String)
                txt_userid.Text = CType(insert_DR.GetValue(6).ToString(), String)
                txt_price.Text = CType(insert_DR.GetValue(7).ToString(), String)

                '    Dim n As Integer = 0

                '    Do While n < 8
                '        combo_subgroup.Items.Add(CType(insert_DR.GetValue(n).ToString(), String))

                '        n = n + 1
                '    Loop
            End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            MsgBox("Error fetching Invoice details " & ex.Message)
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

                cmd.CommandText = "INSERT INTO tbl_Mic_invoices( Sales_no, Buyer_id, Product_id, Mobile, Date, Units, User_id, Price) VALUES(@Sales_no, @Buyer_id, @Product_id, @Mobile, @Date, @Units, @User_id, @Price)"

                cmd.Parameters.Add("@Sales_no", SqlDbType.NVarChar).Value = txt_salesno.Text
                cmd.Parameters.Add("@Buyer_id", SqlDbType.NVarChar).Value = txt_buyerid.Text
                cmd.Parameters.Add("@Product_id", SqlDbType.NVarChar).Value = txt_productid.Text
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = txt_mobile.Text
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_invoices.Value
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar).Value = txt_units.Text
                cmd.Parameters.Add("@User_id", SqlDbType.NVarChar).Value = txt_userid.Text
                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txt_price.Text

                cmd.ExecuteNonQuery()

                MsgBox("ADDED Invoices", MsgBoxStyle.Information, "mICROfIN")
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

                cmd.CommandText = "UPDATE  tbl_Mic_invoices SET Sales_no=@Sales_no, Buyer_id=@Buyer_id, Product_id=@Product Id, Mobile=@mobile, Date=@Date, Units=@Units, User_id =@User Id, Priceas=@Price WHERE Sales_no=@Sales_no"

                cmd.Parameters.Add("@Sales_no", SqlDbType.NVarChar).Value = txt_salesno.Text
                cmd.Parameters.Add("@Buyer_id", SqlDbType.NVarChar).Value = txt_buyerid.Text
                cmd.Parameters.Add("@Product_id", SqlDbType.NVarChar).Value = txt_productid.Text
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = txt_mobile.Text
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_invoices.Value
                cmd.Parameters.Add("@Units", SqlDbType.NVarChar).Value = txt_units.Text
                cmd.Parameters.Add("@User_id", SqlDbType.NVarChar).Value = txt_userid.Text
                cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = txt_price.Text



                cmd.ExecuteNonQuery()

                MsgBox("Invoice updated successfully", MsgBoxStyle.Information, "MicroFin")

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
    Private Sub frm_invoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        testednetworkconnector = frm_members.testednetworkconnector

        If editmode = True Then
            load_invoices_details(invoicescode)
            'lbleditmode.Text = "Editing Record for: " & inputcode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        infererclass()
    End Sub

    Private Sub dtp_invoices_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_invoices.ValueChanged

    End Sub
End Class