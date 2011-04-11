using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using WatchMeConsume.Models;

namespace WatchMeConsume.ViewModels
{
    public class RegisterViewModel
    {
        /// <summary>
        /// The First Name of the Consumer
        /// </summary>
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Last Name of the Consumer
        /// </summary>
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Email Address of the Consumer
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The Password of the Consumer
        /// </summary>
        [Required]
        [ValidatePasswordLength]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// The Confirm Password of the Consumer
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// The Gender of the Consumer
        /// </summary>
        [Display(Name = "Gender")]
        public char Gender { get; set; }

        /// <summary>
        /// The Birthdate of the Consumer
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// The Location of the Consumer
        /// </summary>
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}