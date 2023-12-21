namespace changingInRazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = "https://productimages.hepsiburada.net/s/379/222-222/110000397669010.jpg";

    }
}
