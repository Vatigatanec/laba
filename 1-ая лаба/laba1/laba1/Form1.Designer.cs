namespace laba1
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            this.URL = new System.Windows.Forms.TextBox();
            this.Get_Data = new System.Windows.Forms.Button();
            this.Show_Data = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(10, 25);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(143, 20);
            this.URL.TabIndex = 0;
            this.URL.Text = "http://www.nbrb.by/API/ExRates/Currencies/231";
            // 
            // Get_Data
            // 
            this.Get_Data.Location = new System.Drawing.Point(10, 51);
            this.Get_Data.Name = "Get_Data";
            this.Get_Data.Size = new System.Drawing.Size(143, 39);
            this.Get_Data.TabIndex = 1;
            this.Get_Data.Text = "Получить API";
            this.Get_Data.UseVisualStyleBackColor = true;
            this.Get_Data.Click += new System.EventHandler(this.Get_Data_Click);
            // 
            // Show_Data
            // 
            this.Show_Data.Location = new System.Drawing.Point(159, 25);
            this.Show_Data.Multiline = true;
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Show_Data.Size = new System.Drawing.Size(435, 195);
            this.Show_Data.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(159, 239);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(433, 292);
            this.Output.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отправить на email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 13000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(7, 183);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(103, 13);
            this.time.TabIndex = 6;
            this.time.Text = "Время обновления";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "WCF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "API сайта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Данные сайта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ссылка на сайт";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.Get_Data);
            this.Controls.Add(this.URL);
            this.Name = "Data";
            this.Text = "Laba1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button Get_Data;
        private System.Windows.Forms.TextBox Show_Data;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

