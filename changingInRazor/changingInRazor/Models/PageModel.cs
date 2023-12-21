namespace changingInRazor.Models
{
    public class PageModel
    {
        public int PageSize { get; set; }
        public int ItemsCount { get; set; }

        public int TotalPages { get => (int)Math.Ceiling((double)(ItemsCount / PageSize)); }

        public int CurrentPage { get; set; }


    }
}
