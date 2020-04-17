using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr_Robot_Electronics.Model
{
    public class ShoppingCart
    {
        public ObservableCollection<Product> Products { get; set; }


        public ShoppingCart()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}
