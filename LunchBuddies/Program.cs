using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var chie = new LunchBuddy("Chie", "Stround");
            chie.eat();
            var rob = new LunchBuddy("Rob", "Stround");
            rob.eat("Natto");

            var noOne = new LunchBuddy("No", "One");
            noOne.eat(new List<LunchBuddy>() { new LunchBuddy("Frog", "Mr."), new LunchBuddy("Cup", "ofTea") });

            var whale = new LunchBuddy("Whale", "Sea");
            whale.eat("Spaghetti", new List<LunchBuddy>() { new LunchBuddy("Dolphin", "King"), new LunchBuddy("Fish", "Tank") });
        }
    }
}
