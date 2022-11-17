namespace Game_Kursak_Admin
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.start_server_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.stop_server_btn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 277);
            this.listBox1.TabIndex = 0;
            // 
            // start_server_btn
            // 
            this.start_server_btn.Location = new System.Drawing.Point(37, 325);
            this.start_server_btn.Name = "start_server_btn";
            this.start_server_btn.Size = new System.Drawing.Size(112, 51);
            this.start_server_btn.TabIndex = 1;
            this.start_server_btn.Text = "Start Server";
            this.start_server_btn.UseVisualStyleBackColor = true;
            this.start_server_btn.Click += new System.EventHandler(this.start_server_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(309, 325);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(112, 51);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // stop_server_btn
            // 
            this.stop_server_btn.Location = new System.Drawing.Point(174, 325);
            this.stop_server_btn.Name = "stop_server_btn";
            this.stop_server_btn.Size = new System.Drawing.Size(112, 51);
            this.stop_server_btn.TabIndex = 3;
            this.stop_server_btn.Text = "Stop Server";
            this.stop_server_btn.UseVisualStyleBackColor = true;
            this.stop_server_btn.Click += new System.EventHandler(this.stop_server_btn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(445, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(308, 277);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.stop_server_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.start_server_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button start_server_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button stop_server_btn;
        private System.Windows.Forms.ListBox listBox2;
    }
}

