using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppSalescomp
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public Componentcs Componentcs { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quntity { get; set; }

        public override string ToString()
        {
            return $"Name-{Name} | Price -{Price}грн";
        }
    }
}
