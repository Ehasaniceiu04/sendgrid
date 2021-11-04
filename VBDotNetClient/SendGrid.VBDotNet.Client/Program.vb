Imports System
Imports System.Threading.Tasks
Imports SendGrid
Imports SendGrid.Helpers.Mail


Module Program
    Sub Main(args As String())
        SendMail.Wait()
    End Sub

    Async Function SendMail() As Task
        Dim apiKey = "<api key>"
        Dim client = New SendGridClient(apiKey)
        Dim from = New EmailAddress("momehoque16@gmail.com", "Morzina Hoque")
        Dim subject = "Sending with SendGrid is Fun"
        Dim toAddress = New EmailAddress("ehice04@gmail.com", "Ehasanul Hoque")
        Dim plainTextContent = "and easy to do anywhere, even with vb.net"
        Dim htmlContent = "<strong>and easy to do anywhere, even with vb.net</strong>"
        Dim msg = MailHelper.CreateSingleEmail(from, toAddress, subject, plainTextContent, htmlContent)
        Dim response = Await client.SendEmailAsync(msg)
    End Function
End Module
