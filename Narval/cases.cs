
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class cases
    {
        private bool target = false;
        private bool used = true;
        private bool touch = false;
        private bool played = false;
        private int x;
        private int y;

        public cases(int x , int y, bool target, bool touch, bool played, bool used)
        {
            this.x = x;
            this.y = y;
            this.target = target;
            this.touch = touch;
            this.played = played;
            this.used = used;
        }
        public bool Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
            }
        }
        public bool Used
        {
            get
            {
                return used;
            }
            set
            {
                used = value;
            }
        }

        public bool Played
        {
            get
            {
                return played;
            }
            set
            {
                played = value;
            }
        }
        public bool Touch
        {
            get
            {
                return touch;
            }
            set
            {
                touch = value;
            }
        }
        public int X
        {
            get 
            
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            string s;
            if (target == true && touch == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                s = "X"; }
            else if (played == true && target == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                s = "O"; }
            else if (target == true && touch == false)
            { s = "."; }
            else
            { s = "."; }
            return s;
        }

        public string toucher()
        {
            string s;
            if (target == true && touch == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                s = "X";
            }
            else if (target == true && touch == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                s = "*";
            }
            else if (played == true && target == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                s = "O";
            }
            else
                s = ".";
            return s;

        }
       
    }
}
