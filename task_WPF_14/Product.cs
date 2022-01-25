using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_WPF_14
{
    public enum Category
    {
        Food,
        HouseholdAppliances,
        Transport,
        Furniture
    }
    internal class Product
    {
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return NameProduct;
        }
    }
}
