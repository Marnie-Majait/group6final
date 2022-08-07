Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Attendance_Records
    Public results As String
    Public CMD As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public user = Login.USER
    Public totalhrs As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'display to ng date 
        DATETODAY.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub Attendance_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Timer1.Start()
        Timer2.Start()
        ReloadData()
    End Sub
    Public Sub ReloadData()
        Try
            Dim Str = "SELECT Employee_Id, Log_Date, Time_In, Before_Status, Time_Out, After_Status FROM time_record"
            CONNECT.Open()
            Dim Search As New MySqlDataAdapter(Str, CONNECT)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "tablename")
            DataGridView1.DataSource = ds.Tables("tablename")
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONNECT.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Payroll_User.Show()
        Me.Hide()
    End Sub
    
  
   

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       
                    Try

                        CONNECT.Open()
            Dim SQL As String = "INSERT INTO time_record (Employee_Id, Log_Date, Time_In, Before_Status) values ('" & Login.USER & "','" & DATETODAY.Text & "','" & TimeOfDay & "','Time In')"
                        CMD = New MySqlCommand(SQL, CONNECT)
                        Dim i As Integer = CMD.ExecuteNonQuery
                        If i <> 0 Then
                            MsgBox("Successfully Timed In", vbInformation, "Admin")
                        Else
                            MsgBox("Time in failed", vbCritical, "Admin")
                        End If
                        CONNECT.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
            

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'display to ng time 
        Time1.Text = DateTime.Now.ToString("HH:mm:ss")
        ReloadData()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
                    Try
                        CONNECT.Open()
            Dim SQL As String = "Update time_record set Time_Out = '" & TimeOfDay & "', After_Status = 'Time Out', Hrs_worked = Time_Out - Time_In WHERE Employee_Id = '" & Login.USER & "' AND Log_Date = '" & DATETODAY.Text & "' AND Before_Status = 'Time In'"
                        CMD = New MySqlCommand(SQL, CONNECT)
                        Dim i As Integer = CMD.ExecuteNonQuery
                        If i <> 0 Then
                            MsgBox("Successfully Timed Out", vbInformation, "Admin")
                        Else
                            MsgBox("Time out failed", vbCritical, "Admin")
                        End If
                        CONNECT.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
               
        

    End Sub

   
  

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim url As String = "http://localhost/view.php"

        Process.Start(url)
    End Sub
End Class