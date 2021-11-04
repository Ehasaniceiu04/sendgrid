using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SendGridEmailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail().Wait();
        }
        static async Task SendEmail()
        {
            var apiKey = "you need to provide your send grid api key";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("momehoque16@gmail.com", "Morzina Hoque");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("ehice04@gmail.com", "Ehasanul Hoque");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
