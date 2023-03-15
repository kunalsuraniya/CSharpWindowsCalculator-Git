namespace Windows_calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_equalsto = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_percentage = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_allclear = new System.Windows.Forms.Button();
            this.btn_rightbracket = new System.Windows.Forms.Button();
            this.btn_lefbracket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txt_display);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_display
            // 
            this.txt_display.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_display.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(22, 28);
            this.txt_display.MaxLength = 10;
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(310, 42);
            this.txt_display.TabIndex = 2;
            this.txt_display.Text = "0";
            this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_display.UseWaitCursor = true;
            this.txt_display.TextChanged += new System.EventHandler(this.txt_display_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btn_divide);
            this.panel1.Controls.Add(this.btn_multiply);
            this.panel1.Controls.Add(this.btn_subtract);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.btn_9);
            this.panel1.Controls.Add(this.btn_6);
            this.panel1.Controls.Add(this.btn_equalsto);
            this.panel1.Controls.Add(this.btn_0);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_percentage);
            this.panel1.Controls.Add(this.btn_7);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_allclear);
            this.panel1.Controls.Add(this.btn_rightbracket);
            this.panel1.Controls.Add(this.btn_lefbracket);
            this.panel1.Location = new System.Drawing.Point(6, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 319);
            this.panel1.TabIndex = 1;
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(263, 259);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(59, 47);
            this.btn_divide.TabIndex = 19;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(263, 194);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(59, 47);
            this.btn_multiply.TabIndex = 18;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.Location = new System.Drawing.Point(263, 132);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(59, 47);
            this.btn_subtract.TabIndex = 17;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(263, 69);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(59, 47);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(99, 132);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(59, 47);
            this.btn_5.TabIndex = 15;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(99, 194);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(59, 47);
            this.btn_8.TabIndex = 14;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(177, 194);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(59, 47);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(177, 132);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(59, 47);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_equalsto
            // 
            this.btn_equalsto.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equalsto.Location = new System.Drawing.Point(177, 259);
            this.btn_equalsto.Name = "btn_equalsto";
            this.btn_equalsto.Size = new System.Drawing.Size(59, 47);
            this.btn_equalsto.TabIndex = 11;
            this.btn_equalsto.Text = "=";
            this.btn_equalsto.UseVisualStyleBackColor = true;
            this.btn_equalsto.Click += new System.EventHandler(this.btn_equalsto_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(99, 259);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(59, 47);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(177, 69);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(59, 47);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(99, 69);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(59, 47);
            this.btn_2.TabIndex = 8;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_percentage
            // 
            this.btn_percentage.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_percentage.Location = new System.Drawing.Point(12, 259);
            this.btn_percentage.Name = "btn_percentage";
            this.btn_percentage.Size = new System.Drawing.Size(59, 47);
            this.btn_percentage.TabIndex = 7;
            this.btn_percentage.Text = "%";
            this.btn_percentage.UseVisualStyleBackColor = true;
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(12, 194);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(59, 47);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(12, 132);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(59, 47);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(12, 69);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(59, 47);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(263, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 35);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DEL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_allclear
            // 
            this.btn_allclear.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allclear.Location = new System.Drawing.Point(177, 12);
            this.btn_allclear.Name = "btn_allclear";
            this.btn_allclear.Size = new System.Drawing.Size(63, 35);
            this.btn_allclear.TabIndex = 2;
            this.btn_allclear.Text = "AC";
            this.btn_allclear.UseVisualStyleBackColor = true;
            this.btn_allclear.Click += new System.EventHandler(this.btn_allclear_Click);
            // 
            // btn_rightbracket
            // 
            this.btn_rightbracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rightbracket.Location = new System.Drawing.Point(99, 12);
            this.btn_rightbracket.Name = "btn_rightbracket";
            this.btn_rightbracket.Size = new System.Drawing.Size(63, 35);
            this.btn_rightbracket.TabIndex = 1;
            this.btn_rightbracket.Text = ")";
            this.btn_rightbracket.UseVisualStyleBackColor = true;
            this.btn_rightbracket.Click += new System.EventHandler(this.btn_rightbracket_Click);
            // 
            // btn_lefbracket
            // 
            this.btn_lefbracket.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lefbracket.Location = new System.Drawing.Point(12, 12);
            this.btn_lefbracket.Name = "btn_lefbracket";
            this.btn_lefbracket.Size = new System.Drawing.Size(63, 35);
            this.btn_lefbracket.TabIndex = 0;
            this.btn_lefbracket.Text = "(";
            this.btn_lefbracket.UseVisualStyleBackColor = true;
            this.btn_lefbracket.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 481);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_equalsto;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_percentage;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_allclear;
        private System.Windows.Forms.Button btn_rightbracket;
        private System.Windows.Forms.Button btn_lefbracket;
    }
}

