namespace EntityFrameworkDemo
{
    partial class ClientInfoForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelFirstOrderDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Info Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(67, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter company name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(132, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total orders:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(71, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(182, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Location = new System.Drawing.Point(406, 200);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(35, 13);
            this.labelTotalOrders.TabIndex = 7;
            this.labelTotalOrders.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(132, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total products bought:";
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.AutoSize = true;
            this.labelTotalProducts.Location = new System.Drawing.Point(406, 236);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(35, 13);
            this.labelTotalProducts.TabIndex = 9;
            this.labelTotalProducts.Text = "label7";
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.AutoSize = true;
            this.labelTotalMoney.Location = new System.Drawing.Point(406, 274);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(35, 13);
            this.labelTotalMoney.TabIndex = 10;
            this.labelTotalMoney.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(132, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total money spent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(132, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "First order date:";
            // 
            // labelFirstOrderDate
            // 
            this.labelFirstOrderDate.AutoSize = true;
            this.labelFirstOrderDate.Location = new System.Drawing.Point(406, 314);
            this.labelFirstOrderDate.Name = "labelFirstOrderDate";
            this.labelFirstOrderDate.Size = new System.Drawing.Size(41, 13);
            this.labelFirstOrderDate.TabIndex = 13;
            this.labelFirstOrderDate.Text = "label11";
            // 
            // ClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 474);
            this.Controls.Add(this.labelFirstOrderDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalMoney);
            this.Controls.Add(this.labelTotalProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotalOrders);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientInfoForm";
            this.Text = "ClientInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalProducts;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFirstOrderDate;
    }
}