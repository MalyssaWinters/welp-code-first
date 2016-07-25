using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        [MaxLength(100)]
        public string PhotoURL { get; set; }

        //Navigation properties
        //used when it is the many side of the relationship
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}