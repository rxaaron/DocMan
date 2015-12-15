Imports System.Net.Mail

Public Class ErrorEmailLog


    Public Sub SendNotifications(ByVal CurrentUserName As String, ByVal ErrorText As String)
        Dim SMTPServer As New SmtpClient("smtp.gmail.com", 587)
        SMTPServer.Credentials = New Net.NetworkCredential("aaron@rxtaylor.com", "192640!aMt")
        SMTPServer.EnableSsl = True
        Dim Emailer As New MailAddress("aaron@rxtaylor.com", "Error Reporting")
        Dim ErrorMail As New MailMessage
        ErrorMail.From = Emailer
        ErrorMail.Subject = "Manifest Manager - Error Report"
        ErrorMail.To.Add(New MailAddress("aaron@rxtaylor.com", "Aaron Taylor"))
        ErrorMail.Body = Now.ToString() & Chr(13) & Chr(13) & CurrentUserName & Chr(13) & Chr(13) & ErrorText
        SMTPServer.Send(ErrorMail)
    End Sub

End Class
