using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace news.Models
{
    public class user_login
    {

        [Key]
        [Required]
        public string username { get; set; }
        [EmailAddress] 
        public string Email { get; set; }
        [Required]
        public string password { get; set; }




    }
}