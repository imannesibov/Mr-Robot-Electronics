using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr_Robot_Electronics.Model
{
    public class Product : Entitiy
    {
        public string Image { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string About { get; set; }

    }
}
