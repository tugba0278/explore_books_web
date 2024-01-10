using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace explore_books.Pages.PROJECT.pages
{
    public class emptycshtmlModel : PageModel
    {
        // Örnek model verileri için varsayılan listeler
        public List<Book> Books { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Authors { get; set; }
        public void OnGet()
        {
            
                // TODO: Veritabanından veya servisten kategori, yazar ve kitap bilgilerini çekme
                Categories = new List<SelectListItem>
                {
                    // Kategori seçenekleri
                };

                Authors = new List<SelectListItem>
                {
                    // Yazar seçenekleri
                };

                Books = new List<Book>
                {
                    // Kitap listesi
                };
            
        }
    }
}
