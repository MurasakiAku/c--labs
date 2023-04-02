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
            Seller seller1 = new Seller()
            {
                Id = 1,
                FirstName = "Иван",
                LastName = "Иванович",
                Fatherland = "Иванов"
            };
            Seller seller2 = new Seller()
            {
                Id = 2,
                FirstName = "Карнаков",
                LastName = "Матвей",
                Fatherland = "Александрович"
            };
            SellerCategory category1 = new SellerCategory()
            {
                Id = 1,
                SellerCategories = "Ученик"
            };
            SellerCategory category2 = new SellerCategory()
            {
                Id = 2,
                SellerCategories = "Кассир"
            };
            SellerCategory category3 = new SellerCategory()
            {
                Id = 3,
                SellerCategories = "Старший кассир"
            };

            Cash cash1 = new Cash()
            {
                Id = 1,
                CashNumber = 1
            };
            Cash cash2 = new Cash()
            {
                Id = 2,
                CashNumber = 2
            };
            Sale sale1 = new Sale()
            {
                Id = 1,
               // DateTime = ""
            };

        }
    }
}
