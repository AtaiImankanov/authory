namespace Lab.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }  

        public int PhoneId { get; set; }
        public Phone Phone { get; set; }


    }
}
