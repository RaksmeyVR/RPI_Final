<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_academic
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelAcademic = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAcadenic = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelID
        '
        Me.LabelID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.ForeColor = System.Drawing.Color.Navy
        Me.LabelID.Location = New System.Drawing.Point(227, 56)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(107, 28)
        Me.LabelID.TabIndex = 7
        Me.LabelID.Text = "លេខសម្គាល់"
        '
        'LabelDescription
        '
        Me.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.ForeColor = System.Drawing.Color.Navy
        Me.LabelDescription.Location = New System.Drawing.Point(227, 138)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(107, 28)
        Me.LabelDescription.TabIndex = 8
        Me.LabelDescription.Text = "ការពិពណ៌នា"
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAcademic
        '
        Me.LabelAcademic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAcademic.AutoSize = True
        Me.LabelAcademic.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAcademic.ForeColor = System.Drawing.Color.Navy
        Me.LabelAcademic.Location = New System.Drawing.Point(227, 97)
        Me.LabelAcademic.Name = "LabelAcademic"
        Me.LabelAcademic.Size = New System.Drawing.Size(76, 28)
        Me.LabelAcademic.TabIndex = 9
        Me.LabelAcademic.Text = "ឆ្នាំសិក្សា"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtID.Location = New System.Drawing.Point(352, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(359, 35)
        Me.txtID.TabIndex = 10
        '
        'txtAcadenic
        '
        Me.txtAcadenic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAcadenic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcadenic.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtAcadenic.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAcadenic.Location = New System.Drawing.Point(352, 94)
        Me.txtAcadenic.Name = "txtAcadenic"
        Me.txtAcadenic.Size = New System.Drawing.Size(359, 35)
        Me.txtAcadenic.TabIndex = 11
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Khmer OS New", 12.0!)
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescription.Location = New System.Drawing.Point(352, 135)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(359, 96)
        Me.txtDescription.TabIndex = 12
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Kh Ang KanTout", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Data.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Data.Location = New System.Drawing.Point(0, 386)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowTemplate.Height = 24
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(955, 272)
        Me.DGV_Data.TabIndex = 13
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInsert.FlatAppearance.BorderSize = 0
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
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnUpdate.FlatAppearance.BorderSize = 0
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
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.FlatAppearance.BorderSize = 0
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
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Khmer OS New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Snow
        Me.btnReset.Image = Global.OfficeDataManagementSystem.My.Resources.Resources.icons8_reset_28_1
        Me.btnReset.Location = New System.Drawing.Point(809, 330)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnReset.Size = New System.Drawing.Size(135, 50)
        Me.btnReset.TabIndex = 111
        Me.btnReset.Text = "សម្អាត"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frm_academic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(955, 658)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DGV_Data)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtAcadenic)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelAcademic)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_academic"
        Me.Text = "ឆ្នាំសិក្សា"
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelID As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelAcademic As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAcadenic As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReset As Button
End Class
