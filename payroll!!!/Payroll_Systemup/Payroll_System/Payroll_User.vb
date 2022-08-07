Imports MySql.Data.MySqlClient

Public Class Payroll_User
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USER id= root; DATABASE = payroll_database"
    Dim CMD As MySqlCommand
    Dim itemcoll(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Attendance_Records.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Call cleardata()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "INSERT INTO payslip_request (firstname,  lastname, emp_id, requestdate, status) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DATETODAY.Text & "','Pending')"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Request Sent", vbInformation, "Admin")
            Else
                MsgBox("Record Not Sent", vbCritical, "Admin")
            End If
            Call LOADLV()
            Call cleardata()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LOADLV()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from payslip_request"
            CMD = New MySqlCommand(sql, CONNECT)
            da = New MySqlDataAdapter(CMD)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitm As New ListViewItem(itemcoll)
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CONNECT.Close()
    End Sub
    Public Sub cleardata()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub


    Private Sub Payroll_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()
        Call cleardata()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'display to ng date 
        DATETODAY.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub
End Class