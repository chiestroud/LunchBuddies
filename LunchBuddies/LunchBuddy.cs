using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public void eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"Your lunch buddy, {FirstName} {LastName}, is at {restaurant.RestaurantName}");
        }

        public void eat(string food)
        {
            Console.WriteLine($"Your lunch buddy, {FirstName} {LastName}, ate the {food} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"Your lunch buddy, {FirstName} {LastName}, is at {restaurant.RestaurantName} with the following friends");
            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"Your friend, {FirstName} {LastName}, is at {restaurant.RestaurantName} and having {food} with the following friends");
            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }
    }
}
