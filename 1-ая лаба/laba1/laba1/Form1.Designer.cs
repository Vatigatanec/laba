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
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(12, 12);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(143, 20);
            this.URL.TabIndex = 0;
            this.URL.Text = "http://www.nbrb.by/API/ExRates/Currencies/231";
            // 
            // Get_Data
            // 
            this.Get_Data.Location = new System.Drawing.Point(12, 38);
            this.Get_Data.Name = "Get_Data";
            this.Get_Data.Size = new System.Drawing.Size(102, 39);
            this.Get_Data.TabIndex = 1;
            this.Get_Data.Text = "Получить данные";
            this.Get_Data.UseVisualStyleBackColor = true;
            this.Get_Data.Click += new System.EventHandler(this.Get_Data_Click);
            // 
            // Show_Data
            // 
            this.Show_Data.Location = new System.Drawing.Point(12, 92);
            this.Show_Data.Multiline = true;
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Show_Data.Size = new System.Drawing.Size(277, 283);
            this.Show_Data.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(305, 92);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(490, 423);
            this.Output.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(221, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 13);
            this.time.TabIndex = 6;
            this.time.Text = "время";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "WCF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 533);
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
    }
}

