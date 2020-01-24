using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Book
{
    public interface ICoinLogic
    {
        bool AddCoin(CommonCoin theCoin);
        bool DeleteCoin(CommonCoin theCoin);
        List<DatabaseDataSet.tblCoinDataRow> GetData();
    }

    public class BusinessLogicCoins : ICoinLogic
    {
        private BackendCode backendCode = new BackendCode();

        public bool AddCoin(CommonCoin theCoin)
        {
            try
            {
                if (backendCode.GetCoinLookUp(theCoin) == false)
                {
                    backendCode.AddTheCoin(theCoin);
                    return true;
                }
            }
            catch (Exception ex)
            {
                
            }

            return false; // Did not add a coin to DB
        }

        public bool DeleteCoin(CommonCoin theCoin)
        {
            try
            {
                if (backendCode.GetCoinLookUp(theCoin) == true)
                {
                    backendCode.AddTheCoin(theCoin);
                    return false;
                }
            }
            catch (Exception ex)
            {

            }

            return true; // Did not delete a coin to DB
        }

        public List<DatabaseDataSet.tblCoinDataRow> GetData()
        {
            return backendCode.GetData();
        }
    }
}
