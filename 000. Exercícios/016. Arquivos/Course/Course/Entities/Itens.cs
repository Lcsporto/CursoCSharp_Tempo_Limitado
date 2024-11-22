
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course.Entities
{
    internal class Itens
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Itens() { }

        public Itens(string name, string price, string quantity)
        {
            Name = name;
            Price = double.Parse(price, CultureInfo.InvariantCulture);
            Quantity = int.Parse(quantity);
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}
