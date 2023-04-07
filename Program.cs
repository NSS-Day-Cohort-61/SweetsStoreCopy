using System;

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




            /*
                Step 2:
                    Create at least one instance of each kind of baked good
             */





            /*
                Step 3:
                    Create a List<> and add all baked goods to the list
             */

        }
    }
}
