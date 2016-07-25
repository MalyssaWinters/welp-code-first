using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        [MaxLength(50)]
        public int StarReview { get; set; }
        public string TextReview { get; set; }
        

        //Navigation properties
        //used when it is the many side of the relationship
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}