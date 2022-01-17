<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbSemester = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbGenerate = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbDegree = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbSkill = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbPayFor = New System.Windows.Forms.ComboBox()
        Me.txtMoneyLetter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpDob = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.txtNameEn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.PanelContainer.SuspendLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnExport)
        Me.PanelContainer.Controls.Add(Me.Label15)
        Me.PanelContainer.Controls.Add(Me.txtSearch)
        Me.PanelContainer.Controls.Add(Me.btnReset)
        Me.PanelContainer.Controls.Add(Me.btnDelete)
        Me.PanelContainer.Controls.Add(Me.btnUpdate)
        Me.PanelContainer.Controls.Add(Me.btnInsert)
        Me.PanelContainer.Controls.Add(Me.Label14)
        Me.PanelContainer.Controls.Add(Me.CmbSemester)
        Me.PanelContainer.Controls.Add(Me.Label13)
        Me.PanelContainer.Controls.Add(Me.CmbYear)
        Me.PanelContainer.Controls.Add(Me.Label12)
        Me.PanelContainer.Controls.Add(Me.CmbGenerate)
        Me.PanelContainer.Controls.Add(Me.Label11)
        Me.PanelContainer.Controls.Add(Me.CmbDegree)
        Me.PanelContainer.Controls.Add(Me.Label10)
        Me.PanelContainer.Controls.Add(Me.CmbSkill)
        Me.PanelContainer.Controls.Add(Me.Label9)
        Me.PanelContainer.Controls.Add(Me.CmbPayFor)
        Me.PanelContainer.Controls.Add(Me.txtMoneyLetter)
        Me.PanelContainer.Controls.Add(Me.Label8)
        Me.PanelContainer.Controls.Add(Me.txtMoney)
        Me.PanelContainer.Controls.Add(Me.Label7)
        Me.PanelContainer.Controls.Add(Me.txtPhone)
        Me.PanelContainer.Controls.Add(Me.Label6)
        Me.PanelContainer.Controls.Add(Me.Label5)
        Me.PanelContainer.Controls.Add(Me.DtpDob)
        Me.PanelContainer.Controls.Add(Me.Label4)
        Me.PanelContainer.Controls.Add(Me.CmbGender)
        Me.PanelContainer.Controls.Add(Me.txtNameEn)
        Me.PanelContainer.Controls.Add(Me.Label3)
        Me.PanelContainer.Controls.Add(Me.txtStName)
        Me.PanelContainer.Controls.Add(Me.Label2)
        Me.PanelContainer.Controls.Add(Me.Label1)
        Me.PanelContainer.Controls.Add(Me.DtpDate)
        Me.PanelContainer.Controls.Add(Me.txtID)
        Me.PanelContainer.Controls.Add(Me.Label_ID)
        Me.PanelContainer.Controls.Add(Me.DGV_Data)
        Me.PanelContainer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(955, 658)
        Me.PanelContainer.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExport.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnExport.FlatAppearance.BorderSize = 2
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Snow
        Me.btnExport.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_insert_28
        Me.btnExport.Location = New System.Drawing.Point(703, 300)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(135, 52)
        Me.btnExport.TabIndex = 165
        Me.btnExport.Text = "Export"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(22, 409)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 28)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "ស្វែងរក"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(113, 406)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 35)
        Me.txtSearch.TabIndex = 163
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
        Me.btnReset.Location = New System.Drawing.Point(808, 398)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 50)
        Me.btnReset.TabIndex = 162
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
        Me.btnDelete.Location = New System.Drawing.Point(669, 398)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDelete.Size = New System.Drawing.Size(135, 50)
        Me.btnDelete.TabIndex = 161
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnUpdate.Location = New System.Drawing.Point(530, 398)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 50)
        Me.btnUpdate.TabIndex = 160
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
        Me.btnInsert.Location = New System.Drawing.Point(391, 398)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(135, 50)
        Me.btnInsert.TabIndex = 159
        Me.btnInsert.Text = "បញ្ជូល"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(514, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 28)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "ឆមាស"
        '
        'CmbSemester
        '
        Me.CmbSemester.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSemester.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbSemester.FormattingEnabled = True
        Me.CmbSemester.Location = New System.Drawing.Point(663, 258)
        Me.CmbSemester.Name = "CmbSemester"
        Me.CmbSemester.Size = New System.Drawing.Size(208, 36)
        Me.CmbSemester.TabIndex = 141
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(514, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 28)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "ឆ្នាំទី"
        '
        'CmbYear
        '
        Me.CmbYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbYear.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Items.AddRange(New Object() {"១", "២", "៣", "៤"})
        Me.CmbYear.Location = New System.Drawing.Point(663, 216)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(208, 36)
        Me.CmbYear.TabIndex = 139
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(514, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 28)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "ជំនាន់ទី"
        '
        'CmbGenerate
        '
        Me.CmbGenerate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbGenerate.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbGenerate.FormattingEnabled = True
        Me.CmbGenerate.Location = New System.Drawing.Point(663, 175)
        Me.CmbGenerate.Name = "CmbGenerate"
        Me.CmbGenerate.Size = New System.Drawing.Size(208, 36)
        Me.CmbGenerate.TabIndex = 137
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(514, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 28)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "កម្រិតសញ្ញាបត្រ"
        '
        'CmbDegree
        '
        Me.CmbDegree.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbDegree.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbDegree.FormattingEnabled = True
        Me.CmbDegree.Location = New System.Drawing.Point(663, 134)
        Me.CmbDegree.Name = "CmbDegree"
        Me.CmbDegree.Size = New System.Drawing.Size(280, 36)
        Me.CmbDegree.TabIndex = 135
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(514, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 28)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "សិក្សាផ្នែក"
        '
        'CmbSkill
        '
        Me.CmbSkill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSkill.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbSkill.FormattingEnabled = True
        Me.CmbSkill.Location = New System.Drawing.Point(663, 93)
        Me.CmbSkill.Name = "CmbSkill"
        Me.CmbSkill.Size = New System.Drawing.Size(280, 36)
        Me.CmbSkill.TabIndex = 133
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(514, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 28)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "បង់ចំពោះ"
        '
        'CmbPayFor
        '
        Me.CmbPayFor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbPayFor.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbPayFor.FormattingEnabled = True
        Me.CmbPayFor.Items.AddRange(New Object() {"ថ្លៃសិក្សា", "បញ្ជាក់ការសិក្សា", "បញ្ជាក់ព្រឹត្តិប័ត្រ្តពិន្ទុះ", "ប្រលងសង"})
        Me.CmbPayFor.Location = New System.Drawing.Point(663, 53)
        Me.CmbPayFor.Name = "CmbPayFor"
        Me.CmbPayFor.Size = New System.Drawing.Size(280, 36)
        Me.CmbPayFor.TabIndex = 131
        '
        'txtMoneyLetter
        '
        Me.txtMoneyLetter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMoneyLetter.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtMoneyLetter.Location = New System.Drawing.Point(663, 12)
        Me.txtMoneyLetter.Name = "txtMoneyLetter"
        Me.txtMoneyLetter.Size = New System.Drawing.Size(280, 35)
        Me.txtMoneyLetter.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(514, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 28)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "ជាអក្សរ"
        '
        'txtMoney
        '
        Me.txtMoney.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMoney.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtMoney.Location = New System.Drawing.Point(195, 301)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(208, 35)
        Me.txtMoney.TabIndex = 128
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(16, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 28)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "ទឹកប្រាក់បានបង់សរុប"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(195, 260)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(208, 35)
        Me.txtPhone.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(16, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 28)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "លេទទូរស័ព្ទ"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(16, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 28)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'DtpDob
        '
        Me.DtpDob.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DtpDob.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDob.Location = New System.Drawing.Point(195, 219)
        Me.DtpDob.Name = "DtpDob"
        Me.DtpDob.Size = New System.Drawing.Size(208, 35)
        Me.DtpDob.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(16, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 28)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "ភេទ"
        '
        'CmbGender
        '
        Me.CmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbGender.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.CmbGender.Location = New System.Drawing.Point(195, 177)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(208, 36)
        Me.CmbGender.TabIndex = 121
        '
        'txtNameEn
        '
        Me.txtNameEn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameEn.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtNameEn.Location = New System.Drawing.Point(195, 135)
        Me.txtNameEn.Name = "txtNameEn"
        Me.txtNameEn.Size = New System.Drawing.Size(280, 35)
        Me.txtNameEn.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(16, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 28)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "ជាអក្សរឡាតាំង"
        '
        'txtStName
        '
        Me.txtStName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStName.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtStName.Location = New System.Drawing.Point(195, 94)
        Me.txtStName.Name = "txtStName"
        Me.txtStName.Size = New System.Drawing.Size(280, 35)
        Me.txtStName.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 28)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "គោត្តនាម នាម"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 28)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "កាលបរិច្ឆេទ"
        '
        'DtpDate
        '
        Me.DtpDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DtpDate.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(195, 53)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(280, 35)
        Me.DtpDate.TabIndex = 115
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(195, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(280, 35)
        Me.txtID.TabIndex = 114
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.Navy
        Me.Label_ID.Location = New System.Drawing.Point(16, 15)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(50, 28)
        Me.Label_ID.TabIndex = 113
        Me.Label_ID.Text = "លេខ"
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Data.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Data.Location = New System.Drawing.Point(0, 454)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(955, 204)
        Me.DGV_Data.TabIndex = 74
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.Text = "ការបង់ប្រាក់"
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbSemester As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbGenerate As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CmbDegree As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbSkill As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbPayFor As ComboBox
    Friend WithEvents txtMoneyLetter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpDob As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents txtNameEn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label_ID As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnExport As Button
End Class
