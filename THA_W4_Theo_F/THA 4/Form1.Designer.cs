namespace THA_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxteamname = new System.Windows.Forms.TextBox();
            this.textboxcountry = new System.Windows.Forms.TextBox();
            this.comboboxcountry = new System.Windows.Forms.ComboBox();
            this.comboboxteam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxcity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textboxnumber = new System.Windows.Forms.TextBox();
            this.textboxplayername = new System.Windows.Forms.TextBox();
            this.addteam = new System.Windows.Forms.Button();
            this.addplayer = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.ComboBox();
            this.listboxresult = new System.Windows.Forms.ListBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team :";
            // 
            // textboxteamname
            // 
            this.textboxteamname.Location = new System.Drawing.Point(372, 75);
            this.textboxteamname.Name = "textboxteamname";
            this.textboxteamname.Size = new System.Drawing.Size(125, 20);
            this.textboxteamname.TabIndex = 3;
            this.textboxteamname.TextChanged += new System.EventHandler(this.textboxteamname_TextChanged);
            // 
            // textboxcountry
            // 
            this.textboxcountry.Location = new System.Drawing.Point(372, 108);
            this.textboxcountry.Name = "textboxcountry";
            this.textboxcountry.Size = new System.Drawing.Size(125, 20);
            this.textboxcountry.TabIndex = 4;
            // 
            // comboboxcountry
            // 
            this.comboboxcountry.FormattingEnabled = true;
            this.comboboxcountry.Location = new System.Drawing.Point(135, 75);
            this.comboboxcountry.Name = "comboboxcountry";
            this.comboboxcountry.Size = new System.Drawing.Size(121, 21);
            this.comboboxcountry.TabIndex = 5;
            this.comboboxcountry.SelectedIndexChanged += new System.EventHandler(this.comboboxcountry_SelectedIndexChanged);
            // 
            // comboboxteam
            // 
            this.comboboxteam.FormattingEnabled = true;
            this.comboboxteam.Location = new System.Drawing.Point(135, 108);
            this.comboboxteam.Name = "comboboxteam";
            this.comboboxteam.Size = new System.Drawing.Size(121, 21);
            this.comboboxteam.TabIndex = 6;
            this.comboboxteam.SelectedIndexChanged += new System.EventHandler(this.comboboxteam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team City:";
            // 
            // textboxcity
            // 
            this.textboxcity.Location = new System.Drawing.Point(372, 142);
            this.textboxcity.Name = "textboxcity";
            this.textboxcity.Size = new System.Drawing.Size(125, 20);
            this.textboxcity.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adding Team:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adding Players:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Player Position:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Player Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Player Name:";
            // 
            // textboxnumber
            // 
            this.textboxnumber.Location = new System.Drawing.Point(612, 108);
            this.textboxnumber.Name = "textboxnumber";
            this.textboxnumber.Size = new System.Drawing.Size(125, 20);
            this.textboxnumber.TabIndex = 13;
            // 
            // textboxplayername
            // 
            this.textboxplayername.Location = new System.Drawing.Point(612, 75);
            this.textboxplayername.Name = "textboxplayername";
            this.textboxplayername.Size = new System.Drawing.Size(125, 20);
            this.textboxplayername.TabIndex = 12;
            // 
            // addteam
            // 
            this.addteam.Location = new System.Drawing.Point(372, 181);
            this.addteam.Name = "addteam";
            this.addteam.Size = new System.Drawing.Size(95, 23);
            this.addteam.TabIndex = 19;
            this.addteam.Text = "ADD";
            this.addteam.UseVisualStyleBackColor = true;
            this.addteam.Click += new System.EventHandler(this.addteam_Click);
            // 
            // addplayer
            // 
            this.addplayer.Location = new System.Drawing.Point(612, 181);
            this.addplayer.Name = "addplayer";
            this.addplayer.Size = new System.Drawing.Size(95, 23);
            this.addplayer.TabIndex = 20;
            this.addplayer.Text = "ADD";
            this.addplayer.UseVisualStyleBackColor = true;
            this.addplayer.Click += new System.EventHandler(this.addplayer_Click);
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.position.Location = new System.Drawing.Point(612, 142);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(125, 21);
            this.position.TabIndex = 21;
            // 
            // listboxresult
            // 
            this.listboxresult.FormattingEnabled = true;
            this.listboxresult.Location = new System.Drawing.Point(44, 181);
            this.listboxresult.Name = "listboxresult";
            this.listboxresult.Size = new System.Drawing.Size(302, 186);
            this.listboxresult.TabIndex = 22;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(44, 373);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(95, 23);
            this.btnremove.TabIndex = 23;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.listboxresult);
            this.Controls.Add(this.position);
            this.Controls.Add(this.addplayer);
            this.Controls.Add(this.addteam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textboxnumber);
            this.Controls.Add(this.textboxplayername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxcity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboboxteam);
            this.Controls.Add(this.comboboxcountry);
            this.Controls.Add(this.textboxcountry);
            this.Controls.Add(this.textboxteamname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxteamname;
        private System.Windows.Forms.TextBox textboxcountry;
        private System.Windows.Forms.ComboBox comboboxcountry;
        private System.Windows.Forms.ComboBox comboboxteam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxcity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textboxnumber;
        private System.Windows.Forms.TextBox textboxplayername;
        private System.Windows.Forms.Button addteam;
        private System.Windows.Forms.Button addplayer;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ListBox listboxresult;
        private System.Windows.Forms.Button btnremove;
    }
}

