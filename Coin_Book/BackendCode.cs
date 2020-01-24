using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Windows.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Coin_Book
{
    public interface IDataLogic
    {
        void AddTheCoin(CommonCoin theCoin);
        void DeleteTheCoin(CommonCoin theCoin);
        bool GetCoinLookUp(CommonCoin theCoin);
        List<DatabaseDataSet.tblCoinDataRow> GetData();
    }

    public class BackendCode : IDataLogic
    {
        DatabaseDataSetTableAdapters.tblCoinDataTableAdapter tblCoinData = new DatabaseDataSetTableAdapters.tblCoinDataTableAdapter();

        public void AddTheCoin(CommonCoin theCoin)
        {
            tblCoinData.Insert(theCoin.Year, theCoin.Type, theCoin.Mint);
        }

        public void DeleteTheCoin(CommonCoin theCoin)
        {
            tblCoinData.Delete(theCoin.Year, theCoin.Type, theCoin.Mint);
        }

        public bool GetCoinLookUp(CommonCoin theCoin)
        {
            if(tblCoinData.GetDataBy(theCoin.Type, theCoin.Mint, theCoin.Year).Count > 0) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DatabaseDataSet.tblCoinDataRow> GetData()
        {
            return tblCoinData.PopulateData().ToList();
        }
    }
}
