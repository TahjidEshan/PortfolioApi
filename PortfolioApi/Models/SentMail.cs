namespace PortfolioApi.Models
{
    public class SentMail : BaseClass
    {
        public string Name { get; set; }
        public Email EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Comments { get; set; }
        public string Subject { get; set; }
        public Email To { get; set; }
    }
}
