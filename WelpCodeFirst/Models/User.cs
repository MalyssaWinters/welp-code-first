using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class User
    {
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }

        //Navigation properties
        //used when it is the one side of the relationship
        public virtual Business Business { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Photo Photo { get; set; }
    }
}