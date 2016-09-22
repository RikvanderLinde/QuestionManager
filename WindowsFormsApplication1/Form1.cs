using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MySqlConnection myConnection;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void ButConnect_Click(object sender, EventArgs e)
        {
            //myConnection = new MySqlConnection("server = " + BoxServer.Text + "; user id = " + BoxUser.Text + ";database = app" + ";password= " + BoxPassword.Text);
            myConnection = new MySqlConnection("server = " + BoxServer.Text + "; user id = " + BoxUser.Text + ";database = app");

            Connect();

            test();
                
            

        }
        private void Connect()
        {
            try
            {
                myConnection.Open();
                ButConnect.BackColor = System.Drawing.Color.LightGreen;
                TabControl.SelectedIndex = 1;
            }
            catch (Exception e)
            {
                ButConnect.BackColor = System.Drawing.Color.Red;
                Console.WriteLine(e.ToString());
            }
        }
        private void test()
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from questions", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetInt32(0).ToString() + " " +
                    myReader.GetString(1) + " " + myReader.GetString(2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void close()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void Form1_Closed(object sender, EventArgs e)
        {
            close();
        }
        
    }
}
