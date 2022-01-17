Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frm_student
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
    '    LabelStudentname.ForeColor = ThemeColor.PrimaryColor
    '    LabelGender.ForeColor = ThemeColor.SecondaryColor
    '    LabelPOB.ForeColor = ThemeColor.PrimaryColor
    '    LabelNameEn.ForeColor = ThemeColor.SecondaryColor
    '    LabelPhone.ForeColor = ThemeColor.PrimaryColor
    '    LabelDOB.ForeColor = ThemeColor.SecondaryColor
    '    LabelAddress.ForeColor = ThemeColor.PrimaryColor
    '    DataGridView.BackgroundColor = ThemeColor.SecondaryColor
    'End Sub

    Private Sub frm_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadTheme()
        LoadGrid()
        'headdvg()
        autoid()
        autoidst()

        Gendershow()
        Nationshow()
    End Sub

#Region "Auto ID"
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtID.Text = sql.getMaxID("tbl_register", "id", "RPI-00000000", 5, 9)
    End Sub
    Sub autoidst()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtIDStudent.Text = sql.getMaxID("tbl_student", "idst", "ST-00000000", 4, 9)
    End Sub
#End Region

#Region "Save data in form"
    'Private Sub Insert()
    '    ' ADD SQL PARAMS & RUN THE COMMAND
    '    Dim fname As String = txtNameEn.Text & ".jpg"
    '    Dim folder As String = "D:\Files\Register"
    '    Dim folders As String = "D:\Files\Student"

    '    sql.AddParam("@id", txtID.Text)
    '    sql.AddParam("@idst", txtIDStudent.Text)
    '    sql.AddParam("@namekh", txtNameKH.Text)
    '    sql.AddParam("@nameen", txtNameEn.Text)
    '    sql.AddParam("@gender", CmbGender.Text)
    '    sql.AddParam("@dob", DtpDOB.Text)
    '    sql.AddParam("@nation", CmbNation.Text)
    '    sql.AddParam("@phone", txtPhone.Text)
    '    sql.AddParam("@email", txtEmail.Text)
    '    sql.AddParam("@pobpro", CmbProPob.Text)
    '    sql.AddParam("@pobdistrict", CmbDisrictPob.Text)
    '    sql.AddParam("@pobcommune", CmbCommunePob.Text)
    '    sql.AddParam("@pobvillage", CmbVillagePob.Text)
    '    sql.AddParam("@parentname", txtParentName.Text)
    '    sql.AddParam("@relateparent", txtParentRelate.Text)
    '    sql.AddParam("@parentphone", txtParentPhone.Text)
    '    sql.AddParam("@addpro", CmbAddPro.Text)
    '    sql.AddParam("@adddistric", CmbAddDistrict.Text)
    '    sql.AddParam("@addcommune", CmbAddCommune.Text)
    '    sql.AddParam("@addvillage", CmbAddVillage.Text)
    '    'sql.AddParam("@year", CmbYear.Text)
    '    'sql.AddParam("@semester", CmbSemester.Text)
    '    'sql.AddParam("@generate", CmbGenerate.Text)
    '    'sql.AddParam("@academic", CmbAcademic.Text)
    '    'sql.AddParam("@department", CmbDepartment.Text)
    '    'sql.AddParam("@skill", CmbSkill.Text)
    '    'sql.AddParam("@degree", CmbDegree.Text)
    '    'sql.AddParam("@studyshift", CmbStudyShift.Text)
    '    sql.AddParam("@hisdegree", CmbHistoryDegree.Text)
    '    sql.AddParam("@hisdegreeno", txtDegreeno.Text)
    '    sql.AddParam("@hishighschool", txtHisHighSchool.Text)
    '    sql.AddParam("@hispro", CmbHisPro.Text)
    '    sql.AddParam("@primschool", txtPrimarySchool.Text)
    '    sql.AddParam("@primpro", CmbPrimaProvince.Text)
    '    sql.AddParam("@primyear", txtPrimYear.Text)
    '    sql.AddParam("@primdegree", txtPrimaDegreeGot.Text)
    '    sql.AddParam("@secondschool", txtSecondarySchool.Text)
    '    sql.AddParam("@secondpro", CmbSecondPro.Text)
    '    sql.AddParam("@secondyear", txtSecondYear.Text)
    '    sql.AddParam("@seconddegree", txtSecondDegreeGot.Text)
    '    sql.AddParam("@highschool", txtHighSchool.Text)
    '    sql.AddParam("@highpro", CmbHighProvince.Text)
    '    sql.AddParam("@highyear", txtHighYear.Text)
    '    sql.AddParam("@highdegree", txtHighDegreeGot.Text)
    '    sql.AddParam("@university", txtUniversity.Text)
    '    sql.AddParam("@univerpro", CmbUniverPro.Text)
    '    sql.AddParam("@univeryear", txtUniverYear.Text)
    '    sql.AddParam("@univerdegree", txtUniverDegreeGot.Text)

    '    sql.AddParam("@picture", fname)





    '    'sql.AddParam("@img", fname)
    '    'sql.AddParam("@category", Cmb_Category.SelectedValue)
    '    'sql.AddParam("@material", Cmb_Material.SelectedValue)



    '    sql.ExecQuery("INSERT INTO tbl_register " &
    '                  "VALUES (@id,@idst,@namekh,@nameen,@gender,@dob,@nation,@phone,@email,@pobpro,@pobdistrict,@pobcommune,@pobvillage,@parentname,@relateparent,@parentphone,@addpro,@adddistric,@addcommune,@addvillage,@year,@semester,@generate,@academic,@department,@skill,@degree,@studyshift,@hisdegree,@hisdegreeno,@hishighschool,@hispro,@primschool,@primpro,@primyear,@primdegree,@secondschool,@secondpro,@secondyear,@seconddegree,@highschool,@highpro,@highyear,@highdegree,@university,@univerpro,@univeryear,@univerdegree,@picture);", True)

    '    Dim pathstring As String = System.IO.Path.Combine(folders, fname)
    '    Dim a As Image = PicLogo.Image
    '    a.Save(pathstring)

    '    'Table Student
    '    sql.AddParam("@idst", txtIDStudent.Text)
    '    sql.AddParam("@namekh", txtNameKH.Text)
    '    sql.AddParam("@nameen", txtNameEn.Text)
    '    sql.AddParam("@gender", CmbGender.Text)
    '    sql.AddParam("@dob", DtpDOB.Text)
    '    sql.AddParam("@nation", CmbNation.Text)
    '    sql.AddParam("@phone", txtPhone.Text)
    '    sql.AddParam("@email", txtEmail.Text)
    '    sql.AddParam("@pobpro", CmbProPob.Text)
    '    sql.AddParam("@pobdistrict", CmbDisrictPob.Text)
    '    sql.AddParam("@pobcommune", CmbCommunePob.Text)
    '    sql.AddParam("@pobvillage", CmbVillagePob.Text)
    '    sql.AddParam("@parentname", txtParentName.Text)
    '    sql.AddParam("@relateparent", txtParentRelate.Text)
    '    sql.AddParam("@parentphone", txtParentPhone.Text)
    '    sql.AddParam("@addpro", CmbAddPro.Text)
    '    sql.AddParam("@adddistric", CmbAddDistrict.Text)
    '    sql.AddParam("@addcommune", CmbAddCommune.Text)
    '    sql.AddParam("@addvillage", CmbAddVillage.Text)
    '    sql.AddParam("@hisdegree", CmbHistoryDegree.Text)
    '    sql.AddParam("@hisdegreeno", txtDegreeno.Text)
    '    sql.AddParam("@hishighschool", txtHisHighSchool.Text)
    '    sql.AddParam("@hispro", CmbHisPro.Text)
    '    sql.AddParam("@primschool", txtPrimarySchool.Text)
    '    sql.AddParam("@primpro", CmbPrimaProvince.Text)
    '    sql.AddParam("@primyear", txtPrimYear.Text)
    '    sql.AddParam("@primdegree", txtPrimaDegreeGot.Text)
    '    sql.AddParam("@secondschool", txtSecondarySchool.Text)
    '    sql.AddParam("@secondpro", CmbSecondPro.Text)
    '    sql.AddParam("@secondyear", txtSecondYear.Text)
    '    sql.AddParam("@seconddegree", txtSecondDegreeGot.Text)
    '    sql.AddParam("@highschool", txtHighSchool.Text)
    '    sql.AddParam("@highpro", CmbHighProvince.Text)
    '    sql.AddParam("@highyear", txtHighYear.Text)
    '    sql.AddParam("@highdegree", txtHighDegreeGot.Text)
    '    sql.AddParam("@university", txtUniversity.Text)
    '    sql.AddParam("@univerpro", CmbUniverPro.Text)
    '    sql.AddParam("@univeryear", txtUniverYear.Text)
    '    sql.AddParam("@univerdegree", txtUniverDegreeGot.Text)

    '    sql.AddParam("@picture", fname)

    '    sql.ExecQuery("INSERT INTO tbl_student " &
    '                  "VALUES (@idst,@namekh,@nameen,@gender,@dob,@nation,@phone,@email,@pobpro,@pobdistrict,@pobcommune,@pobvillage,@parentname,@relateparent,@parentphone,@addpro,@adddistric,@addcommune,@addvillage,@hisdegree,@hisdegreeno,@hishighschool,@hispro,@primschool,@primpro,@primyear,@primdegree,@secondschool,@secondpro,@secondyear,@seconddegree,@highschool,@highpro,@highyear,@highdegree,@university,@univerpro,@univeryear,@univerdegree,@picture);", True)
    '    Dim pathstrings As String = System.IO.Path.Combine(folders, fname)
    '    Dim img As Image = PicLogo.Image
    '    img.Save(pathstrings)


    '    ' REPORT & ABORT ON ERRORS
    '    If sql.HasException(True) Then Exit Sub

    '    'If SQL.dt.Rows.Count > 0 Then
    '    '    Dim r As DataRow = SQL.dt.Rows(0)
    '    '    MsgBox(r("LastID").ToString)
    '    'End If
    '    MsgBox("ការបញ្ចូលទិន្នន័យថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ការជូនដំណឹង")
    '    'LoadGrid()
    '    'autoid()
    'End Sub

    Private Sub Update()
        ' ADD SQL PARAMS & RUN THE COMMAND
        Dim fname As String = txtNameEn.Text & ".jpg"
        Dim folder As String = "D:\Files\Register"
        Dim folders As String = "D:\Files\Student"

        'Update Table Register
        sql.AddParam("@id", txtID.Text)
        sql.AddParam("@idst", txtIDStudent.Text)
        sql.AddParam("@namekh", txtNameKH.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@dob", DtpDOB.Text)
        sql.AddParam("@nation", CmbNation.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@email", txtEmail.Text)
        sql.AddParam("@pobpro", CmbProPob.Text)
        sql.AddParam("@pobdistrict", CmbDisrictPob.Text)
        sql.AddParam("@pobcommune", CmbCommunePob.Text)
        sql.AddParam("@pobvillage", CmbVillagePob.Text)
        sql.AddParam("@parentname", txtParentName.Text)
        sql.AddParam("@relateparent", txtParentRelate.Text)
        sql.AddParam("@parentphone", txtParentPhone.Text)
        sql.AddParam("@addpro", CmbAddPro.Text)
        sql.AddParam("@adddistric", CmbAddDistrict.Text)
        sql.AddParam("@addcommune", CmbAddCommune.Text)
        sql.AddParam("@addvillage", CmbAddVillage.Text)
        'sql.AddParam("@year", CmbYear.Text)
        'sql.AddParam("@semester", CmbSemester.Text)
        'sql.AddParam("@generate", CmbGenerate.Text)
        'sql.AddParam("@academic", CmbAcademic.Text)
        'sql.AddParam("@department", CmbDepartment.Text)
        'sql.AddParam("@skill", CmbSkill.Text)
        'sql.AddParam("@degree", CmbDegree.Text)
        'sql.AddParam("@studyshift", CmbStudyShift.Text)
        sql.AddParam("@hisdegree", CmbHistoryDegree.Text)
        sql.AddParam("@hisdegreeno", txtDegreeno.Text)
        sql.AddParam("@hishighschool", txtHisHighSchool.Text)
        sql.AddParam("@hispro", CmbHisPro.Text)
        sql.AddParam("@primschool", txtPrimarySchool.Text)
        sql.AddParam("@primpro", CmbPrimaProvince.Text)
        sql.AddParam("@primyear", txtPrimYear.Text)
        sql.AddParam("@primdegree", txtPrimaDegreeGot.Text)
        sql.AddParam("@secondschool", txtSecondarySchool.Text)
        sql.AddParam("@secondpro", CmbSecondPro.Text)
        sql.AddParam("@secondyear", txtSecondYear.Text)
        sql.AddParam("@seconddegree", txtSecondDegreeGot.Text)
        sql.AddParam("@highschool", txtHighSchool.Text)
        sql.AddParam("@highpro", CmbHighProvince.Text)
        sql.AddParam("@highyear", txtHighYear.Text)
        sql.AddParam("@highdegree", txtHighDegreeGot.Text)
        sql.AddParam("@university", txtUniversity.Text)
        sql.AddParam("@univerpro", CmbUniverPro.Text)
        sql.AddParam("@univeryear", txtUniverYear.Text)
        sql.AddParam("@univerdegree", txtUniverDegreeGot.Text)

        sql.AddParam("@picture", fname)





        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_register​​​ SET idst = @idst, nameKH = @nameKH,nameEN = @nameEN,gender = @gender,dob = @dob,nation = @nation,phone = @phone, email = @email,pobpro = @pobpro,pobdistrict = @pobdistrict,pobcommune = @pobcommune,pobvillage = @pobvillage,parentname = @parentname,relateparent = @relateparent ,parentphone = @parentphone, addpro = @addpro,adddistric = @adddistric,addcommune = @addcommune,addvillage = @addvillage,hisdegree = @hisdegree,hisdegreeno = @hisdegreeno,hishighschool = @hishighschool,hispro = @hispro,primschool = @primschool,primpro = @primpro,primyear = @primyear,primdegree = @primdegree,secondschool = @secondschool,secondpro = @secondpro,secondyear = @secondyear,seconddegree = @seconddegree,highschool = @highschool,highpro = @highpro,highdegree = @highdegree,university = @university,univerpro = @univerpro,univeryear = @univeryear,univerdegree = @univerdegree,picture = @picture WHERE id=@id ")
        Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        Dim a As Image = PicLogo.Image
        a.Save(pathstring)

        'Table Student
        sql.AddParam("@idst", txtIDStudent.Text)
        sql.AddParam("@idregis", txtID.Text)
        sql.AddParam("@namekh", txtNameKH.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        sql.AddParam("@gender", CmbGender.Text)
        sql.AddParam("@dob", DtpDOB.Text)
        sql.AddParam("@nation", CmbNation.Text)
        sql.AddParam("@phone", txtPhone.Text)
        sql.AddParam("@email", txtEmail.Text)
        sql.AddParam("@pobpro", CmbProPob.Text)
        sql.AddParam("@pobdistrict", CmbDisrictPob.Text)
        sql.AddParam("@pobcommune", CmbCommunePob.Text)
        sql.AddParam("@pobvillage", CmbVillagePob.Text)
        sql.AddParam("@parentname", txtParentName.Text)
        sql.AddParam("@relateparent", txtParentRelate.Text)
        sql.AddParam("@parentphone", txtParentPhone.Text)
        sql.AddParam("@addpro", CmbAddPro.Text)
        sql.AddParam("@adddistric", CmbAddDistrict.Text)
        sql.AddParam("@addcommune", CmbAddCommune.Text)
        sql.AddParam("@addvillage", CmbAddVillage.Text)
        sql.AddParam("@hisdegree", CmbHistoryDegree.Text)
        sql.AddParam("@hisdegreeno", txtDegreeno.Text)
        sql.AddParam("@hishighschool", txtHisHighSchool.Text)
        sql.AddParam("@hispro", CmbHisPro.Text)
        sql.AddParam("@primschool", txtPrimarySchool.Text)
        sql.AddParam("@primpro", CmbPrimaProvince.Text)
        sql.AddParam("@primyear", txtPrimYear.Text)
        sql.AddParam("@primdegree", txtPrimaDegreeGot.Text)
        sql.AddParam("@secondschool", txtSecondarySchool.Text)
        sql.AddParam("@secondpro", CmbSecondPro.Text)
        sql.AddParam("@secondyear", txtSecondYear.Text)
        sql.AddParam("@seconddegree", txtSecondDegreeGot.Text)
        sql.AddParam("@highschool", txtHighSchool.Text)
        sql.AddParam("@highpro", CmbHighProvince.Text)
        sql.AddParam("@highyear", txtHighYear.Text)
        sql.AddParam("@highdegree", txtHighDegreeGot.Text)
        sql.AddParam("@university", txtUniversity.Text)
        sql.AddParam("@univerpro", CmbUniverPro.Text)
        sql.AddParam("@univeryear", txtUniverYear.Text)
        sql.AddParam("@univerdegree", txtUniverDegreeGot.Text)

        sql.AddParam("@picture", fname)





        'sql.AddParam("@img", fname)
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("Update tbl_student​​​ SET  idregis = @idregis,nameKH = @nameKH,nameEN = @nameEN,gender = @gender,dob = @dob,nation = @nation,phone = @phone, email = @email,pobpro = @pobpro,pobdistrict = @pobdistrict,pobcommune = @pobcommune,pobvillage = @pobvillage,parentname = @parentname,relateparent = @relateparent ,parentphone = @parentphone, addpro = @addpro,adddistric = @adddistric,addcommune = @addcommune,addvillage = @addvillage,hisdegree = @hisdegree,hisdegreeno = @hisdegreeno,hishighschool = @hishighschool,hispro = @hispro,primschool = @primschool,primpro = @primpro,primyear = @primyear,primdegree = @primdegree,secondschool = @secondschool,secondpro = @secondpro,secondyear = @secondyear,seconddegree = @seconddegree,highschool = @highschool,highpro = @highpro,highdegree = @highdegree,university = @university,univerpro = @univerpro,univeryear = @univeryear,univerdegree = @univerdegree,picture = @picture WHERE idst=@idst ")
        Dim pathstrings As String = System.IO.Path.Combine(folders, fname)
        Dim img As Image = PicLogo.Image
        img.Save(pathstrings)

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
            DelString += "DELETE FROM tbl_register WHERE id= @id ;"

            sql.ExecQuery(DelString)


            Dim DelStrings As String = "" ' query string builder
            sql.AddParam("@idst", txtIDStudent.Text)
            DelStrings += "DELETE FROM tbl_student WHERE idst= @idst ;"

            sql.ExecQuery(DelStrings)
            ' REPORT & ABORT ON ERRORS
            If sql.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបទិន្នន័យបានជោគជ័យ!")
            ''LoadGrid()
            ''autoid()
            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub
    Private Sub reset()
        txtNameKH.Text = ""
        txtNameEn.Text = ""
        CmbGender.Text = ""
        CmbNation.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        CmbProPob.Text = ""
        CmbDisrictPob.Text = ""
        CmbCommunePob.Text = ""
        CmbVillagePob.Text = ""
        txtParentName.Text = ""
        txtParentRelate.Text = ""
        txtParentPhone.Text = ""
        CmbAddPro.Text = ""
        CmbAddDistrict.Text = ""
        CmbAddCommune.Text = ""
        CmbAddVillage.Text = ""
        'CmbYear.Text = ""
        'CmbSemester.Text = ""
        'CmbGenerate.Text = ""
        'CmbAcademic.Text = ""
        'CmbDepartment.Text = ""
        'CmbDegree.Text = ""
        'CmbStudyShift.Text = ""
        CmbHistoryDegree.Text = ""
        txtDegreeno.Text = ""
        txtHisHighSchool.Text = ""
        CmbHisPro.Text = ""
        txtPrimarySchool.Text = ""
        CmbPrimaProvince.Text = ""
        txtPrimYear.Text = ""
        txtPrimaDegreeGot.Text = ""
        txtSecondarySchool.Text = ""
        CmbSecondPro.Text = ""
        txtSecondYear.Text = ""
        txtSecondDegreeGot.Text = ""
        txtHighSchool.Text = ""
        CmbHighProvince.Text = ""
        txtHighYear.Text = ""
        txtHighDegreeGot.Text = ""
        txtUniversity.Text = ""
        CmbUniverPro.Text = ""
        txtUniverYear.Text = ""
        txtUniverDegreeGot.Text = ""
        txtNameKH.Focus()
        PicLogo.Image = Nothing
        txtNameKH.Focus()

        autoid()
        autoidst()
        Gendershow()
        Nationshow()
    End Sub
#End Region

#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_student")
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
            Me.txtIDStudent.Text = row.Cells("idst").Value.ToString
            Me.txtID.Text = row.Cells("idregis").Value.ToString
            Me.txtNameKH.Text = row.Cells("nameKH").Value.ToString
            Me.txtNameEn.Text = row.Cells("nameEN").Value.ToString
            Me.CmbGender.Text = row.Cells("gender").Value.ToString
            Me.DtpDOB.Text = row.Cells("dob").Value.ToString
            Me.CmbNation.Text = row.Cells("nation").Value.ToString
            Me.txtPhone.Text = row.Cells("phone").Value.ToString
            Me.txtEmail.Text = row.Cells("email").Value.ToString
            Me.CmbProPob.Text = row.Cells("pobpro").Value.ToString
            Me.CmbDisrictPob.Text = row.Cells("pobdistrict").Value.ToString
            Me.CmbCommunePob.Text = row.Cells("pobcommune").Value.ToString
            Me.CmbVillagePob.Text = row.Cells("pobvillage").Value.ToString
            Me.txtParentName.Text = row.Cells("parentname").Value.ToString
            Me.txtParentRelate.Text = row.Cells("relateparent").Value.ToString
            Me.txtParentPhone.Text = row.Cells("parentphone").Value.ToString
            Me.CmbAddPro.Text = row.Cells("addpro").Value.ToString
            Me.CmbAddDistrict.Text = row.Cells("adddistric").Value.ToString
            Me.CmbAddCommune.Text = row.Cells("addcommune").Value.ToString
            Me.CmbAddVillage.Text = row.Cells("addvillage").Value.ToString
            Me.CmbHistoryDegree.Text = row.Cells("hisdegree").Value.ToString
            Me.txtDegreeno.Text = row.Cells("hisdegreeno").Value.ToString
            Me.txtHisHighSchool.Text = row.Cells("hishighschool").Value.ToString
            Me.CmbHisPro.Text = row.Cells("hispro").Value.ToString
            Me.txtPrimarySchool.Text = row.Cells("primschool").Value.ToString
            Me.CmbPrimaProvince.Text = row.Cells("primpro").Value.ToString
            Me.txtPrimYear.Text = row.Cells("primyear").Value.ToString
            Me.txtPrimaDegreeGot.Text = row.Cells("primdegree").Value.ToString
            Me.txtSecondarySchool.Text = row.Cells("secondschool").Value.ToString
            Me.CmbSecondPro.Text = row.Cells("secondpro").Value.ToString
            Me.txtSecondYear.Text = row.Cells("secondyear").Value.ToString
            Me.txtSecondDegreeGot.Text = row.Cells("seconddegree").Value.ToString
            Me.txtHighSchool.Text = row.Cells("highschool").Value.ToString
            Me.CmbHighProvince.Text = row.Cells("highpro").Value.ToString
            Me.txtHighYear.Text = row.Cells("highyear").Value.ToString
            Me.txtHighDegreeGot.Text = row.Cells("highdegree").Value.ToString
            Me.txtUniversity.Text = row.Cells("university").Value.ToString
            Me.CmbUniverPro.Text = row.Cells("univerpro").Value.ToString
            Me.txtUniverYear.Text = row.Cells("univeryear").Value.ToString
            Me.txtUniverDegreeGot.Text = row.Cells("univerdegree").Value.ToString
        End If
        sql.Pic_Student(PicLogo, "Select picture from tbl_student  where idst = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub

    'Sub headdvg()
    '    DGV_Data.Columns(0).HeaderText = "លេខសម្កាល់និស្សិត"
    '    DGV_Data.Columns(1).HeaderText = "លេខសម្គាល់ចុះឈ្មោះ"
    '    DGV_Data.Columns(2).HeaderText = "គោត្តនាម-នាម"
    '    DGV_Data.Columns(3).HeaderText = "ជាអក្សរឡាតាំង"
    '    DGV_Data.Columns(4).HeaderText = "ភេទ"
    '    DGV_Data.Columns(5).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
    '    DGV_Data.Columns(6).HeaderText = "សញ្ជាតិ"
    '    DGV_Data.Columns(7).HeaderText = "លេខទូរស័ព្ទផ្ទាល់ខ្លួន"
    '    DGV_Data.Columns(8).HeaderText = "អ៊ីម៉ែល"
    '    DGV_Data.Columns(9).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(10).HeaderText = "ស្រុក/ខណ្ឌ"
    '    DGV_Data.Columns(11).HeaderText = "ឃុំ/សង្កាត់"
    '    DGV_Data.Columns(12).HeaderText = "ភូមិ"
    '    DGV_Data.Columns(13).HeaderText = "ឈ្មោះអាណាព្យាបាល"
    '    DGV_Data.Columns(14).HeaderText = "អាណាព្យាបាលត្រូវជា"
    '    DGV_Data.Columns(15).HeaderText = "លេខទូរស័ព្ទ"
    '    DGV_Data.Columns(16).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(17).HeaderText = "ស្រុក/ខណ្ឌ"
    '    DGV_Data.Columns(18).HeaderText = "ឃុំ/សង្កាត់"
    '    DGV_Data.Columns(19).HeaderText = "ភូមិ"
    '    ''DGV_Data.Columns(20).HeaderText = "ចូលរៀនឆ្នាំទី"
    '    ''DGV_Data.Columns(21).HeaderText = "ឆមាស"
    '    ''DGV_Data.Columns(22).HeaderText = "ជំនាន់"
    '    ''DGV_Data.Columns(23).HeaderText = "ឆ្នាំសិក្សា"
    '    ''DGV_Data.Columns(24).HeaderText = "ដេប៉ាតឺម៉ង់"
    '    ''DGV_Data.Columns(25).HeaderText = "ជំនាញ/វិជ្ជាជីវះ"
    '    ''DGV_Data.Columns(26).HeaderText = "កម្រិតសិក្សា"
    '    ''DGV_Data.Columns(27).HeaderText = "វេនសិក្សា"
    '    DGV_Data.Columns(20).HeaderText = "កម្រិតវប្បធម៌"
    '    DGV_Data.Columns(21).HeaderText = "លេខកូដសញ្ញាបត្រ"
    '    DGV_Data.Columns(22).HeaderText = "មកពីវិទ្យាល័យ"
    '    DGV_Data.Columns(23).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(24).HeaderText = "បឋមសិក្សា"
    '    DGV_Data.Columns(25).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(26).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
    '    DGV_Data.Columns(27).HeaderText = "សញ្ញាបត្រទទួលបាន"
    '    DGV_Data.Columns(28).HeaderText = "អនុវិទ្យាល័យ"
    '    DGV_Data.Columns(29).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(30).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
    '    DGV_Data.Columns(31).HeaderText = "សញ្ញាបត្រទទួលបាន"
    '    DGV_Data.Columns(32).HeaderText = "វិទ្យាល័យ"
    '    DGV_Data.Columns(33).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(34).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
    '    DGV_Data.Columns(35).HeaderText = "សញ្ញាបត្រទទួលបាន"
    '    DGV_Data.Columns(36).HeaderText = "មហាវិទ្យាល័យ"
    '    DGV_Data.Columns(37).HeaderText = "ខេត្ត/ក្រុង"
    '    DGV_Data.Columns(38).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
    '    DGV_Data.Columns(39).HeaderText = "សញ្ញាបត្រទទួលបាន"

    '    DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    'End Sub


#End Region

#Region "Event Click"
    'Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
    '    Insert()
    '    reset()
    '    autoid()
    '    autoidst()
    '    LoadGrid()
    '    headdvg()
    'End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
        reset()
        autoid()
        autoidst()
        LoadGrid()
        ' headdvg()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        reset()
        autoid()
        autoidst()
        LoadGrid()
        'headdvg()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
        autoid()
        autoidst()
        LoadGrid()
        'headdvg()
    End Sub

    Private Sub btnBroweImg_Click(sender As Object, e As EventArgs) Handles btnBroweImg.Click
        sql.browsImg(PicLogo)
    End Sub


#End Region


#Region "Combobox Show"
    Private Sub Gendershow()
        If CmbGender.Items.Count > 1 Then
            CmbGender.SelectedIndex = -1
            CmbGender.SelectedText = "--ជ្រើសរើសភេទ--"
        End If
    End Sub
    Private Sub Nationshow()
        CmbNation.SelectedText = "--ជ្រើសរើសសញ្ជាតិ--"
    End Sub

#End Region
End Class