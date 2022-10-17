namespace TraversalCoreProje.Models
{
    public class MailRequest
    {
        public string Name  { get; set; } 
        public string SenderMail  { get; set; } //gönderen mail adresi
        public string ReceiverMail  { get; set; } //Alıcı mail adresi
        public string Subject  { get; set; } //Konu
        public string Body  { get; set; } //
    }
}
