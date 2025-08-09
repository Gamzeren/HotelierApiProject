using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage= new MimeMessage();

            //kimden
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "gamzerenn55@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //kime
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //mesaj içeriği
            var bodyBuilder=new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient Client = new SmtpClient();
            Client.Connect("smtp.gmail.com", 587, false);
            Client.Authenticate("gamzerenn55@gmail.com", "cjch eohy pyaq icvx");
            Client.Send(mimeMessage);
            Client.Disconnect(true);

            //Gönderilen mailin veri tabanına kaydedilmesi işlemi burada yapılabilir.
            return View();
        }
    }
}
