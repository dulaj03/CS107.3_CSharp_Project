using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.WebRequestMethods;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace horizon_travels_and_tours
{
    internal class HotelClass
    {
        private DBconnect connect = new DBconnect();

        public bool insertHotel(string hname, string location, string phone, int price, DateTime checkin, DateTime checkout, decimal rating, byte[] himg)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `hotel`(`HotelName`, `Location`, `PhoneNumber`, `Price`, `CheckIn`, `CheckOut`, `Rating`, `Image`) VALUES (@hn, @hl, @hp, @hpr, @hci, @hco, @hr, @hi)", connect.getconnection);

            command.Parameters.Add("@hn", MySqlDbType.VarChar).Value = hname;
            command.Parameters.Add("@hl", MySqlDbType.VarChar).Value = location;
            command.Parameters.Add("@hp", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@hpr", MySqlDbType.Int32).Value = price;
            command.Parameters.Add("@hci", MySqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@hco", MySqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@hr", MySqlDbType.Decimal).Value = rating;
            command.Parameters.Add("@hi", MySqlDbType.Blob).Value = himg;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 0)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getHotelList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `hotel`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        public string totalHotels()
        {
            return exeCount("SELECT COUNT(*) FROM hotel;");
        }
        public DataTable searchHotels(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM hotel WHERE HotelName LIKE @searchData OR Location LIKE @searchData OR Rating LIKE @searchData", connect.getconnection);
            command.Parameters.AddWithValue("@searchData", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }



        public bool updateHotel(int hid, string hname, string location, string phone, int price, DateTime checkin, DateTime checkout, decimal rating, byte[] himg)
        {
            MySqlCommand command = new MySqlCommand("UPDATE hotel SET HotelName=@hn, Location=@hl, PhoneNumber=@hp, Price=@hpr, CheckIn=@hci, CheckOut=@hco, Rating=@hr, Image=@hi WHERE HotelId=@hid", connect.getconnection);

            command.Parameters.Add("@hid", MySqlDbType.Int32).Value = hid;
            command.Parameters.Add("@hn", MySqlDbType.VarChar).Value = hname;
            command.Parameters.Add("@hl", MySqlDbType.VarChar).Value = location;
            command.Parameters.Add("@hp", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@hpr", MySqlDbType.Int32).Value = price;
            command.Parameters.Add("@hci", MySqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@hco", MySqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@hr", MySqlDbType.Decimal).Value = rating;
            command.Parameters.Add("@hi", MySqlDbType.Blob).Value = himg;

            connect.openConnect();
            int rowsAffected = command.ExecuteNonQuery();
            connect.closeConnect();

            return rowsAffected > 0;
        }
        public bool bookhotel(int hid)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE `hotel` SET `Booked` = 1 WHERE `HotelId` = @hid", connect.getconnection);
                command.Parameters.Add("@hid", MySqlDbType.Int32).Value = hid;
                connect.openConnect();

                int rowsAffected = command.ExecuteNonQuery();
                connect.closeConnect();

                return rowsAffected == 1;
            }
            catch (Exception ex)
            {


                Console.WriteLine("Error booking hotel: " + ex.Message);
                return false;
            }
        }
        public bool deleteHotel(int hid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM hotel WHERE HotelId=@hid", connect.getconnection);
            command.Parameters.Add("@hid", MySqlDbType.Int32).Value = hid;

            connect.openConnect();
            int rowsAffected = command.ExecuteNonQuery();
            connect.closeConnect();

            return rowsAffected > 0;
        }
       
    }
}



