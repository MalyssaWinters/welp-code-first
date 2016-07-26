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
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }

        //Navigation properties
        //used when it is the one side of the relationship
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}