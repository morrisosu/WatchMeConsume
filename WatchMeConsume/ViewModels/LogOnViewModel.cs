using System.ComponentModel.DataAnnotations;

namespace WatchMeConsume.ViewModels
{
    public class LogOnViewModel
    {
        /// <summary>
        /// The Email Address of the Consumer
        /// </summary>
        [Required]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The Password of the Consumer
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Whether the system should remember the Consumer
        /// </summary>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}