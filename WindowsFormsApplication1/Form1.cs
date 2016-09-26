using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MySqlConnection myConnection;
        List<questionbox> questions = new List<questionbox> { };
        int selected = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private class questionbox
        {
            public int index;
            public string name;
            public int next1;
            public int next2;
            public int next3;
        }

        private void ButConnect_Click(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "")
            {
                myConnection = new MySqlConnection("server = " + BoxServer.Text + "; user id = " + BoxUser.Text + ";database = app");
            }
            else
            {
                myConnection = new MySqlConnection("server = " + BoxServer.Text + "; user id = " + BoxUser.Text + ";database = app" + ";password= " + BoxPassword.Text);
            }

            Connect();

                
            

        }

        private void Connect()
        {
            try
            {
                myConnection.Open();
                ButConnect.BackColor = System.Drawing.Color.LightGreen;
                tabs.SelectedTab = Overview;
            }
            catch (Exception e)
            {
                ButConnect.BackColor = System.Drawing.Color.Red;
                Console.WriteLine(e.ToString());
            }
        }

        private void read()
        {
            text_Questions.Text = "";
            text_Answers.Text = "";
            //Get all the questions in text
            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from questions", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    text_Questions.Text = 
                    text_Questions.Text  + "ID: " +
                    myReader.GetInt32(0).ToString() + "\t Question: " +
                    myReader.GetString(1) + "\t Type: " + 
                    myReader.GetInt32(2).ToString() + "\t Info: " + 
                    myReader.GetString(3) + "\n";
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            //Get all the answers in text
            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from answers", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    text_Answers.Text = 
                    text_Answers.Text + "ID: " +
                    myReader.GetInt32(0).ToString() + "\t Answer 1: " +
                    myReader.GetString(1) + "\t -> " +
                    myReader.GetInt32(2).ToString() + "\t Answer 2: " +
                    myReader.GetString(3) + "\t -> " +
                    myReader.GetInt32(4).ToString() + "\t Answer 3: " +
                    myReader.GetString(5) + "\t -> " +
                    myReader.GetInt32(6).ToString() + "\n";
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void fill()
        {
            int maxQuestions = 0;
            questions.Clear();
            //Get all the questions
            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from questions", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    questionbox box = new questionbox();

                    box.index = myReader.GetInt32(0);
                    box.name = myReader.GetString(1);
                    box.next1 = -1;
                    box.next2 = -1;
                    box.next3 = -1;

                    maxQuestions = box.index;

                    questions.Add(box);

                    /*
                    text_Questions.Text + "ID: " +
                    myReader.GetInt32(0).ToString() + "\t Question: " +
                    myReader.GetString(1) + "\t Type: " +
                    myReader.GetInt32(2).ToString() + "\t Info: " +
                    myReader.GetString(3) + "\n";
                    */
                }
                myReader.Close();
                tablemaker();
                /*
                for (int i = 0; i < maxQuestions; i++)
                {
                    Button newButton = new Button();
                    newButton.Text = box.name;
                }
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void tablemaker()
        {
            tableOverview.Controls.Clear();
            foreach (var questionbox in questions)
            {
                int colomns = tableOverview.ColumnCount;
                int rows = tableOverview.RowCount;
                RadioButton b = new RadioButton();
                b.Text = questionbox.name;
                b.Dock = DockStyle.Fill;
                b.Click += (s, e) =>
                {
                    selected = questionbox.index;
                };

                tableOverview.Controls.Add(b, colomns / 2, questionbox.index);
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

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == Database)
            {
                read();
            }

            if (tabs.SelectedTab == Overview)
            {
                fill();
            }
        }
    }
}
