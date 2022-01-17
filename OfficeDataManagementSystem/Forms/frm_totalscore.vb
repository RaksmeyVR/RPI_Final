Imports Microsoft.Office.Interop
Public Class frm_totalscore
    Private sql As New SQLControl
    'Private Sub LoadTheme()
    '    For Each btns As Control In Me.Controls

    '        If btns.[GetType]() = GetType(Button) Then
    '            Dim btn As Button = CType(btns, Button)
    '            btn.BackColor = ThemeColor.PrimaryColor
    '            btn.ForeColor = Color.White
    '            btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor
    '        End If
    '    Next
    '    Label_ID.ForeColor = ThemeColor.SecondaryColor
    '    Label_Semester.ForeColor = ThemeColor.PrimaryColor
    '    Label_Studentname.ForeColor = ThemeColor.SecondaryColor
    '    Label_Academic.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject1.ForeColor = ThemeColor.SecondaryColor
    '    Label_Subject4.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject7.ForeColor = ThemeColor.SecondaryColor
    '    Label_Subject10.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject2.ForeColor = ThemeColor.SecondaryColor
    '    Label_Subject5.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject8.ForeColor = ThemeColor.SecondaryColor
    '    Label_Total.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject3.ForeColor = ThemeColor.SecondaryColor
    '    Label_Subject6.ForeColor = ThemeColor.PrimaryColor
    '    Label_Subject9.ForeColor = ThemeColor.SecondaryColor
    '    Label_Average.ForeColor = ThemeColor.PrimaryColor
    '    DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub

    Private Sub frm_totalscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTheme()
        reset()
    End Sub

    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_total_score", "id", "TS-00000000", 4, 9)
    End Sub

#Region "Save data in form"
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        sql.AddParam("@id", txtID.Text)
        sql.AddParam("@stname", CmbStuName.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@skill", CmbSkill.Text)
        sql.AddParam("@degree", CmbDegree.Text)
        sql.AddParam("@semester", CmbSemester.Text)
        sql.AddParam("@dateexame", DtpExam.Text)
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@generate", CmbGenerate.Text)
        sql.AddParam("@academic", CmbAcademic.Text)
        sql.AddParam("@dob", DtpDob.Text)
        sql.AddParam("@subject1", CmbSub1.Text)
        sql.AddParam("@score1", txtScore1.Text)
        sql.AddParam("@subject2", CmbSub2.Text)
        sql.AddParam("@score2", txtScore2.Text)
        sql.AddParam("@subject3", CmbSub3.Text)
        sql.AddParam("@score3", txtScore3.Text)
        sql.AddParam("@subject4", CmbSub4.Text)
        sql.AddParam("@score4", txtScore4.Text)
        sql.AddParam("@subject5", CmbSub5.Text)
        sql.AddParam("@score5", txtScore5.Text)
        sql.AddParam("@subject6", CmbSub6.Text)
        sql.AddParam("@score6", txtScore6.Text)
        sql.AddParam("@subject7", CmbSub7.Text)
        sql.AddParam("@score7", txtScore7.Text)
        sql.AddParam("@subject8", CmbSub8.Text)
        sql.AddParam("@score8", txtScore8.Text)
        sql.AddParam("@subject9", CmbSub9.Text)
        sql.AddParam("@score9", txtScore9.Text)
        sql.AddParam("@subject10", CmbSub10.Text)
        sql.AddParam("@score10", txtScore10.Text)
        sql.AddParam("@total", txtTotal.Text)
        sql.AddParam("@average", txtAverage.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_total_score " &
                      "VALUES (@id,@stname,@gender,@skill,@degree,@semester,@dateexame,@year,@generate,@academic,@dob,@subject1,@score1,@subject2,@score2,@subject3,@score3,@subject4,@score4,@subject5,@score5,@subject6,@score6,@subject7,@score7,@subject8,@score8,@subject9,@score9,@subject10,@score10,@total,@average);", True)

        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("ការបញ្ចូលទិន្នន័យថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
        'LoadGrid()
    End Sub

    Private Sub Update()
        ' ADD SQL PARAMS & RUN THE COMMAND

        sql.AddParam("@id", txtID.Text)
        sql.AddParam("@stname", CmbStuName.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@skill", CmbSkill.Text)
        sql.AddParam("@degree", CmbDegree.Text)
        sql.AddParam("@semester", CmbSemester.Text)
        sql.AddParam("@dateexame", DtpExam.Text)
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@generate", CmbGenerate.Text)
        sql.AddParam("@academic", CmbAcademic.Text)
        sql.AddParam("@dob", DtpDob.Text)
        sql.AddParam("@subject1", CmbSub1.Text)
        sql.AddParam("@score1", txtScore1.Text)
        sql.AddParam("@subject2", CmbSub2.Text)
        sql.AddParam("@score2", txtScore2.Text)
        sql.AddParam("@subject3", CmbSub3.Text)
        sql.AddParam("@score3", txtScore3.Text)
        sql.AddParam("@subject4", CmbSub4.Text)
        sql.AddParam("@score4", txtScore4.Text)
        sql.AddParam("@subject5", CmbSub5.Text)
        sql.AddParam("@score5", txtScore5.Text)
        sql.AddParam("@subject6", CmbSub6.Text)
        sql.AddParam("@score6", txtScore6.Text)
        sql.AddParam("@subject7", CmbSub7.Text)
        sql.AddParam("@score7", txtScore7.Text)
        sql.AddParam("@subject8", CmbSub8.Text)
        sql.AddParam("@score8", txtScore8.Text)
        sql.AddParam("@subject9", CmbSub9.Text)
        sql.AddParam("@score9", txtScore9.Text)
        sql.AddParam("@subject10", CmbSub10.Text)
        sql.AddParam("@score10", txtScore10.Text)
        sql.AddParam("@total", txtTotal.Text)
        sql.AddParam("@average", txtAverage.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_total_score SET stname = @stname,gender = @gender,skill = @skill,degree = @degree,semester=@semester,dateexame=@dateexame,year=@year,generate=@generate,academic=@academic,dob=@dob,subject1=@subject1,score1=@score1,subject2=@subject2,score2=@score2,subject3=@subject3,score3=@score3,subject4=@subject4,score4=@score4,subject5=@subject5,score5=@score5,subject6=@subject6,score6=@score6,subject7=@subject7,score7=@score7,subject8=@subject8,score8=@score8,subject9=@subject9,score9=@score9,subject10=@subject10,score10=@score10,total=@total,average=@average WHERE id=@id")

        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("ការកែប្រែទិន្នន័យបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
        'LoadGrid()
    End Sub
    Private Sub Delete()
        If MsgBox("តើអ្នកប្រាកដទេថាចង់លុបទិន្នន័យនេះ !?", MsgBoxStyle.YesNo, "លុបទិនន្នន័យ?") = MsgBoxResult.Yes Then
            ' GENERATE A MASS DELETE COMMAND
            Dim DelString As String = "" ' query string builder
            sql.AddParam("@id", txtID.Text)
            DelString += "DELETE FROM tbl_tota;l_score WHERE id=@id ;"

            sql.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If sql.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបបានជោគជ័យ!")
            ''LoadGrid()
            ''autoid()
            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub
    Private Sub reset()
        autoid()
        LoadGrid()
        headdvg()

        CmbGender.Text = ""
        CmbYear.Text = ""
        txtScore1.Text = ""
        txtScore2.Text = ""
        txtScore3.Text = ""
        txtScore4.Text = ""
        txtScore5.Text = ""
        txtScore6.Text = ""
        txtScore7.Text = ""
        txtScore8.Text = ""
        txtScore9.Text = ""
        txtScore10.Text = ""
        txtTotal.Text = ""
        txtAverage.Text = ""
        txtScore1.Focus()


        StudentShow()
        Gendershow()
        SkillShow()
        DegreeShow()
        SemesterShow()
        Yearshow()
        AcademicShow()
        GenerateShow()

        Sub1Show()
        Sub2Show()
        Sub3Show()
        Sub4Show()
        Sub5Show()
        Sub6Show()
        Sub7Show()
        Sub8Show()
        Sub9Show()
        Sub10Show()
    End Sub
#End Region
#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_total_score")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

    End Sub
    'Private Sub loadsession()

    '    Dim str As String = "SELECT material_id,namekh FROM tbl_Material"
    '    Dim da As SqlDataAdapter = New SqlDataAdapter(str, SQL.cn)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Dim bs As BindingSource = New BindingSource
    '    bs.DataSource = dt
    '    Cmb_Material.DataSource = bs
    '    Cmb_Material.DisplayMember = "namekh"
    '    Cmb_Material.ValueMember = "material_id"
    '    'txtstudentid.Text = ""
    '    Me.Cmb_Material.SelectedValue = -1
    'End Sub
    Private Sub LoadCBX(itm As ComboBox, table As String, index As String)
        ' REFRESH COMBOBOX
        itm.Items.Clear()
        ' RUN QUERY
        sql.ExecQuery(table)

        If sql.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In sql.dt.Rows
            itm.Items.Add(r(index).ToString)
        Next
    End Sub

    Private Sub DGV_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Data.CellContentClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = DGV_Data.Rows(e.RowIndex)
            Me.txtID.Text = row.Cells("id").Value.ToString
            Me.CmbStuName.Text = row.Cells("stname").Value.ToString
            Me.CmbGender.Text = row.Cells("gender").Value.ToString
            Me.CmbSkill.Text = row.Cells("skill").Value.ToString
            Me.CmbDegree.Text = row.Cells("degree").Value.ToString
            Me.CmbSemester.Text = row.Cells("semester").Value.ToString
            Me.DtpExam.Text = row.Cells("dateexame").Value.ToString
            Me.CmbYear.Text = row.Cells("year").Value.ToString
            Me.CmbGenerate.Text = row.Cells("generate").Value.ToString
            Me.CmbAcademic.Text = row.Cells("academic").Value.ToString
            Me.DtpDob.Text = row.Cells("dob").Value.ToString
            Me.CmbSub1.Text = row.Cells("subject1").Value.ToString
            Me.txtScore1.Text = row.Cells("score1").Value.ToString
            Me.CmbSub2.Text = row.Cells("subject2").Value.ToString
            Me.txtScore2.Text = row.Cells("score2").Value.ToString
            Me.CmbSub3.Text = row.Cells("subject3").Value.ToString
            Me.txtScore3.Text = row.Cells("score3").Value.ToString

            Me.CmbSub4.Text = row.Cells("subject4").Value.ToString
            Me.txtScore4.Text = row.Cells("score4").Value.ToString
            Me.CmbSub5.Text = row.Cells("subject5").Value.ToString
            Me.txtScore5.Text = row.Cells("score5").Value.ToString
            Me.CmbSub6.Text = row.Cells("subject6").Value.ToString
            Me.txtScore6.Text = row.Cells("score6").Value.ToString

            Me.CmbSub7.Text = row.Cells("subject7").Value.ToString
            Me.txtScore7.Text = row.Cells("score7").Value.ToString
            Me.CmbSub8.Text = row.Cells("subject8").Value.ToString
            Me.txtScore8.Text = row.Cells("score8").Value.ToString
            Me.CmbSub9.Text = row.Cells("subject9").Value.ToString
            Me.txtScore9.Text = row.Cells("score9").Value.ToString

            Me.CmbSub10.Text = row.Cells("subject10").Value.ToString
            Me.txtScore10.Text = row.Cells("score10").Value.ToString
            Me.txtTotal.Text = row.Cells("total").Value.ToString
            Me.txtAverage.Text = row.Cells("average").Value.ToString
        End If
        'sql.Pic_Student(PicLogo, "Select picture from tbl_student  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ឈ្មោះនិស្សិត"
        DGV_Data.Columns(2).HeaderText = "ភេទ"
        DGV_Data.Columns(3).HeaderText = "ជំនាញ"
        DGV_Data.Columns(4).HeaderText = "កម្រិតសញ្ញាបត្រ"
        DGV_Data.Columns(5).HeaderText = "ឆមាស"
        DGV_Data.Columns(6).HeaderText = "សម័យប្រលង"
        DGV_Data.Columns(7).HeaderText = "ឆ្នាំទី"
        DGV_Data.Columns(8).HeaderText = "ជំនាន់ទី"
        DGV_Data.Columns(9).HeaderText = "ឆ្នាំសិក្សា"
        DGV_Data.Columns(10).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        DGV_Data.Columns(11).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(12).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(13).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(14).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(15).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(16).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(17).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(18).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(19).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(20).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(21).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(22).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(23).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(24).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(25).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(26).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(27).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(28).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(29).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(30).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(31).HeaderText = "ពិន្ទុះសរុប"
        DGV_Data.Columns(32).HeaderText = "មធ្យមភាគ"

        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    End Sub

#End Region
#Region "Event Click"
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Insert()
        reset()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
        reset()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        reset()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Export()
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Result()
    End Sub
#End Region
#Region "Cmb Show"
    Private Sub StudentShow()
        'sql.CMBOX(CmbDegree, "Select * from tbl_student", "namekh", "id")

        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_student")
        sql.da.Fill(dt)
        CmbStuName.DataSource = dt
        CmbStuName.DisplayMember = "namekh"
        CmbStuName.ValueMember = "idst"

        If CmbStuName.Items.Count > 1 Then
            CmbStuName.SelectedIndex = -1
            CmbStuName.SelectedText = "--ជ្រើសរើសឈ្មោះនិស្សិត--"
        End If
    End Sub
    Private Sub Gendershow()
        If CmbGender.Items.Count > 1 Then
            CmbGender.SelectedIndex = -1
            CmbGender.SelectedText = "--ជ្រើសរើសភេទ--"
        End If
    End Sub
    Private Sub SkillShow()
        sql.CMBOX(CmbSkill, "Select * from tbl_skill", "namekh", "id")
        If CmbSkill.Items.Count > 1 Then
            CmbSkill.SelectedIndex = -1
            CmbSkill.SelectedText = "--ជ្រើសរើសជំនាញ--"
        End If
    End Sub
    Private Sub DegreeShow()
        sql.CMBOX(CmbDegree, "Select * from tbl_degree", "namekh", "id")
        If CmbDegree.Items.Count > 1 Then
            CmbDegree.SelectedIndex = -1
            CmbDegree.SelectedText = "--ជ្រើសរើសកម្រិតសិក្សា--"
        End If
    End Sub
    Private Sub SemesterShow()
        sql.CMBOX(CmbSemester, "Select * from tbl_semester", "namekh", "id")

        If CmbSemester.Items.Count > 1 Then
            CmbSemester.SelectedIndex = -1
            CmbSemester.SelectedText = "--ជ្រើសរើសឆមាស--"
        End If
    End Sub
    Private Sub Yearshow()
        If CmbYear.Items.Count > 1 Then
            CmbYear.SelectedIndex = -1
            CmbYear.SelectedText = "--ជ្រើសរើសឆ្នាំ--"
        End If
    End Sub
    Private Sub AcademicShow()
        'sql.CMBOX(CmbAcademic, "Select * from tbl_academic", "namekh", "id")

        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_academic")
        sql.da.Fill(dt)
        CmbAcademic.DataSource = dt
        CmbAcademic.DisplayMember = "academic"
        CmbAcademic.ValueMember = "id"
        If CmbAcademic.Items.Count > 1 Then
            CmbAcademic.SelectedIndex = -1
            CmbAcademic.SelectedText = "--ជ្រើសរើសឆ្នាំសិក្សា--"
        End If
    End Sub

    Private Sub GenerateShow()
        sql.CMBOX(CmbGenerate, "Select * from tbl_generate", "namekh", "id")
        If CmbGenerate.Items.Count > 1 Then
            CmbGenerate.SelectedIndex = -1
            CmbGenerate.SelectedText = "--ជ្រើសរើសជំនាន់--"
        End If
    End Sub

    Private Sub Sub1Show()
        sql.CMBOX(CmbSub1, "Select * from tbl_subject", "namekh", "id")
        If CmbSub1.Items.Count > 1 Then
            CmbSub1.SelectedIndex = -1
            CmbSub1.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub2Show()
        sql.CMBOX(CmbSub2, "Select * from tbl_subject", "namekh", "id")
        If CmbSub2.Items.Count > 1 Then
            CmbSub2.SelectedIndex = -1
            CmbSub2.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub3Show()
        sql.CMBOX(CmbSub3, "Select * from tbl_subject", "namekh", "id")
        If CmbSub3.Items.Count > 1 Then
            CmbSub3.SelectedIndex = -1
            CmbSub3.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub4Show()
        sql.CMBOX(CmbSub4, "Select * from tbl_subject", "namekh", "id")
        If CmbSub4.Items.Count > 1 Then
            CmbSub4.SelectedIndex = -1
            CmbSub4.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub5Show()
        sql.CMBOX(CmbSub5, "Select * from tbl_subject", "namekh", "id")
        If CmbSub5.Items.Count > 1 Then
            CmbSub5.SelectedIndex = -1
            CmbSub5.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub6Show()
        sql.CMBOX(CmbSub6, "Select * from tbl_subject", "namekh", "id")
        If CmbSub6.Items.Count > 1 Then
            CmbSub6.SelectedIndex = -1
            CmbSub6.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub7Show()
        sql.CMBOX(CmbSub7, "Select * from tbl_subject", "namekh", "id")
        If CmbSub7.Items.Count > 1 Then
            CmbSub7.SelectedIndex = -1
            CmbSub7.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub8Show()
        sql.CMBOX(CmbSub8, "Select * from tbl_subject", "namekh", "id")
        If CmbSub8.Items.Count > 1 Then
            CmbSub8.SelectedIndex = -1
            CmbSub8.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub9Show()
        sql.CMBOX(CmbSub9, "Select * from tbl_subject", "namekh", "id")
        If CmbSub9.Items.Count > 1 Then
            CmbSub9.SelectedIndex = -1
            CmbSub9.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub
    Private Sub Sub10Show()
        sql.CMBOX(CmbSub10, "Select * from tbl_subject", "namekh", "id")
        If CmbSub10.Items.Count > 1 Then
            CmbSub10.SelectedIndex = -1
            CmbSub10.SelectedText = "--ជ្រើសរើសមុខវិជ្ជា--"
        End If
    End Sub



#End Region

#Region "Export To Excel"
    Private Sub Export()
        Dim app As New Excel.Application
        'Dim wk As Excel.Workbook = app.Workbooks.Open(Application.StartupPath & "\ExameResult.xlsx", True)
        Dim wk As Excel.Workbook = app.Workbooks.Open("D:\Files\ScoreExame\ExameResult.xlsx", True)
        Dim wh As Excel.Worksheet = app.Worksheets(1)

        wh.Range("D10:E10").Value = CmbSemester.Text
        wh.Range("D11:E11").Value = DtpExam.Text
        wh.Range("D12:E12").Value = CmbSkill.Text
        wh.Range("D13:E13").Value = CmbDegree.Text
        'wh.Range("D14:E14").Value = CmbDegree.Text
        'wh.Range("D10:E10").Value = CmbSemester.Text
        'wh.Range("D10:E10").Value = CmbSemester.Text
        'wh.Range("D10:E10").Value = CmbSemester.Text

        app.Visible = True
    End Sub


#End Region

#Region "Textbox Result and..."
    Private Sub Result()
        Dim s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, grade, total As Integer
        Dim per As Double
        s1 = txtScore1.Text
        s2 = txtScore2.Text
        s3 = txtScore3.Text
        s4 = txtScore4.Text
        s5 = txtScore5.Text
        s6 = txtScore6.Text
        s7 = txtScore7.Text
        s8 = txtScore8.Text
        s9 = txtScore9.Text
        s10 = txtScore10.Text

        total = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
        txtTotal.Text = total

        per = txtTotal.Text / 10
        txtAverage.Text = per


        'If txtAverage.Text <= 100 Then
        '    txtGpa.Text = "4.0"
        'ElseIf txtAverage.Text <= 85 Then
        '    txtGpa.Text = "3.7"
        'ElseIf txtAverage.Text <= 80 Then
        '    txtGpa.Text = "3.3"
        'ElseIf txtAverage.Text <= 75 Then
        '    txtGpa.Text = "3.0"
        'ElseIf txtAverage.Text <= 70 Then
        '    txtGpa.Text = "2.7"
        'ElseIf txtAverage.Text <= 65 Then
        '    txtGpa.Text = "2.3"
        'ElseIf txtAverage.Text >= 60 Then
        '    txtGpa.Text = "2.0"
        'ElseIf txtAverage.Text <= 57 Then
        '    txtGpa.Text = "1.7"
        'ElseIf txtAverage.Text <= 54 Then
        '    txtGpa.Text = "1.0"
        'ElseIf txtAverage.Text <= 49 Then
        '    txtGpa.Text = "0.0"
        'End If

        grade = txtTotal.Text
        If grade >= 900 And grade <= 100 Then
            txtgrade.Text = "A"
        ElseIf grade >= 800 Then
            txtgrade.Text = "B"
        ElseIf grade >= 700 Then
            txtgrade.Text = "C"
        ElseIf grade >= 600 Then
            txtgrade.Text = "D"
        ElseIf grade < 600 Then
            txtgrade.Text = "F"
        End If

        'If per >= 85 And per <= 100 Then
        '    txtGpa.Text = "4.0"
        'ElseIf per >= 80 And per <= 84 Then
        '    txtGpa.Text = "3.7"
        'ElseIf per >= 75 And per <= 79 Then
        '    txtGpa.Text = "3.3"
        'ElseIf per >= 70 And per <= 74 Then
        '    txtGpa.Text = "3.0"
        'ElseIf per >= 65 And per <= 69 Then
        '    txtGpa.Text = "2.7"
        'ElseIf per >= 61 And per <= 64 Then
        '    txtGpa.Text = "2.3"
        'ElseIf per >= 58 And per >= 60 Then
        '    txtGpa.Text = "2.0"
        'ElseIf per >= 55 And per <= 57 Then
        '    txtGpa.Text = "1.7"
        'ElseIf per >= 50 And per <= 54 Then
        '    txtGpa.Text = "1.0"
        'ElseIf per >= 0 And per <= 49 Then
        '    txtGpa.Text = "0.0"
        'End If
        Exit Sub
    End Sub


#End Region
End Class