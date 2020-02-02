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
        private string strName;

        // Contructor
        public CommonCoin(string strType, string strMint, int intYear, string strName)
        {
            this.strType = strType;
            this.strMint = strMint;
            this.intYear = intYear;
            this.strName = strName;
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

        public string Name
        {
            get
            {
                return strName;
            }

            set
            {
                if (IsNameValid(value, Type))
                {
                    strName = value;
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

        public bool IsYearValid(int intYear)
        {
            if (intYear > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNameValid(string strName, string strType)
        {
            bool value = false;

            switch (strType.ToLower())
            {
                case "penny":
                    if (strName.ToLower().Contains("wheat") ||
                        strName.ToLower().Contains("memorial") ||
                        strName.ToLower().Contains("shield"))
                    {
                        value = true;
                    }
                    return value;
                case "nickel":
                    if (strName.ToLower().Contains("v") ||
                        strName.ToLower().Contains("indian head") ||
                        strName.ToLower().Contains("jefferson"))
                    {
                        value = true;
                    }
                    return value;
                case "dime":
                    if (strName.ToLower().Contains("disme") ||
                        strName.ToLower().Contains("draped bust") ||
                        strName.ToLower().Contains("capped bust") ||
                        strName.ToLower().Contains("seated liberty") ||
                        strName.ToLower().Contains("barber") ||
                        strName.ToLower().Contains("mercury") ||
                        strName.ToLower().Contains("franklin"))
                    {
                        value = true;
                    }
                    return value;
                case "quarter":
                    if (strName.ToLower().Contains("wright") ||
                        strName.ToLower().Contains("draped bust") ||
                        strName.ToLower().Contains("capped bust") ||
                        strName.ToLower().Contains("seated liberty") ||
                        strName.ToLower().Contains("barber") ||
                        strName.ToLower().Contains("standing liberty") ||
                        strName.ToLower().Contains("washington"))
                    {
                        value = true;
                    }
                    return value;
                case "half-dollar":
                    if (strName.ToLower().Contains("flowing") ||
                        strName.ToLower().Contains("draped bust") ||
                        strName.ToLower().Contains("capped bust") ||
                        strName.ToLower().Contains("seated liberty") ||
                        strName.ToLower().Contains("barber") ||
                        strName.ToLower().Contains("walking liberty") ||
                        strName.ToLower().Contains("franklin") ||
                        strName.ToLower().Contains("kennedy"))
                    {
                        value = true;
                    }
                    return value;
                case "dollar":
                    if (strName.ToLower().Contains("seated liberty") ||
                        strName.ToLower().Contains("gold") ||
                        strName.ToLower().Contains("trade") ||
                        strName.ToLower().Contains("morgan") ||
                        strName.ToLower().Contains("peace") ||
                        strName.ToLower().Contains("eisenhower") ||
                        strName.ToLower().Contains("susan b anthony") ||
                        strName.ToLower().Contains("american silver eagle") ||
                        strName.ToLower().Contains("sacagawea") ||
                        strName.ToLower().Contains("president") ||
                        strName.ToLower().Contains("innovation"))
                    {
                        value = true;
                    }
                    return value;
                default:
                    return false;
            }
        }
    }
}
