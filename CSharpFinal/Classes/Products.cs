using CSharpFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class  Products:IProduct
    {
        List<Products> products= new List<Products>();

        public string Name { get; set; }
        public double Price { get; set; }
        public enum Category { }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Products()
        {
            _id++;
            Id = _id++;
        }
        public Products(string name, double price,int number)
        {
            Name = name;
            Price = price;
            Number = number;

        }

        void IProduct.Products()
        {
            throw new NotImplementedException();
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProduct()
        {
            Console.WriteLine("Yeni mehsul elave et");
            Console.WriteLine("Mehsulun Adin Daxil edin");
            Name = Console.ReadLine();
            Console.WriteLine("Mehsulun Qiymetin Daxil Edin");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mehsulun Sayin Daxil Edin");
            Number = Convert.ToInt32(Console.ReadLine());
            products.Add(new Products(Name, Price, Number));
           
        }

        public void ChangeProductInfo()
        {
            throw new NotImplementedException();
        }

        public string ProductForCategory()
        {
            throw new NotImplementedException();
        }

        public string ProductForPrice()
        {
            throw new NotImplementedException();
        }

        public void ShowProductForName()
        {
            throw new NotImplementedException();
        }
    }
}
