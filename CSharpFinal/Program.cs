using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFinal.Classes;
using CSharpFinal.Interfaces;



namespace CSharpFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();

            //Products product1 = new Products("Qatiq", 2.50, 3);
            //Products product2 = new Products("Kesmik",3.45,12);
            //product1.AddProduct();
            //Console.WriteLine(product2);
            //List<Products> products = new List<Products>();
            //products.Add(product1); 

        }

        

        public  static void Start()
        {
            Console.WriteLine("1-Satislar uzerinde emeliyyat aparmaq");
            Console.WriteLine("2-Sistemden cixmaq");
            Console.WriteLine("3-Duzgun reqem daxil edin edin");
            Console.WriteLine("Reqem daxil et");
            string a = Console.ReadLine();
            if (a=="1")
            {
                Console.WriteLine("Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("1-Yeni mehsul elave et");
                Console.WriteLine("2-Mehsul uzerinde duzelis et");
                Console.WriteLine("3-Mehsulu sil");
                Console.WriteLine("4-Butun mehsullari goster");
                Console.WriteLine("5-Categoriyasina gore mehsullari goster");
                Console.WriteLine("6-Qiymet araligina gore mehsullari goster");
                Console.WriteLine("7-Mehsullar arasinda ada gore axtaris et");
                string a1 = Console.ReadLine();
                switch (a1)

                {

                    case "1":
                        Products product1 = new Products();
                        Products product2 = new Products();
                        product1.AddProduct(product1);
                        product2.AddProduct(product2);
                        product1.ShowProduct();
                        product2.ShowProduct();
                        //Console.WriteLine($"{product1.Name},{product1.Price },{ product1.Number}");                       
                        break;

                    case "2":
                        Console.WriteLine("2-Mehsul uzerinde duzelis et");
                        break;
                    case "3":
                        Console.WriteLine("3-Mehsulu sil");
                        break;
                    case "4":
                        Console.WriteLine("4-Butun mehsullari goster");
                        break;
                    case "5":
                        Console.WriteLine("5-Categoriyasina gore mehsullari goster");
                        break;
                    case "6":
                        Console.WriteLine("6-Qiymet araligina gore mehsullari goster");
                        break;
                    case "7":
                        Console.WriteLine("7-Mehsullar arasinda ada gore axtaris et");
                        break;
                    default:
                        Console.WriteLine("Duzgun reqem daxil edin{1,2,3,4,5,6,7}");
                        break;
                }
            }
            else if (a=="2")
            {
                Console.WriteLine("Satislar uzerinde emeliyyat aparmaq");
            }
            else if (a=="3")
            {
                Console.WriteLine("Sistemden cixmaq");
            }
            else
            {
                Console.WriteLine("Duzgun reqem daxil edin edin");
            }
            
        }

        private static object AddProduct()
        {
            throw new NotImplementedException();
        }
    }
}
