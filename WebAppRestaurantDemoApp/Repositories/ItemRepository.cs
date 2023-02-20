using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class ItemRepository
    {
        private readonly RestaurantEntities1 restaurantDBEntities;
        public ItemRepository()
        {
            restaurantDBEntities = new RestaurantEntities1();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in restaurantDBEntities.Items
                                    select new SelectListItem
                                    {
                                        Text = obj.ItemName,
                                        Value = obj.ItemId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}