using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class vender : Form
    {
        public vender()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vender obj = new vender();
            this.Hide();
            obj.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminD obj = new AdminD();
            this.Hide();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vender12 values (@Id,@Name,@Telephone,@Address,@Email)",con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);







        }

        private void vender_Load()
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vender_Load(object sender, EventArgs e)
        {
            vender_Load();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string name = textBox1.Text;
            string tele = textBox2.Text;
            string add = textBox3.Text;
            string email= textBox4.Text;
            int id= int.Parse(textBox5.Text);

            string Query="UPDATE vender12 SET Name='"+name+ "', Telephone='"+tele+ "',Address='"+add+"',Email='"+email+ "' WHERE Id='"+id+"' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            
             textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("update Succesful!");
            vender_Load();
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            







            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            timer1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
