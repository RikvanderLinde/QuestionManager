namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BoxServer = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxUser = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.tableOverview = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.butaddq = new System.Windows.Forms.Button();
            this.butremoveq = new System.Windows.Forms.Button();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.butEdit = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BoxNext3 = new System.Windows.Forms.TextBox();
            this.BoxNext2 = new System.Windows.Forms.TextBox();
            this.BoxNext1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BoxAnswer3 = new System.Windows.Forms.TextBox();
            this.BoxAnswer2 = new System.Windows.Forms.TextBox();
            this.BoxAnswer1 = new System.Windows.Forms.TextBox();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.BoxInfo = new System.Windows.Forms.TextBox();
            this.BoxQuestion = new System.Windows.Forms.TextBox();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.text_Answers = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Questions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.answersTableAdapter1 = new WindowsFormsApplication1.appDataSetTableAdapters.answersTableAdapter();
            this.tabs.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Location = new System.Drawing.Point(0, 40);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(191, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "Server :";
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(191, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "User :";
            // 
            // BoxServer
            // 
            this.BoxServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxServer.Location = new System.Drawing.Point(0, 0);
            this.BoxServer.Name = "BoxServer";
            this.BoxServer.Size = new System.Drawing.Size(350, 20);
            this.BoxServer.TabIndex = 3;
            this.BoxServer.Text = "localhost";
            // 
            // BoxPassword
            // 
            this.BoxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxPassword.Location = new System.Drawing.Point(0, 20);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.PasswordChar = '*';
            this.BoxPassword.Size = new System.Drawing.Size(350, 20);
            this.BoxPassword.TabIndex = 2;
            // 
            // BoxUser
            // 
            this.BoxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxUser.Location = new System.Drawing.Point(0, 40);
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(350, 20);
            this.BoxUser.TabIndex = 1;
            this.BoxUser.Text = "root";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabConnection);
            this.tabs.Controls.Add(this.tabOverview);
            this.tabs.Controls.Add(this.tabQuestion);
            this.tabs.Controls.Add(this.tabDatabase);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(573, 419);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.tableLayoutPanel1);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(565, 393);
            this.tabConnection.TabIndex = 2;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButConnect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButConnect
            // 
            this.ButConnect.BackColor = System.Drawing.Color.Orange;
            this.ButConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButConnect.Location = new System.Drawing.Point(3, 112);
            this.ButConnect.Name = "ButConnect";
            this.ButConnect.Size = new System.Drawing.Size(553, 23);
            this.ButConnect.TabIndex = 0;
            this.ButConnect.Text = "Connect";
            this.ButConnect.UseVisualStyleBackColor = false;
            this.ButConnect.Click += new System.EventHandler(this.ButConnect_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8047F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.1953F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(553, 103);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BoxUser);
            this.panel1.Controls.Add(this.BoxPassword);
            this.panel1.Controls.Add(this.BoxServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 173);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 173);
            this.panel2.TabIndex = 5;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tableOverview);
            this.tabOverview.Controls.Add(this.tableLayoutPanel4);
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(565, 393);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // tableOverview
            // 
            this.tableOverview.AutoScroll = true;
            this.tableOverview.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableOverview.ColumnCount = 4;
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOverview.Location = new System.Drawing.Point(3, 48);
            this.tableOverview.Name = "tableOverview";
            this.tableOverview.RowCount = 7;
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableOverview.Size = new System.Drawing.Size(559, 342);
            this.tableOverview.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.butaddq, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.butremoveq, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(559, 45);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // butaddq
            // 
            this.butaddq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butaddq.Location = new System.Drawing.Point(3, 3);
            this.butaddq.Name = "butaddq";
            this.butaddq.Size = new System.Drawing.Size(273, 39);
            this.butaddq.TabIndex = 0;
            this.butaddq.Text = "Add Question";
            this.butaddq.UseVisualStyleBackColor = true;
            this.butaddq.Click += new System.EventHandler(this.butaddq_Click);
            // 
            // butremoveq
            // 
            this.butremoveq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butremoveq.Location = new System.Drawing.Point(282, 3);
            this.butremoveq.Name = "butremoveq";
            this.butremoveq.Size = new System.Drawing.Size(274, 39);
            this.butremoveq.TabIndex = 1;
            this.butremoveq.Text = "Remove Question";
            this.butremoveq.UseVisualStyleBackColor = true;
            this.butremoveq.Click += new System.EventHandler(this.butremoveq_Click);
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.butEdit);
            this.tabQuestion.Controls.Add(this.splitContainer2);
            this.tabQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(565, 393);
            this.tabQuestion.TabIndex = 1;
            this.tabQuestion.Text = "Question";
            this.tabQuestion.UseVisualStyleBackColor = true;
            // 
            // butEdit
            // 
            this.butEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butEdit.Location = new System.Drawing.Point(3, 367);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(559, 23);
            this.butEdit.TabIndex = 1;
            this.butEdit.Text = "SAVE";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox22);
            this.splitContainer2.Panel1.Controls.Add(this.textBox21);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel2.Controls.Add(this.ComboBoxType);
            this.splitContainer2.Panel2.Controls.Add(this.BoxInfo);
            this.splitContainer2.Panel2.Controls.Add(this.BoxQuestion);
            this.splitContainer2.Size = new System.Drawing.Size(559, 387);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(0, 280);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Answer 3 :";
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Location = new System.Drawing.Point(0, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Answer 2 :";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Location = new System.Drawing.Point(0, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Answer 1 :";
            // 
            // textBox22
            // 
            this.textBox22.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox22.Location = new System.Drawing.Point(0, 220);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(200, 20);
            this.textBox22.TabIndex = 6;
            this.textBox22.Text = "Type :";
            // 
            // textBox21
            // 
            this.textBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox21.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox21.Location = new System.Drawing.Point(0, 40);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(200, 180);
            this.textBox21.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(0, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Info :";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Question :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.01408F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98592F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 240);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(355, 85);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BoxNext3);
            this.panel4.Controls.Add(this.BoxNext2);
            this.panel4.Controls.Add(this.BoxNext1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(315, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 60);
            this.panel4.TabIndex = 1;
            // 
            // BoxNext3
            // 
            this.BoxNext3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxNext3.Location = new System.Drawing.Point(0, 40);
            this.BoxNext3.Name = "BoxNext3";
            this.BoxNext3.Size = new System.Drawing.Size(40, 20);
            this.BoxNext3.TabIndex = 4;
            // 
            // BoxNext2
            // 
            this.BoxNext2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxNext2.Location = new System.Drawing.Point(0, 20);
            this.BoxNext2.Name = "BoxNext2";
            this.BoxNext2.Size = new System.Drawing.Size(40, 20);
            this.BoxNext2.TabIndex = 2;
            // 
            // BoxNext1
            // 
            this.BoxNext1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxNext1.Location = new System.Drawing.Point(0, 0);
            this.BoxNext1.Name = "BoxNext1";
            this.BoxNext1.Size = new System.Drawing.Size(40, 20);
            this.BoxNext1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BoxAnswer3);
            this.panel3.Controls.Add(this.BoxAnswer2);
            this.panel3.Controls.Add(this.BoxAnswer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 60);
            this.panel3.TabIndex = 0;
            // 
            // BoxAnswer3
            // 
            this.BoxAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer3.Location = new System.Drawing.Point(0, 40);
            this.BoxAnswer3.Name = "BoxAnswer3";
            this.BoxAnswer3.Size = new System.Drawing.Size(315, 20);
            this.BoxAnswer3.TabIndex = 4;
            // 
            // BoxAnswer2
            // 
            this.BoxAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer2.Location = new System.Drawing.Point(0, 20);
            this.BoxAnswer2.Name = "BoxAnswer2";
            this.BoxAnswer2.Size = new System.Drawing.Size(315, 20);
            this.BoxAnswer2.TabIndex = 2;
            // 
            // BoxAnswer1
            // 
            this.BoxAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer1.Location = new System.Drawing.Point(0, 0);
            this.BoxAnswer1.Name = "BoxAnswer1";
            this.BoxAnswer1.Size = new System.Drawing.Size(315, 20);
            this.BoxAnswer1.TabIndex = 3;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxType.IntegralHeight = false;
            this.ComboBoxType.ItemHeight = 12;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Ok",
            "Yes / No",
            "Multiple Choice",
            "Open"});
            this.ComboBoxType.Location = new System.Drawing.Point(0, 220);
            this.ComboBoxType.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(355, 20);
            this.ComboBoxType.TabIndex = 7;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // BoxInfo
            // 
            this.BoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxInfo.Location = new System.Drawing.Point(0, 20);
            this.BoxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.BoxInfo.Multiline = true;
            this.BoxInfo.Name = "BoxInfo";
            this.BoxInfo.Size = new System.Drawing.Size(355, 200);
            this.BoxInfo.TabIndex = 1;
            // 
            // BoxQuestion
            // 
            this.BoxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxQuestion.Location = new System.Drawing.Point(0, 0);
            this.BoxQuestion.Name = "BoxQuestion";
            this.BoxQuestion.Size = new System.Drawing.Size(355, 20);
            this.BoxQuestion.TabIndex = 0;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.text_Answers);
            this.tabDatabase.Controls.Add(this.label2);
            this.tabDatabase.Controls.Add(this.text_Questions);
            this.tabDatabase.Controls.Add(this.label1);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(565, 393);
            this.tabDatabase.TabIndex = 3;
            this.tabDatabase.Text = "DataBase";
            // 
            // text_Answers
            // 
            this.text_Answers.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_Answers.Location = new System.Drawing.Point(3, 147);
            this.text_Answers.Name = "text_Answers";
            this.text_Answers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.text_Answers.Size = new System.Drawing.Size(559, 118);
            this.text_Answers.TabIndex = 2;
            this.text_Answers.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answers : ";
            // 
            // text_Questions
            // 
            this.text_Questions.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_Questions.Location = new System.Drawing.Point(3, 16);
            this.text_Questions.Name = "text_Questions";
            this.text_Questions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.text_Questions.Size = new System.Drawing.Size(559, 118);
            this.text_Questions.TabIndex = 0;
            this.text_Questions.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questions : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // answersTableAdapter1
            // 
            this.answersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabOverview.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox BoxAnswer3;
        private System.Windows.Forms.TextBox BoxAnswer1;
        private System.Windows.Forms.TextBox BoxAnswer2;
        private System.Windows.Forms.TextBox BoxInfo;
        private System.Windows.Forms.TextBox BoxQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox BoxServer;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.RichTextBox text_Questions;
        private System.Windows.Forms.RichTextBox text_Answers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableOverview;
        private appDataSetTableAdapters.answersTableAdapter answersTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox BoxNext3;
        private System.Windows.Forms.TextBox BoxNext2;
        private System.Windows.Forms.TextBox BoxNext1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button butaddq;
        private System.Windows.Forms.Button butremoveq;
        private System.Windows.Forms.ComboBox ComboBoxType;
    }
}

