using System;
using System.Collections.Generic;
using System.Text;

namespace Optum.Services.VendingMachine.Interfaces
{
   public interface IVendingMachine
    {


        /// <summary>
        /// Gets  the coin from the User and calcuates its Value
        /// </summary>
        /// <param name="coinValue">The Coin Value.</param>
        /// <param name="menuOption">The vending Machine menu opton.</param>
        /// <returns>boolean value true if coin is valid </returns>
        public void GetUserChoice(string coinValue ,double menuOption);
        /// <summary>
        ///  Calculate coin validity  
        /// </summary>
        /// <param name="coinValue">The Coin Value.</param>
        /// <returns>boolean value true if coin is valid </returns>
        public bool CheckValidityofCoin(string coinValue);

        /// <summary>
        /// calcualtes current ammount for current User 
        /// </summary>
        /// <param name="">.</param>
        /// <returns>value of existing amount </returns>
        public double CalcualteCurrentAmmount();

        /// <summary>
        /// Dispense the Product 
        /// </summary>
        /// <param name=""></param>
        /// <returns> </returns>
        public void DispenseProduct();

        /// <summary>
        /// calcualtes current ammount for current User after product dispense
        /// </summary>
        /// <param name="">.</param>
        /// <returns></returns>
        public double DispenseChange();
    }
}
