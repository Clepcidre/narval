using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class board
    {
        private List<cases> position = new List<cases>();
        private cases[,] vue = new cases[11, 11];


        public board()
        {
            for (int i = 0; i <=9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    vue[i, j] = new cases(i,j,false, false, false, false);
                }
            }

        }

        public void changetype(int x,int y)
        {
           
                vue[x, y].Target = true;
           
         
        }
        public void changeUsed(int x, int y)
        {
            vue[x, y].Used = true;
        }

        public void hitboat(int x, int y)
        {
            vue[x, y].Touch = true;
        }

        public void play(int x, int y)
        {
            vue[x, y].Played = true;
        }

        public List<cases> Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }


               
        public void display()
        {

            for ( int i = 0; i <= 9;  i++)
            {
                Console.WriteLine();
                if (i == 0)
                    Console.WriteLine("0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");
                                
               
                    
                for (int j = 0; j <= 9; j++)
                {
                    if (j == 0)
                        Console.Write(colonne(i));
                    else
                    {
                        if (i == 0)
                        {}
                        else
                        {
                                
                               
                                Console.Write(vue[i, j].toucher());
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" | ");
                        }
                        
                    }

                }
                Console.WriteLine();
                Console.Write("----------------------------------------");

            }
        }




        public void display2()
        {

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine();
                if (i == 0)
                    Console.WriteLine("0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |");



                for (int j = 0; j <= 9; j++)
                {
                    if (j == 0)
                        Console.Write(colonne(i));
                    else
                    {
                        if (i == 0)
                        { }
                        else
                        {


                            Console.Write(vue[i, j].ToString());
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(" | ");
                        }

                    }

                }
                Console.WriteLine();
                Console.Write("----------------------------------------");

            }
        }











        private string colonne(int i)
        {
            string str = " ";
            switch (i)
            { 
                case 0:
                break;
                case 1:
                str = "A" + " | ";
                    break;
                case 2:
                    str = "B" + " | ";
                    break;
                case 3:
                    str = "C" + " | ";
                    break;
                case 4:
                    str = "D" + " | ";
                    break;
                case 5:
                    str = "E" + " | ";
                    break;
                case 6:
                    str = "F" + " | ";
                    break;
                case 7:
                    str = "G" + " | ";
                    break;
                case 8:
                    str = "H" + " | ";
                    break;
                case 9:
                    str = "I" + " | ";
                    break;
                case 10:
                    str = "J" + " | ";
                    break;
            }
            return str;
        }


       

        public cases [,] Vues 
        
        {
            get
            {
                return vue;
            }
            set
            {
                vue = value;
            }
        }




        
    }
    

   
}
