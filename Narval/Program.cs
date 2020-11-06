using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            player P1 = new player();
           // player P2 = new player();
            //while (continuer)
            {
                P1.b2.display2();
                P1.b1.display();
                Console.WriteLine("-------------------------------------------------");
                //Console.WriteLine(P1.name + " tire sur les bateaux de " +P2.name);
                //Console.WriteLine("_____________________________________________________");
                //P1.Shoot(P2.b1, P1.b2);
                //P2.b2.display2();
                //P2.b1.display();
                //Console.WriteLine("-------------------------------------------------");
                //Console.WriteLine(P2.name + " tire sur les bateaux de " + P1.name);
                //Console.WriteLine("_____________________________________________________");
                //P2.Shoot(P1.b1, P2.b2);
                ////int x = P1.b1.Position.Count;
                
                //Console.WriteLine(x);
                Console.ReadLine();
            }
           
        }
    }

}
