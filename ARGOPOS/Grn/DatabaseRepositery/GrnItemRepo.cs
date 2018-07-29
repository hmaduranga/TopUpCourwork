using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Grn.DatabaseRepositery
{
   public class GrnItemRepo
    {
        private ArgoPosEntities dbentities;

        public GrnItemRepo()
        {
            dbentities = new ArgoPosEntities();
        }

        public string GetItemNameFromid(int id)
        {
           var item = dbentities.pos_item.Find(id);
            return item.itemname;

        }

        public RepositeryResponce SaveGrnItems(List<pos_grnitem> grnitemlist)
        {
            int sucsee = 0;
            try
            {
                dbentities.pos_grnitem.AddRange(grnitemlist);
               sucsee= dbentities.SaveChanges();

            }catch(Exception exception)
            {
                return new RepositeryResponce(false, "Error on item save", null);
            }
            if (sucsee == 1)
            {
                return new RepositeryResponce(true, "Sucsesfully saves", null);
            }
            else {
                return new RepositeryResponce(false, "Error on item save", null);
            }
        }
    }
}
