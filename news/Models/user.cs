using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace news.Models
{
    public class user
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        [Key]
        public string username { get; set; }
        [EmailAddress]

        public string Email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        
        [StringLength(2000), DisplayName("upload Image")]
        public string photo { get; set; }

        public string userRole { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }



    }
}