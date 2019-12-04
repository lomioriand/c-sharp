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
    public partial class Form3 : Form
    {
        string conn_string = ConfigurationManager.ConnectionStrings["Kursov_proekt.Properties.Settings.nbadbConnectionString"].ConnectionString;
        string query;
        public Form3()
        {
            InitializeComponent();
            loadPlayers();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void loadPlayers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                query = "select * from Player";
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
            int age = ((DataRowView)listBox1.SelectedValue).Row.Field<int>("Age");
            string pos = ((DataRowView)listBox1.SelectedValue).Row.Field<string>("Position");
            int id = ((DataRowView)listBox1.SelectedValue).Row.Field<int>("Id");

            textBox1.Text = name;
            textBox2.Text = age.ToString();
            textBox3.Text = pos;
            textBox4.Text = id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = "UPDATE Player SET Name = '"+ textBox1.Text + 
                "', Age = '" + textBox2.Text + "', Position = '" + textBox3.Text + "' WHERE Id ="+ textBox4.Text+";";

            using (SqlConnection conn = new SqlConnection(conn_string))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
