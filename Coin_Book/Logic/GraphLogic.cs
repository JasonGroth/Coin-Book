using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Book
{
    public interface IGraphLogic
    {
        int CountCoinsOwnedNameYear(string name, string type, int yearOne, int yearTwo);
        int CountCoinsOwnedNameType(string name, string type);
        int CountCoinsOwnedName(string name);
    }

    class GraphLogic : IGraphLogic
    {
        private GraphsDB graphBackendCode = new GraphsDB();

        public int CountCoinsOwnedNameYear(string name, string type, int yearOne, int yearTwo)
        {
            return graphBackendCode.CountTotalCoinCurrentlyOwnNameYear(name, type, yearOne, yearTwo);
        }

        public int CountCoinsOwnedNameType(string name, string type)
        {
            return graphBackendCode.CountTotalCoinCurrentlyOwnNameType(name, type);
        }

        public int CountCoinsOwnedName(string name)
        {
            return graphBackendCode.CountTotalCoinCurrentlyOwnName(name);
        }
    }
}