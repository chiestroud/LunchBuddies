using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName { get; set; }
        private List<string> Restaurants { get; } = new List<string> { "McDonald's", "Burger King", "Starbucks"};
        public Restaurant()
        {
            Random rand = new Random();
            int index = rand.Next(Restaurants.Count);
            RestaurantName = Restaurants[index];
        }
    }
}
