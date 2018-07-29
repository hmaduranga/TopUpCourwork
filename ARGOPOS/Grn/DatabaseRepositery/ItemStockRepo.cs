using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Grn.DatabaseRepositery
{
    public class ItemStockRepo
    {
        private ArgoPosEntities dbentities;
        public ItemStockRepo()
        {
            dbentities = new ArgoPosEntities();
        }

        public RepositeryResponce saveGrn(pos_grnitem grnitem)
        {
            int sucses = 0;
            try
            {
                dbentities.pos_grnitem.Add(grnitem);
                sucses = dbentities.SaveChanges();
            }
            catch (Exception exception)
            {
                return new RepositeryResponce(false, GrnConstances.SAVEERROR, null);
            }
            if (sucses == 1)
            {
                return new RepositeryResponce(true, GrnConstances.SAVESUCESS, null);
            }
            else
            {
                return new RepositeryResponce(false, GrnConstances.SAVEERROR, null);

            }
        }
    }
}
