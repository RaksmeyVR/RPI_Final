Imports System.IO

Public Class frm_campus
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
    '    Label_NameKH.ForeColor = ThemeColor.PrimaryColor
    '    Label_NameEng.ForeColor = ThemeColor.SecondaryColor
    '    Label_Phone.ForeColor = ThemeColor.PrimaryColor
    '    Label_Email.ForeColor = ThemeColor.SecondaryColor
    '    Label_Website.ForeColor = ThemeColor.PrimaryColor
    '    Label_Address.ForeColor = ThemeColor.SecondaryColor
    '    'DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub

    'Private Sub Insert()
    '    ' ADD SQL PARAMS & RUN THE COMMAND

    '    Dim fname As String = txtNameEN.Text & ".jpg"
    '    Dim folder As String = "D:\Files\School"
    '    sql.AddParam("@id", txtID.Text)
    '    sql.AddParam("@namekh", txtNameKH.Text)
    '    sql.AddParam("@nameen", txtNameEN.Text)
    '    sql.AddParam("@tel", txtTel.Text)
    '    sql.AddParam("@email", txtEmail.Text)
    '    sql.AddParam("@address", txtAddress.Text)
    '    sql.AddParam("@website", txtWebsite.Text)
    '    sql.AddParam("@logo", fname)

    '    'sql.AddParam("@img", fname)
    '    'sql.AddParam("@category", Cmb_Category.SelectedValue)
    '    'sql.AddParam("@material", Cmb_Material.SelectedValue)

    '    sql.ExecQuery("INSERT INTO tbl_campus " &
    '                  "VALUES (@id,@namekh,@nameen,@tel,@email,@website,@address,@logo);", True)

    '    Dim pathstring As String = System.IO.Path.Combine(folder, fname)
    '    Dim a As Image = PicLogo.Image
    '    a.Save(pathstring)

    '    ' REPORT & ABORT ON ERRORS
    '    If sql.HasException(True) Then Exit Sub

    '    'If SQL.dt.Rows.Count > 0 Then
    '    '    Dim r As DataRow = SQL.dt.Rows(0)
    '    '    MsgBox(r("LastID").ToString)
    '    'End If
    '    MsgBox("ការបញ្ចូលទិន្នន័យថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
    '    'LoadGrid()
    'End Sub
    Private Sub Update()
        '' ADD SQL PARAMS & RUN THE COMMAND
        Dim fname As String = txtNameEN.Text & ".jpg"
        Dim folder As String = "D:\Files\School"
        sql.AddParam("@id", txtID.Text)
        Sql.AddParam("@namekh", txtNameKH.Text)
        Sql.AddParam("@nameen", txtNameEN.Text)
        sql.AddParam("@tel", txtTel.Text)
        sql.AddParam("@email", txtEmail.Text)
        sql.AddParam("@address", txtAddress.Text)
        sql.AddParam("@website", txtWebsite.Text)
        sql.AddParam("@logo", fname)

        ''sql.AddParam("@img", fname)
        ''sql.AddParam("@category", Cmb_Category.SelectedValue)
        ''sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_campus​​​ SET nameKH = @nameKH,nameEN = @nameEN,tel = @tel,email = @email,address = @address,website = @website, logo = @logo WHERE id=@id")
        Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        Dim a As Image = PicLogo.Image
        a.Save(pathstring)

        '' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        ''If SQL.dt.Rows.Count > 0 Then
        ''    Dim r As DataRow = SQL.dt.Rows(0)
        ''    MsgBox(r("LastID").ToString)
        ''End If
        MsgBox("ការកែប្រែទិន្នន័យបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
        ''LoadGrid()
    End Sub
    Private Sub frm_campus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''LoadTheme()
        Showtext()
    End Sub

#Region "Events Click"

    Private Sub btnBroweImg_Click(sender As Object, e As EventArgs) Handles btnBroweImg.Click
        sql.browsImg(PicLogo)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    'Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
    '    Insert()
    'End Sub
#End Region
    Private Sub Showtext()
        sql.ExecQuery("SELECT * FROM tbl_campus")
        sql.da.Fill(sql.dt)
        If sql.dt.Rows.Count <= 0 Then
            MsgBox("No record")
        Else
            txtID.Text = sql.dt.Rows(0).Item(0).ToString
            txtNameKH.Text = sql.dt.Rows(0).Item(1).ToString
            txtNameEN.Text = sql.dt.Rows(0).Item(2).ToString
            txtTel.Text = sql.dt.Rows(0).Item(3).ToString
            txtEmail.Text = sql.dt.Rows(0).Item(4).ToString
            txtWebsite.Text = sql.dt.Rows(0).Item(5).ToString
            txtAddress.Text = sql.dt.Rows(0).Item(6).ToString
        End If
        sql.Pic_School(PicLogo, "Select logo from tbl_campus  where id = '" & Me.txtID.Text & "'")
    End Sub


End Class