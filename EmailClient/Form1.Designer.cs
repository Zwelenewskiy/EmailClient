namespace EmailClient
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.письмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_getEmails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_addEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.P_tmp = new System.Windows.Forms.Panel();
            this.L_tmpText = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_emails = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_changeEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.P_tmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_emails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.письмаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // письмаToolStripMenuItem
            // 
            this.письмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_getEmails,
            this.TSMI_addEmail});
            this.письмаToolStripMenuItem.Name = "письмаToolStripMenuItem";
            this.письмаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.письмаToolStripMenuItem.Text = "Письма";
            // 
            // TSMI_getEmails
            // 
            this.TSMI_getEmails.Name = "TSMI_getEmails";
            this.TSMI_getEmails.Size = new System.Drawing.Size(180, 22);
            this.TSMI_getEmails.Text = "Просмотреть";
            this.TSMI_getEmails.Click += new System.EventHandler(this.TSMI_getEmails_Click);
            // 
            // TSMI_addEmail
            // 
            this.TSMI_addEmail.Name = "TSMI_addEmail";
            this.TSMI_addEmail.Size = new System.Drawing.Size(180, 22);
            this.TSMI_addEmail.Text = "Добавить";
            this.TSMI_addEmail.Click += new System.EventHandler(this.TSMI_addEmail_Click);
            // 
            // P_tmp
            // 
            this.P_tmp.BackColor = System.Drawing.SystemColors.Control;
            this.P_tmp.Controls.Add(this.L_tmpText);
            this.P_tmp.Location = new System.Drawing.Point(293, 95);
            this.P_tmp.Name = "P_tmp";
            this.P_tmp.Size = new System.Drawing.Size(191, 90);
            this.P_tmp.TabIndex = 2;
            // 
            // L_tmpText
            // 
            this.L_tmpText.AutoSize = true;
            this.L_tmpText.Location = new System.Drawing.Point(18, 41);
            this.L_tmpText.Name = "L_tmpText";
            this.L_tmpText.Size = new System.Drawing.Size(35, 13);
            this.L_tmpText.TabIndex = 0;
            this.L_tmpText.Text = "label1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Тэги";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Содержание";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отправитель";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адресат";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            // 
            // DGV_emails
            // 
            this.DGV_emails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_emails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGV_emails.Location = new System.Drawing.Point(12, 27);
            this.DGV_emails.Name = "DGV_emails";
            this.DGV_emails.ReadOnly = true;
            this.DGV_emails.RowHeadersVisible = false;
            this.DGV_emails.Size = new System.Drawing.Size(737, 234);
            this.DGV_emails.TabIndex = 0;
            this.DGV_emails.DoubleClick += new System.EventHandler(this.DGV_emails_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_changeEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // TSMI_changeEmail
            // 
            this.TSMI_changeEmail.Name = "TSMI_changeEmail";
            this.TSMI_changeEmail.Size = new System.Drawing.Size(180, 22);
            this.TSMI_changeEmail.Text = "Изменить";
            this.TSMI_changeEmail.Click += new System.EventHandler(this.TSMI_changeEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 271);
            this.Controls.Add(this.P_tmp);
            this.Controls.Add(this.DGV_emails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.P_tmp.ResumeLayout(false);
            this.P_tmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_emails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem письмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_getEmails;
        private System.Windows.Forms.Panel P_tmp;
        private System.Windows.Forms.Label L_tmpText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGV_emails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_addEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_changeEmail;
    }
}

