using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Book
{
    public interface ICoinLogic
    {
        int AddCoin(CommonCoin theCoin);
        int DeleteCoin(CommonCoin theCoin);
        List<CommonCoin> GetData();
        bool DoesCoinHaveSilver(CommonCoin theCoin);
        Tuple<bool, string> IsCoinKeyDate(CommonCoin theCoin);
    }

    public class BusinessLogicCoins : ICoinLogic
    {
        private BackendCode backendCode = new BackendCode();

        public int AddCoin(CommonCoin theCoin)
        {
            try
            {
                if (backendCode.DoesCoinExistInDB(theCoin) == 0)
                {
                    if (theCoin.Mint != "W")
                    {
                        backendCode.AddTheCoin(theCoin);
                        return 1;
                    }
                    else if(theCoin.Type != "Quarter")
                    {
                        return 2;
                    }
                    else
                    {
                        backendCode.AddTheCoin(theCoin);
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return 0; // Did not add a coin to DB
        }

        public int DeleteCoin(CommonCoin theCoin)
        {
            try
            {
                if (backendCode.DoesCoinExistInDB(theCoin) == 1)
                {
                    backendCode.DeleteTheCoin(theCoin);
                    return 0;
                }
            }
            catch (Exception ex)
            {

            }

            return 1; // Did not delete a coin to DB
        }

        public List<CommonCoin> GetData()
        {
            return backendCode.GetData();
        }

        public bool DoesCoinHaveSilver(CommonCoin theCoin)
        {
            switch (theCoin.Type.ToLower())
            {
                case "dime":
                    return theCoin.Year < 1965;

                case "quarter":
                case "dollar":
                    bool contains = false;
                    if ((theCoin.Year == 1975 || theCoin.Year == 1976) && theCoin.Mint.ToLower() == "s" && theCoin.Name.ToLower() == "bicentennial")
                    {
                        contains = true;
                    }
                    else if (theCoin.Year < 1965)
                    {
                        contains = true;
                    }
                    return contains;

                case "half-dollar":
                    bool halfContains = false;
                    if ((theCoin.Year == 1975 || theCoin.Year == 1976) && theCoin.Mint.ToLower() == "s" && theCoin.Name.ToLower() == "bicentennial")
                    {
                        halfContains = true;
                    }
                    else if (theCoin.Year < 1971)
                    {
                        halfContains = true;
                    }
                    return halfContains;
                default:
                    return false;
            }
        }

        public Tuple<bool, string> IsCoinKeyDate(CommonCoin theCoin)
        {
            string strMessage = "";
            bool blnValue = false;

            switch (theCoin.Type.ToLower())
            {
                case "penny":
                    if ((theCoin.Year == 2009 && theCoin.Name.ToLower() == "lincoln") || 
                        ((theCoin.Year == 1943 || theCoin.Year == 1909) && theCoin.Name.ToLower() == "wheat"))
                    {
                        strMessage = "You found a " + theCoin.Year + " penny. This is a keeper!";
                        blnValue = true;
                    }
                    else if (theCoin.Year > 1908 && theCoin.Year < 1916 && theCoin.Mint.ToLower() == "s" && theCoin.Name.ToLower() == "wheat")
                    {
                        strMessage = "Key date! Keeper!";
                    }
                    else if (theCoin.Year > 1909 && theCoin.Year < 1960 && theCoin.Name.ToLower() == "wheat")
                    {
                        strMessage = "Keeper!";
                        blnValue = true;
                    }
                    else if (theCoin.Name.ToLower() == "indian head" || theCoin.Name.ToLower() == "wheat" || theCoin.Name.ToLower() == "flying eagle")
                    {
                        strMessage = "You found an " + theCoin.Name + " ! This is a keeper!";
                        blnValue = true;
                    }
                    break;
                case "nickel":
                    if (((theCoin.Year > 1929 && theCoin.Year < 1960) || theCoin.Year == 2009) && theCoin.Name.ToLower() == "Jefferson")
                    {
                        strMessage = "You found a keeper!";
                        blnValue = true;
                    }
                    else if (theCoin.Year == 2004 || theCoin.Year == 2005)
                    {
                        strMessage = "You found a Louis and Clark commemerative coin!";
                        blnValue = true;
                    }
                    else if (theCoin.Name.ToLower() == "buffalo" || theCoin.Name.ToLower() == "shield" || theCoin.Name.ToLower() == "war")
                    {
                        strMessage = "You found a " + theCoin.Name + " !";
                        blnValue = true;
                    }
                    break;
                case "dime":
                    if (theCoin.Year == 2009)
                    {
                        strMessage = "Keeper!";
                        blnValue = true;
                    }
                    break;
                case "quarter":
                    if (theCoin.Mint.ToLower() == "w" && theCoin.Year == 2019)
                    {
                        strMessage = "2,000,000 coins were made of each!";
                        blnValue = true;
                    }
                    else if (theCoin.Year == 2009)
                    {
                        strMessage = "Keeper!";
                    }
                    break;
                case "half-dollar":

                    break;
                case "dollar":

                    break;
                default:
                    break;
            }

            var tuple = new Tuple<bool, string>(blnValue, strMessage);

            return tuple;
        }
    }
}
