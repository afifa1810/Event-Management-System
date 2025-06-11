
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;



namespace EventManagement.Pages

{

    public class ContactModel : PageModel

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
        [Required(ErrorMessage = "Type is required.")]
        public string EventType { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Type is required.")]
        public string WeddingFunction { get; set; } = "";

        [BindProperty]
        public string BirthdayTheme { get; set; } = "";

        [BindProperty]
        public string package { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Please select this field")]
        public string location { get; set; } = "";


        [BindProperty]
        public string venue { get; set; } = "";

        [BindProperty]
        public string VenueType { get; set; } = "";

        [BindProperty]
        public string SpecifyLocation { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Please enter no. of guests")]
        public string guests { get; set; } = "";

        [BindProperty]
        public string ContactMethod { get; set; } = "";

        [BindProperty]
        public bool catering { get; set; }

        [BindProperty]
        public bool decoration { get; set; }

        [BindProperty]
        public bool photography { get; set; }

        [BindProperty]
        public bool music { get; set; }

        [BindProperty]
        public bool venu { get; set; }

        [BindProperty]
        public string textare { get; set; }

        [BindProperty]
        public bool newsletter { get; set; }

        [BindProperty]
        public bool privacyy { get; set; }


        public string SuccessMessage { get; set; } = "";
        public string ErrorMessage { get; set; } = "";
        public void OnGet()

        {

            // Initialization code if needed

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

            WeddingFunction = "";

            





            ModelState.Clear();





        }

    }

}