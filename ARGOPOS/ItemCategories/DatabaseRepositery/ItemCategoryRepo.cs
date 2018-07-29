using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.ItemCategories.DatabaseRepositery
{
    public class ItemCategoryRepo
    {
        private ArgoPosEntities dbentities;
        public ItemCategoryRepo()
        {
            dbentities = new ArgoPosEntities();
        }


        public List<pos_itemcategory> GetList()
        {
            return dbentities.pos_itemcategory.ToList();
        }

        public RepositeryResponce Save(pos_itemcategory itemcategory)
        {
            int sucses = 0;
            RepositeryResponce responce = new RepositeryResponce();
            try
            {
                if (itemcategory.id >0) {

                    var current = dbentities.pos_itemcategory.Find(itemcategory.id);
                    dbentities.Entry(current).CurrentValues.SetValues(itemcategory);
                }
                else
                {
                    dbentities.pos_itemcategory.Add(itemcategory);

                }
               sucses = dbentities.SaveChanges();

            }
            catch (Exception exception)
            {
                responce.sucsess = false;
                responce.message = exception.Message;
                return responce ;
            }
            if (sucses == 1)
            {
                responce.sucsess = true;
                responce.message = CatogoryConstant.Savesucses;
                return responce;
            }
            else
            {
                responce.sucsess = false;
                responce.message = CatogoryConstant.SaveError;
                return responce;
            }
        }



        public RepositeryResponce remove(int id)
        {
            int sucses = 0;
            RepositeryResponce responce = new RepositeryResponce();
            try
            {

               pos_itemcategory itemcatogory = dbentities.pos_itemcategory.Find(id);
                dbentities.Entry(itemcatogory).State = EntityState.Deleted;
                sucses = dbentities.SaveChanges();

            }
            catch (Exception exception)
            {

                responce.sucsess = false;
                responce.message = exception.Message;
                dbentities.pos_itemcategory.AsNoTracking();
            }

            if (sucses == 1)
            {
                responce.sucsess = true;
                responce.message = CatogoryConstant.Savesucses;
                return responce;
            }
            else
            {
                pos_itemcategory itemcatogory = dbentities.pos_itemcategory.Find(id);
                dbentities.Entry(itemcatogory).State = EntityState.Unchanged;
                sucses = dbentities.SaveChanges();
                responce.sucsess = false;
                responce.message = CatogoryConstant.SaveError;
                return responce;
            }
        }
    }
}
