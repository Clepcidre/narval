using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class player
    {
        private string _nom;
        public board b1;
        public board b2;
        private List<boat> lesboat = new List<boat>();
        



        public player()
        {
            b1 = new board();
            b2 = new board();
            getName();
            flotte();
            Amarrer(lesboat);
        }

        public void Amarrer(List<boat> lesboat)
        {
            foreach (boat bat in lesboat)
            {
                Console.WriteLine(bat.Name+"  " + bat.Size + "  cases");
            }
            foreach (boat bat in lesboat)
            {


                bool isok;
                do
                
                {
                    isok = true;
                    Console.WriteLine("Donner la position du haut de votre " + bat.Name + " en X");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Donner la position du haut du navire en Y");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Positionnement Vertical (1) ou Horizontal (2) ");                  
                    int direction = int.Parse(Console.ReadLine());

                    switch (direction)
                    {
                        case 2:
                            {
                                if ((-1+x + bat.Size > 9) ||  (b1.Vues[x, y].Used == true))
                                {
                                    isok = false;
                                }  
                                else
                                {
                                    for (int i = y; i <= - 1+y + bat.Size ; i++)
                                    {


                                        b1.Position.Add(new cases(x, i, true, false, false, false));
                                        b1.changetype(x, i);
                                        b1.changeUsed(x, i);
                                        b2.changetype(x, i);
                                        
                                    }
                                }       
                                break;
                            }
                        case 1:
                            {
                                if ((y-1 + bat.Size > 9) || (b1.Vues[x, y].Used == true))
                                {
                                    isok = false;
                                }
                                else
                                {
                                    for (int i = x; i <= - 1+x + bat.Size ; i++)
                                    {

                                        b1.Position.Add(new cases(i, y, true, false, false, false));
                                        b1.changetype(i, y);
                                        b1.changeUsed(i, y);
                                        b2.changetype(i, y);
                                    }                                  
                                }
                            }                            
                            break;                           
                    }
                }
                while (isok == false);
             

            }

        }

        public void flotte()
        {
            boat bat1 = new boat(5, "porte-avion");
            lesboat.Add(bat1);
            boat bat2 = new boat(4, "croiseur");
            lesboat.Add(bat2);
            boat bat3 = new boat(3, "contre-torpilleur");
            lesboat.Add(bat3);
            boat bat4 = new boat(3, "sous-marin");
            lesboat.Add(bat4);
            boat bat5 = new boat(2, "torpilleur");
            lesboat.Add(bat5);
        }

        private void getName()
        {
            Console.WriteLine("Entrer le nom du joueur ");
            _nom = Console.ReadLine();

        }


        public void Shoot(board b, board bb)
        {

            Console.WriteLine("Entrer les coordonner en X ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer les coordonner en Y ");
            int y = int.Parse(Console.ReadLine());
            if (b.Vues[x, y].Target == true)
            {
                b.hitboat(x, y);
                bb.play(x, y);
            }
            else
            {
                b.Vues[x, y].Played = true;
                bb.Vues[x, y].Played = true;
            }
            if (bb.Vues[x, y].Target == true)
            {
                bb.hitboat(x, y);
                b.play(x, y);
            }
            else 
            {
                bb.Vues[x, y].Played = true;    
            }
        }

        public List<boat> Lesboat
        {
            get
            {
                return lesboat;
            }

            set
            {
                value = lesboat;
            }
        
        }


        public string  name
        {
            get {
                return _nom;
                }
        }
    }
}
