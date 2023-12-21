using changingInRazor.Models;

namespace changingInRazor.Services
{
    public class CategoryService
    {
        public List<Category> GetCategories() => new() {
            new() {  Id=1, Name="Elektronik"},
            new() {  Id=1, Name="Kozmetik"}

        };


    }
}

