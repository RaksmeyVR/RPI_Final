Public Class frm_register
    Private sql As New SQLControl
    Private Sub frm_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        AcademicShow()
        DegreeShow()
        SkillShow()
        DepartmentShow()
        generateShow()
        'LoadGrid()
    End Sub


    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        txtIDStudent.Text = sql.getMaxID("tbl_student", "id", "ST-00000000", 4, 9)
    End Sub

#Region "Save data in form"
    Private Sub Insert()

    End Sub
    Private Sub Update()
        ' ADD SQL PARAMS & RUN THE COMMAND
        Dim fname As String = txtNameEn.Text & ".jpg"
        Dim folder As String = "D:\Files\Register"
        Dim folders As String = "D:\Files\Student"


        ' sql.AddParam("@id", txtID.Text)
        sql.AddParam("@idst", txtIDStudent.Text)
        sql.AddParam("@namekh", txtNameKH.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        ' sql.AddParam("@gender", CmbGender.Text)
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
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@semester", CmbSemester.Text)
        sql.AddParam("@generate", CmbGenerate.Text)
        sql.AddParam("@academic", CmbAcademic.Text)
        sql.AddParam("@department", CmbDepartment.Text)
        sql.AddParam("@skill", CmbSkill.Text)
        sql.AddParam("@degree", CmbDegree.Text)
        sql.AddParam("@studyshift", CmbStudyShift.Text)
        sql.AddParam("@hisdegree", cmbcertify.Text)
        sql.AddParam("@hisdegreeno", txthighercode.Text)
        sql.AddParam("@hishighschool", txthigher.Text)
        sql.AddParam("@hispro", cmbhigherprovince.Text)
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

        sql.ExecQuery("Update tbl_register​​​ SET idst = @idst, nameKH = @nameKH,nameEN = @nameEN,gender = @gender,dob = @dob,nation = @nation,phone = @phone, email = @email,pobpro = @pobpro,pobdistrict = @pobdistrict,pobcommune = @pobcommune,pobvillage = @pobvillage,parentname = @parentname,relateparent = @relateparent ,parentphone = @parentphone, addpro = @addpro,adddistric = @adddistric,addcommune = @addcommune,addvillage = @addvillage,year = @year,semester = @semester,generate = @generate,academic = @academic,department = @department,skill = @skill,degree = @degree,studyshift = @studyshift,hisdegree = @hisdegree,hisdegreeno = @hisdegreeno,hishighschool = @hishighschool,hispro = @hispro,primschool = @primschool,primpro = @primpro,primyear = @primyear,primdegree = @primdegree,secondschool = @secondschool,secondpro = @secondpro,secondyear = @secondyear,seconddegree = @seconddegree,highschool = @highschool,highpro = @highpro,highdegree = @highdegree,university = @university,univerpro = @univerpro,univeryear = @univeryear,univerdegree = @univerdegree,picture = @picture WHERE id=@id ")
        Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        Dim a As Image = PicLogo.Image
        a.Save(pathstring)

        'Table Student
        sql.AddParam("@idst", txtIDStudent.Text)
        ' sql.AddParam("idregis", txtID.Text)
        sql.AddParam("@namekh", txtNameKH.Text)
        sql.AddParam("@nameen", txtNameEn.Text)
        ' sql.AddParam("@gender", CmbGender.Text)
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
        sql.AddParam("@hisdegree", cmbcertify.Text)
        sql.AddParam("@hisdegreeno", txthighercode.Text)
        sql.AddParam("@hishighschool", txthigher.Text)
        sql.AddParam("@hispro", cmbhigherprovince.Text)
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
            ' Sql.AddParam("@id", txtID.Text)
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
        'txtNameKH.Text = ""
        'txtNameEn.Text = ""
        ''CmbGender.Text = ""
        CmbNation.Text = ""
        'txtPhone.Text = ""
        'txtEmail.Text = ""
        'CmbProPob.Text = ""
        'CmbDisrictPob.Text = ""
        'CmbCommunePob.Text = ""
        'CmbVillagePob.Text = ""
        'txtParentName.Text = ""
        'txtParentRelate.Text = ""
        'txtParentPhone.Text = ""
        'CmbAddPro.Text = ""
        'CmbAddDistrict.Text = ""
        'CmbAddCommune.Text = ""
        'CmbAddVillage.Text = ""
        CmbYear.Text = ""
        CmbSemester.Text = ""
        CmbGenerate.Text = ""
        CmbAcademic.Text = ""
        CmbDepartment.Text = ""
        CmbDegree.Text = ""
        CmbStudyShift.Text = ""
        cmbcertify.Text = ""
        'txtDegreeno.Text = ""
        'txtHisHighSchool.Text = ""
        'CmbHisPro.Text = ""
        'txtPrimarySchool.Text = ""
        'CmbPrimaProvince.Text = ""
        'txtPrimYear.Text = ""
        'txtPrimaDegreeGot.Text = ""
        'txtSecondarySchool.Text = ""
        'CmbSecondPro.Text = ""
        'txtSecondYear.Text = ""
        'txtSecondDegreeGot.Text = ""
        'txtHighSchool.Text = ""
        'CmbHighProvince.Text = ""
        'txtHighYear.Text = ""
        'txtHighDegreeGot.Text = ""
        'txtUniversity.Text = ""
        'CmbUniverPro.Text = ""
        'txtUniverYear.Text = ""
        'txtUniverDegreeGot.Text = ""
        'txtNameKH.Focus()
        'PicLogo.Image = Nothing
        'txtNameKH.Focus()

        autoid()

        'LoadGrid()
        'headdvg()
        'Gendershow()
        Nationshow()
        Yearshow()
        SemesterShow()
        AcademicShow()
        DepartmentShow()
        SkillShow()
        DegreeShow()
        StudyShiftShow()
        generateShow()
    End Sub
#End Region

#Region "Retreive Data in Form"
    'Public Sub LoadGrid(Optional Query As String = "")
    '    If Query = "" Then
    '        sql.ExecQuery("SELECT * FROM v_register")
    '    Else
    '        sql.ExecQuery(Query)
    '    End If

    '    ' ERROR HANDLING
    '    If sql.HasException(True) Then Exit Sub

    '    DGV_Data.DataSource = sql.dt

    'End Sub

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
            'Me.txtID.Text = row.Cells("id").Value.ToString
            Me.txtIDStudent.Text = row.Cells("idst").Value.ToString
            Me.txtNameKH.Text = row.Cells("nameKH").Value.ToString
            Me.txtNameEn.Text = row.Cells("nameEN").Value.ToString
            ' Me.CmbGender.Text = row.Cells("gender").Value.ToString
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
            Me.CmbYear.Text = row.Cells("year").Value.ToString
            Me.CmbSemester.Text = row.Cells("semester").Value.ToString
            Me.CmbGenerate.Text = row.Cells("generate").Value.ToString
            Me.CmbAcademic.Text = row.Cells("academic").Value.ToString
            Me.CmbDepartment.Text = row.Cells("department").Value.ToString
            Me.CmbSkill.Text = row.Cells("skill").Value.ToString
            Me.CmbDegree.Text = row.Cells("degree").Value.ToString
            Me.CmbStudyShift.Text = row.Cells("studyshift").Value.ToString
            Me.cmbcertify.Text = row.Cells("hisdegree").Value.ToString
            Me.txthighercode.Text = row.Cells("hisdegreeno").Value.ToString
            Me.txthigher.Text = row.Cells("hishighschool").Value.ToString
            Me.cmbhigherprovince.Text = row.Cells("hispro").Value.ToString
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
        sql.Pic_Register(PicLogo, "Select picture from tbl_register  where id = '" & Me.DGV_Data.SelectedRows(0).Cells(0).Value & "'")
    End Sub
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "លេខសម្កាល់និស្សិត"
        DGV_Data.Columns(2).HeaderText = "គោត្តនាម-នាម"
        DGV_Data.Columns(3).HeaderText = "ជាអក្សរឡាតាំង"
        DGV_Data.Columns(4).HeaderText = "ភេទ"
        DGV_Data.Columns(5).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        DGV_Data.Columns(6).HeaderText = "សញ្ជាតិ"
        DGV_Data.Columns(7).HeaderText = "លេខទូរស័ព្ទផ្ទាល់ខ្លួន"
        DGV_Data.Columns(8).HeaderText = "អ៊ីម៉ែល"
        DGV_Data.Columns(9).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(10).HeaderText = "ស្រុក/ខណ្ឌ"
        DGV_Data.Columns(11).HeaderText = "ឃុំ/សង្កាត់"
        DGV_Data.Columns(12).HeaderText = "ភូមិ"
        DGV_Data.Columns(13).HeaderText = "ឈ្មោះអាណាព្យាបាល"
        DGV_Data.Columns(14).HeaderText = "អាណាព្យាបាលត្រូវជា"
        DGV_Data.Columns(15).HeaderText = "លេខទូរស័ព្ទ"
        DGV_Data.Columns(16).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(17).HeaderText = "ស្រុក/ខណ្ឌ"
        DGV_Data.Columns(18).HeaderText = "ឃុំ/សង្កាត់"
        DGV_Data.Columns(19).HeaderText = "ភូមិ"
        DGV_Data.Columns(20).HeaderText = "ចូលរៀនឆ្នាំទី"
        DGV_Data.Columns(21).HeaderText = "ឆមាស"
        DGV_Data.Columns(22).HeaderText = "ជំនាន់"
        DGV_Data.Columns(23).HeaderText = "ឆ្នាំសិក្សា"
        DGV_Data.Columns(24).HeaderText = "ដេប៉ាតឺម៉ង់"
        DGV_Data.Columns(25).HeaderText = "ជំនាញ/វិជ្ជាជីវះ"
        DGV_Data.Columns(26).HeaderText = "កម្រិតសិក្សា"
        DGV_Data.Columns(27).HeaderText = "វេនសិក្សា"
        DGV_Data.Columns(28).HeaderText = "កម្រិតវប្បធម៌"
        DGV_Data.Columns(29).HeaderText = "លេខកូដសញ្ញាបត្រ"
        DGV_Data.Columns(30).HeaderText = "មកពីវិទ្យាល័យ"
        DGV_Data.Columns(31).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(32).HeaderText = "បឋមសិក្សា"
        DGV_Data.Columns(33).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(34).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
        DGV_Data.Columns(35).HeaderText = "សញ្ញាបត្រទទួលបាន"
        DGV_Data.Columns(36).HeaderText = "អនុវិទ្យាល័យ"
        DGV_Data.Columns(37).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(38).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
        DGV_Data.Columns(39).HeaderText = "សញ្ញាបត្រទទួលបាន"
        DGV_Data.Columns(40).HeaderText = "វិទ្យាល័យ"
        DGV_Data.Columns(41).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(42).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
        DGV_Data.Columns(43).HeaderText = "សញ្ញាបត្រទទួលបាន"
        DGV_Data.Columns(44).HeaderText = "មហាវិទ្យាល័យ"
        DGV_Data.Columns(45).HeaderText = "ខេត្ត/ក្រុង"
        DGV_Data.Columns(46).HeaderText = "ពីឆ្នាំណាដល់ឆ្នាំណា"
        DGV_Data.Columns(47).HeaderText = "សញ្ញាបត្រទទួលបាន"

        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS New", 10.8F, FontStyle.Bold)
    End Sub


#End Region
#Region "Save"
    Public Sub save()

        'sql.AddParam("@id", txtIDStudent.Text)

        'sql.AddParam("@namekh", txtNameKH.Text)

        'sql.AddParam("@nameen", txtNameEn.Text)

        'sql.AddParam("@gender", RD_Male.Text)


        'sql.AddParam("@dob", DtpDOB.Value)
        'sql.AddParam("@nation", CmbNation.Text)
        'sql.AddParam("@phone", txtPhone.Text)
        'sql.AddParam("@email", txtEmail.Text)
        'sql.AddParam("@village", CmbVillagePob.Text)
        'sql.AddParam("@commune", CmbCommunePob.Text)
        'sql.AddParam("@district", CmbDisrictPob.Text)
        'sql.AddParam("@province", CmbPrimaProvince.Text)
        'sql.AddParam("@address", CmbAddPro.Text)
        'sql.AddParam("@parent", txtParentName.Text)
        'sql.AddParam("@role", txtParentRelate.Text)
        'sql.AddParam("@tel", txtParentPhone.Text)

        'sql.AddParam("@pic", "Picture")


        'sql.ExecQuery("INSERT INTO tbl_student values(@id,@namekh,@nameen,@gender,@dob,@nation,@phone,@email,@village,@commune,@district,@province,@address,@parent,@role,@tel,@pic)", True)




        sql.AddParam("@student", txtIDStudent.Text)
        sql.AddParam("@year", CmbYear.Text)
        sql.AddParam("@semester", CmbSemester.Text)
        sql.AddParam("@batch", CmbGenerate.SelectedValue)
        sql.AddParam("@academic", CmbAcademic.SelectedValue)
        sql.AddParam("@department", CmbDepartment.SelectedValue)
        sql.AddParam("@skill", CmbSkill.SelectedValue)
        sql.AddParam("@degree", CmbDegree.SelectedValue)
        sql.AddParam("@shift", CmbStudyShift.Text)
        sql.AddParam("@certify", cmbcertify.Text)
        sql.AddParam("@code", txthighercode.Text)
        sql.AddParam("@higher", txthigher.Text)
        sql.AddParam("@province", cmbhigherprovince.Text)


        sql.ExecQuery("INSERT INTO tbl_register(student,year,semester,batch,academic,department,skill,degree,shift,certify,code,higher,province)" &
                      "values(@student,@year,@semester,@batch,@academic,@department,@skill,@degree,@shift,@certify,@code,@higher,@province)", True)




        MessageBox.Show("successfull")





    End Sub
#End Region
#Region "Event Click"
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        save()
        autoid()
        reset()
        'LoadGrid()
        'headdvg()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
        reset()
        autoid()

        'LoadGrid()
        headdvg()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        reset()
        autoid()

        'LoadGrid()
        headdvg()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
        autoid()

        'LoadGrid()
        headdvg()
    End Sub

    Private Sub btnBroweImg_Click(sender As Object, e As EventArgs) Handles btnBroweImg.Click
        sql.browsImg(PicLogo)
    End Sub


#End Region

#Region "Combobox Show"

    Private Sub Nationshow()
        CmbNation.SelectedText = "--ជ្រើសរើសសញ្ជាតិ--"
    End Sub
    Private Sub Yearshow()
        CmbYear.SelectedText = "--ជ្រើសរើសឆ្នាំ--"
    End Sub

    Private Sub SemesterShow()
        'Dim dt As New DataTable
        'sql.ExecQuery("SELECT * FROM tbl_semester")
        'sql.da.Fill(dt)
        'CmbSemester.DataSource = dt
        'CmbSemester.DisplayMember = "namekh"
        'CmbSemester.ValueMember = "id"

        If CmbSemester.Items.Count > 1 Then
            CmbSemester.SelectedIndex = -1
            CmbSemester.SelectedText = "--ជ្រើសរើសឆមាស--"
        End If
    End Sub

    Private Sub AcademicShow()
        'Dim dt As New DataTable
        'sql.ExecQuery("SELECT * FROM tbl_academic")
        'sql.da.Fill(dt)
        'CmbAcademic.DataSource = dt
        'CmbAcademic.DisplayMember = "academic"
        'CmbAcademic.ValueMember = "id"
        sql.CMBOX(CmbAcademic, "Select * from tbl_academic", "academic", "id")
        'If CmbAcademic.Items.Count > 1 Then
        '    CmbAcademic.SelectedIndex = -1
        '    CmbAcademic.SelectedText = "--ជ្រើសរើសឆ្នាំសិក្សា--"
        'End If
    End Sub

    Private Sub DepartmentShow()
        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_department")
        sql.da.Fill(dt)
        CmbDepartment.DataSource = dt
        CmbDepartment.DisplayMember = "namekh"
        CmbDepartment.ValueMember = "id"

        If CmbDepartment.Items.Count > 1 Then
            CmbDepartment.SelectedIndex = -1
            CmbDepartment.SelectedText = "--ជ្រើសរើសដេប៉ាតឺម៉ង់--"
        End If
    End Sub

    Private Sub SkillShow()
        Dim dt As New DataTable
        sql.ExecQuery("SELECT * FROM tbl_skill")
        sql.da.Fill(dt)
        CmbSkill.DataSource = dt
        CmbSkill.DisplayMember = "namekh"
        CmbSkill.ValueMember = "id"

        'If CmbSkill.Items.Count > 1 Then
        '    CmbSkill.SelectedIndex = -1
        '    CmbSkill.SelectedText = "--ជ្រើសរើសជំនាញ/វិជ្ជាជីវះ--"
        'End If
    End Sub

    Private Sub DegreeShow()
        sql.CMBOX(CmbDegree, "Select * from tbl_level", "namekh", "id")
        'Dim dt As New DataTable
        'sql.ExecQuery("SELECT * FROM tbl_degree")
        'sql.da.Fill(dt)
        'CmbDegree.DataSource = dt
        'CmbDegree.DisplayMember = "namekh"
        'CmbDegree.ValueMember = "id"

        'If CmbDegree.Items.Count > 1 Then
        '    CmbDegree.SelectedIndex = -1
        '    CmbDegree.SelectedText = "--ជ្រើសរើសកម្រិតសិក្សា--"
        'End If
    End Sub

    Private Sub StudyShiftShow()
        CmbStudyShift.SelectedText = "--ជ្រើសរើសវេនសិក្សា--"
    End Sub

    Private Sub generateShow()
        sql.CMBOX(CmbGenerate, "Select * from tbl_batch", "namekh", "id")
        'If CmbGenerate.Items.Count > 1 Then
        '    CmbGenerate.SelectedIndex = -1
        '    CmbGenerate.SelectedText = "--ជ្រើសរើសជំនាន់--"
        'End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub txthigher_TextChanged(sender As Object, e As EventArgs) Handles txthigher.TextChanged

    End Sub


#End Region
End Class