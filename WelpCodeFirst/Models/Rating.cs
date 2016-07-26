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
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public short? StarRating { get; set; }
        public string TextReview { get; set; }
        
        //Navigation properties
        //used when it is the many side of the relationship
        public virtual Business Business { get; set; }
        public virtual User User { get; set; }
    }
}