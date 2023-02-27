using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_Tovar_hw6
{
    class Tovar
    {
        string Name;
        public Tovar() { }
        public Tovar(string _Name) => Name = _Name;     
        public void Print() => Write($"{Name}");
    }
    class Prodact: Tovar
    {
        double Price;
        int Expiration;
        DateTime dd;
        public int Quantity { get; set; }
        public Prodact(string _Name, int _Expiration, double _price, DateTime _dd)
            : base(_Name)
        {
            Price = _price;
            Expiration = _Expiration;
            dd = _dd;
        }
        public new void Print() 
        {
            base.Print();
            WriteLine($" - цена: {Price} руб., срок годности (дни): {Expiration}, дата изготовления: {dd.ToShortDateString()} кол.-во: {Quantity} ");
        }
    }
    
    class Milk : Prodact 
    {
        public Milk(string _Name, int _Expiration, double _price, DateTime _dd)
            : base(_Name, _Expiration, _price,_dd) { }

        public void ShowMilk() =>WriteLine($"Хранить при температуре +2, +6");
    }
    class Air_freshener:Prodact
    {
        public Air_freshener(string _Name, int _Expiration, double _price, DateTime _dd)
            : base(_Name, _Expiration, _price,_dd) { }

        public void ShowAir() => WriteLine($"Огнеопасно. Не хранить возле огня");
    }
    class Bread : Prodact
    {
        public Bread(string _Name, int _Expiration, double _price, DateTime _dd)
            : base(_Name, _Expiration, _price, _dd) { }
    }
}
