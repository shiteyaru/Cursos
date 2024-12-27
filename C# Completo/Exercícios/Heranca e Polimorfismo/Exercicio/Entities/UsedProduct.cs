using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities {
    internal class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price) {

            ManufactureDate = manufactureDate;

        }

        public override string PriceTag() {
            return $"{Name} (Used), R${Price} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
