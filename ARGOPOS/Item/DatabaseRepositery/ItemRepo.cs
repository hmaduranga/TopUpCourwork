using ARGOPOS.Item.Model;
using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Item.DatabaseRepositery
{
    public class ItemRepo
    {
        private ArgoPosEntities dbentities;
        public ItemRepo()
        {
            dbentities = new ArgoPosEntities();
        }

        public RepositeryResponce Save(pos_item item)
        {
            int sucses = 0;
            RepositeryResponce responce = new RepositeryResponce();
            try
            {
                if (item.id > 0)
                {
                    var current = dbentities.pos_item.Find(item.id);
                    dbentities.Entry(current).CurrentValues.SetValues(item);
                }
                else
                {
                    dbentities.pos_item.Add(item);
                }
                
                sucses = dbentities.SaveChanges();
            }
            catch (Exception exception)
            {
                responce.sucsess = false;
                responce.message = exception.Message;
                dbentities.pos_item.Remove(item);
                return responce;
            }
            if (sucses == 1)
            {
                responce.sucsess = true;
                responce.message = CatgoryConstant.Savesucses;
                return responce;
            }
            else
            {
                responce.sucsess = false;
                responce.message = CatgoryConstant.SaveError;
                return responce;
            }
        }



        public List<ItemDto> GetDisplayList()
        {

            List<ItemDto> responcelist = new List<ItemDto>();
            var list = dbentities.pos_item.ToList();
            list.ForEach(item =>
            {
                ItemDto itemDto = new ItemDto
                {
                    id = item.id,
                    positemname = item.itemname,
                    itemcatogory = item.pos_itemcategory.category,
                    discreption = item.discreption,
                    unit = item.pos_unit.name,
                    stock = item.pos_itemstock.Sum(stock => stock.curentstock),
                };


                responcelist.Add(itemDto);

            });

            return responcelist;
        }

        public RepositeryResponce Remove(int id)
        {
            int sucses = 0;
            RepositeryResponce responce = new RepositeryResponce();
            try
            {
                pos_item item = getByItemId(id);

                dbentities.pos_item.Remove(item);
               sucses = dbentities.SaveChanges();

            }catch(Exception exception)
            {

                responce.sucsess = false;
                responce.message = exception.Message;
            }

            if (sucses == 1)
            {
                responce.sucsess = true;
                responce.message = CatgoryConstant.Savesucses;
                return responce;
            }
            else
            {
                pos_item item = getByItemId(id);
                dbentities.Entry(item).State = EntityState.Unchanged;
                dbentities.SaveChanges();
                responce.sucsess = false;
                responce.message = CatgoryConstant.SaveError;
                return responce;
            }

        }

        public pos_item getByItemId(int id)
        {

            return dbentities.pos_item.Find(id);
        }
    }
}
