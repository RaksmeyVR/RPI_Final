<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Label_UserType = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.CmbUserType = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Data.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Data.Location = New System.Drawing.Point(0, 386)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(955, 272)
        Me.DGV_Data.TabIndex = 21
        '
        'Label_UserType
        '
        Me.Label_UserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_UserType.AutoSize = True
        Me.Label_UserType.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UserType.ForeColor = System.Drawing.Color.Navy
        Me.Label_UserType.Location = New System.Drawing.Point(490, 144)
        Me.Label_UserType.Name = "Label_UserType"
        Me.Label_UserType.Size = New System.Drawing.Size(114, 28)
        Me.Label_UserType.TabIndex = 16
        Me.Label_UserType.Text = "ប្រភេទគណនី"
        '
        'Label_Password
        '
        Me.Label_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.ForeColor = System.Drawing.Color.Navy
        Me.Label_Password.Location = New System.Drawing.Point(53, 143)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(101, 28)
        Me.Label_Password.TabIndex = 15
        Me.Label_Password.Text = "លេខសម្ងាត់"
        '
        'Label_Name
        '
        Me.Label_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.ForeColor = System.Drawing.Color.Navy
        Me.Label_Name.Location = New System.Drawing.Point(51, 102)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(110, 28)
        Me.Label_Name.TabIndex = 14
        Me.Label_Name.Text = "ឈ្មោះគណនី"
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.Navy
        Me.Label_ID.Location = New System.Drawing.Point(52, 61)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(107, 28)
        Me.Label_ID.TabIndex = 13
        Me.Label_ID.Text = "លេខសម្គាល់"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(488, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 28)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "នាមខ្លួន"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(488, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 28)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "គោត្តនាម"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(490, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 28)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "អ៊ីម៉ែល"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(51, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "លេទទូរស័ព្ទ"
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
        Me.txtID.Location = New System.Drawing.Point(176, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(280, 35)
        Me.txtID.TabIndex = 112
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(176, 99)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(280, 35)
        Me.txtUsername.TabIndex = 113
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(176, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(280, 35)
        Me.txtPassword.TabIndex = 114
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(176, 181)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(280, 35)
        Me.txtPhone.TabIndex = 115
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtLastName.Location = New System.Drawing.Point(614, 58)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(280, 35)
        Me.txtLastName.TabIndex = 116
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(614, 99)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(280, 35)
        Me.txtFirstName.TabIndex = 117
        '
        'CmbUserType
        '
        Me.CmbUserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbUserType.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.CmbUserType.FormattingEnabled = True
        Me.CmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.CmbUserType.Location = New System.Drawing.Point(614, 140)
        Me.CmbUserType.Name = "CmbUserType"
        Me.CmbUserType.Size = New System.Drawing.Size(280, 36)
        Me.CmbUserType.TabIndex = 118
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(614, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 35)
        Me.txtEmail.TabIndex = 119
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
        Me.lbSearch.TabIndex = 140
        Me.lbSearch.Text = "ស្វែងរក"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(85, 338)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 35)
        Me.txtSearch.TabIndex = 139
        Me.txtSearch.Tag = ""
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.CmbUserType)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_Data)
        Me.Controls.Add(Me.Label_UserType)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Label_ID)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_user"
        Me.Text = "អ្នកប្រើប្រាស់"
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Label_UserType As Label
    Friend WithEvents Label_Password As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents CmbUserType As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
