using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioProduto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $" R$ {TotalPrice():F2} (Customs fee: R$ {CustomsFee:F2})";
        }

    }
}
