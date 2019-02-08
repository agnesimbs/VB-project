Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Windows.Forms
Imports System.Threading

Public Class mic_functions

    'checks the network connection and sets it for all

    Dim retrievedconnector As String

    Dim constr As String = retrievedconnector

    Dim loglocation As String

    Dim insert_DR As SqlDataReader

    Public db_loc = "C:\SMS_SENDER"

    Dim testednetworkconnector As String = frm_members.testednetworkconnector

    Dim sqlconnector As New SqlConnection

    Dim com As New SqlCommand

    Dim conncheck As Boolean

    Public Sub dbConnect(ByVal comstr As String)

        sqlconnector = New SqlConnection(constr)
        com = New SqlCommand(comstr, sqlconnector)

    End Sub

    Public Sub mic_errors_logger(ByVal logentry As String)
        Try
            Dim s As StreamWriter
            Dim file_name_index As Integer = db_loc.LastIndexOfAny("\") + 1
            Dim loglocation As String = db_loc.Substring(0, file_name_index) & "MicroFin"

            If Not Directory.Exists(loglocation) Then
                Directory.CreateDirectory(loglocation)
                File.Create(loglocation & "\MicroFin.txt").Close()
                s = New StreamWriter(loglocation & "\MicroFin.txt", True)
                s.WriteLine(Date.Now & " " & logentry)
                s.Flush()
                s.Close()
            Else
                s = New StreamWriter(loglocation & "\MicroFin.txt", True)
                s.WriteLine(Date.Now & " " & logentry)
                s.Flush()
                s.Close()
            End If

        Catch ex As Exception
        End Try

    End Sub

    Public Function authenticator()

        Dim user_level As New Dictionary(Of String, String)

        Try
            Dim userlist As String = "SELECT MUser_id, Muser_name, Muser_class, user_phone, user_email, Muser_password, Muser_status FROM tbl_Mic_users"
            dbConnect(userlist)


        Catch ex As Exception
            mic_errors_logger("Authenticator Error:  " & ex.Message)
        End Try
        Return user_level

    End Function

    Public Sub colorcodereport(ByVal dggridtocolor As Windows.Forms.DataGridView)
        For Each receiptrow As DataGridViewRow In dggridtocolor.Rows

            If IsDBNull(receiptrow.Cells("Status").Value) = False Then
                If receiptrow.Cells("Status").Value = "Inactive" Then
                    receiptrow.DefaultCellStyle.BackColor = Color.OrangeRed
                    receiptrow.DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Next

        ' SETS THE SORTMODE FOR THE COLUMNS IN THE GRIDVIEW

        For Each COLUMN As DataGridViewColumn In dggridtocolor.Columns
            COLUMN.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub


    Public Sub fill_dgrid_view(ByVal comstr As String, ByVal datatable As String, ByVal dgrid As Windows.Forms.DataGridView)

        Dim da As New SqlDataAdapter(comstr, testednetworkconnector)

        Dim ds As New DataSet

        Dim cmb As New SqlCommandBuilder(da)

        da.Fill(ds, datatable)

        dgrid.DataSource = ds.Tables(datatable)

    End Sub

    Public Function initialnetworktester(ByVal lbldisplaystatus As Windows.Forms.Label)

        Try
            conn.setconnector()

            retrievedconnector = conn.serverconstring

            Using sqlconnector As New SqlConnection(retrievedconnector)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then

                    With lbldisplaystatus
                        .Text = "Server Connected"
                        .ForeColor = Color.FloralWhite
                    End With

                    'server.Text = "Server Connected"
                    conncheck = True
                    testednetworkconnector = retrievedconnector

                Else
                    conncheck = False

                    With lbldisplaystatus
                        .Text = "Server Not Connected"
                        .ForeColor = Color.Red
                    End With
                    lbldisplaystatus.Text = "Server Not Connected"
                End If

            End Using

        Catch ex As Exception
            conncheck = False
            lbldisplaystatus.Text = "Server Not Connected"
            lbldisplaystatus.Text = "Server Not Connected"
        Finally
            sqlconnector.Close()
        End Try

        Return retrievedconnector

    End Function

    Public Function set_networkconnection(ByVal lbldisplaystatus As Windows.Forms.Label)
        Try

            Do While True
                Try
                    conn.setconnector()

                    retrievedconnector = conn.serverconstring

                    Using sqlconnector As New SqlConnection(retrievedconnector)

                        sqlconnector.Open()
                        Dim connectionstatestate As String = sqlconnector.State.ToString
                        If connectionstatestate = "Open" Then

                            With lbldisplaystatus
                                .Text = "Server Connected"
                                .ForeColor = Color.FloralWhite
                            End With

                            lbldisplaystatus.Text = "Server Connected"
                            conncheck = True
                            testednetworkconnector = retrievedconnector

                        Else
                            conncheck = False

                            With lbldisplaystatus
                                .Text = "Server Not Connected"
                                .ForeColor = Color.Red
                            End With
                            lbldisplaystatus.Text = "Server Not Connected"
                        End If

                    End Using

                    Thread.Sleep(900000)

                Catch ex As Exception
                    conncheck = False
                    lbldisplaystatus.Text = "Server Not Connected"
                    lbldisplaystatus.Text = "Server Not Connected"
                Finally
                    sqlconnector.Close()
                End Try

            Loop


        Catch ex As Exception

        End Try

        Return retrievedconnector

    End Function



End Class
