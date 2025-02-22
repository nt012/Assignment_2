using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public PersonModel Person { get; set; } = new PersonModel();

        public void OnGet()
        {
            _logger.LogInformation("Index OnGet");
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index OnPost");
            _logger.LogInformation($"Name={Person.Name}");
            _logger.LogInformation($"Age={Person.Age}");

            // data stored in TempData to be redirected
            TempData["Name"] = Person.Name;
            TempData["Age"] = Person.Age;

            // Redirect to Privacy page
            return RedirectToPage("Privacy");
        }
    }
}
