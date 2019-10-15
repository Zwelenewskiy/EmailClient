namespace EmailClient
{
    partial class ChangeEmail
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
            this.TB_sender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_recepient = new System.Windows.Forms.TextBox();
            this.RTB_content = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.BT_send = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_tags = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tags)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_sender
            // 
            this.TB_sender.Location = new System.Drawing.Point(12, 28);
            this.TB_sender.Name = "TB_sender";
            this.TB_sender.Size = new System.Drawing.Size(133, 20);
            this.TB_sender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От кого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кому:";
            // 
            // TB_recepient
            // 
            this.TB_recepient.Location = new System.Drawing.Point(12, 74);
            this.TB_recepient.Name = "TB_recepient";
            this.TB_recepient.Size = new System.Drawing.Size(133, 20);
            this.TB_recepient.TabIndex = 2;
            // 
            // RTB_content
            // 
            this.RTB_content.Location = new System.Drawing.Point(12, 129);
            this.RTB_content.MaxLength = 300;
            this.RTB_content.Name = "RTB_content";
            this.RTB_content.Size = new System.Drawing.Size(425, 117);
            this.RTB_content.TabIndex = 4;
            this.RTB_content.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Содержание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Название:";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(178, 28);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(125, 20);
            this.TB_name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата:";
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(178, 74);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(125, 20);
            this.DTP_date.TabIndex = 10;
            // 
            // BT_send
            // 
            this.BT_send.Location = new System.Drawing.Point(195, 252);
            this.BT_send.Name = "BT_send";
            this.BT_send.Size = new System.Drawing.Size(75, 23);
            this.BT_send.TabIndex = 11;
            this.BT_send.Text = "Отправить";
            this.BT_send.UseVisualStyleBackColor = true;
            this.BT_send.Click += new System.EventHandler(this.BT_send_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // DGV_tags
            // 
            this.DGV_tags.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGV_tags.Location = new System.Drawing.Point(320, 28);
            this.DGV_tags.Name = "DGV_tags";
            this.DGV_tags.RowHeadersVisible = false;
            this.DGV_tags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_tags.Size = new System.Drawing.Size(117, 98);
            this.DGV_tags.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Теги:";
            // 
            // ChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(450, 281);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_tags);
            this.Controls.Add(this.BT_send);
            this.Controls.Add(this.DTP_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB_content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_recepient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_sender);
            this.MaximizeBox = false;
            this.Name = "ChangeEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление письма";
            this.Load += new System.EventHandler(this.ChangeEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_sender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_recepient;
        private System.Windows.Forms.RichTextBox RTB_content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.Button BT_send;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGV_tags;
        private System.Windows.Forms.Label label6;
    }
}