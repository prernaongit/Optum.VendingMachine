using Optum.Services.VendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optum.Services.VendingMachine
{
    public class VendingMachineFactory : IVendingMachine
    {
        public double CalcualteCurrentAmmount()
        {
            throw new NotImplementedException();
        }

        public bool CheckValidityofCoin(string coinValue)
        {
            throw new NotImplementedException();
        }

        public double DispenseChange()
        {
            throw new NotImplementedException();
        }

        public void DispenseProduct()
        {
            throw new NotImplementedException();
        }

        public void GetUserChoice(string coinValue, double menuOption)
        {
            throw new NotImplementedException();
        }
    }
}
