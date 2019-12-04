using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Kursov_proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTeam1();
            loadTeam2();
        }
        string conn_string = ConfigurationManager.ConnectionStrings["Kursov_proekt.Properties.Settings.nbadbConnectionString"].ConnectionString;
        string query;

        //listbox1 load
        private void loadTeam1()
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
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }

        //listbox3 load
        private void loadTeam2()
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
                    listBox3.DisplayMember = "Name";
                    listBox3.SelectedValue = "Id";
                    listBox3.DataSource = teamTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
              // MessageBox.Show(ex.ToString());
            }

        }

        //menu -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //menu -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Това е курсов проект за NBA :) \n\n Създаден от:\n\t\t" +
                "Йордан Димитров 17621776\n\t\tНутфи Айхан 17621758","NBA Course Project v1");
        }

        private void editTest()
        { 
            string commandText = "DELETE FROM Team WHERE Coach = 'Nutfi Ayhan'";

            using (SqlConnection conn = new SqlConnection(conn_string))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        //Team 1 selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conn_string);
            query = "select * from Player p inner join TeamPlayers tp on p.Id = tp.player_id where tp.team_id=@TeamID";
            

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                using (sqlDataAdapter)
                {
                    int team_i = ((DataRowView)listBox1.SelectedValue).Row.Field<int>("Id");
                    sqlCommand.Parameters.AddWithValue("@TeamID", team_i);

                    DataTable teamPlayers = new DataTable();
                    sqlDataAdapter.Fill(teamPlayers);
                    listBox2.DisplayMember = "Name";
                    //  listBox3.SelectedValue = "Id";
                    listBox2.DataSource = teamPlayers.DefaultView;
                }
            }catch{ }
        }


        //Menu -> Make Game
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();

            string t1 = listBox1.GetItemText(listBox1.SelectedItem);
            string t2 = listBox3.GetItemText(listBox3.SelectedItem);

            string p1 = listBox2.GetItemText(listBox2.Items[0]);
            string p2 = listBox2.GetItemText(listBox2.Items[1]);
            string p3 = listBox2.GetItemText(listBox2.Items[2]);
            string p4 = listBox2.GetItemText(listBox2.Items[3]);
            string p5 = listBox2.GetItemText(listBox2.Items[4]);

            string p6 = listBox4.GetItemText(listBox4.Items[0]);
            string p7 = listBox4.GetItemText(listBox4.Items[1]);
            string p8 = listBox4.GetItemText(listBox4.Items[2]);
            string p9 = listBox4.GetItemText(listBox4.Items[3]);
            string p10 = listBox4.GetItemText(listBox4.Items[4]);
            Form2 f2 = new Form2(t1,t2, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            f2.Show();
        }

        //listbox4 Team 2
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conn_string);
            query = "select * from Player p inner join TeamPlayers tp on p.Id = tp.player_id where tp.team_id=@TeamID";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                using (sqlDataAdapter)
                {
                    int team_i = ((DataRowView)listBox3.SelectedValue).Row.Field<int>("Id");
                    sqlCommand.Parameters.AddWithValue("@TeamID", team_i);

                    DataTable teamPlayers = new DataTable();
                    sqlDataAdapter.Fill(teamPlayers);
                    listBox4.DisplayMember = "Name";
                    //  listBox3.SelectedValue = "Id";
                    listBox4.DataSource = teamPlayers.DefaultView;
                }
            }
            catch { }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        // Menu -> Players
        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();

        }

        // Menu -> Teams
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        // Refresh button
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            loadTeam1(); 
            listBox3.DataSource = null;
            loadTeam2();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
