Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class conn

    Dim constr As String = "Provider=Microsoft.Jet.OleDB.4.0; Data Source=|DataDirectory|\infinitum.mdb; Jet OLEDB:Database Password=kagumo;"

    Dim con As New OleDbConnection

    Dim sqlconnector As New SqlConnection

    Public serverconstring As String

    Dim com As OleDbCommand

    Dim oleconn As New OleDbConnection

    Dim DA As OleDbDataAdapter

    Dim DS As DataSet

    Dim insert_DR As OleDbDataReader

    Dim s_name, u_name, pass, catalog As String

    Public clearancelevel As Boolean = False

    Dim mythread As Threading.Thread

    Private Sub dbConnect(ByVal comstr As String)

        con = New OleDbConnection(constr)

        com = New OleDbCommand(comstr, con)

    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click

        ' If lblerr.Text = "Server Credentials accepted:" Then

        Try

            Dim id As String = 1
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text
            con = New OleDbConnection(constr)
            cmd.Connection = con
            con.Open()

            cmd.CommandText = "UPDATE tblconn SET user_name=@uname, user_password=@upassword, initial_catalog=@initial_catalog, server_name=@server_name WHERE ID= @id"

            cmd.Parameters.Add("@uname", OleDbType.VarChar).Value = Me.txtu_name.Text
            cmd.Parameters.Add("@upassword", OleDbType.VarChar).Value = Me.txtpass.Text
            cmd.Parameters.Add("@initial_catalog", OleDbType.VarChar).Value = Me.txtcatalog.Text
            cmd.Parameters.Add("@server", OleDbType.VarChar).Value = Me.txts_name.Text
            cmd.Parameters.Add("@id", OleDbType.VarChar).Value = id

            cmd.ExecuteNonQuery()

            MsgBox("Server parameters updated: ", MsgBoxStyle.Information, "Server settings")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        'con.Close()

        'frmuserlogin.Show()

        'Me.Hide()

        'Else

        'MsgBox("First test the connection variables!")

        'End If

    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            constr = "Data Source=" + txts_name.Text + ";Initial Catalog=" + txtcatalog.Text + ";Persist Security Info=True;User ID=" + txtu_name.Text + ";Password=" + txtpass.Text + ""

            Using sqlconnector As New SqlConnection(constr)
                sqlconnector.Open()
                If sqlconnector.State = ConnectionState.Open Then
                    lblerr.ForeColor = Color.MediumSpringGreen
                    lblerr.Text = "Server Credentials accepted:"
                Else
                    lblerr.ForeColor = Color.Red
                    lblerr.Text = "Incorrect Server credentials:"
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error connecting to server: " & ex.Message)
        Finally
            sqlconnector.Close()
        End Try

    End Sub

    Private Sub conn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        setconnector()

        'If clearancelevel = False Then
        '    txtcatalog.Enabled = False
        '    txtpass.Enabled = False
        '    txts_name.Enabled = False
        '    txtu_name.Enabled = False
        'End If

    End Sub

    Public Sub setconnector()

        Try
            Dim id As String = "1"

            Dim m_com_string As String = "select server_name, user_name, user_password, initial_catalog from tblconn where ID =" + "'" + id + "'" + ""

            dbConnect(m_com_string)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                s_name = insert_DR.GetValue(0).ToString()

                txts_name.Text = s_name

                u_name = insert_DR.GetValue(1).ToString()

                txtu_name.Text = u_name

                pass = insert_DR.GetValue(2).ToString()

                txtpass.Text = pass

                catalog = insert_DR.GetValue(3).ToString()

                txtcatalog.Text = catalog


                ' serverconstring = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\schooldbase.mdf;Integrated Security=True;Connect Timeout=120;User Instance=True"

                serverconstring = "Data Source=" + s_name + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + u_name + "; Password=" + pass + ""

                frm_members.testednetworkconnector = serverconstring

            End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception

            MsgBox("Error getting connector: " & ex.Message)
        End Try

    End Sub

    Sub checkconnector()

        Try

            Cursor = Cursors.WaitCursor

            Dim serverconstring As String = "Data Source=" + txts_name.Text + ";Initial Catalog=" + txtcatalog.Text + ";Persist Security Info=True;User ID=" + txtu_name.Text + ";Password=" + txtpass.Text + ""

            '  Dim serverconstring As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\schooldbase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

            Using sqlconnector As New SqlConnection(serverconstring)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then
                    lblerr.ForeColor = Color.MediumSpringGreen
                    lblerr.Text = "Server Credentials accepted:"
                Else
                    lblerr.ForeColor = Color.Red
                    lblerr.Text = "Incorrect Server credentials:"
                End If

            End Using

        Catch ex As Exception
            lblerr.ForeColor = Color.Red
            lblerr.Text = "Incorrect Server credentials:" & ex.Message
        Finally
            sqlconnector.Close()
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim mythread As New Thread(AddressOf checkconnector)

        mythread.Start()

    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub
End Class