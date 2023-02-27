using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_Tovar_hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Домашнее задание № 6 (Товар)";
            SetWindowSize(100, 40);

            List<Prodact> l1=new List<Prodact>            
            {
                new Milk("Milk",14,34.6, DateTime.Now),
                new Air_freshener("Air", 365,145.5,DateTime.Now),
                new Bread("Bread", 5,35,DateTime.Now)
            };
            Prodact pr = new Milk("Milk2", 14, 56, DateTime.Now);
            pr.Quantity = 50;

            l1.Add(pr);

            foreach (var item in l1)
            {
                item.Quantity = 100;
                item.Print();
                if (item is Milk) 
                {
                    (item as Milk).ShowMilk();
                }
                else if (item is Air_freshener)
                {
                    (item as Air_freshener).ShowAir();
                }
                WriteLine();
            }         
        }  
    }
}
