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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.View = new System.Windows.Forms.TabControl();
            this.Connection = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.BoxServer = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxUser = new System.Windows.Forms.TextBox();
            this.ButConnect = new System.Windows.Forms.Button();
            this.Overview = new System.Windows.Forms.TabPage();
            this.Question = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.BoxAnswer3 = new System.Windows.Forms.TextBox();
            this.BoxAnswer2 = new System.Windows.Forms.TextBox();
            this.BoxAnswer1 = new System.Windows.Forms.TextBox();
            this.BoxInfo = new System.Windows.Forms.TextBox();
            this.TextQuestion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.View.SuspendLayout();
            this.Connection.SuspendLayout();
            this.Question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.View);
            this.splitContainer1.Size = new System.Drawing.Size(673, 534);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Panel2.Controls.Add(this.BoxServer);
            this.splitContainer3.Panel2.Controls.Add(this.BoxPassword);
            this.splitContainer3.Panel2.Controls.Add(this.BoxUser);
            this.splitContainer3.Size = new System.Drawing.Size(241, 534);
            this.splitContainer3.SplitterDistance = 98;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Size = new System.Drawing.Size(241, 98);
            this.splitContainer4.SplitterDistance = 101;
            this.splitContainer4.TabIndex = 0;
            // 
            // View
            // 
            this.View.Controls.Add(this.Connection);
            this.View.Controls.Add(this.Overview);
            this.View.Controls.Add(this.Question);
            this.View.Location = new System.Drawing.Point(-1, 3);
            this.View.Name = "View";
            this.View.SelectedIndex = 0;
            this.View.Size = new System.Drawing.Size(429, 531);
            this.View.TabIndex = 0;
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.tableLayoutPanel1);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(3);
            this.Connection.Size = new System.Drawing.Size(421, 505);
            this.Connection.TabIndex = 2;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Location = new System.Drawing.Point(0, 40);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(144, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "Server :";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "User :";
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Location = new System.Drawing.Point(0, 20);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Password :";
            // 
            // BoxServer
            // 
            this.BoxServer.Location = new System.Drawing.Point(44, 111);
            this.BoxServer.Name = "BoxServer";
            this.BoxServer.Size = new System.Drawing.Size(130, 20);
            this.BoxServer.TabIndex = 3;
            this.BoxServer.Text = "Localhost";
            // 
            // BoxPassword
            // 
            this.BoxPassword.Location = new System.Drawing.Point(44, 164);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.PasswordChar = '*';
            this.BoxPassword.Size = new System.Drawing.Size(130, 20);
            this.BoxPassword.TabIndex = 2;
            this.BoxPassword.Text = "Admin";
            // 
            // BoxUser
            // 
            this.BoxUser.Location = new System.Drawing.Point(44, 138);
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(96, 20);
            this.BoxUser.TabIndex = 1;
            this.BoxUser.Text = "Admin";
            // 
            // ButConnect
            // 
            this.ButConnect.BackColor = System.Drawing.Color.Orange;
            this.ButConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButConnect.Location = new System.Drawing.Point(3, 188);
            this.ButConnect.Name = "ButConnect";
            this.ButConnect.Size = new System.Drawing.Size(415, 23);
            this.ButConnect.TabIndex = 0;
            this.ButConnect.Text = "Connect";
            this.ButConnect.UseVisualStyleBackColor = false;
            this.ButConnect.Click += new System.EventHandler(this.ButConnect_Click);
            // 
            // Overview
            // 
            this.Overview.Location = new System.Drawing.Point(4, 22);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(3);
            this.Overview.Size = new System.Drawing.Size(421, 505);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Overview";
            this.Overview.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.Controls.Add(this.splitContainer2);
            this.Question.Location = new System.Drawing.Point(4, 22);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(3);
            this.Question.Size = new System.Drawing.Size(421, 505);
            this.Question.TabIndex = 1;
            this.Question.Text = "Question";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox7);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox10);
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer3);
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer2);
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer1);
            this.splitContainer2.Panel2.Controls.Add(this.BoxInfo);
            this.splitContainer2.Panel2.Controls.Add(this.TextQuestion);
            this.splitContainer2.Size = new System.Drawing.Size(415, 499);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(4, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(142, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Type :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 362);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(142, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Answer 3 :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(4, 336);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(142, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Answer 2 :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(142, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Answer 1 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Info :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Question :";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(4, 362);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(250, 20);
            this.textBox10.TabIndex = 5;
            // 
            // BoxAnswer3
            // 
            this.BoxAnswer3.Location = new System.Drawing.Point(4, 336);
            this.BoxAnswer3.Name = "BoxAnswer3";
            this.BoxAnswer3.Size = new System.Drawing.Size(250, 20);
            this.BoxAnswer3.TabIndex = 4;
            // 
            // BoxAnswer2
            // 
            this.BoxAnswer2.Location = new System.Drawing.Point(4, 310);
            this.BoxAnswer2.Name = "BoxAnswer2";
            this.BoxAnswer2.Size = new System.Drawing.Size(250, 20);
            this.BoxAnswer2.TabIndex = 3;
            // 
            // BoxAnswer1
            // 
            this.BoxAnswer1.Location = new System.Drawing.Point(4, 284);
            this.BoxAnswer1.Name = "BoxAnswer1";
            this.BoxAnswer1.Size = new System.Drawing.Size(250, 20);
            this.BoxAnswer1.TabIndex = 2;
            // 
            // BoxInfo
            // 
            this.BoxInfo.Location = new System.Drawing.Point(4, 30);
            this.BoxInfo.Multiline = true;
            this.BoxInfo.Name = "BoxInfo";
            this.BoxInfo.Size = new System.Drawing.Size(250, 250);
            this.BoxInfo.TabIndex = 1;
            // 
            // TextQuestion
            // 
            this.TextQuestion.Location = new System.Drawing.Point(3, 4);
            this.TextQuestion.Name = "TextQuestion";
            this.TextQuestion.Size = new System.Drawing.Size(250, 20);
            this.TextQuestion.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButConnect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 179);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(45, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 150);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 534);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.View.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.Question.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl View;
        private System.Windows.Forms.TabPage Overview;
        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox BoxAnswer3;
        private System.Windows.Forms.TextBox BoxAnswer2;
        private System.Windows.Forms.TextBox BoxAnswer1;
        private System.Windows.Forms.TextBox BoxInfo;
        private System.Windows.Forms.TextBox TextQuestion;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox BoxServer;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage Connection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

