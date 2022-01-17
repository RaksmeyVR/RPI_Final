<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnTotalScore = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.btnSkill = New System.Windows.Forms.Button()
        Me.btnSemester = New System.Windows.Forms.Button()
        Me.btn_Degree = New System.Windows.Forms.Button()
        Me.btnCampus = New System.Windows.Forms.Button()
        Me.btnAcademic = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.btnStudentInfo = New System.Windows.Forms.Button()
        Me.btnRegiser = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.lbUserType = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnCloseApp = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelHome = New System.Windows.Forms.Label()
        Me.PictureContainer = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        CType(Me.PictureContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelMenu.Controls.Add(Me.btnExit)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnUser)
        Me.PanelMenu.Controls.Add(Me.btnGenerate)
        Me.PanelMenu.Controls.Add(Me.btnTotalScore)
        Me.PanelMenu.Controls.Add(Me.btnScore)
        Me.PanelMenu.Controls.Add(Me.btnSubject)
        Me.PanelMenu.Controls.Add(Me.btnSkill)
        Me.PanelMenu.Controls.Add(Me.btnSemester)
        Me.PanelMenu.Controls.Add(Me.btn_Degree)
        Me.PanelMenu.Controls.Add(Me.btnCampus)
        Me.PanelMenu.Controls.Add(Me.btnAcademic)
        Me.PanelMenu.Controls.Add(Me.btnDepartment)
        Me.PanelMenu.Controls.Add(Me.btnStudentInfo)
        Me.PanelMenu.Controls.Add(Me.btnRegiser)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(244, 585)
        Me.PanelMenu.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_move_left_32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 497)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(244, 33)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "ចាកចេញ / Log Out"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbTime)
        Me.Panel1.Controls.Add(Me.lbDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 561)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 24)
        Me.Panel1.TabIndex = 14
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.BackColor = System.Drawing.Color.Transparent
        Me.lbTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTime.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.Snow
        Me.lbTime.Location = New System.Drawing.Point(15, 0)
        Me.lbTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lbTime.Size = New System.Drawing.Size(8, 16)
        Me.lbTime.TabIndex = 15
        '
        'lbDate
        '
        Me.lbDate.AutoSize = True
        Me.lbDate.BackColor = System.Drawing.Color.Transparent
        Me.lbDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbDate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate.ForeColor = System.Drawing.Color.Snow
        Me.lbDate.Location = New System.Drawing.Point(0, 0)
        Me.lbDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lbDate.Size = New System.Drawing.Size(15, 16)
        Me.lbDate.TabIndex = 14
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Snow
        Me.btnUser.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_users_32
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 464)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(244, 33)
        Me.btnUser.TabIndex = 13
        Me.btnUser.Text = "អ្នកប្រើប្រាស់ / User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.Snow
        Me.btnGenerate.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_users_32
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(0, 431)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnGenerate.Size = New System.Drawing.Size(244, 33)
        Me.btnGenerate.TabIndex = 12
        Me.btnGenerate.Text = "ជំនាន់ / Generate"
        Me.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnTotalScore
        '
        Me.btnTotalScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTotalScore.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTotalScore.FlatAppearance.BorderSize = 0
        Me.btnTotalScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalScore.ForeColor = System.Drawing.Color.Snow
        Me.btnTotalScore.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_report_card_32
        Me.btnTotalScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotalScore.Location = New System.Drawing.Point(0, 398)
        Me.btnTotalScore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTotalScore.Name = "btnTotalScore"
        Me.btnTotalScore.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnTotalScore.Size = New System.Drawing.Size(244, 33)
        Me.btnTotalScore.TabIndex = 11
        Me.btnTotalScore.Text = "ពិន្ទុះសរុប / Total Score"
        Me.btnTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotalScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTotalScore.UseVisualStyleBackColor = True
        '
        'btnScore
        '
        Me.btnScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScore.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnScore.FlatAppearance.BorderSize = 0
        Me.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScore.ForeColor = System.Drawing.Color.Snow
        Me.btnScore.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_report_card_32
        Me.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScore.Location = New System.Drawing.Point(0, 365)
        Me.btnScore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnScore.Size = New System.Drawing.Size(244, 33)
        Me.btnScore.TabIndex = 10
        Me.btnScore.Text = "ការបង់ប្រាក់ / Payment"
        Me.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'btnSubject
        '
        Me.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubject.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubject.FlatAppearance.BorderSize = 0
        Me.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubject.ForeColor = System.Drawing.Color.Snow
        Me.btnSubject.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_elective_32
        Me.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubject.Location = New System.Drawing.Point(0, 332)
        Me.btnSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnSubject.Size = New System.Drawing.Size(244, 33)
        Me.btnSubject.TabIndex = 9
        Me.btnSubject.Text = "មុខវិជ្ជា / Subject"
        Me.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubject.UseVisualStyleBackColor = True
        '
        'btnSkill
        '
        Me.btnSkill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSkill.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSkill.FlatAppearance.BorderSize = 0
        Me.btnSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkill.ForeColor = System.Drawing.Color.Snow
        Me.btnSkill.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_graduation_scroll_32
        Me.btnSkill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSkill.Location = New System.Drawing.Point(0, 299)
        Me.btnSkill.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSkill.Name = "btnSkill"
        Me.btnSkill.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnSkill.Size = New System.Drawing.Size(244, 33)
        Me.btnSkill.TabIndex = 8
        Me.btnSkill.Text = "ជំនាញ / Skill"
        Me.btnSkill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSkill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSkill.UseVisualStyleBackColor = True
        '
        'btnSemester
        '
        Me.btnSemester.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSemester.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSemester.FlatAppearance.BorderSize = 0
        Me.btnSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemester.ForeColor = System.Drawing.Color.Snow
        Me.btnSemester.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_exam_32
        Me.btnSemester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemester.Location = New System.Drawing.Point(0, 266)
        Me.btnSemester.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSemester.Name = "btnSemester"
        Me.btnSemester.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnSemester.Size = New System.Drawing.Size(244, 33)
        Me.btnSemester.TabIndex = 7
        Me.btnSemester.Text = "ឆមាស / Semester"
        Me.btnSemester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSemester.UseVisualStyleBackColor = True
        '
        'btn_Degree
        '
        Me.btn_Degree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Degree.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Degree.FlatAppearance.BorderSize = 0
        Me.btn_Degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Degree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Degree.ForeColor = System.Drawing.Color.Snow
        Me.btn_Degree.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_graduation_scroll_32
        Me.btn_Degree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Degree.Location = New System.Drawing.Point(0, 233)
        Me.btn_Degree.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Degree.Name = "btn_Degree"
        Me.btn_Degree.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btn_Degree.Size = New System.Drawing.Size(244, 33)
        Me.btn_Degree.TabIndex = 6
        Me.btn_Degree.Text = "កម្រិតសិក្សា / Degree"
        Me.btn_Degree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Degree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Degree.UseVisualStyleBackColor = True
        '
        'btnCampus
        '
        Me.btnCampus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCampus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCampus.FlatAppearance.BorderSize = 0
        Me.btnCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCampus.ForeColor = System.Drawing.Color.Snow
        Me.btnCampus.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_school_32
        Me.btnCampus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCampus.Location = New System.Drawing.Point(0, 200)
        Me.btnCampus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCampus.Name = "btnCampus"
        Me.btnCampus.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnCampus.Size = New System.Drawing.Size(244, 33)
        Me.btnCampus.TabIndex = 5
        Me.btnCampus.Text = "ព័ត៌មានសាលា / Campus"
        Me.btnCampus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCampus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCampus.UseVisualStyleBackColor = True
        '
        'btnAcademic
        '
        Me.btnAcademic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcademic.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAcademic.FlatAppearance.BorderSize = 0
        Me.btnAcademic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcademic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcademic.ForeColor = System.Drawing.Color.Snow
        Me.btnAcademic.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_mortarboard_32
        Me.btnAcademic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcademic.Location = New System.Drawing.Point(0, 167)
        Me.btnAcademic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAcademic.Name = "btnAcademic"
        Me.btnAcademic.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnAcademic.Size = New System.Drawing.Size(244, 33)
        Me.btnAcademic.TabIndex = 4
        Me.btnAcademic.Text = "ឆ្នាំសិក្សា / Academic"
        Me.btnAcademic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcademic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcademic.UseVisualStyleBackColor = True
        '
        'btnDepartment
        '
        Me.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDepartment.FlatAppearance.BorderSize = 0
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.Snow
        Me.btnDepartment.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_department_32
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.Location = New System.Drawing.Point(0, 134)
        Me.btnDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnDepartment.Size = New System.Drawing.Size(244, 33)
        Me.btnDepartment.TabIndex = 3
        Me.btnDepartment.Text = "ដេប៉ាតឺម៉ង់ / Department"
        Me.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDepartment.UseVisualStyleBackColor = True
        '
        'btnStudentInfo
        '
        Me.btnStudentInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentInfo.FlatAppearance.BorderSize = 0
        Me.btnStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentInfo.ForeColor = System.Drawing.Color.Snow
        Me.btnStudentInfo.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_more_info_32
        Me.btnStudentInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentInfo.Location = New System.Drawing.Point(0, 101)
        Me.btnStudentInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStudentInfo.Name = "btnStudentInfo"
        Me.btnStudentInfo.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnStudentInfo.Size = New System.Drawing.Size(244, 33)
        Me.btnStudentInfo.TabIndex = 2
        Me.btnStudentInfo.Text = "ព័ត៌មាននិស្សិត / Students"
        Me.btnStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentInfo.UseVisualStyleBackColor = True
        '
        'btnRegiser
        '
        Me.btnRegiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegiser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegiser.FlatAppearance.BorderSize = 0
        Me.btnRegiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegiser.ForeColor = System.Drawing.Color.Snow
        Me.btnRegiser.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_petition_32__1_
        Me.btnRegiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegiser.Location = New System.Drawing.Point(0, 68)
        Me.btnRegiser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegiser.Name = "btnRegiser"
        Me.btnRegiser.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnRegiser.Size = New System.Drawing.Size(244, 33)
        Me.btnRegiser.TabIndex = 1
        Me.btnRegiser.Text = "ការចុះឈ្មោះ / Register"
        Me.btnRegiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegiser.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.GhostWhite
        Me.PanelLogo.Controls.Add(Me.PictureBoxLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(244, 68)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.LOGO_RPITST
        Me.PictureBoxLogo.Location = New System.Drawing.Point(3, -11)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(239, 85)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.lbUserName)
        Me.PanelTitle.Controls.Add(Me.lbUserType)
        Me.PanelTitle.Controls.Add(Me.LabelTitle)
        Me.PanelTitle.Controls.Add(Me.btnCloseForm)
        Me.PanelTitle.Controls.Add(Me.btnMinimize)
        Me.PanelTitle.Controls.Add(Me.btnMaximize)
        Me.PanelTitle.Controls.Add(Me.btnCloseApp)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(244, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(716, 50)
        Me.PanelTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(428, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ស្វាគមន៍៖"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.Color.Snow
        Me.lbUserName.Location = New System.Drawing.Point(535, 10)
        Me.lbUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(55, 19)
        Me.lbUserName.TabIndex = 6
        Me.lbUserName.Text = "Label2"
        '
        'lbUserType
        '
        Me.lbUserType.AutoSize = True
        Me.lbUserType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserType.ForeColor = System.Drawing.Color.Snow
        Me.lbUserType.Location = New System.Drawing.Point(485, 10)
        Me.lbUserType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUserType.Name = "lbUserType"
        Me.lbUserType.Size = New System.Drawing.Size(55, 19)
        Me.lbUserType.TabIndex = 5
        Me.lbUserType.Text = "Label2"
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(50, 10)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(69, 24)
        Me.LabelTitle.TabIndex = 4
        Me.LabelTitle.Text = "ទំព័រដើម"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCloseForm
        '
        Me.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseForm.FlatAppearance.BorderSize = 0
        Me.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseForm.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_home_48
        Me.btnCloseForm.Location = New System.Drawing.Point(4, 6)
        Me.btnCloseForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(40, 39)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_minimize_window_35
        Me.btnMinimize.Location = New System.Drawing.Point(626, 2)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 28)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_maximize_window_35
        Me.btnMaximize.Location = New System.Drawing.Point(657, 2)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(26, 28)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnCloseApp
        '
        Me.btnCloseApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseApp.FlatAppearance.BorderSize = 0
        Me.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseApp.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_close_window_35
        Me.btnCloseApp.Location = New System.Drawing.Point(688, 2)
        Me.btnCloseApp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(26, 28)
        Me.btnCloseApp.TabIndex = 0
        Me.btnCloseApp.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.GhostWhite
        Me.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContainer.Controls.Add(Me.Label1)
        Me.PanelContainer.Controls.Add(Me.LabelHome)
        Me.PanelContainer.Controls.Add(Me.PictureContainer)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(244, 50)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(716, 535)
        Me.PanelContainer.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(156, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "វិទ្យាស្ថានពហុបច្ចេកទេសភូមភាគតេជោសែនតាកែវ"
        '
        'LabelHome
        '
        Me.LabelHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHome.AutoSize = True
        Me.LabelHome.BackColor = System.Drawing.Color.Transparent
        Me.LabelHome.Font = New System.Drawing.Font("Khmer OS Muol", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHome.ForeColor = System.Drawing.Color.Brown
        Me.LabelHome.Location = New System.Drawing.Point(88, 50)
        Me.LabelHome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHome.Name = "LabelHome"
        Me.LabelHome.Size = New System.Drawing.Size(563, 37)
        Me.LabelHome.TabIndex = 1
        Me.LabelHome.Text = "REGIONAL POLYTECHNIC INSTITUTE TECHO SEN TAKEO"
        Me.LabelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureContainer
        '
        Me.PictureContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureContainer.BackColor = System.Drawing.Color.Transparent
        Me.PictureContainer.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.RPI_LOGO_Last_edit_ok
        Me.PictureContainer.Location = New System.Drawing.Point(182, 117)
        Me.PictureContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureContainer.Name = "PictureContainer"
        Me.PictureContainer.Size = New System.Drawing.Size(375, 366)
        Me.PictureContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureContainer.TabIndex = 0
        Me.PictureContainer.TabStop = False
        '
        'Timer1
        '
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 585)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_main"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        CType(Me.PictureContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnScore As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents btnSkill As Button
    Friend WithEvents btnSemester As Button
    Friend WithEvents btn_Degree As Button
    Friend WithEvents btnCampus As Button
    Friend WithEvents btnAcademic As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents btnStudentInfo As Button
    Friend WithEvents btnRegiser As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnCloseApp As Button
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelHome As Label
    Friend WithEvents PictureContainer As PictureBox
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnUser As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnTotalScore As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbTime As Label
    Friend WithEvents lbDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbUserType As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
End Class
