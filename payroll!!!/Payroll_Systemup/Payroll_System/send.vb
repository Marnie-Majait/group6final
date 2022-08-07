Imports System.Net.Mail

Public Class send

    Private Sub send_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        email.Text = Generate__Payslip.em

    End Sub


    Private Sub Attach_Click(sender As Object, e As EventArgs) Handles Attach.Click
        OpenFileDialog1.ShowDialog()
        Label4.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click

        Try

            Dim smtServer As New SmtpClient
            Dim mail As New MailMessage()
            smtServer.UseDefaultCredentials = False
            smtServer.Credentials = New Net.NetworkCredential("payrollsystem@outlook.ph", "Passwordforpayroll")
            smtServer.Port = 587
            smtServer.EnableSsl = True
            smtServer.Host = "smtp.office365.com"
            mail.From = New MailAddress("payrollsystem@outlook.ph")
            mail.To.Add(email.Text)
            mail.Subject = subtxt.Text
            mail.Body = bodytxt.Text
            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment(Label4.Text)
            mail.Attachments.Add(attach)
            smtServer.Send(mail)
            MessageBox.Show("Pay Slip Sent!", "Admin", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub



End Class