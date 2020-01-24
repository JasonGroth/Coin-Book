using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Book
{
    public class CommonCoin
    {
        // Global variables
        private string strType;
        private string strMint;
        private int intYear;

        // Contructor
        public CommonCoin(string strType, string strMint, int intYear)
        {
            this.strType = strType;
            this.strMint = strMint;
            this.intYear = intYear;
        }

        // Properties
        public string Type
        {
            get
            {
                return strType;
            }

            set
            {
                if (IsTypeValid(value))
                {
                    strType = value;
                }
            }
        }

        public string Mint
        {
            get
            {
                return strMint;
            }

            set
            {
                if (IsMintValid(value))
                {
                    strMint = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return intYear;
            }

            set
            {
                if (IsYearValid(value))
                {
                    intYear = value;
                }
            }
        }

        // Functions
        public bool IsTypeValid(string strType)
        {
            switch (strType.ToLower())
            {
                case "penny":
                case "nickel":
                case "dime":
                case "quarter":
                case "half-dollar":
                case "dollar":
                    return true;
                default:
                    return false;
            }
        }

        public bool IsMintValid(string strMint)
        {
            switch (strMint.ToLower())
            {
                case "p":
                case "d":
                case "s":
                case "w":
                    return true;
                default:
                    return false;
            }
        }

        public bool IsYearValid(int year)
        {
            if (year > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
