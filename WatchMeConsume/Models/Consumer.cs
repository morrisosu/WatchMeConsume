using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchMeConsume.Models
{
    public class Consumer
    {
        /// <summary>
        /// The Id of the Consumer
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The First Name of the Consumer
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// The Last Name of the Consumer
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The Email Address of the Consumer
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The Password of the Consumer
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// The Gender of the Consumer
        /// </summary>
        public char Gender { get; set; }

        /// <summary>
        /// The Birthdate of the Consumer
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// The Location of the Consumer
        /// </summary>]
        public string Location { get; set; }
    }
}