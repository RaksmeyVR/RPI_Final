Public Class frm_score
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
    '    Label_Score.ForeColor = ThemeColor.PrimaryColor
    '    Label_Grade.ForeColor = ThemeColor.SecondaryColor
    '    Label_GPA.ForeColor = ThemeColor.PrimaryColor
    '    Label_StudentName.ForeColor = ThemeColor.SecondaryColor
    '    Label_Subject.ForeColor = ThemeColor.PrimaryColor
    '    Label_Mention.ForeColor = ThemeColor.SecondaryColor
    '    DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub

    Private Sub frm_score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTheme()
        NameShow()
        SubjectShow()
        LoadGrid()
        headdvg()
        autoid()
    End Sub
#Region "Save data in form"

    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        sql.AddParam("@id", txtID.Text)
        sql.AddParam("@student", CmbStudentName.Text)
        sql.AddParam("@subject", CmbSubject.Text)
        sql.AddParam("@score", txtScore.Text)
        sql.AddParam("@grade", CmbGrade.Text)
        sql.AddParam("@gpa", CmbGPA.Text)
        sql.AddParam("@mention", txtMention.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_score " &
                      "VALUES (@id,@student,@subject,@score,@grade,@gpa,@mention);", True)

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
        sql.AddParam("@student", CmbStudentName.Text)
        sql.AddParam("@subject", CmbSubject.Text)
        sql.AddParam("@score", txtScore.Text)
        sql.AddParam("@grade", CmbGrade.Text)
        sql.AddParam("@gpa", CmbGPA.Text)
        sql.AddParam("@mention", txtMention.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_score SET student = @student,subject = @subject,score = @score,grade = @grade,gpa = @gpa,mention = @mention WHERE id=@id")

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
            DelString += "DELETE FROM tbl_score WHERE id=@id ;"

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
        CmbStudentName.Text = ""
        CmbSubject.Text = ""
        txtScore.Text = ""
        CmbGrade.Text = ""
        CmbGPA.Text = ""
        txtMention.Text = ""
        CmbStudentName.Focus()
    End Sub
#End Region
#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_score")
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
            Me.CmbStudentName.Text = row.Cells("student").Value.ToString
            Me.CmbSubject.Text = row.Cells("subject").Value.ToString
            Me.txtScore.Text = row.Cells("score").Value.ToString
            Me.CmbGrade.Text = row.Cells("grade").Value.ToString
            Me.CmbGPA.Text = row.Cells("gpa").Value.ToString
            Me.txtMention.Text = row.Cells("mention").Value.ToString
        End If
        'sql.Pic_Student(PicLogo, "Select picture from tbl_student  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ឈ្មោះនិស្សិត"
        DGV_Data.Columns(2).HeaderText = "មុខវិជ្ជា"
        DGV_Data.Columns(3).HeaderText = "ពិន្ទុះ"
        DGV_Data.Columns(4).HeaderText = "ចំនាត់ថ្នាក់"
        DGV_Data.Columns(5).HeaderText = "GPA"
        DGV_Data.Columns(6).HeaderText = "Mention"
        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    End Sub
#End Region
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_score", "id", "SC-00000000", 4, 9)
    End Sub

#Region "Event Clicks"
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'Insert()
        'LoadGrid()
        'headdvg()
        'autoid()
        'reset()
        TextalertInsert()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update()
        'LoadGrid()
        'headdvg()
        'autoid()
        'reset()
        TextalertUpdate()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        LoadGrid()
        headdvg()
        autoid()
        reset()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
        autoid()
    End Sub

#End Region

#Region "Combobox Sub"
    Private Sub NameShow()
        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_student")
        sql.da.Fill(dt)
        CmbStudentName.DataSource = dt
        CmbStudentName.DisplayMember = "namekh"
        'CmbStudentName.ValueMember = "id"
    End Sub
    Private Sub SubjectShow()
        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_subject")
        sql.da.Fill(dt)
        CmbSubject.DataSource = dt
        CmbSubject.DisplayMember = "nameen"
        'CmbSubject.ValueMember = "id"
    End Sub



#End Region

    Private Sub TextalertInsert()

        If CmbStudentName.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះនិស្សិត")

            CmbStudentName.Focus()

        ElseIf CmbSubject.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលមុខវិជ្ជា")

            CmbSubject.Focus()

        ElseIf txtScore.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលបញ្ចូលពិន្ទុះ")

            txtScore.Focus()

        ElseIf CmbGrade.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលចំណាត់ថ្នាក់")

            CmbGrade.Focus()

        ElseIf CmbGPA.Text = "" Then
            MessageBox.Show("សូមបញ្ចូល GPA")

            CmbGPA.Focus()

        ElseIf txtMention.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលមូលវាចា")

            txtMention.Focus()

        Else
            Insert()
            LoadGrid()
            headdvg()
            autoid()
            reset()
        End If
    End Sub

    Private Sub TextalertUpdate()

        If CmbStudentName.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះនិស្សិត")
            CmbStudentName.Focus()

        ElseIf CmbSubject.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលមុខវិជ្ជា")
            CmbSubject.Focus()

        ElseIf txtScore.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលបញ្ចូលពិន្ទុះ")
            txtScore.Focus()

        ElseIf CmbGrade.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលចំណាត់ថ្នាក់")
            CmbGrade.Focus()

        ElseIf CmbGPA.Text = "" Then
            MessageBox.Show("សូមបញ្ចូល GPA")
            CmbGPA.Focus()

        ElseIf txtMention.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលមូលវាចា")
            txtMention.Focus()

        Else
            Update()
            LoadGrid()
            headdvg()
            autoid()
            reset()
        End If
    End Sub
End Class