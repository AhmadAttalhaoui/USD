namespace USD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btChange = new System.Windows.Forms.Button();
            this.lbUSD = new System.Windows.Forms.Label();
            this.lbPounds = new System.Windows.Forms.Label();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbYen = new System.Windows.Forms.Label();
            this.lbRupee = new System.Windows.Forms.Label();
            this.lbFranken = new System.Windows.Forms.Label();
            this.tb_USD = new System.Windows.Forms.TextBox();
            this.tbPound = new System.Windows.Forms.TextBox();
            this.tbEuro = new System.Windows.Forms.TextBox();
            this.tbRupees = new System.Windows.Forms.TextBox();
            this.tbYen = new System.Windows.Forms.TextBox();
            this.tbFranken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(279, 196);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Location = new System.Drawing.Point(22, 132);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(63, 15);
            this.lbUSD.TabIndex = 1;
            this.lbUSD.Text = "U.S.Dollars";
            // 
            // lbPounds
            // 
            this.lbPounds.AutoSize = true;
            this.lbPounds.Location = new System.Drawing.Point(134, 132);
            this.lbPounds.Name = "lbPounds";
            this.lbPounds.Size = new System.Drawing.Size(83, 15);
            this.lbPounds.TabIndex = 2;
            this.lbPounds.Text = "British Pounds";
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Location = new System.Drawing.Point(255, 132);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(39, 15);
            this.lbEuro.TabIndex = 3;
            this.lbEuro.Text = "Euro\'s";
            // 
            // lbYen
            // 
            this.lbYen.AutoSize = true;
            this.lbYen.Location = new System.Drawing.Point(324, 132);
            this.lbYen.Name = "lbYen";
            this.lbYen.Size = new System.Drawing.Size(70, 15);
            this.lbYen.TabIndex = 4;
            this.lbYen.Text = "Japanse Yen";
            // 
            // lbRupee
            // 
            this.lbRupee.AutoSize = true;
            this.lbRupee.Location = new System.Drawing.Point(405, 132);
            this.lbRupee.Name = "lbRupee";
            this.lbRupee.Size = new System.Drawing.Size(91, 15);
            this.lbRupee.TabIndex = 5;
            this.lbRupee.Text = "Indiaase Rupees";
            // 
            // lbFranken
            // 
            this.lbFranken.AutoSize = true;
            this.lbFranken.Location = new System.Drawing.Point(511, 132);
            this.lbFranken.Name = "lbFranken";
            this.lbFranken.Size = new System.Drawing.Size(101, 15);
            this.lbFranken.TabIndex = 6;
            this.lbFranken.Text = "Zwitserse Franken";
            // 
            // tb_USD
            // 
            this.tb_USD.Location = new System.Drawing.Point(22, 150);
            this.tb_USD.Name = "tb_USD";
            this.tb_USD.Size = new System.Drawing.Size(63, 23);
            this.tb_USD.TabIndex = 7;
            // 
            // tbPound
            // 
            this.tbPound.Location = new System.Drawing.Point(134, 150);
            this.tbPound.Name = "tbPound";
            this.tbPound.Size = new System.Drawing.Size(83, 23);
            this.tbPound.TabIndex = 8;
            // 
            // tbEuro
            // 
            this.tbEuro.Location = new System.Drawing.Point(241, 150);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(64, 23);
            this.tbEuro.TabIndex = 9;
            // 
            // tbRupees
            // 
            this.tbRupees.Location = new System.Drawing.Point(405, 150);
            this.tbRupees.Name = "tbRupees";
            this.tbRupees.Size = new System.Drawing.Size(91, 23);
            this.tbRupees.TabIndex = 10;
            // 
            // tbYen
            // 
            this.tbYen.Location = new System.Drawing.Point(324, 150);
            this.tbYen.Name = "tbYen";
            this.tbYen.Size = new System.Drawing.Size(70, 23);
            this.tbYen.TabIndex = 11;
            // 
            // tbFranken
            // 
            this.tbFranken.Location = new System.Drawing.Point(511, 150);
            this.tbFranken.Name = "tbFranken";
            this.tbFranken.Size = new System.Drawing.Size(101, 23);
            this.tbFranken.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFranken);
            this.Controls.Add(this.tbYen);
            this.Controls.Add(this.tbRupees);
            this.Controls.Add(this.tbEuro);
            this.Controls.Add(this.tbPound);
            this.Controls.Add(this.tb_USD);
            this.Controls.Add(this.lbFranken);
            this.Controls.Add(this.lbRupee);
            this.Controls.Add(this.lbYen);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbPounds);
            this.Controls.Add(this.lbUSD);
            this.Controls.Add(this.btChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label lbUSD;
        private System.Windows.Forms.Label lbPounds;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbYen;
        private System.Windows.Forms.Label lbRupee;
        private System.Windows.Forms.Label lbFranken;
        private System.Windows.Forms.TextBox tb_USD;
        private System.Windows.Forms.TextBox tbPound;
        private System.Windows.Forms.TextBox tbEuro;
        private System.Windows.Forms.TextBox tbRupees;
        private System.Windows.Forms.TextBox tbYen;
        private System.Windows.Forms.TextBox tbFranken;
    }
}

