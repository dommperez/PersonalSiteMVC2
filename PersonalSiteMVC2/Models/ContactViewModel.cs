using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PersonalSiteMVC2.Models
{
    public class ContactViewModel
    {
       [Required(ErrorMessage = "**Please provide a name**")]
        public string Name { get; set; }

        [Required(ErrorMessage = "**Please provide a email**")]
        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "**Please provide a message**")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}