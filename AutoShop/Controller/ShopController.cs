using AutoShop1.Data.Models;
using AutoShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop1.Controller
{
    public class ShopController
    {
        private ShopContext auto_ShopContext;

        public List<Shop> GetAll()
        {

            using (auto_ShopContext = new ShopContext())
            {
                return auto_ShopContext.Shop.ToList();
            }
        }

        public Shop Get(int id)
        {
            using (auto_ShopContext = new ShopContext())
            {
                return auto_ShopContext.Shop.Find(id);

            }
        }
        public void Add(Shop autoshop)
        {
            using (auto_ShopContext = new ShopContext())
            {
                auto_ShopContext.Shop.Add(autoshop);
                auto_ShopContext.SaveChanges();

            }
        }

        public void Update(Shop shop)
        {
            using (auto_ShopContext = new ShopContext())
            {
                var item = (auto_ShopContext.Shop.Find(shop.IdShop));
                if (item != null)
                {
                    auto_ShopContext.Entry(item).CurrentValues.SetValues(shop);
                    auto_ShopContext.SaveChanges();
                }

            }
        }
        public void Delete(int id)
        {

            using (auto_ShopContext = new ShopContext())
            {
                var autoshop = auto_ShopContext.Shop.Find(id);
                if (autoshop != null)
                {
                    auto_ShopContext.Shop.Remove(autoshop);
                    auto_ShopContext.SaveChanges();
                }
            }
        }

    }
}
