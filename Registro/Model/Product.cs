using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Model
{
    public struct Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        internal void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
