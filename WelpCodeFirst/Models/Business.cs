using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Business
    {
        public int BusinessID { get; set; }
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string BusinessName { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        public string Menu { get; set; }
        public int UserID { get; set; }

        //Navigation properties
        //used when it is the many side of the relationship
        public virtual BusinessType BusinessType { get; set; }
        public virtual User User { get; set; }
        //used when it is the one side of the relationship
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}