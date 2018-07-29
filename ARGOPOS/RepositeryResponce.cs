using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.ItemCategories.DatabaseRepositery
{
    /// <summary>
    /// class represen the repository responce 
    /// </summary>
    public class RepositeryResponce
    {
        public RepositeryResponce()
        {

        }

        public RepositeryResponce(bool staus, string message, object data)
        {
            this.sucsess = staus;
            this.message = message;
            this.data = data;
        }
       /// <summary>
       /// responce status 
       /// </summary>
       public  bool sucsess { get; set; }

       /// <summary>
       /// responce meaasge.
       /// </summary>
       public  string message { get; set; }

       /// <summary>
       /// responce data.
       /// </summary>
       public object data { get; set; }

        
    }
}
