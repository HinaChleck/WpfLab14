using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace WpfLab14
{
    public enum ProductTypes

    {
       Еда,
       [Description ("Бытовая техника")]
       Техника
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
