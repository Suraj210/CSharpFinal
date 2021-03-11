﻿using CSharpFinal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Interfaces
{
    interface IProduct
    {
      // Mehsullar
        void  ShowProduct();
      //Satisdan mehsulun geri qaytarilmasi
        string ProductSales();
      //Yeni mehsul elave etmek
        void AddProduct(Products product);
      //Mehsulun adini,sayini ve meblegini,categoriyasini deyismek
        void ChangeProductInfo();
      //Verilmis kateqoriyaya esasen hemin kateqoriyada olan mehsullarin qaytarilmasi
        string ProductForCategory();
      //Verilmis qiymet araligina esasen hemin araliqda olan mehsullarin qaytarilmasi
        string ProductForPrice();
      //Verilmis ada esasen mehsullarin search edilib qaytarilmasi
        void ShowProductForName();
    }
}
