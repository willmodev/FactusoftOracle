using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal UnitValue { get; set; }
        public string UnitMeasure { get; set; }
        public float Quantity { get; set; }
        public decimal IVA { get; set; }


    }
}
