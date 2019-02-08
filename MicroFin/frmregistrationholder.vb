Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class frmregistrationholder

    Dim constr As String = Schoolparentmdi.testednetworkconnector

    Dim con As SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

    Dim mediccond, impairment As Boolean

    Dim gender As String

    Dim religion As String

    Public editmode As Boolean = False

    Dim STUDNAMETOUSE As String

    Dim guardiancounter As Integer = 0

    Dim academicinfocounter As Integer = 0

    Dim medcount As Integer = 0

    Dim routenameid As New Dictionary(Of String, Integer)


    Private Sub frmregistrationholder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblmedicalinformation.Text = "Does the student suffer any medical information?" + vbCrLf + "If yes, Kindly give a description below."

        lblimpairment.Text = "Does the student suffer any physical impairment?" + vbCrLf + "If yes, Kindly give a description below."

        If editmode = True Then

            lbleditmode.Text = "Edit Mode"
            lbledita.Text = "Edit Mode"
            lbleditg.Text = "Edit Mode"
            lbleditm.Text = "Edit Mode"
            lbleditmode.ForeColor = Color.Red
            lbledita.ForeColor = Color.Red
            lbleditg.ForeColor = Color.Red
            lbleditm.ForeColor = Color.Red
            btnrstudent.Text = "Update Student"

            getbiodata(txtadmission.Text)
            Load_Image(txtadmission.Text, picpassport)
            cbdsavemedical.Text = "Update Medical"
            getamedicalinfo(txtadmission.Text)
            getacademicinfo(txtadmission.Text)
            btnguardians.Text = "Update Guardian"
            getguardian(txtadmission.Text)

        End If

        If cboroute.Text <> "" Then
            createorder("Transport", txtrcharge.Text, "TERMLY")
        End If

        GETSTREAMSandROUTES(cbostream, cboroute)
        frmaddinvoice.load_votehead_names(cbovote)
        getvar_votes(txtadmission.Text)

    End Sub

    Dim voteamountdict As New Dictionary(Of String, Integer)
    Dim voteoccurdict As New Dictionary(Of String, String)

    Sub getvar_votes(ByVal admission As String)

        Try
            Dim adm_vote_amount_getter As String = "SELECT vote, Amount, freq FROM Students_var_votes   WHERE Admission_no= " + "'" + admission + "'" + ""

            dbConnect(adm_vote_amount_getter)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim vote As String
                Dim vote_charge As Integer
                Dim vote_freq As String


                vote = insert_DR.GetValue(0).ToString()
                vote_charge = insert_DR.GetValue(1).ToString()
                vote_freq = insert_DR.GetValue(2).ToString()


                If voteamountdict.ContainsKey(vote) = False Then
                    voteamountdict.Add(vote, vote_charge)
                ElseIf voteamountdict.ContainsKey(vote) = True Then
                    voteamountdict(vote) = vote_charge
                End If

                If voteoccurdict.ContainsKey(vote) = False Then
                    voteoccurdict.Add(vote, vote_freq)
                ElseIf voteoccurdict.ContainsKey(vote) = True Then
                    voteoccurdict(vote) = vote_freq
                End If

                ' Add item to list view items collection
            End While

            ' Close data reader
            insert_DR.Close()

            con.Close()

            createdisplayvar_votes()

        Catch ex As Exception
            MsgBox("Error getting var votes " & ex.Message)
        End Try

    End Sub


    Sub createdisplayvar_votes()

        Try

            Dim varcharges As New DataTable

            If varcharges.Columns.Contains("Vote") = False Then
                varcharges.Columns.Add("Vote", GetType(String))
            End If

            If varcharges.Columns.Contains("Amount") = False Then
                varcharges.Columns.Add("Amount", GetType(Integer))
            End If

            If varcharges.Columns.Contains("Frequency") = False Then
                varcharges.Columns.Add("Frequency", GetType(String))
            End If

            For Each item As KeyValuePair(Of String, Integer) In voteamountdict

                Dim newrow As DataRow = varcharges.NewRow
                newrow("Vote") = item.Key
                newrow("Amount") = item.Value
                newrow("Frequency") = voteoccurdict(item.Key)
                varcharges.Rows.Add(newrow)

            Next

            dgvariables.DataSource = varcharges

            If dgvariables.Columns.Contains("Del") Then
                dgvariables.Columns.Remove("Del")
            End If

            Dim n As Integer = dgvariables.Columns.Count
            Dim testbutton As New DataGridViewButtonColumn
            testbutton.HeaderText = "Del"
            testbutton.Text = "Del"
            testbutton.Name = "Del"
            testbutton.UseColumnTextForButtonValue = True
            testbutton.FlatStyle = FlatStyle.Flat
            dgvariables.Columns.Insert(n, testbutton)


        Catch ex As Exception
            MsgBox("Error creating votes " & ex.Message)
        End Try
    End Sub

    Sub createorder(ByVal votename As String, ByVal voteamount As Integer, ByVal voteoccurence As String)

        Try

            Dim varcharges As New DataTable

            If varcharges.Columns.Contains("Vote") = False Then
                varcharges.Columns.Add("Vote", GetType(String))
            End If

            If varcharges.Columns.Contains("Amount") = False Then
                varcharges.Columns.Add("Amount", GetType(Integer))
            End If

            If varcharges.Columns.Contains("Frequency") = False Then
                varcharges.Columns.Add("Frequency", GetType(String))
            End If


            If voteamountdict.ContainsKey(votename) = True Then
                voteamountdict(votename) = voteamount
            ElseIf voteamountdict.ContainsKey(votename) = False Then
                voteamountdict.Add(votename, voteamount)
            End If

            If voteoccurdict.ContainsKey(votename) = True Then
                voteoccurdict(votename) = voteoccurence
            ElseIf voteoccurdict.ContainsKey(votename) = False Then
                voteoccurdict.Add(votename, voteoccurence)
            End If


            For Each item As KeyValuePair(Of String, Integer) In voteamountdict

                Dim newrow As DataRow = varcharges.NewRow
                newrow("Vote") = item.Key
                newrow("Amount") = item.Value
                newrow("Frequency") = voteoccurdict(item.Key)
                varcharges.Rows.Add(newrow)

            Next

            dgvariables.DataSource = varcharges

            If dgvariables.Columns.Contains("Del") Then
                dgvariables.Columns.Remove("Del")
            End If

            Dim n As Integer = dgvariables.Columns.Count
            Dim testbutton As New DataGridViewButtonColumn
            testbutton.HeaderText = "Del"
            testbutton.Text = "Del"
            testbutton.Name = "Del"
            testbutton.UseColumnTextForButtonValue = True
            testbutton.FlatStyle = FlatStyle.Flat
            dgvariables.Columns.Insert(n, testbutton)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub getgender()

        If rbmale.Checked = True Then
            gender = "Male"
        ElseIf rbfemale.Checked = True Then
            gender = "Female"
        Else
            MsgBox("kindly review select your gender selection", MsgBoxStyle.Information)
            Return
        End If

    End Sub

    Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(constr)

        com = New SqlCommand(comstr, con)

    End Sub

    Sub getguardian(ByVal adm As String)

        Dim guardinfo As String = "SELECT count(*) FROM guardians WHERE Admission_no= " + "'" + adm + "'"
        dbConnect(guardinfo)
        con.Open()
        insert_DR = com.ExecuteReader

        While insert_DR.Read()

            Dim medcounter As String = insert_DR.GetValue(0).ToString()
            If medcounter <> "" Then
                guardiancounter = CType(medcounter, Integer)
            End If

        End While

        insert_DR.Close()
        con.Close()


        Dim guardians As String = "SELECT  First_name, postal_code, Postal_box, mobile_no, occupation, Relation, Town, email, regdate, mothers_name,mothers_occupation, mothers_mobile_no FROM guardians WHERE Admission_no= " + "'" + adm + "'"

        Try

            dbConnect(guardians)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim First_name, parental_status, postal_code, Postal_box, mobile_no, occupation, Relation, Town, email, regdate, mothers_name, mothers_occupation, mothers_mobile_no As String

                First_name = insert_DR.GetValue(0).ToString()
                postal_code = insert_DR.GetValue(1).ToString()
                Postal_box = insert_DR.GetValue(2).ToString()
                mobile_no = insert_DR.GetValue(3).ToString()
                occupation = insert_DR.GetValue(4).ToString()
                Relation = insert_DR.GetValue(5).ToString()
                Town = insert_DR.GetValue(6).ToString()
                regdate = insert_DR.GetValue(8).ToString()
                mothers_name = insert_DR.GetValue(9).ToString()
                mothers_occupation = insert_DR.GetValue(10).ToString()
                mothers_mobile_no = insert_DR.GetValue(11).ToString()


                txtfathersname.Text = First_name
                txtcode.Text = postal_code
                txtbox.Text = Postal_box
                txtfcontact.Text = mobile_no
                txtoccupation.Text = occupation
                txttown.Text = Town
                txtemail.Text = email
                dtpregdate.Value = regdate
                txtmothersname.Text = mothers_name
                txtmothersno.Text = mothers_mobile_no
                txtmothersoccupation.Text = mothers_occupation

            End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception

            MsgBox("Error loading students: " & ex.Message)

        End Try

    End Sub

    Public Sub Load_Image(ByVal iImageID As String, ByVal pcbox As System.Windows.Forms.PictureBox)

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream

        Try

            Dim constr As String = Schoolparentmdi.testednetworkconnector

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Admission_no as id, student_photo from students where Admission_no= " + "'" + iImageID + "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    arrImage = dr("student_photo")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    '
                    'Me.Pic_passport.Image = System.Drawing.Image.FromStream(myMS)

                    pcbox.Image = System.Drawing.Image.FromStream(myMS)

                End While

            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try

    End Sub


    Sub getreligion()

        If rbchristian.Checked = True Then
            religion = "christian"
        ElseIf rbhindu.Checked = True Then
            religion = "Hindu"
        ElseIf rbmuslim.Checked = True Then
            religion = "Muslim"
        ElseIf rbother.Checked = True Then
            religion = "Other"
        Else
            MsgBox("kindly review your religion choices", MsgBoxStyle.Information)
            Return
        End If
    End Sub


    Sub subjectloader()

        Using conn As New SqlConnection(constr)

            Using cmd As New SqlCommand("INSERT INTO stdsubject_sheet(Admission_no,form_class,stream_class) VALUES(@admission,@formclass,@stream)", conn)

                cmd.Parameters.Add("@formclass", SqlDbType.NVarChar).Value = Me.cboadmform.Text
                cmd.Parameters.Add("@stream", SqlDbType.NVarChar).Value = Me.cbostream.Text
                cmd.Parameters.Add("@admission", SqlDbType.NVarChar).Value = Me.txtadmission.Text
                conn.Open()

                cmd.ExecuteNonQuery()

                conn.Close()

            End Using

        End Using

        Dim count As Integer = 1

        Dim counte As Integer = 0

        Dim subjectnames As String = "SELECT subject_name as [Subject] from tblsubjects "

        dbConnect(subjectnames)

        con.Open()

        insert_DR = com.ExecuteReader

        While insert_DR.Read()

            Dim NewItem As String

            NewItem = insert_DR.GetValue(0).ToString()

            cbostream.Items.Add(NewItem)

            Using conn As New SqlConnection(constr)

                Dim columname As String = "exp" + CType(counte + 1, String)

                Using cmd As New SqlCommand(" UPDATE stdsubject_sheet set " + columname + " = @subject  where admission_no = @admission", conn)

                    cmd.Parameters.AddWithValue("@subject", SqlDbType.NVarChar).Value = NewItem

                    cmd.Parameters.Add("@admission", SqlDbType.NVarChar).Value = Me.txtadmission.Text

                    counte = counte + 1

                    conn.Open()

                    cmd.ExecuteNonQuery()

                    conn.Close()

                End Using

            End Using

        End While

        insert_DR.Close()

        con.Close()

    End Sub

    Dim routecost As New Dictionary(Of String, Integer)

    Public Sub GETSTREAMSandROUTES(ByVal cbostreams As Windows.Forms.ComboBox, ByVal cboroutess As Windows.Forms.ComboBox)

        Try
            routecost.Clear()

            Dim streamgetter As String = "SELECT distinct stream_name as [STREAM] from streams "
            Dim routegetter As String = "SELECT route_id, route_name,route_cost  from routes "

            cbostreams.Items.Clear()
            cboroutess.Items.Clear()
            routenameid.Clear()

            dbConnect(streamgetter)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim NewItem As String

                NewItem = insert_DR.GetValue(0).ToString()

                cbostreams.Items.Add(NewItem)

            End While

            'getting the routes now.

            ' cboroutess.Items.Add("None")
            ' cboroutess.Text = "None"

            insert_DR.Close()

            con.Close()

            dbConnect(routegetter)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim Newroute As String
                Dim routeid As Integer
                Dim rcost As Integer

                routeid = insert_DR.GetValue(0).ToString()
                Newroute = insert_DR.GetValue(1).ToString()
                rcost = insert_DR.GetValue(2).ToString()

                'If routenameid.ContainsKey(routeid) = False Then
                '    routenameid.Add(routeid, Newroute)
                'End If

                cboroutess.Items.Add(Newroute)

                If routecost.ContainsKey(Newroute) = False Then
                    routecost.Add(Newroute, rcost)
                End If

            End While

            insert_DR.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Sub evconditions()

        If chkmedyes.Checked = True Then
            mediccond = True
        ElseIf chkmedno.Checked = True Then
            mediccond = False
        End If

        If chkimpyes.Checked = True Then
            impairment = True
        ElseIf chkimpno.Checked = True Then
            impairment = False
        End If

    End Sub

    Sub getbiodata(ByVal adm As String)

        Dim biodata As String = "SELECT stud_name,Bcert_no, DOB, Gender, Religion, Admin_Date, STUDENT_TYPE,school_status,class_now,stream_now, route_id, lunch_include, rcost FROM students WHERE Admission_no= " + "'" + adm + "'"

        Try

            dbConnect(biodata)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim studname, bcertno, dob, gender, religion, admindate, studenttype, schoolstatus, currform, currstream, route_id, lunch_include, routecost As String

                studname = insert_DR.GetValue(0).ToString()
                bcertno = insert_DR.GetValue(1).ToString()
                dob = insert_DR.GetValue(2).ToString()
                gender = insert_DR.GetValue(3).ToString()
                religion = insert_DR.GetValue(4).ToString()
                studenttype = insert_DR.GetValue(6).ToString()
                schoolstatus = insert_DR.GetValue(7).ToString()
                currform = insert_DR.GetValue(8).ToString()
                currstream = insert_DR.GetValue(9).ToString()
                admindate = insert_DR.GetValue(5).ToString()
                route_id = insert_DR.GetValue(10).ToString()
                lunch_include = insert_DR.GetValue(11).ToString()
                routecost = insert_DR.GetValue(12).ToString()
                ' Add item to list view items collection

                txtfname.Text = studname
                lblgadmin.Text = adm
                lblgname.Text = studname
                lblrname.Text = studname
                lbladmission.Text = adm
                lblaadmin.Text = adm
                lblaname.Text = studname
                cboadmform.Text = currform
                cbostream.Text = currstream
                txtbcert.Text = bcertno
                dtpadmdate.Value = admindate
                dtpdob.Value = dob
                cboroute.Text = route_id
                ' cbovote.Text = lunch_include
                txtrcharge.Text = routecost
                cbostatus.Text = schoolstatus
                cbotype.Text = studenttype

                If gender = "Male" Then
                    rbmale.Checked = True
                ElseIf gender = "Female" Then
                    rbfemale.Checked = True
                End If


                If religion = "christian" Then
                    rbchristian.Checked = True
                ElseIf religion = "Hindu" Then
                    rbhindu.Checked = True
                ElseIf religion = "Muslim" Then
                    rbmuslim.Checked = True
                ElseIf religion = "Other" Then
                    rbother.Checked = True
                End If

            End While

            ' Close data reader
            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        opendlgphoto.FileName = ""
        opendlgphoto.Filter = "JPEG files(*.jpg)|*.jpg|GIF files(*.gif)|*.gif|All files(*.*)|*.*"
        opendlgphoto.ShowDialog()
        Me.lbldesc.Text = opendlgphoto.FileName
        Me.picpassport.ImageLocation = Me.lbldesc.Text
    End Sub



    Sub regeneratevar_votes(ByVal admission As String)
        ' first delete all student records in the voteheadsheet

        Try
            Dim studentvotes As String = "DELETE  FROM Students_var_votes WHERE  Admission_no= " + "'" + admission + "'"
            dbConnect(studentvotes)
            con.Open()
            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim medcounter As String = insert_DR.GetValue(0).ToString()
                If medcounter <> "" Then
                    medcount = CType(medcount, Integer)
                End If

            End While

            insert_DR.Close()
            con.Close()

            'INSERT THE RECORDS INTO THE SYSTEM
            For Each voterow As DataGridViewRow In dgvariables.Rows

                Using conn As New SqlConnection(constr)

                    Using cmd As New SqlCommand("INSERT INTO Students_var_votes(Admission_no,Vote, amount, freq) VALUES(@Admission_no,@Vote,@amount,@freq)", conn)

                        cmd.Parameters.Add("@Admission_no", SqlDbType.NVarChar).Value = admission
                        cmd.Parameters.Add("@Vote", SqlDbType.NVarChar).Value = voterow.Cells("Vote").Value
                        cmd.Parameters.Add("@amount", SqlDbType.NVarChar).Value = voterow.Cells("Amount").Value
                        cmd.Parameters.Add("@freq", SqlDbType.NVarChar).Value = voterow.Cells("Frequency").Value

                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()

                    End Using

                End Using
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnrstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrstudent.Click

        getgender()
        getreligion()

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
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

                cmd.CommandText = "INSERT INTO students(Admission_no,Stud_name,bcert_no,dob,gender,religion,Admin_date,class_now,stream_now,school_status,Year_now,student_photo,student_type, route_id,rcost, lunch_include) VALUES(@admno,@stud_name,@brno,@dob,@gender,@religion,@admindate,@classnow,@streamnow,@schoolstatus,@Year_now,@passport,@studenttype, @route_id, @rcost, @lunch_include)"

                cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.txtadmission.Text
                cmd.Parameters.Add("@Stud_name", SqlDbType.NVarChar).Value = Me.txtfname.Text
                cmd.Parameters.Add("@brno", SqlDbType.NVarChar).Value = Me.txtbcert.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Me.dtpdob.Value.Date
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Me.gender
                cmd.Parameters.Add("@religion", SqlDbType.NVarChar).Value = Me.religion
                cmd.Parameters.Add("@classnow", SqlDbType.NVarChar).Value = Me.cboadmform.Text
                cmd.Parameters.Add("@Year_now", SqlDbType.NVarChar).Value = Me.dtpadmdate.Value.Year
                cmd.Parameters.Add("@streamnow", SqlDbType.NVarChar).Value = Me.cbostream.Text
                cmd.Parameters.Add("@admindate", SqlDbType.Date).Value = Me.dtpadmdate.Value.Date
                cmd.Parameters.Add("@schoolstatus", SqlDbType.NVarChar).Value = cbostatus.Text
                cmd.Parameters.Add("@passport", SqlDbType.Binary).Value = arrImage
                cmd.Parameters.Add("@studenttype", SqlDbType.NVarChar).Value = cbotype.Text
                cmd.Parameters.Add("@route_id", SqlDbType.NVarChar).Value = cboroute.Text
                cmd.Parameters.Add("@rcost", SqlDbType.Int).Value = CType(txtrcharge.Text, Integer)
                cmd.Parameters.Add("@lunch_include", SqlDbType.NVarChar).Value = cbovote.Text

                cmd.ExecuteNonQuery()

                regeneratevar_votes(txtadmission.Text)

                frmadministerexam.insertpasstrends(txtadmission.Text)

                '  If cboadmform.Text = "FORM 1" Or cboadmform.Text = "FORM 2" Then
                subjectloader()
                MsgBox("Student Bio-Data captured & Subjects set up", MsgBoxStyle.Information, "Schools Systems")
                'Else
                '    MsgBox("Student Bio-Data captured ", MsgBoxStyle.Information, "Schools Systems")
                'End If



                lblgadmin.Text = txtadmission.Text
                lblgname.Text = txtfname.Text
                lbladmission.Text = txtadmission.Text
                lblrname.Text = txtfname.Text
                lblaadmin.Text = txtadmission.Text
                lblaname.Text = txtfname.Text

                lblgadmin.ForeColor = Color.SeaGreen
                lblgname.ForeColor = Color.SeaGreen
                lbladmission.ForeColor = Color.SeaGreen
                lblrname.ForeColor = Color.SeaGreen
                lblaadmin.ForeColor = Color.SeaGreen
                lblaname.ForeColor = Color.SeaGreen

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

                ' cmd.CommandText = "UPDATE students SET school_status=@schoolstatus"

                cmd.CommandText = "UPDATE students SET stud_name = @stud_name,stream_now= @streamnow, class_now= @classnow, bcert_no=@brno, dob=@dob, gender=@gender, religion=@religion, Admin_date=@admindate, school_status=@schoolstatus, student_photo=@passport,student_type= @studenttype, rcost= @rcost,route_id= @route_id, lunch_include= @lunch_include WHERE Admission_no = @admno"

                cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.txtadmission.Text
                cmd.Parameters.Add("@stud_name", SqlDbType.NVarChar).Value = Me.txtfname.Text
                cmd.Parameters.Add("@brno", SqlDbType.NVarChar).Value = Me.txtbcert.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Me.dtpdob.Value.Date
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Me.gender
                cmd.Parameters.Add("@religion", SqlDbType.NVarChar).Value = Me.religion
                cmd.Parameters.Add("@classnow", SqlDbType.NVarChar).Value = Me.cboadmform.Text
                cmd.Parameters.Add("@streamnow", SqlDbType.NVarChar).Value = Me.cbostream.Text
                cmd.Parameters.Add("@admindate", SqlDbType.Date).Value = Me.dtpadmdate.Value.Date
                cmd.Parameters.Add("@schoolstatus", SqlDbType.NVarChar).Value = cbostatus.Text
                cmd.Parameters.Add("@passport", SqlDbType.Binary).Value = arrImage
                cmd.Parameters.Add("@studenttype", SqlDbType.NVarChar).Value = cbotype.Text
                cmd.Parameters.Add("@route_id", SqlDbType.NVarChar).Value = cboroute.Text
                cmd.Parameters.Add("@rcost", SqlDbType.Int).Value = CType(txtrcharge.Text, Integer)
                cmd.Parameters.Add("@lunch_include", SqlDbType.NVarChar).Value = cbovote.Text

                cmd.ExecuteNonQuery()

                regeneratevar_votes(txtadmission.Text)

                MsgBox("Student Bio-Data updated successfully", MsgBoxStyle.Information, "Schools Systems")

            End If
            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox(ErrorToString)

        Finally
            conn.Close()

            Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            Schoolparentmdi.editmode = False

        End Try

    End Sub

    Sub getamedicalinfo(ByVal adm As String)

        Dim medicalinfo As String = "Select  Medical_condition, condition_description, physical_impairment, Impairment_description, date_recorded FROM  Medical_info WHERE  admission_no= " + "'" + adm + "'"
        Dim medicalcount As String = "Select  count(*) FROM  Medical_info WHERE  admission_no= " + "'" + adm + "'"

        Try
            dbConnect(medicalcount)
            con.Open()
            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim medcounter As String = insert_DR.GetValue(0).ToString()
                If medcounter <> "" Then
                    medcount = CType(medcount, Integer)
                End If

            End While

            insert_DR.Close()
            con.Close()


            dbConnect(medicalinfo)
            con.Open()
            insert_DR = com.ExecuteReader
            While insert_DR.Read()
                Dim Medical_condition, condition_description, physical_impairment, Impairment_description, date_recorded As String
                Medical_condition = insert_DR.GetValue(0).ToString()
                condition_description = insert_DR.GetValue(1).ToString()
                physical_impairment = insert_DR.GetValue(2).ToString()
                Impairment_description = insert_DR.GetValue(3).ToString()
                date_recorded = insert_DR.GetValue(4).ToString()

                ' Add item to list view items collection

                txtmeddesc.Text = condition_description
                txtimpdesc.Text = Impairment_description
                dtpentrydate.Value = date_recorded


                If Medical_condition = True Then
                    chkmedyes.Checked = True
                ElseIf Medical_condition = False Then
                    chkmedno.Checked = True
                End If

                If physical_impairment = True Then
                    chkimpyes.Checked = True
                ElseIf physical_impairment = False Then
                    chkimpno.Checked = True
                End If

            End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception

            MsgBox("Error loading medical info" & ex.Message)

        End Try

    End Sub

    Sub getacademicinfo(ByVal adm As String)

        Try
            Dim guardinfo As String = " Select  count(*) FROm tbl_academicinfo WHERE  admission_no= " + "'" + adm + "'"
            dbConnect(guardinfo)
            con.Open()
            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                Dim medcounter As String = insert_DR.GetValue(0).ToString()
                If medcounter <> "" Then
                    academicinfocounter = CType(medcounter, Integer)
                End If

            End While

            insert_DR.Close()
            con.Close()

            Dim academicinfo As String = " Select  kcpe_index, kcpe_mark, previus_school, kcpe_year FROm tbl_academicinfo WHERE  admission_no= " + "'" + adm + "'"

            dbConnect(academicinfo)
            con.Open()
            insert_DR = com.ExecuteReader
            While insert_DR.Read()
                Dim kcpe_index, kcpe_mark, previus_school, kcpe_year As String

                kcpe_index = insert_DR.GetValue(0).ToString()
                kcpe_mark = insert_DR.GetValue(1).ToString()
                previus_school = insert_DR.GetValue(2).ToString()
                kcpe_year = insert_DR.GetValue(3).ToString()

                txtindex.Text = kcpe_index
                txtkcpemarks.Text = kcpe_mark
                txtprevschool.Text = previus_school
                nmdate.Value = kcpe_year

            End While
            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            MsgBox("Error getting academic info " & ex.Message)
        End Try


    End Sub



    Private Sub cbdsavemedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdsavemedical.Click
        evconditions()

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False


        Try

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If editmode = False Then

                cmd.CommandText = "INSERT INTO medical_info(Admission_no,medical_condition,condition_description,physical_impairment,impairment_description,date_recorded) VALUES(@admno,@medcond,@conddesc,@physicalimp,@impairmentdesc,@daterec)"

                cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                cmd.Parameters.Add("@medcond", SqlDbType.Bit).Value = Me.mediccond
                cmd.Parameters.Add("@conddesc", SqlDbType.NVarChar).Value = Me.txtmeddesc.Text
                cmd.Parameters.Add("@physicalimp", SqlDbType.Bit).Value = Me.impairment
                cmd.Parameters.Add("@impairmentdesc", SqlDbType.NVarChar).Value = Me.txtimpdesc.Text
                cmd.Parameters.Add("@daterec", SqlDbType.Date).Value = Me.dtpentrydate.Value.Date

                cmd.ExecuteNonQuery()

                'MsgBox("Success! student " + lbladmission.Text + " has been registered.", MsgBoxStyle.Information, "Schools Systems")
                MsgBox("Medical Data captured", MsgBoxStyle.Information, "Schools Systems")

            ElseIf editmode = True Then
                If medcount > 0 Then
                    cmd.CommandText = "UPDATE medical_info SET  medical_condition=@medcond, condition_description=@conddesc, physical_impairment=@physicalimp, impairment_description=@impairmentdesc, date_recorded=@daterec WHERE Admission_no= @admno"

                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@medcond", SqlDbType.Bit).Value = Me.mediccond
                    cmd.Parameters.Add("@conddesc", SqlDbType.NVarChar).Value = Me.txtmeddesc.Text
                    cmd.Parameters.Add("@physicalimp", SqlDbType.Bit).Value = Me.impairment
                    cmd.Parameters.Add("@impairmentdesc", SqlDbType.NVarChar).Value = Me.txtimpdesc.Text
                    cmd.Parameters.Add("@daterec", SqlDbType.Date).Value = Me.dtpentrydate.Value.Date

                    cmd.ExecuteNonQuery()

                    MsgBox("Success! medical information successfully updated .", MsgBoxStyle.Information, "Schools Systems")

                ElseIf medcount = 0 Then

                    cmd.CommandText = "INSERT INTO medical_info(Admission_no,medical_condition,condition_description,physical_impairment,impairment_description,date_recorded) VALUES(@admno,@medcond,@conddesc,@physicalimp,@impairmentdesc,@daterec)"
                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@medcond", SqlDbType.Bit).Value = Me.mediccond
                    cmd.Parameters.Add("@conddesc", SqlDbType.NVarChar).Value = Me.txtmeddesc.Text
                    cmd.Parameters.Add("@physicalimp", SqlDbType.Bit).Value = Me.impairment
                    cmd.Parameters.Add("@impairmentdesc", SqlDbType.NVarChar).Value = Me.txtimpdesc.Text
                    cmd.Parameters.Add("@daterec", SqlDbType.Date).Value = Me.dtpentrydate.Value.Date
                    cmd.ExecuteNonQuery()

                    'MsgBox("Success! student " + lbladmission.Text + " has been registered.", MsgBoxStyle.Information, "Schools Systems")
                    MsgBox("Medical Data captured", MsgBoxStyle.Information, "Schools Systems")

                End If
            End If
        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub chkmedyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmedyes.CheckedChanged
        If chkmedno.Checked = False Then
            txtmeddesc.Enabled = True
        End If
    End Sub

    Private Sub chkmedno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmedno.CheckedChanged
        txtmeddesc.Enabled = False
    End Sub

    Private Sub chkimpyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkimpyes.CheckedChanged
        txtimpdesc.Enabled = True
    End Sub

    Private Sub chkimpno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkimpno.CheckedChanged
        txtimpdesc.Enabled = False
    End Sub

    Private Sub btnguardians_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardians.Click

        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False

        Try
            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            If editmode = False Then

                cmd.CommandText = "INSERT INTO guardians(Admission_no,first_name,mothers_name,occupation,mothers_occupation,mobile_no,mothers_mobile_no,postal_box,postal_code,town,email,regdate) VALUES(@admno,@fname,@mothers_name,@occupation,@mothers_occupation,@mobileno,@mothers_mobile_no,@postbox,@postcode,@town,@email,@regdate)"

                cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = Me.txtfathersname.Text
                cmd.Parameters.Add("@mothers_name", SqlDbType.NVarChar).Value = Me.txtmothersname.Text
                cmd.Parameters.Add("@occupation", SqlDbType.NVarChar).Value = Me.txtoccupation.Text
                cmd.Parameters.Add("@mothers_occupation", SqlDbType.NVarChar).Value = Me.txtmothersoccupation.Text
                cmd.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = Me.txtfcontact.Text
                cmd.Parameters.Add("@mothers_mobile_no", SqlDbType.NVarChar).Value = Me.txtmothersno.Text
                cmd.Parameters.Add("@postbox", SqlDbType.NVarChar).Value = Me.txtbox.Text
                cmd.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = Me.txtcode.Text
                cmd.Parameters.Add("@town", SqlDbType.NVarChar).Value = Me.txttown.Text
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtemail.Text
                cmd.Parameters.Add("@regdate", SqlDbType.Date).Value = Me.dtpregdate.Value.Date

                cmd.ExecuteNonQuery()

                MsgBox("Student registration completed  successfully", MsgBoxStyle.Information, "Schools Systems")


            ElseIf editmode = True Then

                If guardiancounter > 0 Then

                    cmd.CommandText = "UPDATE guardians SET  first_name=@fname, mothers_mobile_no=@mothers_mobile_no, mothers_name= @mothers_name,  occupation=@occupation,  mobile_no=@mobileno, postal_box = @postbox, postal_code=@postcode, town=@TOWN, email=@email,regdate= @regdate WHERE Admission_no = @admno"

                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = Me.txtfname.Text
                    cmd.Parameters.Add("@mothers_name", SqlDbType.NVarChar).Value = Me.txtmothersname.Text
                    cmd.Parameters.Add("@mothers_mobile_no", SqlDbType.NVarChar).Value = Me.txtmothersno.Text
                    cmd.Parameters.Add("@occupation", SqlDbType.NVarChar).Value = Me.txtoccupation.Text
                    cmd.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = Me.txtfcontact.Text
                    cmd.Parameters.Add("@postbox", SqlDbType.NVarChar).Value = Me.txtbox.Text
                    cmd.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = Me.txtcode.Text
                    cmd.Parameters.Add("@town", SqlDbType.NVarChar).Value = Me.txttown.Text
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtemail.Text
                    cmd.Parameters.Add("@regdate", SqlDbType.Date).Value = Me.dtpregdate.Value.Date
                    cmd.Parameters.Add("@mothers_occupation", SqlDbType.NVarChar).Value = Me.txtmothersoccupation.Text

                    cmd.ExecuteNonQuery()

                    MsgBox("Student Guardian information updated successfully", MsgBoxStyle.Information, "Schools Systems")

                ElseIf guardiancounter = 0 Then

                    cmd.CommandText = "INSERT INTO guardians(Admission_no,first_name,mothers_name,occupation,mothers_occupation,mobile_no,mothers_mobile_no,postal_box,postal_code,town,email,regdate) VALUES(@admno,@fname,@mothers_name,@occupation,@mothers_occupation,@mobileno,@mothers_mobile_no,@postbox,@postcode,@town,@email,@regdate)"

                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = Me.txtfname.Text
                    cmd.Parameters.Add("@mothers_name", SqlDbType.NVarChar).Value = Me.txtmothersname.Text
                    cmd.Parameters.Add("@mothers_mobile_no", SqlDbType.NVarChar).Value = Me.txtmothersno.Text
                    cmd.Parameters.Add("@occupation", SqlDbType.NVarChar).Value = Me.txtoccupation.Text
                    cmd.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = Me.txtfcontact.Text
                    cmd.Parameters.Add("@postbox", SqlDbType.NVarChar).Value = Me.txtbox.Text
                    cmd.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = Me.txtcode.Text
                    cmd.Parameters.Add("@town", SqlDbType.NVarChar).Value = Me.txttown.Text
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtemail.Text
                    cmd.Parameters.Add("@regdate", SqlDbType.Date).Value = Me.dtpregdate.Value.Date
                    cmd.Parameters.Add("@mothers_occupation", SqlDbType.NVarChar).Value = Me.txtmothersoccupation.Text

                    cmd.ExecuteNonQuery()

                    MsgBox("Student registration completed  successfully", MsgBoxStyle.Information, "Schools Systems")

                End If

            End If

            conn.Close()

            Schoolparentmdi.admission_no = ""

        Catch ex As Exception

            MsgBox(ErrorToString)

        End Try

    End Sub

    Private Sub btnacademic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacademic.Click
        Dim conn As New SqlConnection
        Dim sConnString As String = constr
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty

        Try

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text


            If editmode = False Then

                cmd.CommandText = "INSERT INTO tbl_academicinfo(Admission_no,kcpe_index,kcpe_mark,previus_school,kcpe_year) VALUES(@admno,@kcpeindex,@kcpemarks,@previus_school,@kcpe_year)"
                cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                cmd.Parameters.Add("@kcpeindex", SqlDbType.NVarChar).Value = Me.txtindex.Text
                cmd.Parameters.Add("@kcpemarks", SqlDbType.NVarChar).Value = Me.txtkcpemarks.Text
                cmd.Parameters.Add("@previus_school", SqlDbType.NVarChar).Value = Me.txtprevschool.Text
                cmd.Parameters.Add("@kcpe_year", SqlDbType.Int).Value = Me.nmdate.Value

                cmd.ExecuteNonQuery()

                MsgBox("Student academic information captured", MsgBoxStyle.Information, "Schools Systems")

            ElseIf editmode = True Then
                If academicinfocounter > 0 Then
                    cmd.CommandText = "UPDATE tbl_academicinfo SET kcpe_index = @kcpeindex, kcpe_mark=@kcpemarks, previus_school=@previus_school, kcpe_year=@kcpe_year WHERE Admission_no= @admno"

                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@kcpeindex", SqlDbType.NVarChar).Value = Me.txtindex.Text
                    cmd.Parameters.Add("@kcpemarks", SqlDbType.NVarChar).Value = Me.txtkcpemarks.Text
                    cmd.Parameters.Add("@previus_school", SqlDbType.NVarChar).Value = Me.txtprevschool.Text
                    cmd.Parameters.Add("@kcpe_year", SqlDbType.Int).Value = Me.nmdate.Value

                    cmd.ExecuteNonQuery()

                    MsgBox("Student academic information Updated", MsgBoxStyle.Information, "Schools Systems")

                ElseIf academicinfocounter = 0 Then
                    cmd.CommandText = "INSERT INTO tbl_academicinfo(Admission_no,kcpe_index,kcpe_mark,previus_school,kcpe_year) VALUES(@admno,@kcpeindex,@kcpemarks,@previus_school,@kcpe_year)"
                    cmd.Parameters.Add("@admno", SqlDbType.NVarChar).Value = Me.lbladmission.Text
                    cmd.Parameters.Add("@kcpeindex", SqlDbType.NVarChar).Value = Me.txtindex.Text
                    cmd.Parameters.Add("@kcpemarks", SqlDbType.NVarChar).Value = Me.txtkcpemarks.Text
                    cmd.Parameters.Add("@previus_school", SqlDbType.NVarChar).Value = Me.txtprevschool.Text
                    cmd.Parameters.Add("@kcpe_year", SqlDbType.Int).Value = Me.nmdate.Value
                    cmd.ExecuteNonQuery()
                    MsgBox("Student academic information captured", MsgBoxStyle.Information, "Schools Systems")
                End If
               

            End If

        Catch ex As Exception

            MsgBox(ErrorToString)

        Finally

        End Try

    End Sub

    Private Sub cboroute_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboroute.SelectedIndexChanged
        Try
            If cboroute.Text <> "" Then
                txtrcharge.Text = routecost(cboroute.Text)
                createorder("Transport", txtrcharge.Text, "TERMLY")
            End If
        Catch ex As Exception
            MsgBox("Error getting transport cost:  " & ex.Message)
        End Try

    End Sub


    Private Sub cboroute_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboroute.TextChanged
        'Try
        '    If cboroute.Text <> "" Then
        '        txtrcharge.Text = routecost(cboroute.Text)
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error getting transport cost:  " & ex.Message)
        'End Try
    End Sub
    Sub checknullsinvoteadder()
        If cbovote.Text <> "" Then
            txtamount.Enabled = True
        ElseIf cbovote.Text = "" Then
            txtamount.Enabled = False
        End If

        If txtamount.Text <> "" Then
            cbooccurence.Enabled = True
        ElseIf txtamount.Text = "" Then
            cbooccurence.Enabled = False
        End If
    End Sub
    Private Sub cbovote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovote.SelectedIndexChanged
        checknullsinvoteadder()
    End Sub

    Private Sub cboamount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        checknullsinvoteadder()
    End Sub

    Private Sub cbooccurence_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbooccurence.SelectedIndexChanged
        createorder(cbovote.Text, txtamount.Text, cbooccurence.Text)
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        checknullsinvoteadder()
    End Sub

    Private Sub dgvariables_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvariables.CellClick

        If dgvariables.CurrentCell.OwningColumn.Name = "Del" Then

            Dim vkey As String = dgvariables.CurrentRow.Cells("Vote").Value
            If voteamountdict.ContainsKey(vkey) = True Then
                voteamountdict.Remove(vkey)
                voteoccurdict.Remove(vkey)
            End If
        End If

        createdisplayvar_votes()

    End Sub
    Sub load_report(ByVal adm As String)
        Try

            Cursor = Cursors.WaitCursor
            ' frmstudentview.fill_bIodata()

            frmstudentview.fill_reg_data(txtadmission.Text)
            frmstudentview.fill_academicinfo(txtadmission.Text)
            frmstudentview.fill_guardianinfo(txtadmission.Text)
            frmstudentview.fill_medicalreport(txtadmission.Text)

            Dim regreport As New registrationreport
            regreport.Refresh()
            regreport.SetDataSource(frmstudentview.DSREPORT)

            regreport.SetParameterValue("admission_no", txtadmission.Text)
            regreport.SetParameterValue("schoolid", txtadmission.Text)

            'If cboreportoptions.Text = "Print Report" Then
            '    'classlist.PrintToPrinter(1, False, 0, 0)
            '    PRINTREPORTS(classlist)
            '    whattosay = "Classlist Printed successfully"
            '    MsgBox(classnow & " " & streamnow & " " & whattosay)
            'ElseIf cboreportoptions.Text = "Export Report" Then
            '    Dim SFD As New SaveFileDialog()
            '    SFD.FilterIndex = 2
            '    SFD.RestoreDirectory = True
            '    SFD.FileName = classnow & "_" & streamnow & "_" & yeardate & " classlist.pdf"
            '    If SFD.ShowDialog() = DialogResult.OK Then
            '        CType(classlist, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName)
            '    End If
            '    whattosay = "Classlist Exported successfully"
            '    MsgBox(classnow & " " & streamnow & " " & whattosay)
            'ElseIf cboreportoptions.Text = "View Report" Then

            Dim REPORTTSHOW2 As New frmreports
            REPORTTSHOW2.CrystalReportViewer1.ReportSource = regreport
            REPORTTSHOW2.ShowDialog()

            Cursor = Cursors.Default

            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Cursor = Cursors.WaitCursor

            ' frmstudentview.fill_bIodata()

            frmstudentview.fillschooldetails()
            frmstudentview.fill_reg_data(txtadmission.Text)

            Dim regreport As New registrationreport
            regreport.Refresh()
            regreport.SetDataSource(frmstudentview.DSREPORT)

            regreport.SetParameterValue("admission_no", txtadmission.Text)

            regreport.SetParameterValue("schoolid", 1)

            ''If cboreportoptions.Text = "Print Report" Then
            '    'classlist.PrintToPrinter(1, False, 0, 0)
            '    PRINTREPORTS(classlist)
            '    whattosay = "Classlist Printed successfully"
            '    MsgBox(classnow & " " & streamnow & " " & whattosay)
            'ElseIf cboreportoptions.Text = "Export Report" Then
            '    Dim SFD As New SaveFileDialog()
            '    SFD.FilterIndex = 2
            '    SFD.RestoreDirectory = True
            '    SFD.FileName = classnow & "_" & streamnow & "_" & yeardate & " classlist.pdf"
            '    If SFD.ShowDialog() = DialogResult.OK Then
            '        CType(classlist, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName)
            '    End If
            '    whattosay = "Classlist Exported successfully"
            '    MsgBox(classnow & " " & streamnow & " " & whattosay)
            'ElseIf cboreportoptions.Text = "View Report" Then


            regreportviewer.ReportSource = regreport
          
            Cursor = Cursors.Default

            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub studentdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentdetails.Click

    End Sub
End Class