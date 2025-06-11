using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManagement.Pages
{
    public class FinalContactModel : PageModel
   
    {
        [BindProperty]
        [Required(ErrorMessage = "Full Name is required.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "First Name must contain only alphabets and spaces.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public string FullName { get; set; } = "";

       

        [BindProperty]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits.")]
        public string Phone { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Subject is required.")]
        [StringLength(100, ErrorMessage = "Subject cannot exceed 100 characters.")]
        public string EventType { get; set; } = "";

        [BindProperty]
        
       
        public string Message { get; set; } = "";

        public string SuccessMessage { get; set; } = "";
        public string ErrorMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "Data validation failed. Please correct the errors and try again.";
                return;
            }

            SuccessMessage = "Your message has been submitted successfully.";

            // Clear form fields
            FullName = "";
         
            Email = "";
            Phone = "";
            EventType = "";
            Message = "";

            ModelState.Clear();
        }
    }
}
