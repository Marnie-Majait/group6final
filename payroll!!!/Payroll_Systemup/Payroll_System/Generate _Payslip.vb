Imports MySql.Data.MySqlClient

Public Class Generate__Payslip
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USER id= root; DATABASE = payroll_database"
    Dim CMD As MySqlCommand
    Dim itemcoll(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim i As Integer
    Public em As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Payroll_Admin.Show()
        Me.Hide()
    End Sub
    Public Sub LoadView()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from payslip"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        payslip_requests.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.Show()
        Me.Hide()
        Call clear()

    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Generate__Payslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ref As Integer

        Randomize()
        ref = Int((313773 * Rnd()) + 15)
        r1.Text = Convert.ToString(ref)
        e1.Text = Payroll_Admin.emp_id
        e2.Text = Payroll_Admin.firstn
        e3.Text = Payroll_Admin.middlen
        e4.Text = Payroll_Admin.lastn
        e5.Text = Payroll_Admin.emailadd
        e6.Text = Payroll_Admin.rate
        Call LoadView()

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim save As New SaveFileDialog

        save.Filter = "txt files (*.txt)| *.txt |doc files (*.doc) |*.doc "
        save.FilterIndex = 2
        save.RestoreDirectory = False

        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(save.FileName, RichTextBox1.Text)
        End If
    End Sub



    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "INSERT INTO payslip (Employee_ID, First_Name, Middle_Name,  Last_Name, Email_ad, Reference_Number, Payslip_Date, Rate_per_hour, Hours_worked, Overtime, Tax, SSS, Pag_Ibig, Philhealth, Cash_Advance, Total_Deduction, Gross_Pay, Total_Pay) values ('" & Payroll_Admin.emp_id & "','" & Payroll_Admin.firstn & "','" & Payroll_Admin.middlen & "','" & Payroll_Admin.lastn & "','" & Payroll_Admin.emailadd & "','" & r1.Text & "','" & DateTimePicker1.Text & "','" & Payroll_Admin.rate & "','" & h1.Text & "', '" & h2.Text & "','" & d1.Text & "','" & d2.Text & "','" & d3.Text & "','" & d4.Text & "','" & d5.Text & "','" & d6.Text & "','" & p1.Text & "','" & p2.Text & "')"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Record Added", vbInformation, "Admin")
            Else
                MsgBox("Record Not Added", vbCritical, "Admin")
            End If
            Call LoadView()
            Call clear()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Update payslip set Employee_ID = '" & e1.Text & "', First_Name = '" & e2.Text & "',  Middle_name = '" & e3.Text & "', Last_Name = '" & e4.Text & "', Email_ad = '" & e5.Text & "', Rate_per_hour = '" & e6.Text & "', Hours_worked = '" & h1.Text & "', Overtime = '" & h2.Text & "', Tax = '" & d1.Text & "', SSS = '" & d2.Text & "', Pag_Ibig = '" & d3.Text & "', Philhealth = '" & d4.Text & "', Cash_Advance = '" & d5.Text & "', Total_Deduction = '" & d6.Text & "', Gross_Pay = '" & p1.Text & "', Total_Pay = '" & p2.Text & "' where Reference_Number = '" & r1.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Record Updated", vbInformation, "Admin")
            Else
                MsgBox("Record cannot be updated", vbCritical, "Admin")
            End If
            Call LoadView()
            Call clear()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub clear()
        e1.Clear()
        e2.Clear()
        e3.Clear()
        e4.Clear()
        e5.Clear()
        e6.Clear()

        h1.Clear()
        h2.Clear()

        d1.Clear()
        d2.Clear()
        d3.Clear()
        d4.Clear()
        d5.Clear()
        d6.Clear()

        p1.Clear()
        p2.Clear()



        DateTimePicker1.ResetText()

        Dim ref As Integer

        Randomize()
        ref = Int((313773 * Rnd()) + 15)
        r1.Text = Convert.ToString(ref)
    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Call clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            e1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
            e2.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            e3.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
            e4.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
            e5.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text
            r1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(5).Text
            e6.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(7).Text
            h1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(8).Text
            h2.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(9).Text
            d1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(10).Text
            d2.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(11).Text
            d3.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(12).Text
            d4.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(13).Text
            d5.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(14).Text
            d6.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(15).Text
            p1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(16).Text
            p2.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(17).Text

        End If
    End Sub

    Private Sub totalbtn_Click(sender As Object, e As EventArgs) Handles totalbtn.Click
        Dim rateperhour, hrsworked, netpay, net_inc, overtime, overtimerate, overtimepay, tax, sss, pagibig, phil, casha, totaldeduc, totalpay As Double
        hrsworked = Val(h1.Text)
        rateperhour = Val(e6.Text)
        netpay = 48 * rateperhour
        If hrsworked > 48 Then
            netpay = 48 * rateperhour
            overtime = hrsworked - 48
            h2.Text = overtime
            overtimerate = rateperhour * 1.5
            overtimepay = overtime * overtimerate

        Else

            overtimepay = 0
            h2.Text = 0

        End If
        net_inc = overtimepay + netpay
        p1.Text = net_inc

        sss = net_inc * 0.0572
        d2.Text = sss
        pagibig = net_inc * 0.075
        d3.Text = pagibig
        phil = net_inc * 0.082
        d4.Text = phil
        tax = net_inc * 0.12
        d1.Text = tax
        casha = Val(d5.Text)
        totaldeduc = sss + pagibig + phil + tax + casha
        d6.Text = totaldeduc

        totalpay = net_inc - totaldeduc
        p2.Text = totalpay


    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Delete from payslip where Reference_Number = '" & r1.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("The record was deleted successfully", vbInformation, "Admin")
            Else
                MsgBox("The record cannot be deleted", vbCritical, "Admin")
            End If

            Call LoadView()
            Call clear()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub paybtn_Click(sender As Object, e As EventArgs) Handles paybtn.Click
        Try
            RichTextBox1.Clear()
            RichTextBox1.AppendText(vbTab + vbTab + "Pay Slip" + vbTab + vbTab + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "---------------" + vbTab + vbTab + vbNewLine)
            RichTextBox1.AppendText("Date" + vbTab + vbTab + DateTimePicker1.Text + vbNewLine)
            RichTextBox1.AppendText("Employee ID" + vbTab + vbTab + e1.Text + vbNewLine)
            RichTextBox1.AppendText("First Name" + vbTab + vbTab + e2.Text + vbNewLine)
            RichTextBox1.AppendText("Middle Name" + vbTab + vbTab + e3.Text + vbNewLine)
            RichTextBox1.AppendText("Last Name" + vbTab + vbTab + e4.Text + vbNewLine)
            RichTextBox1.AppendText("Email Address" + vbTab + vbTab + e5.Text + vbNewLine)
            RichTextBox1.AppendText("Reference Number" + vbTab + vbTab + r1.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "---------------" + vbTab + vbTab + vbNewLine)
            RichTextBox1.AppendText("Rate per Hour" + vbTab + vbTab + e6.Text + vbNewLine)
            RichTextBox1.AppendText("Hours Worked" + vbTab + vbTab + h1.Text + vbNewLine)
            RichTextBox1.AppendText("Overtime" + vbTab + vbTab + h2.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "---------------" + vbTab + vbTab + vbNewLine)
            RichTextBox1.AppendText("Tax" + vbTab + vbTab + d1.Text + vbNewLine)
            RichTextBox1.AppendText("SSS" + vbTab + vbTab + d2.Text + vbNewLine)
            RichTextBox1.AppendText("Pagibig" + vbTab + vbTab + d3.Text + vbNewLine)
            RichTextBox1.AppendText("Philhealth" + vbTab + vbTab + d4.Text + vbNewLine)
            RichTextBox1.AppendText("Cash Advance" + vbTab + vbTab + d5.Text + vbNewLine)
            RichTextBox1.AppendText("Total Deduction" + vbTab + vbTab + d6.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "---------------" + vbTab + vbTab + vbNewLine)
            RichTextBox1.AppendText("Gross Pay" + vbTab + vbTab + p1.Text + vbNewLine)
            RichTextBox1.AppendText("Total Pay" + vbTab + vbTab + p2.Text + vbNewLine)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Pay Slip", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(RichTextBox1.Text, New Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, 100, 100)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        em = e5.Text
        send.Show()
    End Sub
End Class