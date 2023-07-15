using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao6Listas
{
    internal class Product
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product()
        {

        }
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string name, string description): this(id, name) 
        {
            Description = description;
        }

        public override string ToString()
        {
            return "ID: "+Id+" "+Name+" "+Description;
        }
    }
}
