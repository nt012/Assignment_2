using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_2.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public PersonModel? Person { get; set; }

        public void OnGet()
        {
            _logger.LogInformation("Privacy OnGet");

            // Retrieve TempData values
            if (TempData.ContainsKey("Name") && TempData.ContainsKey("Age"))
            {
                Person = new PersonModel
                {
                    Name = TempData["Name"] as string ?? "",
                    Age = (int)TempData["Age"]
                };
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }
    }
}
