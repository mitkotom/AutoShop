using AutoShop1.Data.Models;
using AutoShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop1.Controller
{
    public class CarController
    {
        private Auto_ShopContext Auto_ShopContext;

        public List<AutoShop> GetAll()
        {

            using (Auto_ShopContext = new Auto_ShopContext())
            {
                return Auto_ShopContext.AutoShop.ToList();
            }
        }

        public AutoShop Get(int id)
        {
            using (Auto_ShopContext = new Auto_ShopContext())
            {
                return Auto_ShopContext.AutoShop.Find(id);

            }
        }
        public void Add(AutoShop autoshop)
        {
            using (Auto_ShopContext = new Auto_ShopContext())
            {
                Auto_ShopContext.AutoShop.Add(autoshop);
                Auto_ShopContext.SaveChanges();

            }
        }

        public void Update(AutoShop autoshop)
        {
            using (Auto_ShopContext = new Auto_ShopContext())
            {
                var item = Auto_ShopContext.AutoShop.Find(autoshop.IdCar);
                if (item != null)
                {
                    Auto_ShopContext.Entry(item).CurrentValues.SetValues(autoshop);
                    Auto_ShopContext.SaveChanges();
                }

            }
        }

        internal void Add(Shop shop)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            
            using (Auto_ShopContext = new Auto_ShopContext())
            {
                var autoshop = Auto_ShopContext.AutoShop.Find(id);
                if (autoshop != null)
                {
                    Auto_ShopContext.AutoShop.Remove(autoshop);
                    Auto_ShopContext.SaveChanges();
                }
            }
        }

    }
}

