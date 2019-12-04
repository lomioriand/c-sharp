using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov_proekt
{
    public partial class Form4 : Form
    {
        string conn_string = ConfigurationManager.ConnectionStrings["Kursov_proekt.Properties.Settings.nbadbConnectionString"].ConnectionString;
        string query;
        public Form4()
        {
            InitializeComponent();
            loadPlayers();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadPlayers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                query = "select * from Team";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                using (sqlDataAdapter)
                {
                    DataTable teamTable = new DataTable();
                    sqlDataAdapter.Fill(teamTable);
                    listBox1.DisplayMember = "Name";
                    listBox1.SelectedValue = "Id";
                    listBox1.DataSource = teamTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = ((DataRowView)listBox1.SelectedValue).Row.Field<string>("Name");
            string coach = ((DataRowView)listBox1.SelectedValue).Row.Field<string>("Coach");
            int id = ((DataRowView)listBox1.SelectedValue).Row.Field<int>("Id");

            textBox1.Text = name;
            textBox2.Text = coach;
            textBox3.Text = id.ToString();        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = "UPDATE Team SET Name = '" + textBox1.Text +
                "', Coach = '" + textBox2.Text + "' WHERE Id = " + textBox3.Text + ";";

            using (SqlConnection conn = new SqlConnection(conn_string))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            this.Close();
        }
    }
}
