using Mr_Robot_Electronics.Command;
using Mr_Robot_Electronics.Model;
using Mr_Robot_Electronics.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mr_Robot_Electronics.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ShoppingCart ShoppingCart { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ICommand BuyCommand { get; set; }
        public ICommand CancelCommand { get; set; }
  
        public ProductViewModel()
        {

            Products = new ObservableCollection<Product>(ProductList.GetProducts());

            ShoppingCart = new ShoppingCart();

            BuyCommand = new RelayCommand(b => { var pt = b as Product;ShoppingCart.Products.Add(pt); }); ;
            CancelCommand = new RelayCommand(o=> { var pt = o as Product; ShoppingCart.Products.Remove(pt); });
        } 

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
