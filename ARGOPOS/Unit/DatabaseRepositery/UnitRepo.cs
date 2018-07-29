using ARGOPOS.Unit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Unit.DatabaseRepositery
{
   public class UnitRepo
    {
       private ArgoPosEntities dbentities;
        public UnitRepo()
        {
            dbentities = new ArgoPosEntities();
        }
        internal string SaveUnit(UnitDto posunit) {
            int sucses = 0;
            try
            {
                dbentities.pos_unit.Add(posunit.Map());
                 sucses = dbentities.SaveChanges();
            }
            catch(Exception exception)
            {

                return exception.Message;
            }
            if (sucses == 1)
            {
                return "save correctly";
            }
            else
            {
                return "some thing went wrong";
            }

        }


        public List<UnitDto> GetList()
        {
            List<UnitDto> list = new List<UnitDto>();
            dbentities.pos_unit.ToList().ForEach(unititem => list.Add(
                new UnitDto{
                    id = unititem.id,
                    posunit = unititem.unit,
                    posunitname = unititem.name
                }));

            return list;
        }

 
    }
}
