namespace Clan
{
    partial class SelectProfile
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
            this.btnsumbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsumbit
            // 
            this.btnsumbit.Location = new System.Drawing.Point(173, 358);
            this.btnsumbit.Name = "btnsumbit";
            this.btnsumbit.Size = new System.Drawing.Size(75, 23);
            this.btnsumbit.TabIndex = 0;
            this.btnsumbit.Text = "sumbit";
            this.btnsumbit.UseVisualStyleBackColor = true;
            this.btnsumbit.Click += new System.EventHandler(this.btnsumbit_Click);
            // 
            // SelectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 482);
            this.Controls.Add(this.btnsumbit);
            this.Name = "SelectProfile";
            this.Text = "Select Profile";
            this.Load += new System.EventHandler(this.SelectProfile_Load);
            this.Click += new System.EventHandler(this.SelectProfile_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsumbit;
    }
}