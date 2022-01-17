Imports System.Runtime.InteropServices

Module ThemeColor
    Public Property PrimaryColor As Color
    Public Property SecondaryColor As Color
    Public ColorList As List(Of String) = New List(Of String)() From {
        "#3F51B5",
        "#009688",
        "#FF5722",
        "#607D8B",
        "#FF9800",
        "#9C27B0",
        "#2196F3",
        "#EA676C",
        "#E41A4A",
        "#5978BB",
        "#018790",
        "#0E3441",
        "#00B0AD",
        "#721D47",
        "#EA4833",
        "#EF937E",
        "#F37521",
        "#A12059",
        "#126881",
        "#8BC240",
        "#364D5B",
        "#C7DC5B",
        "#0094BC",
        "#E4126B",
        "#43B76E",
        "#7BCFE9",
        "#B71C46"
    }

    Function ChangeColorBrightness(color As Color, correctionFactor As Double) As Color
        Dim red As Double = color.R
        Dim green As Double = color.G
        Dim blue As Double = color.B
        'If correction factor is less than 0, darken color.'
        If correctionFactor < 0 Then
            correctionFactor = 1 + correctionFactor
            red *= correctionFactor
            green *= correctionFactor
            blue *= correctionFactor
            'If correction factor is greater than zero, lighten color.'
        Else
            red = (255 - red) * correctionFactor + red
            green = (255 - green) * correctionFactor + green
            blue = (255 - blue) * correctionFactor + blue
        End If
        Return Color.FromArgb(color.A, CByte(red), CByte(green), CByte(blue))
    End Function

End Module
Public Class FormMain

    'FIELDS'
    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer
    Private activeForm As Form

    'CONSTRUCTOR'
    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()
        Me.btnCloseForm.Visible = False
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub

    'METHODS'
    Private Function SelectThemeColor() As Color
        Dim index As Integer = random.[Next](ThemeColor.ColorList.Count)
        While tempIndex = index
            index = random.[Next](ThemeColor.ColorList.Count)
        End While
        tempIndex = index
        Dim color As String = ThemeColor.ColorList(index)
        Return ColorTranslator.FromHtml(color)
    End Function
    'Active and Disable Button
    Private Sub ActivateButton(btnSender As Object)
        If btnSender IsNot Nothing Then
            If currentButton.Name <> CType(btnSender, Button).Name Then
                DisableButton()
                Dim color As Color = SelectThemeColor()
                currentButton = CType(btnSender, Button)
                currentButton.BackColor = color
                currentButton.ForeColor = Color.Snow
                ''currentButton.Font = New System.Drawing.Font("Khmer OS Content", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
                'PanelTitle.BackColor = color
                'PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3)
                ThemeColor.PrimaryColor = color
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3)
                btnCloseForm.Visible = True
            End If
        End If
    End Sub

    Private Sub DisableButton()
        For Each previousBtn As Control In PanelMenu.Controls

            If previousBtn.[GetType]() = GetType(Button) Then
                previousBtn.BackColor = Color.SteelBlue
                previousBtn.ForeColor = Color.Snow
                'previousBtn.Font = New System.Drawing.Font("Khmer OS Conten", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            End If
        Next
    End Sub

    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If activeForm IsNot Nothing Then activeForm.Close()
        ActivateButton(btnSender)
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.PanelContainer.Controls.Add(childForm)
        Me.PanelContainer.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelTitle.Text = childForm.Text
    End Sub
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        If (Not (activeForm) Is Nothing) Then
            activeForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        LabelTitle.Text = "ទំព័រដើម"
        'PanelTitle.BackColor = Color.FromArgb(Indigo)
        'PanelTitle.BackColor = Color.SteelBlue
        'PanelLogo.BackColor = Color.GhostWhite
        currentButton = New Button()
        btnCloseForm.Visible = False
    End Sub

    'DRAG FORM'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Paneltitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#Region "CLOSE, MAXIMIZE, MINIMIZE FORM MAIN"

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If (WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "EVENTS Click "
    Private Sub btnRegiser_Click(sender As Object, e As EventArgs) Handles btnRegiser.Click
        OpenChildForm(New frm_register(), sender)
    End Sub
    Private Sub btnStudentInfo_Click(sender As Object, e As EventArgs) Handles btnStudentInfo.Click
        OpenChildForm(New frm_student(), sender)
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        OpenChildForm(New frm_department(), sender)
    End Sub
    Private Sub btnAcademic_Click(sender As Object, e As EventArgs) Handles btnAcademic.Click
        OpenChildForm(New frm_academic(), sender)
    End Sub
    Private Sub btnCampus_Click(sender As Object, e As EventArgs) Handles btnCampus.Click
        OpenChildForm(New frm_campus(), sender)
    End Sub
    Private Sub btn_Degree_Click(sender As Object, e As EventArgs) Handles btn_Degree.Click
        OpenChildForm(New frm_degree(), sender)
    End Sub
    Private Sub btnSemester_Click(sender As Object, e As EventArgs) Handles btnSemester.Click
        OpenChildForm(New frm_semester(), sender)
    End Sub
    Private Sub btnSkill_Click(sender As Object, e As EventArgs) Handles btnSkill.Click
        OpenChildForm(New frm_skill(), sender)
    End Sub
    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        OpenChildForm(New frm_subject(), sender)
    End Sub
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        OpenChildForm(New Payment(), sender)
    End Sub
    Private Sub btnTotalScore_Click(sender As Object, e As EventArgs) Handles btnTotalScore.Click
        OpenChildForm(New frm_totalscore(), sender)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        OpenChildForm(New frm_generate(), sender)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        OpenChildForm(New frm_user(), sender)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Me.Hide()

        If MessageBox.Show("អ្នកពិតជាចង់ចាកចេញឬ?", "Warning",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            frm_login.Show()
        End If
    End Sub
    'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnUser.Click
    '    'frm_login.Show()
    '    'Me.Hide()

    '    If MessageBox.Show("Are you sure to log out?", "Warning",
    '              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
    '        Me.Close()
    '    End If
    'End Sub

#End Region
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        loadUser()
        DisablaBtn()
    End Sub

    Private Sub loadUser()
        lbUserType.Text = ActiveUser.usertype
        'lblEmail.Text = ActiveUser.email
        lbUserName.Text = ActiveUser.username
    End Sub

    Private Sub DisablaBtn()
        If lbUserType.Text = "User" Or lbUserType.Text = "user" Then
            btnUser.Enabled = False
        End If
    End Sub

    '' Date and Time Show
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTime.Text = DateTime.Now.ToString("hh:mm:ss")
        lbDate.Text = DateTime.Now.ToLongDateString()
    End Sub


End Class



