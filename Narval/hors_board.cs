using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class hors_board:ApplicationException
    {
        public hors_board(List<boat> lesboat)
        {
            Console.WriteLine("Tu place ton bateau hors de ton plateau de jeux");
            Console.WriteLine("Pense à la taille de ton bateau et à l orientation!");
            foreach (boat bat in lesboat)
            {
                Console.WriteLine(bat.Size);
                
            }
        }
    }
}
