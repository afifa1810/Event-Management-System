using System.Numerics;
using EventManagement.DAL;
using EventManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Pages.Products
{
    public class contactusModel : PageModel
    {
        private readonly MyAppDbContext _context;

        public contactusModel(MyAppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Products { get; set; }


        public string SuccessMessage { get; set; } = "";
        public string ErrorMessage { get; set; } = "";
        public async Task<IActionResult> OnPost()
        {
            if (!Products.privacyy)
            {
                ModelState.AddModelError("AgreeToTerms", "You must agree to the terms.");
            }
            if (!ModelState.IsValid)
            {
                ErrorMessage = "Data validation failed. Please correct the errors and try again.";

                // Log the validation errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage); // or use a logging framework
                }

                return Page();
            }

            SuccessMessage = "Booked Successfully";
   
            _context.Products.Add(Products);
            await _context.SaveChangesAsync();
            // Clear the form
            Products = new Product();
            ModelState.Clear();

            return Page();
           


        }
    }
}