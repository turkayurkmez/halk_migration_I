namespace basicDifferences.Services
{
    public interface IProductService
    {
        public List<string> GetProductNames();
    }

    public class ProductService : IProductService
    {
        public List<string> GetProductNames()
        {
            return new() { "Gözlük", "Şapka", "Baston" };
        }
    }

    public class OzHakikiProductService : IProductService
    {
        public List<string> GetProductNames()
        {
            return new() { "Klavye", "Mouse" };
        }
    }


}
