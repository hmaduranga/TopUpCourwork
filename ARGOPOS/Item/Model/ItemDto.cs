using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Item.Model
{
   public class ItemDto
    {

        public int id { get; set; }
        public string positemname { get; set; }
        public string unit { get; set; }
        public string discreption { get; set; }
        public string itemcatogory { get; set; }
        public decimal stock { get; set; }

    }
}

