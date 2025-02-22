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

        public void OnGet(string? name, int? age)
        {
            _logger.LogInformation("Privacy OnGet");

            if (!string.IsNullOrEmpty(name) && age.HasValue)
            {
                Person = new PersonModel { Name = name, Age = age.Value };
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }

        public void OnPost(PersonModel person)
        {
            _logger.LogInformation("Privacy OnPost");

            if (person != null)
            {
                Person = person;
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }
    }

}
