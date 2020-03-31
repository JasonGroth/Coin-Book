using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Coin_Book
{
    public interface IGraphDB
    {
        int CountTotalCoinCurrentlyOwnNameYear(string name, string type, int yearOne, int yearTwo);
        int CountTotalCoinCurrentlyOwnNameType(string name, string type);
        int CountTotalCoinCurrentlyOwnName(string name);
    }

    public class GraphsDB : IGraphDB
    {
        string connectString = "Data Source=JASGR0TH;Initial Catalog=Jason;Integrated Security=True";

        public int CountTotalCoinCurrentlyOwnNameYear(string name, string type, int yearOne, int yearTwo)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "select count(*) from tblCoinsDataSQL where Name like '%"+ name + "%' and Type like '%" + type + "%'and Year >= " + yearOne + " and Year <= " + yearTwo;
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

        public int CountTotalCoinCurrentlyOwnNameType(string name, string type)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "select count(*) from tblCoinsDataSQL where Name like '%" + name + "%' and Type like '%" + type + "%'";
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

        public int CountTotalCoinCurrentlyOwnName(string name)
        {
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();
            string sql = "select count(*) from tblCoinsDataSQL where Name like '%" + name + "%'";
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
