Public Class frm_department
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
    '    LabelID.ForeColor = ThemeColor.SecondaryColor
    '    LabelDeparment.ForeColor = ThemeColor.PrimaryColor
    '    LabelDepartmentEng.ForeColor = ThemeColor.SecondaryColor
    '    LabelDescription.ForeColor = ThemeColor.PrimaryColor
    '    DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub
    Private Sub frm_department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTheme()
        LoadGrid()
        headdvg()
        autoid()
    End Sub

#Region "Save data in form"
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        Sql.AddParam("@id", txtID.Text)
        Sql.AddParam("@nameKH", txtNameKH.Text)
        Sql.AddParam("@nameEN", txtNameEN.Text)
        Sql.AddParam("@description", txtDescription.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_department " &
                      "VALUES (@id,@nameKH,@nameEN,@description);", True)

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("ការបញ្ចូលទិន្នន័យថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
        'LoadGrid()
    End Sub

    Private Sub Update()
        ' ADD SQL PARAMS & RUN THE COMMAND

        Sql.AddParam("@id", txtID.Text)
        Sql.AddParam("@nameKH", txtNameKH.Text)
        Sql.AddParam("@nameEN", txtNameEN.Text)
        Sql.AddParam("@description", txtDescription.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_department SET nameKH= @nameKH,nameEN = @nameEN,description = @description WHERE id=@id")

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

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
            DelString += "DELETE FROM tbl_department WHERE id=@id ;"

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
        txtNameKH.Text = ""
        txtNameEN.Text = ""
        txtDescription.Text = ""
        txtNameKH.Focus()
    End Sub
#End Region

#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_department")
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
            Me.txtNameKH.Text = row.Cells("nameKH").Value.ToString
            Me.txtNameEN.Text = row.Cells("nameEN").Value.ToString
            Me.txtDescription.Text = row.Cells("description").Value.ToString
        End If
        'sql.Pic_Student(PicLogo, "Select picture from tbl_student  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ដេប៉ាតឺន៉ង់"
        DGV_Data.Columns(2).HeaderText = "ជាអក្សាឡាតាំង"
        DGV_Data.Columns(3).HeaderText = "ការពិពណ៌នា"
        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    End Sub
#End Region

#Region "Events Click"
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

    '' Auto ID
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_department", "id", "DPM-000", 5, 4)
    End Sub


    '' No Text Alert in Textbox
    Private Sub TextalertInsert()

        If txtNameKH.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលដេប៉ាតឺម៉ង់")
            txtNameKH.Focus()

        ElseIf txtNameEN.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលជាអក្សរឡាតាំង")
            txtNameEN.Focus()

        ElseIf txtDescription.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលការពិពណ៌នា")
            txtDescription.Focus()

        Else
            Insert()
            LoadGrid()
            headdvg()
            autoid()
            reset()
        End If
    End Sub

    Private Sub TextalertUpdate()

        If txtNameKH.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលដេប៉ាតឺម៉ង់")
            txtNameKH.Focus()

        ElseIf txtNameEN.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលជាអក្សរឡាតាំង")
            txtNameEN.Focus()

        ElseIf txtDescription.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលការពិពណ៌នា")
            txtDescription.Focus()

        Else
            Update()
            LoadGrid()
            headdvg()
            autoid()
            reset()
        End If
    End Sub
End Class