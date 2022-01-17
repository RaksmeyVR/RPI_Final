Public Class frm_report
    Private sql As New SQLControl
    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        CrystalView()
    End Sub

#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM student")
        Else
            Sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If Sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = Sql.dt

    End Sub
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
        Sql.ExecQuery(table)

        If Sql.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In Sql.dt.Rows
            itm.Items.Add(r(index).ToString)
        Next
    End Sub

#End Region

    Private Sub CrystalView()
        Dim ds As New ds_student
        Dim da As New ds_studentTableAdapters.studentTableAdapter
        da.Fill(ds.student)
        Dim report As New Cr_student
        report.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = report
    End Sub

    'Private Sub btnPrint_Click(sender As Object, e As EventArgs)
    '    CrystalView()
    'End Sub
End Class