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
            this.View = new System.Windows.Forms.TabControl();
            this.Connection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Overview = new System.Windows.Forms.TabPage();
            this.Question = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BoxType = new System.Windows.Forms.TextBox();
            this.BoxAnswer3 = new System.Windows.Forms.TextBox();
            this.BoxAnswer2 = new System.Windows.Forms.TextBox();
            this.BoxAnswer1 = new System.Windows.Forms.TextBox();
            this.BoxInfo = new System.Windows.Forms.TextBox();
            this.BoxQuestion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.View.SuspendLayout();
            this.Connection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Location = new System.Drawing.Point(0, 40);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(192, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "Server :";
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(192, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "User :";
            // 
            // BoxServer
            // 
            this.BoxServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxServer.Location = new System.Drawing.Point(0, 0);
            this.BoxServer.Name = "BoxServer";
            this.BoxServer.Size = new System.Drawing.Size(349, 20);
            this.BoxServer.TabIndex = 3;
            this.BoxServer.Text = "localhost";
            // 
            // BoxPassword
            // 
            this.BoxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxPassword.Location = new System.Drawing.Point(0, 20);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.PasswordChar = '*';
            this.BoxPassword.Size = new System.Drawing.Size(349, 20);
            this.BoxPassword.TabIndex = 2;
            // 
            // BoxUser
            // 
            this.BoxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxUser.Location = new System.Drawing.Point(0, 40);
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(349, 20);
            this.BoxUser.TabIndex = 1;
            this.BoxUser.Text = "root";
            // 
            // View
            // 
            this.View.Controls.Add(this.Connection);
            this.View.Controls.Add(this.Overview);
            this.View.Controls.Add(this.Question);
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.Location = new System.Drawing.Point(0, 0);
            this.View.Name = "View";
            this.View.SelectedIndex = 0;
            this.View.Size = new System.Drawing.Size(573, 419);
            this.View.TabIndex = 0;
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.tableLayoutPanel1);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(3);
            this.Connection.Size = new System.Drawing.Size(565, 393);
            this.Connection.TabIndex = 2;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
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
            // Overview
            // 
            this.Overview.Location = new System.Drawing.Point(4, 22);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(3);
            this.Overview.Size = new System.Drawing.Size(565, 393);
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
            this.Question.Size = new System.Drawing.Size(565, 393);
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
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer3);
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer2);
            this.splitContainer2.Panel2.Controls.Add(this.BoxAnswer1);
            this.splitContainer2.Panel2.Controls.Add(this.BoxType);
            this.splitContainer2.Panel2.Controls.Add(this.BoxInfo);
            this.splitContainer2.Panel2.Controls.Add(this.BoxQuestion);
            this.splitContainer2.Size = new System.Drawing.Size(559, 387);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
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
            // BoxType
            // 
            this.BoxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxType.Location = new System.Drawing.Point(0, 220);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(355, 20);
            this.BoxType.TabIndex = 5;
            // 
            // BoxAnswer3
            // 
            this.BoxAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer3.Location = new System.Drawing.Point(0, 280);
            this.BoxAnswer3.Name = "BoxAnswer3";
            this.BoxAnswer3.Size = new System.Drawing.Size(355, 20);
            this.BoxAnswer3.TabIndex = 4;
            // 
            // BoxAnswer2
            // 
            this.BoxAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer2.Location = new System.Drawing.Point(0, 260);
            this.BoxAnswer2.Name = "BoxAnswer2";
            this.BoxAnswer2.Size = new System.Drawing.Size(355, 20);
            this.BoxAnswer2.TabIndex = 3;
            // 
            // BoxAnswer1
            // 
            this.BoxAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxAnswer1.Location = new System.Drawing.Point(0, 240);
            this.BoxAnswer1.Name = "BoxAnswer1";
            this.BoxAnswer1.Size = new System.Drawing.Size(355, 20);
            this.BoxAnswer1.TabIndex = 2;
            // 
            // BoxInfo
            // 
            this.BoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxInfo.Location = new System.Drawing.Point(0, 20);
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BoxUser);
            this.panel1.Controls.Add(this.BoxPassword);
            this.panel1.Controls.Add(this.BoxServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(201, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 173);
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
            this.panel2.Size = new System.Drawing.Size(192, 173);
            this.panel2.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox21
            // 
            this.textBox21.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox21.Location = new System.Drawing.Point(0, 40);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(200, 180);
            this.textBox21.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.View);
            this.Name = "Form1";
            this.Text = "Form1";
            this.View.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Question.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl View;
        private System.Windows.Forms.TabPage Overview;
        private System.Windows.Forms.TabPage Question;
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
        private System.Windows.Forms.TextBox BoxQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox BoxServer;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox BoxType;
        private System.Windows.Forms.TabPage Connection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

