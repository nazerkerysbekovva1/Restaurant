using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class CustomerRepository
    {
        private readonly RestaurantEntities1 restaurantDBEntities;
        public CustomerRepository()
        {
            restaurantDBEntities = new RestaurantEntities1();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in restaurantDBEntities.Customers
                                    select new SelectListItem
                                    {
                                        Text = obj.CustomerName,
                                        Value = obj.CustomerId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}