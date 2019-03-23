namespace SomerenUI
{
    partial class Revenue
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
            this.mcStartDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.rbTurnover = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.lstvRevenue = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mcStartDate
            // 
            this.mcStartDate.Location = new System.Drawing.Point(19, 85);
            this.mcStartDate.Name = "mcStartDate";
            this.mcStartDate.TabIndex = 0;
            this.mcStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcStartDate_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "End date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(193, 26);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 17);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "dd-mm-yy";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(193, 59);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 17);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "dd-mm-yy";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(19, 315);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(178, 57);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rbTurnover
            // 
            this.rbTurnover.AutoSize = true;
            this.rbTurnover.Location = new System.Drawing.Point(217, 315);
            this.rbTurnover.Name = "rbTurnover";
            this.rbTurnover.Size = new System.Drawing.Size(87, 21);
            this.rbTurnover.TabIndex = 10;
            this.rbTurnover.TabStop = true;
            this.rbTurnover.Text = "Turnover";
            this.rbTurnover.UseVisualStyleBackColor = true;
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Location = new System.Drawing.Point(217, 351);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(64, 21);
            this.rbSales.TabIndex = 11;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            this.rbSales.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lstvRevenue
            // 
            this.lstvRevenue.Location = new System.Drawing.Point(348, 32);
            this.lstvRevenue.Name = "lstvRevenue";
            this.lstvRevenue.Size = new System.Drawing.Size(429, 427);
            this.lstvRevenue.TabIndex = 12;
            this.lstvRevenue.UseCompatibleStateImageBehavior = false;
            this.lstvRevenue.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 57);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 484);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstvRevenue);
            this.Controls.Add(this.rbSales);
            this.Controls.Add(this.rbTurnover);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcStartDate);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.RadioButton rbTurnover;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.ListView lstvRevenue;
        private System.Windows.Forms.Button btnExit;
    }
}