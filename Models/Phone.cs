namespace Lab.Models
{
    public class Phone
    {
      public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }

        public int BrandId  { get; set; }
        public Brand Brand { get; set; }
    }
}
