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
            this.start_server_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.stop_server_btn = new System.Windows.Forms.Button();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.dataGridView_PC_Id_Name = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ban = new System.Windows.Forms.Button();
            this.label_online = new System.Windows.Forms.Label();
            this.label_кating_result = new System.Windows.Forms.Label();
            this.label_ban = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PC_Id_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_server_btn
            // 
            this.start_server_btn.Location = new System.Drawing.Point(12, 387);
            this.start_server_btn.Name = "start_server_btn";
            this.start_server_btn.Size = new System.Drawing.Size(112, 51);
            this.start_server_btn.TabIndex = 1;
            this.start_server_btn.Text = "Start Server";
            this.start_server_btn.UseVisualStyleBackColor = true;
            this.start_server_btn.Click += new System.EventHandler(this.start_server_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(468, 387);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(112, 51);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // stop_server_btn
            // 
            this.stop_server_btn.Location = new System.Drawing.Point(162, 387);
            this.stop_server_btn.Name = "stop_server_btn";
            this.stop_server_btn.Size = new System.Drawing.Size(112, 51);
            this.stop_server_btn.TabIndex = 3;
            this.stop_server_btn.Text = "Stop Server";
            this.stop_server_btn.UseVisualStyleBackColor = true;
            this.stop_server_btn.Click += new System.EventHandler(this.stop_server_btn_Click);
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Location = new System.Drawing.Point(295, 86);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.Size = new System.Drawing.Size(458, 277);
            this.dataGridView_Results.TabIndex = 5;
            // 
            // dataGridView_PC_Id_Name
            // 
            this.dataGridView_PC_Id_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PC_Id_Name.Location = new System.Drawing.Point(12, 86);
            this.dataGridView_PC_Id_Name.Name = "dataGridView_PC_Id_Name";
            this.dataGridView_PC_Id_Name.Size = new System.Drawing.Size(262, 277);
            this.dataGridView_PC_Id_Name.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(776, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 277);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(295, 387);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 51);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ban
            // 
            this.button_ban.Location = new System.Drawing.Point(641, 387);
            this.button_ban.Name = "button_ban";
            this.button_ban.Size = new System.Drawing.Size(112, 51);
            this.button_ban.TabIndex = 9;
            this.button_ban.Text = "Ban";
            this.button_ban.UseVisualStyleBackColor = true;
            // 
            // label_online
            // 
            this.label_online.AutoSize = true;
            this.label_online.Location = new System.Drawing.Point(117, 60);
            this.label_online.Name = "label_online";
            this.label_online.Size = new System.Drawing.Size(37, 13);
            this.label_online.TabIndex = 10;
            this.label_online.Text = "Online";
            // 
            // label_кating_result
            // 
            this.label_кating_result.AutoSize = true;
            this.label_кating_result.Location = new System.Drawing.Point(487, 60);
            this.label_кating_result.Name = "label_кating_result";
            this.label_кating_result.Size = new System.Drawing.Size(66, 13);
            this.label_кating_result.TabIndex = 11;
            this.label_кating_result.Text = "Rating result";
            // 
            // label_ban
            // 
            this.label_ban.AutoSize = true;
            this.label_ban.Location = new System.Drawing.Point(884, 60);
            this.label_ban.Name = "label_ban";
            this.label_ban.Size = new System.Drawing.Size(26, 13);
            this.label_ban.TabIndex = 12;
            this.label_ban.Text = "Ban";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.label_ban);
            this.Controls.Add(this.label_кating_result);
            this.Controls.Add(this.label_online);
            this.Controls.Add(this.button_ban);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView_PC_Id_Name);
            this.Controls.Add(this.dataGridView_Results);
            this.Controls.Add(this.stop_server_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.start_server_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PC_Id_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_server_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button stop_server_btn;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.DataGridView dataGridView_PC_Id_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_ban;
        private System.Windows.Forms.Label label_online;
        private System.Windows.Forms.Label label_кating_result;
        private System.Windows.Forms.Label label_ban;
    }
}

