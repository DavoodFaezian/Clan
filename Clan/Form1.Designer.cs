namespace Clan
{
    partial class Clanfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clanfrm));
            this.button1 = new System.Windows.Forms.Button();
            this.lblcup = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.btneditname = new System.Windows.Forms.Button();
            this.MyName = new System.Windows.Forms.Label();
            this.btnbattle = new System.Windows.Forms.Button();
            this.AddProfile = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgprofile = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.searchgb = new System.Windows.Forms.GroupBox();
            this.CloseSearch = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofile)).BeginInit();
            this.searchgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Two player";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblcup
            // 
            this.lblcup.AutoSize = true;
            this.lblcup.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcup.Location = new System.Drawing.Point(309, 10);
            this.lblcup.Name = "lblcup";
            this.lblcup.Size = new System.Drawing.Size(17, 18);
            this.lblcup.TabIndex = 1;
            this.lblcup.Text = "0";
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoney.Location = new System.Drawing.Point(227, 9);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(17, 18);
            this.lblmoney.TabIndex = 2;
            this.lblmoney.Text = "0";
            // 
            // btneditname
            // 
            this.btneditname.Location = new System.Drawing.Point(207, 250);
            this.btneditname.Name = "btneditname";
            this.btneditname.Size = new System.Drawing.Size(75, 23);
            this.btneditname.TabIndex = 13;
            this.btneditname.Text = "Edit name";
            this.btneditname.UseVisualStyleBackColor = true;
            this.btneditname.Click += new System.EventHandler(this.btneditname_Click);
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Location = new System.Drawing.Point(227, 224);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(41, 13);
            this.MyName.TabIndex = 15;
            this.MyName.Text = "player1";
            // 
            // btnbattle
            // 
            this.btnbattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbattle.BackColor = System.Drawing.Color.Goldenrod;
            this.btnbattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbattle.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbattle.ForeColor = System.Drawing.Color.White;
            this.btnbattle.Location = new System.Drawing.Point(332, 465);
            this.btnbattle.Name = "btnbattle";
            this.btnbattle.Size = new System.Drawing.Size(137, 73);
            this.btnbattle.TabIndex = 16;
            this.btnbattle.Text = "Battle";
            this.btnbattle.UseVisualStyleBackColor = false;
            this.btnbattle.Click += new System.EventHandler(this.btnbattle_Click);
            // 
            // AddProfile
            // 
            this.AddProfile.Location = new System.Drawing.Point(390, 4);
            this.AddProfile.Name = "AddProfile";
            this.AddProfile.Size = new System.Drawing.Size(104, 51);
            this.AddProfile.TabIndex = 17;
            this.AddProfile.Text = "addfriend";
            this.AddProfile.UseVisualStyleBackColor = true;
            this.AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(12, 4);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(101, 51);
            this.btnselect.TabIndex = 18;
            this.btnselect.Text = "friends";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 54);
            this.button2.TabIndex = 19;
            this.button2.Text = "addfriend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(60, 38);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(396, 20);
            this.txtsearch.TabIndex = 20;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgprofile
            // 
            this.dgprofile.AllowUserToAddRows = false;
            this.dgprofile.AllowUserToDeleteRows = false;
            this.dgprofile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprofile.Location = new System.Drawing.Point(6, 183);
            this.dgprofile.Name = "dgprofile";
            this.dgprofile.Size = new System.Drawing.Size(484, 150);
            this.dgprofile.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // searchgb
            // 
            this.searchgb.Controls.Add(this.CloseSearch);
            this.searchgb.Controls.Add(this.button3);
            this.searchgb.Controls.Add(this.dgprofile);
            this.searchgb.Controls.Add(this.txtsearch);
            this.searchgb.Controls.Add(this.btnsearch);
            this.searchgb.Location = new System.Drawing.Point(4, 4);
            this.searchgb.Name = "searchgb";
            this.searchgb.Size = new System.Drawing.Size(492, 430);
            this.searchgb.TabIndex = 23;
            this.searchgb.TabStop = false;
            this.searchgb.Text = "Searchbox";
            // 
            // CloseSearch
            // 
            this.CloseSearch.Image = global::Clan.Properties.Resources.Close_icon;
            this.CloseSearch.Location = new System.Drawing.Point(471, 6);
            this.CloseSearch.Name = "CloseSearch";
            this.CloseSearch.Size = new System.Drawing.Size(19, 16);
            this.CloseSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseSearch.TabIndex = 23;
            this.CloseSearch.TabStop = false;
            this.CloseSearch.Click += new System.EventHandler(this.CloseSearch_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::Clan.Properties.Resources.find;
            this.btnsearch.Location = new System.Drawing.Point(21, 38);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(38, 19);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsearch.TabIndex = 21;
            this.btnsearch.TabStop = false;
            // 
            // profile
            // 
            this.profile.Image = global::Clan.Properties.Resources.face1;
            this.profile.Location = new System.Drawing.Point(175, 68);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(141, 153);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 12;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Clan.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(187, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clan.Properties.Resources.cup;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Clanfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 550);
            this.Controls.Add(this.searchgb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.AddProfile);
            this.Controls.Add(this.btnbattle);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.btneditname);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.lblcup);
            this.Controls.Add(this.button1);
            this.Name = "Clanfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgprofile)).EndInit();
            this.searchgb.ResumeLayout(false);
            this.searchgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcup;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Button btneditname;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Button btnbattle;
        private System.Windows.Forms.Button AddProfile;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgprofile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox searchgb;
        private System.Windows.Forms.PictureBox CloseSearch;
    }
}

