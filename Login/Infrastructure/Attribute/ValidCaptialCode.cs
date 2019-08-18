using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Infrastructure.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidCaptialCode: ValidationAttribute
    {
        
        public override bool IsValid(object value)
        {
            var d = HttpContext.Current.Session["captial"];
            if (value.ToString() != d.ToString())
            {
                return false;
            }
            return true;
        }
    }
}