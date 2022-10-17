using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcore2@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom); // mailin nereden geldigini kullanıcıya gösterdik
          
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);  // kime gönderecegim
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder(); //mesaj içerigi
            bodyBuilder.TextBody= mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject= mailRequest.Subject; //konuyu aldık

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("traversalcore2@gmail.com", "sifregir"); //kim tarafından gönderileecegini belirleme
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
