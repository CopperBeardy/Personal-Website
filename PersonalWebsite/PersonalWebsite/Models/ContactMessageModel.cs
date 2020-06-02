using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class ContactMessageModel
    {
        [Required(ErrorMessage ="You must enter your full name")]
        [MinLength(5,ErrorMessage ="you name must be longer than 5 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="A email address must be entered")]
        [EmailAddress]
        [MinLength(6,ErrorMessage="A valid email must be entered")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Subject must be entered")]
        [MinLength(10,ErrorMessage ="Your subject must be 10 characters long")]
        public string Subject { get; set; }

        [Required(ErrorMessage ="Message can not be sent without text")]
        [MinLength(10,ErrorMessage ="Your message must be longer than 10 characters")]
        public string Message { get; set; }
    }
}
