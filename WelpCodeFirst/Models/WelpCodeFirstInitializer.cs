using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class WelpCodeFirstInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WelpCodeFirstContext>
    {
        protected override void Seed(WelpCodeFirstContext context)
        {
            context.Users.Add(new User() { Username = "JohnDoe", Email = "johndoe@gmail.com", Password = "llama" });
            

            base.Seed(context);
        }
    }
}