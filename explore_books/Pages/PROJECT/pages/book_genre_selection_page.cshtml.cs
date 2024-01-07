namespace explore_books.Pages.PROJECT.sifre;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class bookGenreselectionModel : PageModel
{
    public List<List<string>> GroupedGenres { get; set; } = new List<List<string>>
    {
        new List<string> { "ROMAN", "POLİSİYE" },
        new List<string> { "ŞİİR", "ÇOCUK" },
        new List<string> { "DİNİ", "HİKAYE" },
        new List<string> { "PSİKOLOJİ", "K.GELİŞİM" },
        new List<string> { "TARİH", "SAĞLIK" },
        new List<string> { "BİLİM KURGU", "SANAT" }

    };

    //[BindProperty]
    //public List<string> SelectedGenres { get; set; }
    //public IActionResult OnPost()
    //{
    //    // Formdan gelen verileri kullanma
    //    var selectedGenres = SelectedGenres;

    //    // Veritabanına veri ekleme
    //    // (Bu örnek, veritabanı işlemlerini göstermek için basitleştirilmiştir.)
    //    dbContext.Add(new MyEntity { Genres = selectedGenres });
    //    //dbContext.SaveChanges();

    //    // Başka bir sayfaya yönlendirme
    //    return RedirectToPage("/SelectedGenrePage", new { selectedGenres });
    //}
}



