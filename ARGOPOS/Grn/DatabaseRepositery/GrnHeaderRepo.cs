using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Grn.DatabaseRepositery
{
  /// <summary>
  /// class reprent the grn headader db tan action
  /// </summary>
  public class GrnHeaderRepo
    {
        private ArgoPosEntities dbentities;
        
          public GrnHeaderRepo()
        {
          dbentities = new ArgoPosEntities();
        }

        public RepositeryResponce saveGrn(pos_grnheader grnheader)
        {
            int sucses = 0;
            try
            {
                dbentities.pos_grnheader.Add(grnheader);
              sucses = dbentities.SaveChanges();
            }
            catch (Exception exception)
            {
                dbentities.pos_grnheader.Remove(grnheader);
                return new RepositeryResponce(false,GrnConstances.SAVEERROR,null);
                
            }
            if (sucses == 1)
            {
              int id =  dbentities.pos_grnheader.OrderBy(header => header.time).ToList().Last().id;


                return new RepositeryResponce(true, GrnConstances.SAVESUCESS, new { id});
            }
            else
            {
                return new RepositeryResponce(false, GrnConstances.SAVEERROR, null);

            }
        }

        public List<string> getGrnNumberList()
        {
            List<string> stringlist = new List<string>();
            dbentities.pos_grnheader.ToList().ForEach(grnh => {
                                            stringlist.Add(grnh.number);
                
                });

            return stringlist;
        }

        public List<pos_item> getItemlistFroGrn()
        {

            return dbentities.pos_item.ToList();
        }


        public List<pos_supplier> GetSuppliersForGrn() {

            return dbentities.pos_supplier.ToList();
        }
    }
}
