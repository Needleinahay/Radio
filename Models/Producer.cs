namespace Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public string LinkToOrg { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsApproved { get; set; }
    }
}