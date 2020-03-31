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
                if (IsNameValid(value, Type, Year))
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

        public bool IsNameValid(string strName, string strType, int intYear)
        {
            bool value = false;

            switch (strType.ToLower())
            {
                case "penny":
                    if ((strName.ToLower().Contains("flying") && (intYear >= 1909 && intYear <= 1958)) ||
                        (strName.ToLower().Contains("indian") && (intYear >= 1909 && intYear <= 1958)) ||
                        (strName.ToLower().Contains("wheat") && (intYear >= 1909 && intYear <= 1958)) ||
                        (strName.ToLower().Contains("memorial") && (intYear >= 1959 && intYear <= 2009)) ||
                        (strName.ToLower().Contains("shield") && (intYear >= 2010)))
                    {
                        value = true;
                    }
                    return value;
                case "nickel":
                    if ((strName.ToLower().Contains("shield") && (intYear >= 1909 && intYear <= 1958)) ||
                        (strName.ToLower().Contains("v") && (intYear >= 1883 && intYear <= 1913)) ||
                        (strName.ToLower().Contains("buffalo") && (intYear >= 1913 && intYear <= 1938)) ||
                        (strName.ToLower().Contains("jefferson") && (intYear >= 1938)))
                    {
                        value = true;
                    }
                    return value;
                case "dime":
                    if (strName.ToLower().Contains("disme") && (intYear == 1792) || // NOT A MISS SPELL
                        strName.ToLower().Contains("draped bust") && (intYear >= 1796 && intYear <= 1807) ||
                        strName.ToLower().Contains("capped bust") && (intYear >= 1809 && intYear <= 1837) ||
                        strName.ToLower().Contains("seated liberty") && (intYear >= 1837 && intYear <= 1891) ||
                        strName.ToLower().Contains("barber") && (intYear >= 1892 && intYear <= 1916) ||
                        strName.ToLower().Contains("mercury") && (intYear >= 1916 && intYear <= 1945) ||
                        strName.ToLower().Contains("franklin") && (intYear >= 1946))
                    {
                        value = true;
                    }
                    return value;
                case "quarter":
                    if (strName.ToLower().Contains("wright") && (intYear == 1792) ||
                        strName.ToLower().Contains("draped bust") && (intYear >= 1796 && intYear <= 1807) ||
                        strName.ToLower().Contains("capped bust") && (intYear >= 1815 && intYear <= 1838) ||
                        strName.ToLower().Contains("seated liberty") && (intYear >= 1838 && intYear <= 1930) ||
                        strName.ToLower().Contains("barber") && (intYear >= 1892 && intYear <= 1916) ||
                        strName.ToLower().Contains("standing liberty") && (intYear >= 1916 && intYear <= 1930) ||
                        strName.ToLower().Contains("washington") && (intYear >= 1932))
                    {
                        value = true;
                    }
                    return value;
                case "half-dollar":
                    if (strName.ToLower().Contains("flowing") && (intYear >= 1794 && intYear <= 1795) ||
                        strName.ToLower().Contains("draped bust") && (intYear >= 1796 && intYear <= 1807) ||
                        strName.ToLower().Contains("capped bust") && (intYear >= 1807 && intYear <= 1839) ||
                        strName.ToLower().Contains("seated liberty") && (intYear >= 1839 && intYear <= 1891) ||
                        strName.ToLower().Contains("barber") && (intYear >= 1892 && intYear <= 1915) ||
                        strName.ToLower().Contains("walking liberty") && (intYear >= 1916 && intYear <= 1947) ||
                        strName.ToLower().Contains("franklin") && (intYear >= 1948 && intYear <= 1963) ||
                        strName.ToLower().Contains("kennedy") && (intYear >= 1964 || intYear <= 1976))
                    {
                        value = true;
                    }
                    return value;
                case "dollar":
                    if (strName.ToLower().Contains("seated liberty") && (intYear >= 1836 && intYear <= 1873) ||
                        strName.ToLower().Contains("gold") && (intYear >= 1849 && intYear <= 1889) ||
                        strName.ToLower().Contains("trade") && (intYear >= 1873 && intYear <= 1885) ||
                        strName.ToLower().Contains("morgan") && ((intYear >= 1878 && intYear <= 1904) || intYear == 1921) ||
                        strName.ToLower().Contains("peace") && ((intYear >= 1921 && intYear <= 1928) || (intYear >= 1934 && intYear <= 1935)) ||
                        strName.ToLower().Contains("eisenhower") && (intYear >= 1971 && intYear <= 1978) ||
                        strName.ToLower().Contains("susan b anthony") && ((intYear >= 1979 && intYear <= 1981) || (intYear == 1999)) ||
                        strName.ToLower().Contains("american silver eagle") && (intYear >= 1986) ||
                        strName.ToLower().Contains("sacagawea") && (intYear >= 2000) ||
                        strName.ToLower().Contains("president") && (intYear >= 2007 && intYear <= 2016) ||
                        strName.ToLower().Contains("innovation") && (intYear >= 2018))
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
