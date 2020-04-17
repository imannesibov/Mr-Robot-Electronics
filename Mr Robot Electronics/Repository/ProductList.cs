using Mr_Robot_Electronics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr_Robot_Electronics.Repository
{
    public static class ProductList
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                  Image = "/Images/acer.jpg",
                  Model = "Acer Extensa 15 EX2519-C298",
                  About = "Intel® Inside N3060/\nDDR3L 4 GB/ HDD 500 GB/ HD LED 15.6 / Wi-Fi",
                  Price = 546,
                },

                new Product
                {
                  Image =  "/Images/hp.jpg",
                  Model =  "HP ENVY 13-ah1025cl (5HS18UA)",
                  About =  "Intel® Core™ i7-8565U | LPDDR3 16 GB 2133 MHz \n| NVIDIA® GeForce® MX150 | 512 GB PCIe® NVMe™ M.2 SSD \n| IPS 4K UHD 13.3-inch  | Windows 10 License",
                  Price =  2599,
                },

                new Product
                {
                  Image =  "/Images/acer_aspire.png",
                  Model =  "Acer Aspire A5 A515-54-75VH (NX.HDJAA.005)",
                  About =  "Intel® Core™ i7-8565U | DDR4 12 GB 2666 MHz | Intel UHD620 \n| SSD NVMe 256 GB  | FHD 15.6-inch | no DVD | Windows 10",
                  Price =  1750,
                },

                new Product
                {
                  Image =  "/Images/msi.jpg",
                  Model =  "MSI GP73 8RE Leopard",
                  About =  "Intel® Core™ i7-8750H | DDR4 16 GB | SSD 128 GB | HDD 1 TB \n| NVIDIA® GeForce® GTX1060 6 GB | LED IPS FHD 17,3-inch 120 Hz | Win10 ",
                  Price =  3332,
                },

                new Product
                {
                  Image =  "/Images/asus.jpg",
                  Model =  "ASUS ROG Strix GL704GW-PS74 Scar II Edition (90NR00M1-M01460)",
                  About =  "Intel® Core™ i7-8750H | DDR4 16 GB | SSD 512 GB | NVIDIA® GeForce® RTX 2070 8 GB \n| LED IPS FHD 17,3-inch 144 Hz | Win10",
                  Price =  5163,
                },

                new Product
                {
                  Image =  "/Images/lenovo.jpg",
                  Model =  "Lenovo ThinkPad X1 Carbon 7th Gen (20QD0031RT)",
                  About =  "Intel® Core™ i7-8565U | LPDDR3 8 GB | Intel UHD620 \n| SSD 512 GB  | FHD 14-inch  | Windows 10 License",
                  Price =  3238,
                },

                new Product
                {
                  Image =  "/Images/dell.jpg",
                  Model =  "Dell Inspiron 3584-2077",
                  About =  "Intel® Core™ i3-7020U | DDR4 4 GB 2666 MHz | SSD NVme 128 GB \n|  Intel® UHD Graphics 620 | FHD 15.6-inch | Wi-Fi | FreeDos | no DVD",
                  Price =  699,
                },

                new Product
                {
                  Image = "/Images/AcerPredator.png",
                  Model =  "Acer Predator Helios 300 PH315-52-718G (NH.Q54ER.004)",
                  About =  "Intel® Core™ i7-9750H | DDR4 16 GB 2666 MHz | NVIDIA GeForce® RTX2060 6 GB \n| SSD 256 GB | HDD 1 TB  | IPS FHD 15.6-inch 144 Hz",
                  Price =  3333,
                },

                new Product
                {
                  Image =  "/Images/mac.jpg",
                  Model =  "Apple MacBook Pro 13 2017 Version (MPXQ2LL/A)",
                  About =  "Core i5/DDR3 8Gb/SSD 128 GB\n/Retina Display 13.3/2017 Version",
                  Price =  2975,
                },

                new Product
                {
                  Image =  "/Images/flex.jpg",
                  Model =  "Lenovo Flex Pro 3IKB 2 in 1 (81TF0001US) TouchScreen",
                  About =  "Intel® Core™ i7-8550U | DDR4 12 GB 2666 MHz \n| Intel® UHD Graphics 620 | SSD 256 GB | TouchScreen FHD 13.9-inch | Windows 10 License",
                  Price = 2199,
                },

            };
        }
    }
}
