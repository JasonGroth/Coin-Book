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
using System.Data.EntityClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Coin_Book
{
    public interface IDataLogic
    {
        void AddTheCoin(CommonCoin theCoin);
        void DeleteTheCoin(CommonCoin theCoin);
        int DoesCoinExistInDB(CommonCoin theCoin);
        List<CommonCoin> GetData();
        List<CommonCoin> SearchDatabase(CommonCoin theCoin);
    }

    public class BackendCode : IDataLogic
    {
        string connectString = "Data Source=JASGR0TH;Initial Catalog=Jason;Integrated Security=True";
        
        public void AddTheCoin(CommonCoin theCoin)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            string sql = "INSERT INTO tblCoinsDataSQL (Year, Type, Mint, Name) VALUES('" + theCoin.Year + "','" + theCoin.Type + "','" + theCoin.Mint + "','" + theCoin.Name + "')";

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTheCoin(CommonCoin theCoin)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            string sql = "DELETE tblCoinsDataSQL WHERE Type = '" + theCoin.Type + "' AND Mint = '" + theCoin.Mint + "' AND Year = '" + theCoin.Year + "' AND Name = '" + theCoin.Name + "'";

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
        }

        public int DoesCoinExistInDB(CommonCoin theCoin)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = '" + theCoin.Type + "' AND Mint = '" + theCoin.Mint + "' AND Year = '" + theCoin.Year + "' AND Name = '" + theCoin.Name + "'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public List<CommonCoin> GetData()
        {
            var listOfCoins = new List<CommonCoin>();

            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            string sql = @"SELECT Year, Type, Mint, Name
                           FROM tblCoinsDataSQL
                           ORDER BY Type, Year, Name";

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);

                using (var reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        var coin = new CommonCoin("", "", 0, "");

                        var type = reader["Type"] as string;
                        var mint = reader["Mint"] as string;
                        var year = (int)reader["Year"];
                        var name = reader["Name"] as string;

                        coin.Year = year;
                        coin.Type = type.Trim();
                        coin.Mint = mint.Trim();
                        coin.Name = name.Trim();
                        listOfCoins.Add(coin);
                    }

                    reader.Close();
                }
            }
            return listOfCoins;
        }

        public List<CommonCoin> SearchDatabase(CommonCoin theCoin)
        {
            var listOfCoins = new List<CommonCoin>();

            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            string sql = "SELECT * FROM tblCoinsDataSQL WHERE Type = '" + theCoin.Type + "' AND Mint = '" + theCoin.Mint + "' AND Year = '" + theCoin.Year + "' AND Name = '" + theCoin.Name + "'";

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);

                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var coin = new CommonCoin("", "", 0, "");

                        var type = reader["Type"] as string;
                        var mint = reader["Mint"] as string;
                        var year = (int)reader["Year"];
                        var name = reader["Name"] as string;

                        coin.Year = year;
                        coin.Type = type.Trim();
                        coin.Mint = mint.Trim();
                        coin.Name = name.Trim();
                        listOfCoins.Add(coin);
                    }

                    reader.Close();
                }
            }
            return listOfCoins;
        }

        public int AllPennies()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Penny'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public int AllNickel()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Nickel'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public int AllDime()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Dime'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public int AllQuarter()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Quarter'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public int AllHalf()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Half-Dollar'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }

        public int AllDollar()
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "SELECT count(*) FROM tblCoinsDataSQL WHERE Type = 'Dollar'";
            int value = 0;

            if (connect.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                try
                {
                    value = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
            }

            return (int)value;
        }
    }
}
