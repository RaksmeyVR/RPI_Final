<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_score
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Label_Mention = New System.Windows.Forms.Label()
        Me.Label_GPA = New System.Windows.Forms.Label()
        Me.Label_Grade = New System.Windows.Forms.Label()
        Me.Label_Subject = New System.Windows.Forms.Label()
        Me.Label_StudentName = New System.Windows.Forms.Label()
        Me.Label_Score = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.CmbStudentName = New System.Windows.Forms.ComboBox()
        Me.CmbSubject = New System.Windows.Forms.ComboBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.CmbGrade = New System.Windows.Forms.ComboBox()
        Me.CmbGPA = New System.Windows.Forms.ComboBox()
        Me.txtMention = New System.Windows.Forms.TextBox()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Data.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Data.Location = New System.Drawing.Point(0, 386)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(955, 272)
        Me.DGV_Data.TabIndex = 73
        '
        'Label_Mention
        '
        Me.Label_Mention.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Mention.AutoSize = True
        Me.Label_Mention.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Mention.ForeColor = System.Drawing.Color.Navy
        Me.Label_Mention.Location = New System.Drawing.Point(504, 143)
        Me.Label_Mention.Name = "Label_Mention"
        Me.Label_Mention.Size = New System.Drawing.Size(89, 28)
        Me.Label_Mention.TabIndex = 69
        Me.Label_Mention.Text = "Mention"
        '
        'Label_GPA
        '
        Me.Label_GPA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_GPA.AutoSize = True
        Me.Label_GPA.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_GPA.ForeColor = System.Drawing.Color.Navy
        Me.Label_GPA.Location = New System.Drawing.Point(506, 101)
        Me.Label_GPA.Name = "Label_GPA"
        Me.Label_GPA.Size = New System.Drawing.Size(57, 28)
        Me.Label_GPA.TabIndex = 68
        Me.Label_GPA.Text = "GPA"
        '
        'Label_Grade
        '
        Me.Label_Grade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Grade.AutoSize = True
        Me.Label_Grade.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Grade.ForeColor = System.Drawing.Color.Navy
        Me.Label_Grade.Location = New System.Drawing.Point(506, 59)
        Me.Label_Grade.Name = "Label_Grade"
        Me.Label_Grade.Size = New System.Drawing.Size(71, 28)
        Me.Label_Grade.TabIndex = 67
        Me.Label_Grade.Text = "Grade"
        '
        'Label_Subject
        '
        Me.Label_Subject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Subject.AutoSize = True
        Me.Label_Subject.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Subject.ForeColor = System.Drawing.Color.Navy
        Me.Label_Subject.Location = New System.Drawing.Point(53, 142)
        Me.Label_Subject.Name = "Label_Subject"
        Me.Label_Subject.Size = New System.Drawing.Size(63, 28)
        Me.Label_Subject.TabIndex = 58
        Me.Label_Subject.Text = "មុខវិជ្ជា"
        '
        'Label_StudentName
        '
        Me.Label_StudentName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_StudentName.AutoSize = True
        Me.Label_StudentName.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_StudentName.ForeColor = System.Drawing.Color.Navy
        Me.Label_StudentName.Location = New System.Drawing.Point(52, 100)
        Me.Label_StudentName.Name = "Label_StudentName"
        Me.Label_StudentName.Size = New System.Drawing.Size(110, 28)
        Me.Label_StudentName.TabIndex = 57
        Me.Label_StudentName.Text = "ឈ្មោះនិស្សិត"
        '
        'Label_Score
        '
        Me.Label_Score.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Score.AutoSize = True
        Me.Label_Score.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Score.ForeColor = System.Drawing.Color.Navy
        Me.Label_Score.Location = New System.Drawing.Point(54, 184)
        Me.Label_Score.Name = "Label_Score"
        Me.Label_Score.Size = New System.Drawing.Size(38, 28)
        Me.Label_Score.TabIndex = 56
        Me.Label_Score.Text = "ពិន្ទុ"
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.Navy
        Me.Label_ID.Location = New System.Drawing.Point(55, 59)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(107, 28)
        Me.Label_ID.TabIndex = 55
        Me.Label_ID.Text = "លេខសម្គាល់"
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Snow
        Me.btnReset.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_reset_28_1
        Me.btnReset.Location = New System.Drawing.Point(809, 330)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 50)
        Me.btnReset.TabIndex = 111
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
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Snow
        Me.btnDelete.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_delete_bin_28
        Me.btnDelete.Location = New System.Drawing.Point(670, 330)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 50)
        Me.btnDelete.TabIndex = 110
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
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdate.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_update_28
        Me.btnUpdate.Location = New System.Drawing.Point(531, 330)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 50)
        Me.btnUpdate.TabIndex = 109
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
        Me.btnInsert.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Snow
        Me.btnInsert.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_insert_28
        Me.btnInsert.Location = New System.Drawing.Point(392, 330)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(135, 50)
        Me.btnInsert.TabIndex = 108
        Me.btnInsert.Text = "បញ្ជូល"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(181, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(280, 35)
        Me.txtID.TabIndex = 112
        '
        'CmbStudentName
        '
        Me.CmbStudentName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbStudentName.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbStudentName.FormattingEnabled = True
        Me.CmbStudentName.Location = New System.Drawing.Point(181, 97)
        Me.CmbStudentName.Name = "CmbStudentName"
        Me.CmbStudentName.Size = New System.Drawing.Size(280, 36)
        Me.CmbStudentName.TabIndex = 113
        '
        'CmbSubject
        '
        Me.CmbSubject.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSubject.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbSubject.FormattingEnabled = True
        Me.CmbSubject.Location = New System.Drawing.Point(181, 139)
        Me.CmbSubject.Name = "CmbSubject"
        Me.CmbSubject.Size = New System.Drawing.Size(280, 36)
        Me.CmbSubject.TabIndex = 114
        '
        'txtScore
        '
        Me.txtScore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScore.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtScore.Location = New System.Drawing.Point(181, 181)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(280, 35)
        Me.txtScore.TabIndex = 115
        '
        'CmbGrade
        '
        Me.CmbGrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbGrade.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbGrade.FormattingEnabled = True
        Me.CmbGrade.Location = New System.Drawing.Point(610, 56)
        Me.CmbGrade.Name = "CmbGrade"
        Me.CmbGrade.Size = New System.Drawing.Size(280, 36)
        Me.CmbGrade.TabIndex = 116
        '
        'CmbGPA
        '
        Me.CmbGPA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbGPA.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbGPA.FormattingEnabled = True
        Me.CmbGPA.Location = New System.Drawing.Point(610, 98)
        Me.CmbGPA.Name = "CmbGPA"
        Me.CmbGPA.Size = New System.Drawing.Size(280, 36)
        Me.CmbGPA.TabIndex = 117
        '
        'txtMention
        '
        Me.txtMention.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMention.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtMention.Location = New System.Drawing.Point(610, 140)
        Me.txtMention.Name = "txtMention"
        Me.txtMention.Size = New System.Drawing.Size(280, 35)
        Me.txtMention.TabIndex = 118
        '
        'lbSearch
        '
        Me.lbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSearch.ForeColor = System.Drawing.Color.SlateGray
        Me.lbSearch.Location = New System.Drawing.Point(11, 341)
        Me.lbSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(69, 28)
        Me.lbSearch.TabIndex = 144
        Me.lbSearch.Text = "ស្វែងរក"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(85, 338)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 35)
        Me.txtSearch.TabIndex = 143
        Me.txtSearch.Tag = ""
        '
        'frm_score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtMention)
        Me.Controls.Add(Me.CmbGPA)
        Me.Controls.Add(Me.CmbGrade)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.CmbSubject)
        Me.Controls.Add(Me.CmbStudentName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DGV_Data)
        Me.Controls.Add(Me.Label_Mention)
        Me.Controls.Add(Me.Label_GPA)
        Me.Controls.Add(Me.Label_Grade)
        Me.Controls.Add(Me.Label_Subject)
        Me.Controls.Add(Me.Label_StudentName)
        Me.Controls.Add(Me.Label_Score)
        Me.Controls.Add(Me.Label_ID)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_score"
        Me.Text = "ពិន្ទុះ"
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Label_Mention As Label
    Friend WithEvents Label_GPA As Label
    Friend WithEvents Label_Grade As Label
    Friend WithEvents Label_Subject As Label
    Friend WithEvents Label_StudentName As Label
    Friend WithEvents Label_Score As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents CmbStudentName As ComboBox
    Friend WithEvents CmbSubject As ComboBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents CmbGrade As ComboBox
    Friend WithEvents CmbGPA As ComboBox
    Friend WithEvents txtMention As TextBox
    Friend WithEvents lbSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
