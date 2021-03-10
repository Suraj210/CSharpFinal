using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Items
    {
        public int Number { get; set; }
        public string  Product { get; set; }

        public readonly int Id;
        private static int _id = 0;

        public Items()
        {
            _id++;
            Id = _id;
        }
    }
}
