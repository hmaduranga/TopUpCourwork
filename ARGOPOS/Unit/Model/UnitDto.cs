using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Unit.Model
{
    /// <summary>
    /// class represent the unit 
    /// </summary>
   public class UnitDto
    {
        public int    id { get; set; }
        public string posunit { get; set; }
        public string posunitname { get; set; }


        public pos_unit Map()
        {
            pos_unit posunit = new pos_unit
            {
                name = this.posunitname,
                unit = this.posunit,

            };
            return posunit;
        }

      
    }
}
