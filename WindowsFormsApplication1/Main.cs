using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        MySqlConnection myConnection;
        List<questionbox> questions = new List<questionbox> { };
        int selected = 0;
        string Answer1, Answer2, Answer3, Next1, Next2, Next3, Question, Info;
        int Type;

        public Main()
        {
            InitializeComponent();
        }

        //Question Class
        private class questionbox
        {
            public int index;
            public string name;
            public string descrip;
            public int type;
            public string answer1;
            public int next1;
            public string answer2;
            public int next2;
            public string answer3;
            public int next3;
        }

        #region Connect
        //Go to Connect
        private void ButConnect_Click(object sender, EventArgs e)
        {
            myConnection = new MySqlConnection("server = " + BoxServer.Text + "; user id = " + BoxUser.Text + ";password= " + BoxPassword.Text);
            Connect();
        }

        //Connect to DB
        private void Connect()
        {
            try
            {
                myConnection.Open();
                ButConnect.BackColor = System.Drawing.Color.LightGreen;
                databaseGet();
            }
            catch (Exception e)
            {
                ButConnect.BackColor = System.Drawing.Color.Red;
                Console.WriteLine(e.ToString());
            }
        }
        #endregion

        #region DataBase Select
        //Get Databases
        private void databaseGet()
        {
            MySqlCommand myCommand = new MySqlCommand("show databases", myConnection);
            MySqlDataReader Reader;
            Reader = myCommand.ExecuteReader();
            listQuestionLists.Items.Clear();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    row += Reader.GetValue(i).ToString();

                if (row.Contains("qst_"))
                {
                    row = row.Remove(0, 4);
                    listQuestionLists.Items.Add(row);
                }
            }
            Reader.Close();
        }

        //Database Select
        private void butSelect_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tabOverview;
            myConnection.ChangeDatabase("qst_" + listQuestionLists.SelectedItem.ToString());
            fill();
            Main.ActiveForm.Text = "Database selected : " + listQuestionLists.SelectedItem.ToString();
        }

        //Popup
        public string ShowMyDialogBox()
        {
            Popup testDialog = new Popup();
            string data = "";
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                data = testDialog.textBox1.Text;
            }
            else
            {
                data = "Cancelled";
            }
            testDialog.Dispose();
            return data;
        }

        //Database Add
        private void butAdd_Click(object sender, EventArgs e)
        {
            string name = "qst_" + ShowMyDialogBox();
            try
            {
                MySqlCommand myCommand = new MySqlCommand($"CREATE DATABASE {name}", myConnection);
                myCommand.ExecuteNonQuery();
                databaseGet();

                #region tables
                string comquestion =
                  "USE "+name+";CREATE TABLE questions"
                + "("
                + "ID int NOT NULL AUTO_INCREMENT,"
                + "Question varchar(100),"
                + "Description varchar(500),"
                + "Type int (2),"
                + "Answer1 varchar (100),"
                + "Next1 int (2),"
                + "Answer2 varchar (100),"
                + "Next2 int (2),"
                + "Answer3 varchar (100),"
                + "Next3 int (2),"
                + "PRIMARY KEY(ID)"
                + ")";

                string comanswers =
                  "USE " + name + ";CREATE TABLE answers"
                + "("
                + "ID int NOT NULL AUTO_INCREMENT,"
                + "User varchar(100) NOT NULL,"
                + "Date varchar(20),"
                + "question int (2),"
                + "Answer varchar (100),"
                + "PRIMARY KEY(ID)"
                + ")";

                MySqlCommand myQuestion = new MySqlCommand(comquestion, myConnection);
                myQuestion.ExecuteNonQuery();
                MySqlCommand myAnswers = new MySqlCommand(comanswers, myConnection);
                myAnswers.ExecuteNonQuery();
                #endregion
            }
            catch (Exception f)
            {
                Console.WriteLine(f.ToString());
            }
        }

        //Database Remove
        private void butRemove_Click(object sender, EventArgs e)
        {
            string select = "";
            try
            {
                select = listQuestionLists.SelectedItem.ToString();
            }
            catch { }

            if(select != "" && !select.Contains("users"))
            {
                select = "qst_" + select;
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove the database?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        MySqlCommand myCommand = new MySqlCommand($"DROP DATABASE {select}", myConnection);
                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception f)
                    {
                        Console.WriteLine(f.ToString());
                    }
                    databaseGet();
                }
            }
        }
    
        #endregion

        #region Database Tab
        //Database Tab
        private void read()
        {
            text_Questions.Text = "";
            text_Answers.Text = "";

            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from questions", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string Id, Question, Type, Info, Answer1, Next1, Answer2, Next2, Answer3, Next3;
                    Id= Question=Type=Info=Answer1=Next1=Answer2=Next2=Answer3=Next3="";

                    if (!myReader.IsDBNull(0)) Id       = myReader.GetString(0);
                    if (!myReader.IsDBNull(1)) Question = myReader.GetString(1);
                    if (!myReader.IsDBNull(2)) Info     = myReader.GetString(2);
                    if (!myReader.IsDBNull(3)) Type     = myReader.GetString(3);
                    if (!myReader.IsDBNull(4)) Answer1  = myReader.GetString(4);
                    if (!myReader.IsDBNull(5)) Next1    = myReader.GetString(5);
                    if (!myReader.IsDBNull(6)) Answer2  = myReader.GetString(6);
                    if (!myReader.IsDBNull(7)) Next2    = myReader.GetString(7);
                    if (!myReader.IsDBNull(8)) Answer3  = myReader.GetString(8);
                    if (!myReader.IsDBNull(9)) Next3    = myReader.GetString(9);

                    text_Questions.Text = text_Questions.Text + $"ID: {Id}\t Question: {Question}\t Type: {Type}\t Info: {Info}\n";
                    
                    text_Answers.Text = text_Answers.Text + $"ID: {Id}\t Answer 1: {Answer1}\t -> {Next1}\t Answer 2: {Answer2}\t -> {Next2}\t Answer 3: {Answer3}\t -> {Next3}\n";
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        #endregion

        #region Question edit Tab
        //Questions Tab
        private void edit()
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand($"select * from questions where ID = {selected}", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    //if (!myReader.IsDBNull(0)) BoxQuestion.Text = myReader.GetString(0);
                    if (!myReader.IsDBNull(1)) BoxQuestion.Text = myReader.GetString(1);
                    if (!myReader.IsDBNull(2)) BoxInfo.Text = myReader.GetString(2);
                    if (!myReader.IsDBNull(3)) ComboBoxType.SelectedIndex = myReader.GetInt32(3);
                    if (!myReader.IsDBNull(4)) BoxAnswer1.Text  = myReader.GetString(4);
                    if (!myReader.IsDBNull(5)) BoxNext1.Text    = myReader.GetInt32(5).ToString();
                    if (!myReader.IsDBNull(6)) BoxAnswer2.Text  = myReader.GetString(6);
                    if (!myReader.IsDBNull(7)) BoxNext2.Text    = myReader.GetInt32(7).ToString();
                    if (!myReader.IsDBNull(8)) BoxAnswer3.Text  = myReader.GetString(8);
                    if (!myReader.IsDBNull(9)) BoxNext3.Text    = myReader.GetInt32(9).ToString();
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        //Question Type Changed listener
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexChange();
        }

        //Question Type Changed
        void indexChange()
        {

            switch (ComboBoxType.SelectedIndex)
            {
                case 0: //Ok question
                    BoxAnswer1.Text = "Ok";
                    BoxAnswer1.Enabled = false;
                    BoxNext1.Text = Next1;
                    BoxNext1.Enabled = true;
                    BoxAnswer2.Text = "";
                    BoxAnswer2.Enabled = false;
                    BoxNext2.Text = "-1";
                    BoxNext2.Enabled = false;
                    BoxAnswer3.Text = "";
                    BoxAnswer3.Enabled = false;
                    BoxNext3.Text = "-1";
                    BoxNext3.Enabled = false;
                    break;
                case 1: //Yes-No question
                    BoxAnswer1.Text = "Yes";
                    BoxAnswer1.Enabled = false;
                    BoxNext1.Text = Next1;
                    BoxNext1.Enabled = true;
                    BoxAnswer2.Text = "No";
                    BoxAnswer2.Enabled = false;
                    BoxNext2.Text = Next2;
                    BoxNext2.Enabled = true;
                    BoxAnswer3.Text = "";
                    BoxAnswer3.Enabled = false;
                    BoxNext3.Text = "-1";
                    BoxNext3.Enabled = false;
                    break;
                case 2: //Multiple choice question
                    BoxAnswer1.Text = Answer1;
                    BoxAnswer1.Enabled = true;
                    BoxNext1.Text = Next1;
                    BoxNext1.Enabled = true;
                    BoxAnswer2.Text = Answer2;
                    BoxAnswer2.Enabled = true;
                    BoxNext2.Text = Next2;
                    BoxNext2.Enabled = true;
                    BoxAnswer3.Text = Answer3;
                    BoxAnswer3.Enabled = true;
                    BoxNext3.Text = Next3;
                    BoxNext3.Enabled = true;
                    break;
                case 3: //Open question
                    BoxAnswer1.Text = Answer1;
                    BoxAnswer1.Enabled = true;
                    BoxNext1.Text = Next1;
                    BoxNext1.Enabled = true;
                    BoxAnswer2.Text = "";
                    BoxAnswer2.Enabled = false;
                    BoxNext2.Text = "-1";
                    BoxNext2.Enabled = false;
                    BoxAnswer3.Text = "";
                    BoxAnswer3.Enabled = false;
                    BoxNext3.Text = "-1";
                    BoxNext3.Enabled = false;
                    break;
            }
        }

        //Save Answers
        private void save()
        {
            Answer1 = BoxAnswer1.Text;
            Answer2 = BoxAnswer2.Text;
            Answer3 = BoxAnswer3.Text;
            Next1 = BoxNext1.Text;
            Next2 = BoxNext2.Text;
            Next3 = BoxNext3.Text;
            Question = BoxQuestion.Text;
            Type = ComboBoxType.SelectedIndex;
            Info = BoxInfo.Text;
        }

        //Edit Question
        private void butEdit_Click(object sender, EventArgs e)
        {
            save();
            try
            {
                MySqlCommand myCommand = new MySqlCommand($"update questions set Question='{Question}', Type='{Type}', Description ='{Info}',Answer1='{Answer1}', Next1='{Next1}', Answer2='{Answer2}', Next2='{Next2}', Answer3='{Answer3}', Next3='{Next3}'  where ID = {selected}", myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception f)
            {
                Console.WriteLine(f.ToString());
            }
            tabs.SelectedTab = tabOverview;
        }

        #endregion

        #region Overview Tab
        //Overview Tab
        private void fill()
        {
            questions.Clear();
            try
            {
                MySqlCommand myCommand = new MySqlCommand("select * from questions", myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    questionbox box = new questionbox();
                    if (!myReader.IsDBNull(0)) box.index    = myReader.GetInt32(0);
                    if (!myReader.IsDBNull(1)) box.name     = myReader.GetString(1);
                    if (!myReader.IsDBNull(2)) box.descrip  = myReader.GetString(2);
                    if (!myReader.IsDBNull(3)) box.type     = myReader.GetInt32(3);
                    if (!myReader.IsDBNull(4)) box.answer1  = myReader.GetString(4);
                    if (!myReader.IsDBNull(5)) box.next1    = myReader.GetInt32(5);
                    if (!myReader.IsDBNull(6)) box.answer2  = myReader.GetString(6);
                    if (!myReader.IsDBNull(7)) box.next2    = myReader.GetInt32(7);
                    if (!myReader.IsDBNull(8)) box.answer3  = myReader.GetString(8);
                    if (!myReader.IsDBNull(9)) box.next3    = myReader.GetInt32(9);
                    questions.Add(box);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            tablemaker();
        }

        //Overview Tab Table
        private void tablemaker()
        {
            tableOverview.Visible = false;
            tableOverview.Controls.Clear();
            int row = 0;
            foreach (var questionbox in questions)
            {
                RadioButton b = new RadioButton();
                b.Text = questionbox.name;
                b.Dock = DockStyle.Fill;
                b.Click += (s, e) =>
                {
                    selected = questionbox.index;
                };
                tableOverview.RowCount = questions.Count;
                tableOverview.Controls.Add(b, 0, row);
                
                if (questionbox.next1 != -1)
                {
                    Label l = new Label();
                    l.Dock = DockStyle.Fill;
                    l.Text =
                    $"Type is : {ComboBoxType.Items[questionbox.type] }"
                    + Environment.NewLine +
                    $"Answer is : {questionbox.answer1}"
                    + Environment.NewLine +
                    $"Next Question : {questionbox.next1.ToString()}";
                    tableOverview.Controls.Add(l, 1, row);
                }

                if (questionbox.next2 != -1)
                {
                    Label l = new Label();
                    l.Dock = DockStyle.Fill;
                    l.Text = 
                    $"Type is : {ComboBoxType.Items[questionbox.type] }"
                    + Environment.NewLine +
                    $"Answer is : {questionbox.answer2}"
                    + Environment.NewLine +
                    $"Next Question : {questionbox.next2.ToString()}";
                    tableOverview.Controls.Add(l, 1, row);
                }
                if (questionbox.next3 != -1)
                {
                    Label l = new Label();
                    l.Dock = DockStyle.Fill;
                    l.Text =
                    $"Type is : {ComboBoxType.Items[questionbox.type] }"
                    + Environment.NewLine + 
                    $"Answer is : {questionbox.answer3}"
                    + Environment.NewLine +
                    $"Next Question : {questionbox.next3.ToString()}";
                    tableOverview.Controls.Add(l, 1, row);
                }
                row++;
            }
            tableOverview.Visible = true;
        }

        //Add Question
        private void butaddq_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO questions (Question,Type) VALUES ('Change me!', 0)", myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception f)
            {
                Console.WriteLine(f.ToString());
            }
            
            fill();
        }

        //Remove Question
        private void butremoveq_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove the question?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    MySqlCommand myCommand = new MySqlCommand($"delete from questions where ID = {selected}", myConnection);
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception f)
                {
                    Console.WriteLine(f.ToString());
                }
                fill();
            }
        }

        #endregion
        
        //Change Tab
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tabDatabase)
            {
                read();
            }

            if (tabs.SelectedTab == tabOverview)
            {
                fill();
            }

            if (tabs.SelectedTab == tabQuestion)
            {
                edit();
                save();
                indexChange();
            }
        }

        //Cleanup
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

        //Form Closed
        private void Form1_Closed(object sender, EventArgs e)
        {
            close();
        }

        
    }
}
