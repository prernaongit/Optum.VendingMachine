using System;
using System.Collections.Generic;
using System.Text;

namespace Optum.Services.Common
{
    public  class MenuOption
    {

       public static VendingMenuOption cola = new VendingMenuOption() { Title = "cola", Price = 0.01 };
        public static VendingMenuOption chips = new VendingMenuOption() { Title = "chips", Price = 0.50 };
        public static VendingMenuOption candy = new VendingMenuOption() { Title = "candy", Price = 0.65 };
    }

    public class VendingMenuOption
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public struct UserMenuOption
    {

        public const int cola =1;
        public const int chips = 2; 
        public const int candy = 3;
    }
}
