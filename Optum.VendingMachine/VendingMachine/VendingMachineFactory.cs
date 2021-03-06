using Optum.Services.Common;
using Optum.Services.VendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optum.Services.VendingMachine
{
    public class VendingMachineFactory : IVendingMachine
    {
        private static double _currentAmount;

        public VendingMachineFactory()
        {
            _currentAmount = 0.00;
        }
        public double CalcualteCurrentAmmount()
        {
            return _currentAmount;
        }

        public bool CheckValidityofCoin(string coinValue)
        {
            throw new NotImplementedException();
        }

        public void DispenseChange()
        {
            Console.WriteLine("\n Here is the Money .Please collect", _currentAmount.ToString());
        }

        public void DispenseProduct(MenuOption menuOption)
        {
            Console.WriteLine("\n Here is the Product .Enjoy", menuOption.ToString());
        }

        public void GetUserChoice(string coinValue, double menuOption)
        {
            throw new NotImplementedException();
        }
    }
}
