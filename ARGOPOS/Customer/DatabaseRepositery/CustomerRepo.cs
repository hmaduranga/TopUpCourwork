using ARGOPOS.ItemCategories.DatabaseRepositery;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Customer.DatabaseRepositery
{
   public class CustomerRepo
    {
        private ArgoPosEntities dbentities;
        public CustomerRepo()
        {
            dbentities = new ArgoPosEntities();
        }


        public List<pos_customer> getList()
        {

            return dbentities.pos_customer.ToList();
        }


        public RepositeryResponce Save(pos_customer customer)
        {
            int sucsess = 0;
            

            try
            {
                if(customer.id > 0)
                {
                    //pos_customer curentcustomer = findbyId(customer.id);
                    //dbentities.Entry(curentcustomer).CurrentValues.SetValues(customer);
                    dbentities.Entry(customer).State = EntityState.Modified;
                }
                else
                {
                    dbentities.pos_customer.Add(customer);
                }

              sucsess =  dbentities.SaveChanges();
            }catch(Exception exeption)
            {

                return new RepositeryResponce(false, CustomerConstance.SAVEERROR, null);
            }


            if(sucsess == 1)
            {
                return new RepositeryResponce(true, CustomerConstance.SAVESUCESS, null);
            }
            else
            {

                return new RepositeryResponce(false, CustomerConstance.SAVEERROR, null);
            }
        }

        public RepositeryResponce Remove(int id)
        {
            int sucsess = 0;


            try
            {


                    pos_customer customer =   findbyId(id);
                    dbentities.Entry(customer).State = EntityState.Deleted;
               
                sucsess = dbentities.SaveChanges();
            }
            catch (Exception exeption)
            {

                return new RepositeryResponce(false, CustomerConstance.SAVEERROR, null);
            }


            if (sucsess == 1)
            {
                return new RepositeryResponce(true, CustomerConstance.SAVESUCESS, null);
            }
            else
            {

                return new RepositeryResponce(false, CustomerConstance.SAVEERROR, null);
            }

        }


        public pos_customer findbyId(int id)
        {
            return dbentities.pos_customer.Find(id);
        }


        public List<pos_customer> getSourtby(bool ase)
        {
            if (ase) {
                return dbentities.pos_customer.OrderBy(customer => customer.loyaltypoint).ToList();
            }
            else
            {
                return dbentities.pos_customer.OrderByDescending(customer => customer.loyaltypoint).ToList();

            }
            
        }
    }
}
