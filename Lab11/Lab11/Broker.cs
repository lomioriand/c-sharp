using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/source/repos/Lab11/Data.accdb");
            command = connection.CreateCommand();
        }
        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Person p)
        {
            try
            {
                //command.CommandText = "INSERT INTO Bikes(ModelID, VersionID, Price, [Note]) VALUES (1, 2, 1, 'asa')";
                command.CommandText = "INSERT INTO Bikes(ModelID, VersionID, Price, [Note]) VALUES (" + p.ModelID1 + "," + p.VersionID1 + "," + p.Price1 + "," + "'" + p.Note1 + "'" + ")";
                command.CommandType = CommandType.Text;
                // command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
     }
}
