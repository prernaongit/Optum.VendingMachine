using Optum.Services.Common;
using Optum.Services.VendingMachine;
using System;

namespace Optum.VendingMachine
{
    class Program
    {
        //static MenuOption menuOption;
        VendingMachineFactory factory = new VendingMachineFactory();
        public double UserCoin;
        MenuOption MenuOptionObj = new MenuOption();
        public static void VendionMachineFunction() 
        {
            try
            {


                Console.Write("Enter Menu option :1 for Cola  2 for Chips  3 for Cola ");
                int _UserMenuOption = int.Parse(Console.ReadLine());
                switch (_UserMenuOption)
                {
                    case UserMenuOption.cola:

                        
                            //var = MenuOption.cola.Price;
                        break;
                    case UserMenuOption.chips:

                        //var price = MenuOption.cola.Price;
                        break;

                    case UserMenuOption.candy:

                        //var price = MenuOption.cola.Price;
                        break;

                    default:
                        Console.WriteLine("The item  is unknown. Please press something from Menu");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.Write("exception: " + e);
            }
            finally
            {

                Console.ReadKey();
            }
            Console.Write("Enter money /n");
                try {
                    double UserMoney = double.Parse(Console.ReadLine());

                     
                }

            catch (Exception e)
            {
                Console.Write("exception: " + e);
            }
            finally 
            {

                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User ! Welcome ");
            VendionMachineFunction();
        }
    }
}
