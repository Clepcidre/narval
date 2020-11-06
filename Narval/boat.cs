using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Narval
{
    class boat
    {
        private string _nom;
        private int _size ;
        public boat(int _size, string _nom)
        {
            this._size = _size;
            this._nom = _nom;
            
                       
        }

            public int Size
            {
                get
                {
                    return _size;
                }
            }
            public string Name
            {
                get
                {
                    return _nom;
                }
            }
        }

}

