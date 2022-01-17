<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_totalscore
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DtpDob = New System.Windows.Forms.DateTimePicker()
        Me.CmbAcademic = New System.Windows.Forms.ComboBox()
        Me.CmbGenerate = New System.Windows.Forms.ComboBox()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbSemester = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbDegree = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpExam = New System.Windows.Forms.DateTimePicker()
        Me.CmbSkill = New System.Windows.Forms.ComboBox()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.CmbStuName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label_Semester = New System.Windows.Forms.Label()
        Me.Label_Academic = New System.Windows.Forms.Label()
        Me.Label_Studentname = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbSub1 = New System.Windows.Forms.ComboBox()
        Me.CmbSub2 = New System.Windows.Forms.ComboBox()
        Me.CmbSub3 = New System.Windows.Forms.ComboBox()
        Me.CmbSub4 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbSub5 = New System.Windows.Forms.ComboBox()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore4 = New System.Windows.Forms.TextBox()
        Me.txtScore5 = New System.Windows.Forms.TextBox()
        Me.txtScore10 = New System.Windows.Forms.TextBox()
        Me.txtScore9 = New System.Windows.Forms.TextBox()
        Me.txtScore8 = New System.Windows.Forms.TextBox()
        Me.txtScore7 = New System.Windows.Forms.TextBox()
        Me.txtScore6 = New System.Windows.Forms.TextBox()
        Me.CmbSub10 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbSub9 = New System.Windows.Forms.ComboBox()
        Me.CmbSub8 = New System.Windows.Forms.ComboBox()
        Me.CmbSub7 = New System.Windows.Forms.ComboBox()
        Me.CmbSub6 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.lbgrade = New System.Windows.Forms.Label()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Data.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Data.Location = New System.Drawing.Point(0, 495)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(955, 163)
        Me.DGV_Data.TabIndex = 118
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Snow
        Me.btnReset.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_reset_28_1
        Me.btnReset.Location = New System.Drawing.Point(824, 443)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 46)
        Me.btnReset.TabIndex = 151
        Me.btnReset.Text = "សម្អាត"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Snow
        Me.btnDelete.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_delete_bin_28
        Me.btnDelete.Location = New System.Drawing.Point(700, 443)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 46)
        Me.btnDelete.TabIndex = 150
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdate.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_update_28
        Me.btnUpdate.Location = New System.Drawing.Point(576, 443)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 46)
        Me.btnUpdate.TabIndex = 149
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInsert.FlatAppearance.BorderSize = 2
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInsert.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Snow
        Me.btnInsert.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_insert_28
        Me.btnInsert.Location = New System.Drawing.Point(452, 443)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(120, 46)
        Me.btnInsert.TabIndex = 148
        Me.btnInsert.Text = "បញ្ជូល"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.DtpDob)
        Me.Panel1.Controls.Add(Me.CmbAcademic)
        Me.Panel1.Controls.Add(Me.CmbGenerate)
        Me.Panel1.Controls.Add(Me.CmbYear)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CmbSemester)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CmbDegree)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DtpExam)
        Me.Panel1.Controls.Add(Me.CmbSkill)
        Me.Panel1.Controls.Add(Me.CmbGender)
        Me.Panel1.Controls.Add(Me.CmbStuName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label_Semester)
        Me.Panel1.Controls.Add(Me.Label_Academic)
        Me.Panel1.Controls.Add(Me.Label_Studentname)
        Me.Panel1.Controls.Add(Me.Label_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 224)
        Me.Panel1.TabIndex = 152
        '
        'DtpDob
        '
        Me.DtpDob.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpDob.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDob.Location = New System.Drawing.Point(650, 146)
        Me.DtpDob.Name = "DtpDob"
        Me.DtpDob.Size = New System.Drawing.Size(263, 33)
        Me.DtpDob.TabIndex = 190
        '
        'CmbAcademic
        '
        Me.CmbAcademic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbAcademic.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAcademic.FormattingEnabled = True
        Me.CmbAcademic.Location = New System.Drawing.Point(650, 111)
        Me.CmbAcademic.Name = "CmbAcademic"
        Me.CmbAcademic.Size = New System.Drawing.Size(263, 33)
        Me.CmbAcademic.TabIndex = 189
        '
        'CmbGenerate
        '
        Me.CmbGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbGenerate.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGenerate.FormattingEnabled = True
        Me.CmbGenerate.Location = New System.Drawing.Point(650, 76)
        Me.CmbGenerate.Name = "CmbGenerate"
        Me.CmbGenerate.Size = New System.Drawing.Size(263, 33)
        Me.CmbGenerate.TabIndex = 188
        '
        'CmbYear
        '
        Me.CmbYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbYear.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CmbYear.Location = New System.Drawing.Point(650, 41)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(263, 33)
        Me.CmbYear.TabIndex = 187
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(37, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 26)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "ភេទ"
        '
        'CmbSemester
        '
        Me.CmbSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbSemester.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSemester.FormattingEnabled = True
        Me.CmbSemester.Location = New System.Drawing.Point(199, 183)
        Me.CmbSemester.Name = "CmbSemester"
        Me.CmbSemester.Size = New System.Drawing.Size(263, 33)
        Me.CmbSemester.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(488, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 26)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'CmbDegree
        '
        Me.CmbDegree.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbDegree.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDegree.FormattingEnabled = True
        Me.CmbDegree.Location = New System.Drawing.Point(199, 148)
        Me.CmbDegree.Name = "CmbDegree"
        Me.CmbDegree.Size = New System.Drawing.Size(263, 33)
        Me.CmbDegree.TabIndex = 180
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(37, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 26)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "ឈ្មោះនិស្សិត"
        '
        'DtpExam
        '
        Me.DtpExam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpExam.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpExam.Location = New System.Drawing.Point(650, 6)
        Me.DtpExam.Name = "DtpExam"
        Me.DtpExam.Size = New System.Drawing.Size(263, 33)
        Me.DtpExam.TabIndex = 178
        '
        'CmbSkill
        '
        Me.CmbSkill.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbSkill.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSkill.FormattingEnabled = True
        Me.CmbSkill.Location = New System.Drawing.Point(199, 113)
        Me.CmbSkill.Name = "CmbSkill"
        Me.CmbSkill.Size = New System.Drawing.Size(263, 33)
        Me.CmbSkill.TabIndex = 177
        '
        'CmbGender
        '
        Me.CmbGender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbGender.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.CmbGender.Location = New System.Drawing.Point(199, 78)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(263, 33)
        Me.CmbGender.TabIndex = 176
        '
        'CmbStuName
        '
        Me.CmbStuName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbStuName.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStuName.FormattingEnabled = True
        Me.CmbStuName.Location = New System.Drawing.Point(199, 43)
        Me.CmbStuName.Name = "CmbStuName"
        Me.CmbStuName.Size = New System.Drawing.Size(263, 33)
        Me.CmbStuName.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(488, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "ឆ្នាំសិក្សា"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(488, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 26)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "ឆ្នាំទី"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(488, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 26)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "ជំនាន់"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(37, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 26)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "កម្រិតសសញ្ញាបត្រ"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(199, 8)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(263, 33)
        Me.txtID.TabIndex = 170
        '
        'Label_Semester
        '
        Me.Label_Semester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Semester.AutoSize = True
        Me.Label_Semester.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Semester.ForeColor = System.Drawing.Color.Navy
        Me.Label_Semester.Location = New System.Drawing.Point(37, 186)
        Me.Label_Semester.Name = "Label_Semester"
        Me.Label_Semester.Size = New System.Drawing.Size(60, 26)
        Me.Label_Semester.TabIndex = 169
        Me.Label_Semester.Text = "ឆមាស"
        '
        'Label_Academic
        '
        Me.Label_Academic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Academic.AutoSize = True
        Me.Label_Academic.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Academic.ForeColor = System.Drawing.Color.Navy
        Me.Label_Academic.Location = New System.Drawing.Point(37, 116)
        Me.Label_Academic.Name = "Label_Academic"
        Me.Label_Academic.Size = New System.Drawing.Size(60, 26)
        Me.Label_Academic.TabIndex = 168
        Me.Label_Academic.Text = "ជំនាញ"
        '
        'Label_Studentname
        '
        Me.Label_Studentname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Studentname.AutoSize = True
        Me.Label_Studentname.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Studentname.ForeColor = System.Drawing.Color.Navy
        Me.Label_Studentname.Location = New System.Drawing.Point(488, 9)
        Me.Label_Studentname.Name = "Label_Studentname"
        Me.Label_Studentname.Size = New System.Drawing.Size(108, 26)
        Me.Label_Studentname.TabIndex = 167
        Me.Label_Studentname.Text = "សម័យប្រលង"
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.Navy
        Me.Label_ID.Location = New System.Drawing.Point(37, 11)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(102, 26)
        Me.Label_ID.TabIndex = 166
        Me.Label_ID.Text = "លេខសម្គាល់"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(89, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 26)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "មុខវិជ្ជា"
        '
        'CmbSub1
        '
        Me.CmbSub1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub1.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub1.FormattingEnabled = True
        Me.CmbSub1.Location = New System.Drawing.Point(8, 259)
        Me.CmbSub1.Name = "CmbSub1"
        Me.CmbSub1.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub1.TabIndex = 191
        '
        'CmbSub2
        '
        Me.CmbSub2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub2.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub2.FormattingEnabled = True
        Me.CmbSub2.Location = New System.Drawing.Point(8, 294)
        Me.CmbSub2.Name = "CmbSub2"
        Me.CmbSub2.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub2.TabIndex = 192
        '
        'CmbSub3
        '
        Me.CmbSub3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub3.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub3.FormattingEnabled = True
        Me.CmbSub3.Location = New System.Drawing.Point(8, 329)
        Me.CmbSub3.Name = "CmbSub3"
        Me.CmbSub3.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub3.TabIndex = 193
        '
        'CmbSub4
        '
        Me.CmbSub4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub4.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub4.FormattingEnabled = True
        Me.CmbSub4.Location = New System.Drawing.Point(8, 364)
        Me.CmbSub4.Name = "CmbSub4"
        Me.CmbSub4.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub4.TabIndex = 194
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(274, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 26)
        Me.Label9.TabIndex = 195
        Me.Label9.Text = "ពិន្ទុះ"
        '
        'CmbSub5
        '
        Me.CmbSub5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub5.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub5.FormattingEnabled = True
        Me.CmbSub5.Location = New System.Drawing.Point(8, 399)
        Me.CmbSub5.Name = "CmbSub5"
        Me.CmbSub5.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub5.TabIndex = 196
        '
        'txtScore1
        '
        Me.txtScore1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore1.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore1.Location = New System.Drawing.Point(264, 259)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(71, 33)
        Me.txtScore1.TabIndex = 197
        Me.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore2
        '
        Me.txtScore2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore2.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore2.Location = New System.Drawing.Point(264, 294)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(71, 33)
        Me.txtScore2.TabIndex = 198
        Me.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore3
        '
        Me.txtScore3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore3.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore3.Location = New System.Drawing.Point(264, 329)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(71, 33)
        Me.txtScore3.TabIndex = 199
        Me.txtScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore4
        '
        Me.txtScore4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore4.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore4.Location = New System.Drawing.Point(264, 364)
        Me.txtScore4.Name = "txtScore4"
        Me.txtScore4.Size = New System.Drawing.Size(71, 33)
        Me.txtScore4.TabIndex = 200
        Me.txtScore4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore5
        '
        Me.txtScore5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore5.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore5.Location = New System.Drawing.Point(264, 399)
        Me.txtScore5.Name = "txtScore5"
        Me.txtScore5.Size = New System.Drawing.Size(71, 33)
        Me.txtScore5.TabIndex = 201
        Me.txtScore5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore10
        '
        Me.txtScore10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore10.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore10.Location = New System.Drawing.Point(614, 399)
        Me.txtScore10.Name = "txtScore10"
        Me.txtScore10.Size = New System.Drawing.Size(71, 33)
        Me.txtScore10.TabIndex = 213
        Me.txtScore10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore9
        '
        Me.txtScore9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore9.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore9.Location = New System.Drawing.Point(614, 364)
        Me.txtScore9.Name = "txtScore9"
        Me.txtScore9.Size = New System.Drawing.Size(71, 33)
        Me.txtScore9.TabIndex = 212
        Me.txtScore9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore8
        '
        Me.txtScore8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore8.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore8.Location = New System.Drawing.Point(614, 329)
        Me.txtScore8.Name = "txtScore8"
        Me.txtScore8.Size = New System.Drawing.Size(71, 33)
        Me.txtScore8.TabIndex = 211
        Me.txtScore8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore7
        '
        Me.txtScore7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore7.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore7.Location = New System.Drawing.Point(614, 294)
        Me.txtScore7.Name = "txtScore7"
        Me.txtScore7.Size = New System.Drawing.Size(71, 33)
        Me.txtScore7.TabIndex = 210
        Me.txtScore7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtScore6
        '
        Me.txtScore6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore6.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore6.Location = New System.Drawing.Point(614, 259)
        Me.txtScore6.Name = "txtScore6"
        Me.txtScore6.Size = New System.Drawing.Size(71, 33)
        Me.txtScore6.TabIndex = 209
        Me.txtScore6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbSub10
        '
        Me.CmbSub10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub10.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub10.FormattingEnabled = True
        Me.CmbSub10.Location = New System.Drawing.Point(358, 399)
        Me.CmbSub10.Name = "CmbSub10"
        Me.CmbSub10.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub10.TabIndex = 208
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(625, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 26)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "ពិន្ទុះ"
        '
        'CmbSub9
        '
        Me.CmbSub9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub9.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub9.FormattingEnabled = True
        Me.CmbSub9.Location = New System.Drawing.Point(358, 364)
        Me.CmbSub9.Name = "CmbSub9"
        Me.CmbSub9.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub9.TabIndex = 206
        '
        'CmbSub8
        '
        Me.CmbSub8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub8.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub8.FormattingEnabled = True
        Me.CmbSub8.Location = New System.Drawing.Point(358, 329)
        Me.CmbSub8.Name = "CmbSub8"
        Me.CmbSub8.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub8.TabIndex = 205
        '
        'CmbSub7
        '
        Me.CmbSub7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub7.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub7.FormattingEnabled = True
        Me.CmbSub7.Location = New System.Drawing.Point(358, 294)
        Me.CmbSub7.Name = "CmbSub7"
        Me.CmbSub7.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub7.TabIndex = 204
        '
        'CmbSub6
        '
        Me.CmbSub6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSub6.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSub6.FormattingEnabled = True
        Me.CmbSub6.Location = New System.Drawing.Point(358, 259)
        Me.CmbSub6.Name = "CmbSub6"
        Me.CmbSub6.Size = New System.Drawing.Size(250, 33)
        Me.CmbSub6.TabIndex = 203
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(439, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 26)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "មុខវិជ្ជា"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(794, 259)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(154, 33)
        Me.txtTotal.TabIndex = 215
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(691, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 26)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "ពិន្ទុះសរុប"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(691, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 26)
        Me.Label13.TabIndex = 220
        Me.Label13.Text = "មធ្យមភាគ"
        '
        'txtAverage
        '
        Me.txtAverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAverage.Enabled = False
        Me.txtAverage.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAverage.Location = New System.Drawing.Point(794, 298)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(154, 33)
        Me.txtAverage.TabIndex = 221
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExport.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExport.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnExport.FlatAppearance.BorderSize = 2
        Me.BtnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExport.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.ForeColor = System.Drawing.Color.Snow
        Me.BtnExport.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_insert_28
        Me.BtnExport.Location = New System.Drawing.Point(11, 445)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(120, 42)
        Me.BtnExport.TabIndex = 222
        Me.BtnExport.Text = "Export"
        Me.BtnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExport.UseVisualStyleBackColor = False
        '
        'btnResult
        '
        Me.btnResult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResult.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnResult.FlatAppearance.BorderSize = 2
        Me.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResult.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.ForeColor = System.Drawing.Color.Snow
        Me.btnResult.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_insert_28
        Me.btnResult.Location = New System.Drawing.Point(824, 390)
        Me.btnResult.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(120, 42)
        Me.btnResult.TabIndex = 223
        Me.btnResult.Text = "លទ្ធផល"
        Me.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResult.UseVisualStyleBackColor = False
        '
        'txtgrade
        '
        Me.txtgrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtgrade.Enabled = False
        Me.txtgrade.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrade.Location = New System.Drawing.Point(794, 337)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(154, 33)
        Me.txtgrade.TabIndex = 225
        Me.txtgrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbgrade
        '
        Me.lbgrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbgrade.AutoSize = True
        Me.lbgrade.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrade.ForeColor = System.Drawing.Color.Navy
        Me.lbgrade.Location = New System.Drawing.Point(691, 340)
        Me.lbgrade.Name = "lbgrade"
        Me.lbgrade.Size = New System.Drawing.Size(69, 26)
        Me.lbgrade.TabIndex = 224
        Me.lbgrade.Text = "Grade"
        '
        'frm_totalscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.txtgrade)
        Me.Controls.Add(Me.lbgrade)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtScore10)
        Me.Controls.Add(Me.txtScore9)
        Me.Controls.Add(Me.txtScore8)
        Me.Controls.Add(Me.txtScore7)
        Me.Controls.Add(Me.txtScore6)
        Me.Controls.Add(Me.CmbSub10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmbSub9)
        Me.Controls.Add(Me.CmbSub8)
        Me.Controls.Add(Me.CmbSub7)
        Me.Controls.Add(Me.CmbSub6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtScore5)
        Me.Controls.Add(Me.txtScore4)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.CmbSub5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbSub4)
        Me.Controls.Add(Me.CmbSub3)
        Me.Controls.Add(Me.CmbSub2)
        Me.Controls.Add(Me.CmbSub1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DGV_Data)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_totalscore"
        Me.Text = "ពិន្ទុះសរុប"
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DtpDob As DateTimePicker
    Friend WithEvents CmbAcademic As ComboBox
    Friend WithEvents CmbGenerate As ComboBox
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbSemester As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbDegree As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpExam As DateTimePicker
    Friend WithEvents CmbSkill As ComboBox
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents CmbStuName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label_Semester As Label
    Friend WithEvents Label_Academic As Label
    Friend WithEvents Label_Studentname As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbSub1 As ComboBox
    Friend WithEvents CmbSub2 As ComboBox
    Friend WithEvents CmbSub3 As ComboBox
    Friend WithEvents CmbSub4 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbSub5 As ComboBox
    Friend WithEvents txtScore1 As TextBox
    Friend WithEvents txtScore2 As TextBox
    Friend WithEvents txtScore3 As TextBox
    Friend WithEvents txtScore4 As TextBox
    Friend WithEvents txtScore5 As TextBox
    Friend WithEvents txtScore10 As TextBox
    Friend WithEvents txtScore9 As TextBox
    Friend WithEvents txtScore8 As TextBox
    Friend WithEvents txtScore7 As TextBox
    Friend WithEvents txtScore6 As TextBox
    Friend WithEvents CmbSub10 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbSub9 As ComboBox
    Friend WithEvents CmbSub8 As ComboBox
    Friend WithEvents CmbSub7 As ComboBox
    Friend WithEvents CmbSub6 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents BtnExport As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents lbgrade As Label
End Class
