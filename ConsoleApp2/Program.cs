using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-D26N3LP;Initial Catalog=moamen;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command = cnn.CreateCommand();
                if (cnn.State == ConnectionState.Open)
                {
                    command.CommandText = "INSERT INTO tt VALUES ('moamenjnddac')";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Inserting Data Successfully");
                                                }
            }
            catch
            {
                Console.WriteLine("Exp");
            }
          
        }
    }
}
