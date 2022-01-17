Public Class frm_user
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
    '    Label_Name.ForeColor = ThemeColor.PrimaryColor
    '    Label_Password.ForeColor = ThemeColor.SecondaryColor
    '    Label_UserType.ForeColor = ThemeColor.PrimaryColor
    '    DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTheme()
        autoid()
        LoadGrid()
        headdvg()
        UserTypeShow()
    End Sub

#Region "Save data in form"
    Private Sub Insert()
        '' ADD SQL PARAMS & RUN THE COMMAND
        'Dim fname As String = txtNameEN.Text & ".jpg"
        'Dim folder As String = "D:\Files\Student"

        sql.AddParam("@iduser", txtID.Text)
        sql.AddParam("@username", txtUsername.Text)
        sql.AddParam("@password", txtPassword.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@lastname", txtLastName.Text)
        sql.AddParam("@firstname", txtFirstName.Text)
        sql.AddParam("@usertype", CmbUserType.Text)
        sql.AddParam("@email", txtEmail.Text)





        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_user " &
                      "VALUES (@iduser,@username,@password,@phone,@lastname,@firstname,@usertype,@email);", True)

        'Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        'Dim a As Image = PicLogo.Image
        'A.Save(pathstring)

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("ការបញ្ចូលទិន្នន័យថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
        'LoadGrid()
        'autoid()
    End Sub

    Private Sub Update()
        '' ADD SQL PARAMS & RUN THE COMMAND
        'Dim fname As String = txtNameEN.Text & ".jpg"
        'Dim folder As String = "D:\Files\Student"

        sql.AddParam("@iduser", txtID.Text)
        sql.AddParam("@username", txtUsername.Text)
        sql.AddParam("@password", txtPassword.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@lastname", txtLastName.Text)
        sql.AddParam("@firstname", txtFirstName.Text)
        sql.AddParam("@usertype", CmbUserType.Text)
        sql.AddParam("@email", txtEmail.Text)

        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_user​​​ SET username = @username,password = @password,phone = @phone,lastname = @lastname,firstname = @firstname,usertype = @usertype, email = @email WHERE iduser=@iduser")
        'Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        'Dim a As Image = PicLogo.Image
        'a.Save(pathstring)

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
            sql.AddParam("@iduser", txtID.Text)
            DelString += "DELETE FROM tbl_user WHERE iduser=@iduser ;"

            sql.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If Sql.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបបានជោគជ័យ!")
            ''LoadGrid()
            ''autoid()
            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub
    Private Sub reset()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        CmbUserType.Text = ""
        txtEmail.Text = ""
        txtUsername.Focus()

        UserTypeShow()
    End Sub
#End Region
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_user", "iduser", "U-0000", 3, 5)
    End Sub

#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_user")
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
            Me.txtID.Text = row.Cells("iduser").Value.ToString
            Me.txtUsername.Text = row.Cells("username").Value.ToString
            Me.txtPassword.Text = row.Cells("password").Value.ToString
            Me.txtPhone.Text = row.Cells("phone").Value.ToString
            Me.txtLastName.Text = row.Cells("lastname").Value.ToString
            Me.txtFirstName.Text = row.Cells("firstname").Value.ToString
            Me.CmbUserType.Text = row.Cells("usertype").Value.ToString
            Me.txtEmail.Text = row.Cells("email").Value.ToString
        End If
        'sql.Pic_Student(PicLogo, "Select picture from tbl_student  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")

        'Me.DGV_Data.SelectedRows(0).Cells(0).Value
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់"
        DGV_Data.Columns(2).HeaderText = "លេខសម្ងាត់"
        DGV_Data.Columns(3).HeaderText = "លេខទូរស័ព្ទ"
        DGV_Data.Columns(4).HeaderText = "គោតត្នាម"
        DGV_Data.Columns(5).HeaderText = "នាមខ្លួន"
        DGV_Data.Columns(6).HeaderText = "ប្រភេទគណនី"
        DGV_Data.Columns(7).HeaderText = "អ៊ីម៉ែល"
        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    End Sub


#End Region

#Region "Events Click"
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Insert()
        LoadGrid()
        headdvg()
        autoid()
        reset()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        LoadGrid()
        headdvg()
        autoid()
        reset()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
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
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql.ExecQuery("Select * FROM tbl_user  WHERE username LIKE '%" & txtSearch.Text & "%' OR lastname LIKE '%" & txtSearch.Text & "%' OR firstname LIKE '%" & txtSearch.Text & "%' ")
        sql.da.SelectCommand = sql.cmd
        Using dt As New DataTable
            sql.da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGV_Data.DataSource = dt
                'Else
                '    MessageBox.Show("ទិន្នន័យនេះមិនមានទេ")
                '    txtSearch.Clear()
            End If
        End Using
    End Sub

    Private Sub UserTypeShow()
        If CmbUserType.Items.Count > 1 Then
            CmbUserType.SelectedIndex = -1
            CmbUserType.SelectedText = "--ជ្រើសរើសប្រភេទគណនី--"
        End If
    End Sub
End Class