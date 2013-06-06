using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            try
            {
                SqlConnection thisConnection = new SqlConnection(@"Network Library=DBMSSOCN;Data Source=apv8jive40.database.windows.net,1433;database=team3-to8;User id=michael@apv8jive40;Password=Ditisonzedatabase!;");
                thisConnection.Open();
                //start by creating new command
                SqlCommand thisCommand = thisConnection.CreateCommand();
                Console.WriteLine(thisCommand.CommandText);
                //insert new row to table "TaxiBooking"
                //for testing will be used random id generator, taxiID will always be 999.
                Random random = new Random();
                int rand = random.Next(1, 999999);
                int Id = rand;
                int TaxiId = 2;

                //link it to user [Not yet implemented] 
                thisCommand.CommandText = "INSERT INTO TaxiBooking values('" + Id + "', '" + TaxiId + "')";
                Console.WriteLine(thisCommand.ExecuteNonQuery());
                thisConnection.Close();
                Console.WriteLine("success");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
