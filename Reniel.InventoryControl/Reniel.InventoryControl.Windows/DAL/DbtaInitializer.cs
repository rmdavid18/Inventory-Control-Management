using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reniel.InventoryControl.Windows.DAL
{
    public class DbtaInitializer : System.Data.Entity.DropCreateDatabaseAlways<ProductsDBContex>
    {
        protected override void Seed(ProductsDBContex context)
        {



            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("9c6e0f45-9e98-4636-b9f1-76c8746a694a"),
                ProductName = "zesto",
                Brand = "ZEST-0",
                Price = decimal.Parse("10"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("9c6e0f45-9e98-4636-b9f1-76c8746a694b"),
                ProductName = "Pepsi",
                Brand = "PEPSI",
                Price = decimal.Parse("15"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("b2e20675-83aa-482d-8ad2-7b54ea5022ef"),
                ProductName = "Fanta",
                Brand = " Coca-Cola ",
                Price = decimal.Parse("40"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("9fb75c2e-4c25-4817-8513-17cb73dddb9e"),
                ProductName = "Coca Cola",
                Brand = " Coca-Cola ",
                Price = decimal.Parse("100"),
               



            });
           context.Products.Add(new Models.Product()
           {
               ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df5d8"),
               ProductName = "Sprite",
               Brand = " Coca-Cola ",
               Price = decimal.Parse("12"),
              


           });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("b056d578-ed0d-4ec3-a0fc-b7397021e74b"),
                ProductName = "Jtson Soft Drink",
                Brand = " Jtson",
                Price = decimal.Parse("16"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("aa40d9e4-6afe-4ec2-b883-8767f7957270"),
                ProductName = "Litchi Soft Drink",
                Brand = "Frojo",
                Price = decimal.Parse("35"),
               


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("65fe9f18-b860-4ae5-a875-ad14ca3f20cc"),
                ProductName = "Vanguard Soft Drink ",
                Brand = "Vanguard",
                Price = decimal.Parse("25"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("18ae5b50-5bb3-4c14-bee5-5a8470286e33"),
                ProductName = "Fru Fizzy Carbonated Soft Drink",
                Brand = "Fru Fizzy",
                Price = decimal.Parse("11"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("c82fc87b-5ecb-4485-bb76-664a9e2e77d9"),
                ProductName = "ARIMA SIZZLERZ (SOFT DRINKS-SODA)",
                Brand = "ARIMA -SIZZLERZ",
                Price = decimal.Parse("9"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("625475ee-1b25-4ecb-8833-5cce854b1e82"),
                ProductName = "Green Shahi Pepio Flavour",
                Brand = "Shahi",
                Price = decimal.Parse("16"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("d67fe6f2-8499-41ea-9d23-f09569a49d7d"),
                ProductName = "Golden Crown Mintanine Soft Drink",
                Brand = "Golden Crown",
                Price = decimal.Parse("111"),
              


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("2b624e15-ab76-418a-b67b-bd42f20fd9a6"),
                ProductName = "Soft Drink Green KANHAIYYA LEMON",
                Brand = " Kanhaiyya",
                Price = decimal.Parse("18"),
               


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("3d21f19d-7039-42d4-b833-8b1c806fe3d4"),
                ProductName = "Campa Lemon ",
                Brand = "Campa",
                Price = decimal.Parse("17"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("d92354a9-fc5f-4ac7-9199-b72840d26433"),
                ProductName = "Mountain Dew Cold Drink",
                Brand = "Mountain Dew",
                Price = decimal.Parse("31"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("9f2d49d8-3864-42b0-a377-ef4ef3aefc9b"),
                ProductName = "Black King Plus Cola Soft Drink",
                Brand = "King Plus",
                Price = decimal.Parse("23"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("114bbee1-7304-418d-a2a6-80f836a1153b"),
                ProductName = "Baisaly Orange Zeera Masti Soft Drink",
                Brand = "Baisaly",
                Price = decimal.Parse("34"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("0545f508-b42b-487b-991b-d7aed539f45e"),
                ProductName = "Jeera Masala",
                Brand = "krispy",
                Price = decimal.Parse("90"),
                



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("0fd9d6eb-a72f-47bd-acaa-2585277735ea"),
                ProductName = "Black Energy Drink Kings Cola",
                Brand = "Cola",
                Price = decimal.Parse("111"),
              


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("c1e74c03-773b-4ce4-9646-60dbb5a38731"),
                ProductName = "Bovonto Soft Drinks",
                Brand = "kalimark",
                Price = decimal.Parse("67"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("4e38edee-ed91-4140-b7a0-816e0d16f883"),
                ProductName = "Liquid O Smart Ginger Ale",
                Brand = "O Smart",
                Price = decimal.Parse("90"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("d9531217-66ad-4ad6-a987-72bcaef95ddb"),
                ProductName = "Schweppes Ginger Ale Cold Drink",
                Brand = " Schweppes",
                Price = decimal.Parse("89"),



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("97f8be95-0b4a-4cf9-8b30-3ba4bf76c779"),
                ProductName = "Juci Life Soft Drink",
                Brand = "Juci Life",
                Price = decimal.Parse("78"),
              



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("28802cd0-cd3b-4a34-9d9b-37a7fef48efe"),
                ProductName = "White Lemon",
                Brand = "Limca",
                Price = decimal.Parse("67"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df5d9"),
                ProductName = "Fruit Juice King Peters Non Alcoholic Soft Drink",
                Brand = "M/s Five Star Beverages",
                Price = decimal.Parse("100"),
               


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df510"),
                ProductName = "Softy Lime Lemon Soft Drink",
                Brand = " Softy",
                Price = decimal.Parse("25"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df511"),
                ProductName = "Yellow KAFPI Ginger Carbonated Soft Drink",
                Brand = "KAFPI",
                Price = decimal.Parse("25"),
               



            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df512"),
                ProductName = "He-Man Soft Drinks Lemon Soda",
                Brand = "He-Man",
                Price = decimal.Parse("25"),
               


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df513"),
                ProductName = "Jeera Masala Cold Drink",
                Brand = "mrt",
                Price = decimal.Parse("25"),
                


            });
            context.Products.Add(new Models.Product()
            {
                ProductID = Guid.Parse("cc3c1757-5b7f-40ef-a574-a800b71df514"),
                ProductName = "Mann Socio Drink",
                Brand = "Mann",
                Price = decimal.Parse("103"),
                    



            });





        }

    }
}
