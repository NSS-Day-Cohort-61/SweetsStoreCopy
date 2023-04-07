using System;

using System.Collections.Generic;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Step 1:
                    Create at least one instance of each kind of candy
             */
             Lollipop lolly = new Lollipop();
             lolly.Name = "blue raz muhtazz";
             Console.WriteLine($"{lolly.Name}");

             Gummy gumgum = new Gummy();
             gumgum.Name = "gumby"; 
             Console.WriteLine($"{gumgum.Name}");

             Gummy gummyWorms = new Gummy();
             CandyBar snickers = new CandyBar();
             Cake RedVelvetCake = new Cake();




            /*
                Step 2:
                    Create at least one instance of each kind of baked good
             */

                Macaroon yellowMacaroon = new Macaroon();
                Pie ReesesPie = new Pie();




            /*
                Step 3:
                    Create a List<> and add all baked goods to the list
             */

             Macaroon pinkMacaroon = new Macaroon();
             Pie PecanPie = new Pie();
             Macaroon greenMacaroon = new Macaroon();
             Pie ChocolateMoussePie = new Pie();


             Licorice twisters = new Licorice();
             Sours warheads = new Sours();

             List<IBakedGoods> BakedList = new List<IBakedGoods>(); 
             BakedList.Add(PecanPie);
             BakedList.Add(greenMacaroon);
             BakedList.Add(yellowMacaroon);
             BakedList.Add(ReesesPie);

             foreach(var b in BakedList)
             {
                Console.WriteLine($"{b}");
             }


        }
    }
}
