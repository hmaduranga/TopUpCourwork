using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ARGOPOS
{
   public static  class CustomeValidator
    {

        public static bool IsvalidName(string name)
        {

            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
    }
}
