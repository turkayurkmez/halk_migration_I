using changingInRazor.Models;

namespace changingInRazor.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new()
            {
                new(){ Id=1, Name="Excalibur 1", Price=28000, Description="Oyun makinesi"},
                new(){ Id=2, Name="Excalibur 2", Price=28000, Description="Oyun makinesi"},
                new(){ Id=3, Name="Excalibur 3", Price=28000, Description="Oyun makinesi"},
                new(){ Id=4, Name="Excalibur 4", Price=28000, Description="Oyun makinesi"},
                new(){ Id=5, Name="Excalibur 5", Price=28000, Description="Oyun makinesi"},
                new(){ Id=6, Name="Excalibur 6", Price=28000, Description="Oyun makinesi"},
                new(){ Id=7, Name="Excalibur 7", Price=28000, Description="Oyun makinesi"},
                new(){ Id=8, Name="Excalibur 8", Price=28000, Description="Oyun makinesi"},

            };
        }
    }
}
