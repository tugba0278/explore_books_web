using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Firebase.Auth.Providers;
using static explore_books.FirebaseConfig;




namespace explore_books.Pages.PROJECT.pages
{
    public class LoginRegisterModel : PageModel
    {
        //[BindProperty]

        /*hesap girişi için gerekli alanlar*/

        public string LoginEmail { get; set; }
        [Required(ErrorMessage = "E-mail boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi girin.")]

        public string LoginPassword { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]


        /*hesap oluşturma için gerekli alanlar*/

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Telefon numarası alanı boş bırakılamaz.")]

        public string RegisterEmail { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir e-mail adresi girin.")]
        [Required(ErrorMessage = "E-mail boş bırakılamaz.")]

        public string RegisterPassword { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        

        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }




        //public authProvider =  FirebaseAuthProvider(new FirebaseConfig("AIzaSyBTSP8776bGFjWXK9_NSkEISQiL5jYNl6Q"));
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    try
        //    {
        //        // Kullanıcı kaydı
        //        var createUserResult = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
        //        // createUserResult içindeki bilgileri kullanarak gerekli işlemler yapılabilir.
        //    }
        //    catch (Exception ex)
        //    {
        //        // Hata yönetimi
        //    }

        //    return RedirectToPage("/Success");

        //    // Firebase ile kullanıcı kaydı
        //    // Firebase Authentication instance'ınızı burada kullanın

        //    return RedirectToPage("/Success");
        //}

    }
}

