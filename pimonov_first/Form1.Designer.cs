namespace pimonov_first
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.chrt_prices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_start_price = new System.Windows.Forms.TextBox();
            this.btn_set_random_values = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tcl_graphics = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_prices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tcl_graphics.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(12, 424);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(198, 23);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Рассчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(29, 19);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(163, 20);
            this.txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(29, 45);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(163, 20);
            this.txt_b.TabIndex = 2;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(29, 72);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(163, 20);
            this.txt_c.TabIndex = 3;
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(29, 99);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(163, 20);
            this.txt_d.TabIndex = 4;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(29, 18);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(163, 20);
            this.txt_q.TabIndex = 5;
            // 
            // chrt_prices
            // 
            chartArea2.Name = "ChartArea1";
            this.chrt_prices.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrt_prices.Legends.Add(legend2);
            this.chrt_prices.Location = new System.Drawing.Point(3, 3);
            this.chrt_prices.Name = "chrt_prices";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Price";
            this.chrt_prices.Series.Add(series2);
            this.chrt_prices.Size = new System.Drawing.Size(525, 406);
            this.chrt_prices.TabIndex = 6;
            this.chrt_prices.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "N";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(29, 19);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(163, 20);
            this.txt_n.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "P";
            // 
            // txt_start_price
            // 
            this.txt_start_price.Location = new System.Drawing.Point(29, 19);
            this.txt_start_price.Name = "txt_start_price";
            this.txt_start_price.Size = new System.Drawing.Size(163, 20);
            this.txt_start_price.TabIndex = 15;
            // 
            // btn_set_random_values
            // 
            this.btn_set_random_values.Location = new System.Drawing.Point(12, 395);
            this.btn_set_random_values.Name = "btn_set_random_values";
            this.btn_set_random_values.Size = new System.Drawing.Size(198, 23);
            this.btn_set_random_values.TabIndex = 16;
            this.btn_set_random_values.Text = "Заполнить случайными значениями";
            this.btn_set_random_values.UseVisualStyleBackColor = true;
            this.btn_set_random_values.Click += new System.EventHandler(this.btn_set_random_values_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_b);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.txt_d);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 131);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры производства";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_q);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 50);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Реакция на изменение цены";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_start_price);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 51);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начальная цена";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_n);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 52);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Количество периодов";
            // 
            // tcl_graphics
            // 
            this.tcl_graphics.Controls.Add(this.tabPage1);
            this.tcl_graphics.Location = new System.Drawing.Point(216, 12);
            this.tcl_graphics.Name = "tcl_graphics";
            this.tcl_graphics.SelectedIndex = 0;
            this.tcl_graphics.Size = new System.Drawing.Size(536, 435);
            this.tcl_graphics.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chrt_prices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Цена по периодам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 459);
            this.Controls.Add(this.tcl_graphics);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_set_random_values);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrt_prices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tcl_graphics.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_prices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_start_price;
        private System.Windows.Forms.Button btn_set_random_values;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.TabControl tcl_graphics;
    }
}

