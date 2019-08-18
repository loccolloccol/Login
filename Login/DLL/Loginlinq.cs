using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Login.Domain;
using Login.Models;
using Login.Controllers;

namespace Login.DLL
{
    public class Loginlinq
    {
        private readonly NorthwindEntities db = new NorthwindEntities();
        public bool Act(LogViewModel lo)
        {

            var aa = db.AspNetUsers.Where(x => x.Email == lo.Account && x.PasswordHash == lo.Password).FirstOrDefault();
            if (aa==null)
            {
                return false;
            }
            HttpContext.Current.Session["aa"] = aa;


            return true;

        }
      


}
    }
