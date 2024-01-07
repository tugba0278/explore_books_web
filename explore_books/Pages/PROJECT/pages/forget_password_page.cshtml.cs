using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace explore_books.Pages.PROJECT
{
    public class ForgetPasswordModel : PageModel
    {

        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
