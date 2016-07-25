using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string TypeName { get; set; }
        
        //Navigation properties
        //used when it is the one side of the relationship
        public virtual Business Business { get; set; }

    }
}