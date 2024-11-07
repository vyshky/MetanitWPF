using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_in_xmal_2._4
{
    class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Смартфон: {Name}; Цена: {Price};";
        }
    }
}
