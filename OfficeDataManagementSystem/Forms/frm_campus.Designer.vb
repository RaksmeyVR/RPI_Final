<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_campus
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
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.Label_Phone = New System.Windows.Forms.Label()
        Me.Label_NameEng = New System.Windows.Forms.Label()
        Me.Label_Website = New System.Windows.Forms.Label()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.Label_NameKH = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNameKH = New System.Windows.Forms.TextBox()
        Me.txtNameEN = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnBroweImg = New System.Windows.Forms.Button()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Address
        '
        Me.Label_Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Address.ForeColor = System.Drawing.Color.Navy
        Me.Label_Address.Location = New System.Drawing.Point(115, 556)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(101, 28)
        Me.Label_Address.TabIndex = 44
        Me.Label_Address.Text = "អាស័យដ្ឋាន"
        '
        'Label_Phone
        '
        Me.Label_Phone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Phone.AutoSize = True
        Me.Label_Phone.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Phone.ForeColor = System.Drawing.Color.Navy
        Me.Label_Phone.Location = New System.Drawing.Point(115, 433)
        Me.Label_Phone.Name = "Label_Phone"
        Me.Label_Phone.Size = New System.Drawing.Size(101, 28)
        Me.Label_Phone.TabIndex = 43
        Me.Label_Phone.Text = "លេខទូរស័ព្ទ"
        '
        'Label_NameEng
        '
        Me.Label_NameEng.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_NameEng.AutoSize = True
        Me.Label_NameEng.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NameEng.ForeColor = System.Drawing.Color.Navy
        Me.Label_NameEng.Location = New System.Drawing.Point(116, 392)
        Me.Label_NameEng.Name = "Label_NameEng"
        Me.Label_NameEng.Size = New System.Drawing.Size(126, 28)
        Me.Label_NameEng.TabIndex = 42
        Me.Label_NameEng.Text = "ជាអក្សរឡាតាំង"
        '
        'Label_Website
        '
        Me.Label_Website.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Website.AutoSize = True
        Me.Label_Website.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Website.ForeColor = System.Drawing.Color.Navy
        Me.Label_Website.Location = New System.Drawing.Point(116, 515)
        Me.Label_Website.Name = "Label_Website"
        Me.Label_Website.Size = New System.Drawing.Size(82, 28)
        Me.Label_Website.TabIndex = 37
        Me.Label_Website.Text = "គេហទំព័រ"
        '
        'Label_Email
        '
        Me.Label_Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Email.ForeColor = System.Drawing.Color.Navy
        Me.Label_Email.Location = New System.Drawing.Point(115, 474)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(63, 28)
        Me.Label_Email.TabIndex = 36
        Me.Label_Email.Text = "អ៊ីម៉ែល"
        '
        'Label_NameKH
        '
        Me.Label_NameKH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_NameKH.AutoSize = True
        Me.Label_NameKH.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NameKH.ForeColor = System.Drawing.Color.Navy
        Me.Label_NameKH.Location = New System.Drawing.Point(115, 351)
        Me.Label_NameKH.Name = "Label_NameKH"
        Me.Label_NameKH.Size = New System.Drawing.Size(62, 28)
        Me.Label_NameKH.TabIndex = 35
        Me.Label_NameKH.Text = "សាលា"
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.ForeColor = System.Drawing.Color.Navy
        Me.Label_ID.Location = New System.Drawing.Point(116, 310)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(107, 28)
        Me.Label_ID.TabIndex = 34
        Me.Label_ID.Text = "លេខសម្គាល់"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(243, 307)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(551, 35)
        Me.txtID.TabIndex = 114
        '
        'txtNameKH
        '
        Me.txtNameKH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameKH.Font = New System.Drawing.Font("Khmer OS Muol Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameKH.Location = New System.Drawing.Point(243, 348)
        Me.txtNameKH.Name = "txtNameKH"
        Me.txtNameKH.Size = New System.Drawing.Size(551, 39)
        Me.txtNameKH.TabIndex = 115
        '
        'txtNameEN
        '
        Me.txtNameEN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNameEN.Font = New System.Drawing.Font("Khmer OS New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameEN.Location = New System.Drawing.Point(243, 393)
        Me.txtNameEN.Name = "txtNameEN"
        Me.txtNameEN.Size = New System.Drawing.Size(551, 31)
        Me.txtNameEN.TabIndex = 116
        '
        'txtTel
        '
        Me.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTel.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtTel.Location = New System.Drawing.Point(243, 430)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(551, 35)
        Me.txtTel.TabIndex = 117
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(243, 471)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(551, 35)
        Me.txtEmail.TabIndex = 118
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtWebsite.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtWebsite.Location = New System.Drawing.Point(243, 512)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(551, 35)
        Me.txtWebsite.TabIndex = 119
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtAddress.Location = New System.Drawing.Point(243, 553)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(551, 35)
        Me.txtAddress.TabIndex = 120
        '
        'btnBroweImg
        '
        Me.btnBroweImg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBroweImg.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBroweImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBroweImg.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnBroweImg.FlatAppearance.BorderSize = 0
        Me.btnBroweImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBroweImg.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBroweImg.ForeColor = System.Drawing.Color.Snow
        Me.btnBroweImg.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_browse_folder_28_1
        Me.btnBroweImg.Location = New System.Drawing.Point(399, 254)
        Me.btnBroweImg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBroweImg.Name = "btnBroweImg"
        Me.btnBroweImg.Size = New System.Drawing.Size(155, 50)
        Me.btnBroweImg.TabIndex = 113
        Me.btnBroweImg.Text = "រករូបភាព"
        Me.btnBroweImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBroweImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBroweImg.UseVisualStyleBackColor = False
        '
        'PicLogo
        '
        Me.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicLogo.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.user
        Me.PicLogo.Location = New System.Drawing.Point(357, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(237, 236)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 111
        Me.PicLogo.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdate.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_update_28
        Me.btnUpdate.Location = New System.Drawing.Point(659, 594)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 50)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frm_campus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNameEN)
        Me.Controls.Add(Me.txtNameKH)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnBroweImg)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label_Address)
        Me.Controls.Add(Me.Label_Phone)
        Me.Controls.Add(Me.Label_NameEng)
        Me.Controls.Add(Me.Label_Website)
        Me.Controls.Add(Me.Label_Email)
        Me.Controls.Add(Me.Label_NameKH)
        Me.Controls.Add(Me.Label_ID)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_campus"
        Me.Text = "ព័ត៌មានសាលា"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Address As Label
    Friend WithEvents Label_Phone As Label
    Friend WithEvents Label_NameEng As Label
    Friend WithEvents Label_Website As Label
    Friend WithEvents Label_Email As Label
    Friend WithEvents Label_NameKH As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents btnBroweImg As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNameKH As TextBox
    Friend WithEvents txtNameEN As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents txtAddress As TextBox
End Class
