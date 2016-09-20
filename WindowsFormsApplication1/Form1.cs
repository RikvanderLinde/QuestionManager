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


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void ButConnect_Click(object sender, EventArgs e)
        {
            /*
            myConnection = new SqlConnection("user id=" + BoxUser.Text +
                                                   ";password="+ BoxPassword.Text +";server=" + BoxServer.Text +
                                                   ";Trusted_Connection=yes" +
                                                   ";database=app" +
                                                   ";connection timeout=30");
            */
            myConnection = new SqlConnection("user id=root;" +
                                       "password=;server=localhost;" +
                                       "Trusted_Connection=True;" +
                                       "database=app; " +
                                       "connection timeout=30");
            Connect();

            //test();
                
            

        }
        private void Connect()
        {
            try
            {
                myConnection.Open();
                ButConnect.BackColor = System.Drawing.Color.LightGreen;
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
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from questions",
                                                         myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    System.Diagnostics.Debug.WriteLine(myReader["Column1"].ToString());
                    System.Diagnostics.Debug.WriteLine(myReader["Column2"].ToString());
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
