using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        

        [BindProperty]
     

        [DisplayName("Full Name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "First Name must contain only alphabets and spaces.")]
        public string FullName { get; set; } = "";

        [BindProperty]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = "";


        [BindProperty]
        [DisplayName("Tel no.")]
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits.")]
        public string Phone { get; set; } = "";
        
        [BindProperty]

        [Required(ErrorMessage = "Event Date is required.")]

        public string EventDate { get; set; } = "";

        [BindProperty]
        [DisplayName("Event Type")]
        [Required(ErrorMessage = "Type is required.")]
        public string EventType { get; set; } = "";

        [BindProperty]
        [DisplayName("Function")]
        [Required(ErrorMessage = "Type is required.")]
        public string WeddingFunction { get; set; } = "";

        [BindProperty]
        [DisplayName("Theme")]
        public string BirthdayTheme { get; set; } = "";

        [BindProperty]
        [DisplayName("Package")]
        public string package { get; set; } = "";

        [BindProperty]
        [DisplayName("Location")]
        [Required(ErrorMessage = "Please select this field")]
        public string location { get; set; } = "";


        [BindProperty]
        [DisplayName("Venue")]
        public string venue { get; set; } = "";

        [BindProperty]
        [DisplayName("Venue Type")]
        public string VenueType { get; set; } = "";

        [BindProperty]
        [DisplayName("Instructions for location")]
        public string SpecifyLocation { get; set; } = "";

        [BindProperty]
        [DisplayName("no. of guests")]
        [Required(ErrorMessage = "Please enter no. of guests")]
        public string guests { get; set; } = "";

        [BindProperty]
        [DisplayName("Contact Method")]
        public string ContactMethod { get; set; } = "";

        [BindProperty]
        [DisplayName("Catering")]
        public bool catering { get; set; }

        [BindProperty]
        [DisplayName("Decoration")]
        public bool decoration { get; set; }

        [BindProperty]
        [DisplayName("Photography")]
        public bool photography { get; set; }

        [BindProperty]
        [DisplayName("Music")]
        public bool music { get; set; }

        [BindProperty]
        [DisplayName("Venue-Service")]
        public bool venu { get; set; }

        [BindProperty]
        [DisplayName("Special Message")]
        public string textare { get; set; } = "";

        [BindProperty]
        [DisplayName("subscription to newsletter")]
        public bool newsletter { get; set; }

        [BindProperty]
        [DisplayName("Agree to PP")]
        public bool privacyy { get; set; }

       
    }
}
