using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    class Ini : DropCreateDatabaseIfModelChanges<MarketModel>
    {
        protected override void Seed(MarketModel db)
        {
            Seller s1 = new Seller()
            {
                FirstName = "Иван",
                LastName = "Иванович",
                Fatherland = "Иванов"
            };
            Seller s2 = new Seller()
            {
                FirstName = "Карнаков",
                LastName = "Матвей",
                Fatherland = "Александрович"
            };
            SellerCategory category = new

            Cash cash = new Cash()
            {
                Id = 1,
                CashNumber = 1
            };

        }
    }
}
