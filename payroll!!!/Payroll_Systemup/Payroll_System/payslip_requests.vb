Imports MySql.Data.MySqlClient

Public Class payslip_requests
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USER id= root; DATABASE = payroll_database"
    Dim CMD As MySqlCommand
    Dim itemcoll(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Update payslip_request set status = 'Approved' where request_number = '" & requestnum.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Status Updated", vbInformation, "Admin")
            Else
                MsgBox("Status Update Failed", vbCritical, "Admin")
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
        requestnum.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            requestnum.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
           
            
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Delete from payslip_request where request_number = '" & requestnum.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Request Deleted", vbInformation, "Admin")
            Else
                MsgBox("Request Deletion Failed", vbCritical, "Admin")
            End If
            Call LOADLV()
            Call cleardata()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub payslip_requests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Payroll_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class