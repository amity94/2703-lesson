using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Shopping
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public Int32 Amount { get; set; }
        public Int32 Maavar { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}, id: {Id}, amount needed: {Amount}, isle: {Maavar}";
        }
    }
}
