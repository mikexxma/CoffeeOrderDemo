using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAppDesignDemo
{
   public class Order
    {
       private int orderedDonuts;
        private int orderedCake;
        private string orderedCoffee;
        private string orderedTime;
        public int OrderedDonuts { get; set; }
        public int OrderedCake { get; set; }
        public int OrderedTime { get; set; }
        public int OrderedCoffee { get; set; }
    }
}
