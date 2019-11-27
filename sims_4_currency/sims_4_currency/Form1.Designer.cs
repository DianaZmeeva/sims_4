namespace sims_4_currency
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sell_D = new System.Windows.Forms.Button();
            this.sell_E = new System.Windows.Forms.Button();
            this.buy_D = new System.Windows.Forms.Button();
            this.buy_E = new System.Windows.Forms.Button();
            this.kol_money = new System.Windows.Forms.Label();
            this.num_of_day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dollar = new System.Windows.Forms.Label();
            this.Euro = new System.Windows.Forms.Label();
            this.inputPrice_D = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.inputDays = new System.Windows.Forms.NumericUpDown();
            this.inputPrice_E = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.t);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sell_D);
            this.panel1.Controls.Add(this.sell_E);
            this.panel1.Controls.Add(this.buy_D);
            this.panel1.Controls.Add(this.buy_E);
            this.panel1.Controls.Add(this.kol_money);
            this.panel1.Controls.Add(this.num_of_day);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Dollar);
            this.panel1.Controls.Add(this.Euro);
            this.panel1.Controls.Add(this.inputPrice_D);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.inputDays);
            this.panel1.Controls.Add(this.inputPrice_E);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 143);
            this.panel1.TabIndex = 0;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.ForeColor = System.Drawing.Color.Red;
            this.t.Location = new System.Drawing.Point(187, 101);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(0, 13);
            this.t.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Next day";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sell_D
            // 
            this.sell_D.Location = new System.Drawing.Point(312, 71);
            this.sell_D.Name = "sell_D";
            this.sell_D.Size = new System.Drawing.Size(35, 23);
            this.sell_D.TabIndex = 13;
            this.sell_D.Text = "Sell";
            this.sell_D.UseVisualStyleBackColor = true;
            this.sell_D.Click += new System.EventHandler(this.sell_D_Click);
            // 
            // sell_E
            // 
            this.sell_E.Location = new System.Drawing.Point(152, 71);
            this.sell_E.Name = "sell_E";
            this.sell_E.Size = new System.Drawing.Size(35, 23);
            this.sell_E.TabIndex = 12;
            this.sell_E.Text = "Sell";
            this.sell_E.UseVisualStyleBackColor = true;
            this.sell_E.Click += new System.EventHandler(this.sell_E_Click);
            // 
            // buy_D
            // 
            this.buy_D.Location = new System.Drawing.Point(227, 71);
            this.buy_D.Name = "buy_D";
            this.buy_D.Size = new System.Drawing.Size(35, 23);
            this.buy_D.TabIndex = 11;
            this.buy_D.Text = "Buy";
            this.buy_D.UseVisualStyleBackColor = true;
            this.buy_D.Click += new System.EventHandler(this.buy_D_Click);
            // 
            // buy_E
            // 
            this.buy_E.Location = new System.Drawing.Point(67, 71);
            this.buy_E.Name = "buy_E";
            this.buy_E.Size = new System.Drawing.Size(35, 23);
            this.buy_E.TabIndex = 10;
            this.buy_E.Text = "Buy";
            this.buy_E.UseVisualStyleBackColor = true;
            this.buy_E.Click += new System.EventHandler(this.buy_E_Click);
            // 
            // kol_money
            // 
            this.kol_money.AutoSize = true;
            this.kol_money.Location = new System.Drawing.Point(54, 9);
            this.kol_money.Name = "kol_money";
            this.kol_money.Size = new System.Drawing.Size(63, 13);
            this.kol_money.TabIndex = 9;
            this.kol_money.Text = "Money: 500";
            // 
            // num_of_day
            // 
            this.num_of_day.AutoSize = true;
            this.num_of_day.Location = new System.Drawing.Point(3, 9);
            this.num_of_day.Name = "num_of_day";
            this.num_of_day.Size = new System.Drawing.Size(38, 13);
            this.num_of_day.TabIndex = 8;
            this.num_of_day.Text = "Day: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial price:";
            // 
            // Dollar
            // 
            this.Dollar.AutoSize = true;
            this.Dollar.Location = new System.Drawing.Point(265, 29);
            this.Dollar.Name = "Dollar";
            this.Dollar.Size = new System.Drawing.Size(46, 13);
            this.Dollar.TabIndex = 7;
            this.Dollar.Text = "Dollar: 0";
            // 
            // Euro
            // 
            this.Euro.AutoSize = true;
            this.Euro.Location = new System.Drawing.Point(119, 29);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(41, 13);
            this.Euro.TabIndex = 6;
            this.Euro.Text = "Euro: 0";
            // 
            // inputPrice_D
            // 
            this.inputPrice_D.DecimalPlaces = 4;
            this.inputPrice_D.Location = new System.Drawing.Point(227, 45);
            this.inputPrice_D.Name = "inputPrice_D";
            this.inputPrice_D.Size = new System.Drawing.Size(120, 20);
            this.inputPrice_D.TabIndex = 5;
            this.inputPrice_D.Value = new decimal(new int[] {
            658568,
            0,
            0,
            262144});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputDays
            // 
            this.inputDays.Location = new System.Drawing.Point(122, 117);
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(120, 20);
            this.inputDays.TabIndex = 3;
            this.inputDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inputPrice_E
            // 
            this.inputPrice_E.DecimalPlaces = 4;
            this.inputPrice_E.Location = new System.Drawing.Point(67, 45);
            this.inputPrice_E.Name = "inputPrice_E";
            this.inputPrice_E.Size = new System.Drawing.Size(120, 20);
            this.inputPrice_E.TabIndex = 2;
            this.inputPrice_E.Value = new decimal(new int[] {
            730738,
            0,
            0,
            262144});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days:";
            // 
            // chart1
            // 
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 143);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.LimeGreen;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Dollar";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(359, 273);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 416);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown inputDays;
        private System.Windows.Forms.NumericUpDown inputPrice_E;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown inputPrice_D;
        private System.Windows.Forms.Label Dollar;
        private System.Windows.Forms.Label Euro;
        private System.Windows.Forms.Label kol_money;
        private System.Windows.Forms.Label num_of_day;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button sell_D;
        private System.Windows.Forms.Button sell_E;
        private System.Windows.Forms.Button buy_D;
        private System.Windows.Forms.Button buy_E;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label t;
    }
}

