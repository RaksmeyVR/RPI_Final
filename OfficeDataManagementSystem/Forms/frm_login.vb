Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class frm_login
    Private sql As New SQLControl
    Dim userModel As New UserModel
    Dim userDao As New UserDao
#Region "Close and Minimize Button "
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region

#Region "Events Click"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(txtUser.Text, txtPass.Text)
        If validLogin = True Then
            Dim frm As New FormMain()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            MessageBox.Show("ឈ្មោះអ្នកប្រើប្រាស់និងលេខកូដសម្ងាត់មិនត្រឹមត្រូវ" + vbNewLine + "សូមបញ្ចូលម្ដងទៀត")
            txtPass.Clear()
            txtPass.Focus()
        End If
    End Sub

#End Region

    'Checkbox Show Password
    Private Sub CbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CbShowPass.CheckedChanged
        If CbShowPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    'Nothing Text Alert
    Private Sub textalert()
        If txtUser.Text = Nothing Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់")
            txtUser.Focus()
        ElseIf txtPass.Text = Nothing Then
            MessageBox.Show("សូមបញ្ចូលលេខកូដសម្ងាត់")
            txtPass.Focus()
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextUser()
        TextPass()
    End Sub

#Region "Watermark Textbox"
    Private Sub TextUser()
        sql.SetCueText(txtUser, "បញ្ចូលឈ្មោះអ្នកប្រើប្រាស់")
    End Sub
    Private Sub TextPass()
        sql.SetCueText(txtPass, "បញ្ចូលលេខកូដសម្ងាត់")
    End Sub
#End Region

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
            txtUser.Clear()
            txtPass.Clear()
            Me.Show()
            txtUser.Focus()
        End Sub


End Class