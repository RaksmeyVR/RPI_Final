Imports Microsoft.Office.Interop
Public Class Payment
    Private sql As New SQLControl
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_payment", "id", "IV-000000000", 4, 10)
    End Sub

#Region "Save data in form"

    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        sql.AddParam("@id", txtID.Text)
        sql.AddParam("@date", DtpDate.Text)
        sql.AddParam("@stname", txtStName.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@dob", DtpDob.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@money", txtMoney.Text)
        sql.AddParam("@moneyletter", txtMoneyLetter.Text)
        sql.AddParam("@payfor", CmbPayFor.Text)
        sql.AddParam("@skill", CmbSkill.Text)
        sql.AddParam("@degree", CmbDegree.Text)
        sql.AddParam("@generate", CmbGenerate.Text)
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@semester", CmbSemester.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_payment " &
                      "VALUES (@id,@date,@stname,@nameen,@gender,@dob,@phone,@money,@moneyletter,@payfor,@skill,@degree,@generate,@year,@semester);", True)

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
        sql.AddParam("@date", DtpDate.Text)
        sql.AddParam("@stname", txtStName.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@dob", DtpDob.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@money", txtMoney.Text)
        sql.AddParam("@moneyletter", txtMoneyLetter.Text)
        sql.AddParam("@payfor", CmbPayFor.Text)
        sql.AddParam("@skill", CmbSkill.Text)
        sql.AddParam("@degree", CmbDegree.Text)
        sql.AddParam("@generate", CmbGenerate.Text)
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@semester", CmbSemester.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_payment SET date = @date,stname = @stname,nameen = @nameen,gender = @gender,dob = @dob,phone = @phone,money = @money,moneyletter = @moneyletter,payfor = @payfor,skill = @skill,degree = @degree, generate = @generate,year = @year,semester = @semester  WHERE id=@id")

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
            DelString += "DELETE FROM tbl_payment WHERE id=@id ;"

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
        txtStName.Text = ""
        txtNameEn.Text = ""
        CmbGender.Text = ""
        txtPhone.Text = ""
        txtMoney.Text = ""
        txtMoneyLetter.Text = ""
        CmbPayFor.Text = ""
        CmbYear.Text = ""
        txtStName.Focus()

        LoadGrid()
        headdvg()
        autoid()

        Gendershow()
        SkillShow()
        DegreeShow()
        SemesterShow()
        Yearshow()
        PayForshow()
        generateShow()
    End Sub


#End Region
#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_payment")
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
            Me.DtpDate.Text = row.Cells("date").Value.ToString
            Me.txtStName.Text = row.Cells("stname").Value.ToString
            Me.txtNameEn.Text = row.Cells("nameen").Value.ToString
            Me.CmbGender.Text = row.Cells("gender").Value.ToString
            Me.DtpDob.Text = row.Cells("dob").Value.ToString
            Me.txtPhone.Text = row.Cells("phone").Value.ToString
            Me.txtMoney.Text = row.Cells("money").Value.ToString
            Me.txtMoneyLetter.Text = row.Cells("moneyletter").Value.ToString
            Me.CmbPayFor.Text = row.Cells("payfor").Value.ToString
            Me.CmbSkill.Text = row.Cells("skill").Value.ToString
            Me.CmbDegree.Text = row.Cells("degree").Value.ToString
            Me.CmbGenerate.Text = row.Cells("generate").Value.ToString
            Me.CmbYear.Text = row.Cells("year").Value.ToString
            Me.CmbSemester.Text = row.Cells("semester").Value.ToString

        End If
        'sql.Pic_Student(PicLogo, "Select picture from tbl_student  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខ"
        DGV_Data.Columns(1).HeaderText = "កាលបរិច្ឆេទ"
        DGV_Data.Columns(2).HeaderText = "គោត្ត​នាម នាម"
        DGV_Data.Columns(3).HeaderText = "ជាអក្សរឡាតាំង"
        DGV_Data.Columns(4).HeaderText = "ភេទ"
        DGV_Data.Columns(5).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        DGV_Data.Columns(6).HeaderText = "លេទទូរស័ព្ទ"
        DGV_Data.Columns(7).HeaderText = "ទឹកប្រាក់បានបង់សរុប"
        DGV_Data.Columns(8).HeaderText = "ជាអក្សរ"
        DGV_Data.Columns(9).HeaderText = "បង់ចំពោះ"
        DGV_Data.Columns(10).HeaderText = "សិក្សាផ្នែក"
        DGV_Data.Columns(11).HeaderText = "កម្រិតសញ្ញាបត្រ"
        DGV_Data.Columns(12).HeaderText = "ជំនាន់ទី"
        DGV_Data.Columns(13).HeaderText = "ឆ្នាំទី"
        DGV_Data.Columns(14).HeaderText = "ឆមាស"
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Export()
    End Sub
#End Region

#Region "Cmb Show"
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

    Private Sub PayForshow()
        If CmbPayFor.Items.Count > 1 Then
            CmbPayFor.SelectedIndex = -1
            CmbPayFor.SelectedText = "--ជ្រើសរើសបង់ចំពោះ--"
        End If
    End Sub

    Private Sub generateShow()
        sql.CMBOX(CmbGenerate, "Select * from tbl_batch", "namekh", "id")

        If CmbGenerate.Items.Count > 1 Then
            CmbGenerate.SelectedIndex = -1
            CmbGenerate.SelectedText = "--ជ្រើសរើសជំនាន់--"
        End If
    End Sub




#End Region

#Region "Textbox Drop"
    'Private Sub txtStName_TextChanged(sender As Object, e As EventArgs) Handles txtStName.TextChanged
    '    Dim dt As New DataTable
    '    sql.ExecQuery("select namekh from tbl_student")
    '    sql.da = New SqlDataAdapter(sql.cmd)
    '    dt = New DataTable
    '    sql.da.Fill(dt)

    '    Dim col As New AutoCompleteStringCollection

    '    For i As Integer = 0 To sql.dt.Rows.Count - 1
    '        col.Add(dt.Rows(i)("namekh"))
    '    Next

    '    txtStName.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    txtStName.AutoCompleteCustomSource = col
    '    txtStName.AutoCompleteMode = AutoCompleteMode.Suggest
    'End Sub


#End Region

#Region "TextBox Search"
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql.ExecQuery("Select * From tbl_payment WHERE stname LIKE '%" & txtSearch.Text & "%' OR nameen LIKE '%" & txtSearch.Text & "%' OR id LIKE '%" & txtSearch.Text & "%' ")
        sql.da.SelectCommand = sql.cmd

        'sql.da.Fill(sql.dt)
        If sql.dt.Rows.Count > 0 Then
            DGV_Data.DataSource = sql.dt
        End If
    End Sub
#End Region

#Region "Export To Excel"

    Private Sub Export()
        Dim app As New Excel.Application
        'Dim wk As Excel.Workbook = app.Workbooks.Open(Application.StartupPath & "\ExameResult.xlsx", True)
        Dim wk As Excel.Workbook = app.Workbooks.Open("D:\Files\Payment\payment.xlsx", True)
        Dim wh As Excel.Worksheet = app.Worksheets(1)

        wh.Range("J7:K7").Value = txtID.Text
        wh.Range("J9:K9").Value = DtpDate.Text
        wh.Range("D11:F11").Value = txtStName.Text
        wh.Range("I11:K11").Value = txtNameEn.Text
        wh.Range("C13").Value = CmbGender.Text
        wh.Range("F13:G13").Value = DtpDob.Text
        wh.Range("J13:K13").Value = txtPhone.Text
        wh.Range("E15:H15").Value = txtMoney.Text

        wh.Range("D17:H17").Value = txtMoneyLetter.Text
        wh.Range("D19:F19").Value = CmbPayFor.Text
        wh.Range("I19:K19").Value = CmbSkill.Text
        wh.Range("D21:F21").Value = CmbDegree.Text
        wh.Range("I21:J21").Value = CmbGenerate.Text
        wh.Range("C23:D23").Value = CmbYear.Text
        wh.Range("F23:I23").Value = CmbSemester.Text

        wh.Range("J38:K38").Value = txtID.Text
        wh.Range("J40:K40").Value = DtpDate.Text
        wh.Range("D42:F42").Value = txtStName.Text
        wh.Range("I42:K42").Value = txtNameEn.Text
        wh.Range("C44").Value = CmbGender.Text
        wh.Range("F44:G44").Value = DtpDob.Text
        wh.Range("J44:K44").Value = txtPhone.Text
        wh.Range("E46:H46").Value = txtMoney.Text

        wh.Range("D48:H48").Value = txtMoneyLetter.Text
        wh.Range("D50:F50").Value = CmbPayFor.Text
        wh.Range("I50:K50").Value = CmbSkill.Text
        wh.Range("D52:F52").Value = CmbDegree.Text
        wh.Range("I52:J52").Value = CmbGenerate.Text
        wh.Range("C54:D54").Value = CmbYear.Text
        wh.Range("F54:I54").Value = CmbSemester.Text

        app.Visible = True
    End Sub


#End Region

End Class