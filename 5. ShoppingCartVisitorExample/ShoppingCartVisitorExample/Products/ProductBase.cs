using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartVisitorExample.Products
{
    public abstract class ProductBase
    {
        public int Code { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string Category { get; set; }

        public ProductBase(int code, string name, string description, string category)
        {
            Code = code;
            Name = name;
            Description = description;
            Category = category;
        }

        public override string ToString()
        {
            return $"Code: {Code}, Name: {Name}, Description: {Description}, Category: {Category}";
        }

    }
}
