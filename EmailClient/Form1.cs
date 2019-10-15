using System;
using EmailClient.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DGV_emails.ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P_tmp.Hide();
        }

        private void TSMI_getEmails_Click(object sender, EventArgs e)
        {
           Task.Factory.StartNew(() =>
            {
                P_tmp.Show();
                L_tmpText.Text = "Идет получение списка писем";
                L_tmpText.Left = (P_tmp.Width - L_tmpText.Width) / 2;

                var emails = (List<Email>)Functions.UserAction(new UserActionParams()
                {
                    action = Functions.Action.getEmails
                });

                DGV_emails.Rows.Clear();
                foreach (var email in emails)
                {
                    string tags = null; 
                    if(email.tags.Length != 0)
                      tags = email.tags.Aggregate((x, y) => x += ", " + y);

                    DGV_emails.Rows.Add(email.name, email.date.ToString("yyyy-MM-dd"), email.recepient, email.sender, email.content, tags);
                    DGV_emails.Rows[DGV_emails.RowCount - 2].Tag = email.id;
                }

                P_tmp.Hide();
            });            
        }

        private void TSMI_addEmail_Click(object sender, EventArgs e)
        {
            using(var addEmailForm = new ChangeEmail(new ChangeEmailParams()
            {
                action = Functions.Action.sendEmail
            }))
            {
                addEmailForm.ShowDialog();
            }
        }

        private void TSMI_changeEmail_Click(object sender, EventArgs e)
        {
            if(DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[0].Value != null)
            {
                using (var changeEmailForm = new ChangeEmail(new ChangeEmailParams()
                {
                    action = Functions.Action.changeEmail,
                    email = new Email()
                    {
                        id = (int)DGV_emails.Rows[DGV_emails.CurrentRow.Index].Tag,
                        name = DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[0].Value.ToString(),
                        date = Convert.ToDateTime(DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[1].Value.ToString()),
                        recepient = DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[2].Value.ToString(),
                        sender = DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[3].Value.ToString(),
                        content = DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[4].Value.ToString(),
                        tags = DGV_emails.Rows[DGV_emails.CurrentRow.Index].Cells[5].Value.ToString().Split(',')
                    }
                }))
                {
                    changeEmailForm.ShowDialog();
                }
            }
        }

        private void DGV_emails_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(DGV_emails.Rows[DGV_emails.CurrentRow.Index].Tag + "");
        }
    }
}
