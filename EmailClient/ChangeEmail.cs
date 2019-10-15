using System;
using EmailClient.Classes;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class ChangeEmail : Form
    {
        private Functions.Action act;
        private int id;

        public ChangeEmail(ChangeEmailParams parameters)
        {
            InitializeComponent();

            act = parameters.action;
            switch (act)
            {
                case Functions.Action.changeEmail:
                    Text = "Изменение письма";
                    BT_send.Text = "Изменить";

                    TB_sender.Text = parameters.email.sender;
                    TB_recepient.Text = parameters.email.recepient;
                    TB_name.Text = parameters.email.name;
                    RTB_content.Text = parameters.email.content;
                    DTP_date.Value = parameters.email.date;

                    id = parameters.email.id;

                    for (byte i = 0; i < parameters.email.tags.Length; i++)
                        DGV_tags.Rows.Add(parameters.email.tags[i]);

                    break;
            }
        }

        private void ChangeEmail_Load(object sender, EventArgs e)
        {
            DTP_date.CustomFormat = "yyyy-MM-dd";
            DTP_date.Format = DateTimePickerFormat.Custom;
        }

        private void BT_send_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TB_sender.Text.Trim()) && !string.IsNullOrWhiteSpace(TB_recepient.Text.Trim())
                && !string.IsNullOrWhiteSpace(TB_name.Text) && Functions.CheckEmail(TB_sender.Text.Trim()) 
                && Functions.CheckEmail(TB_recepient.Text.Trim()))
            {
                string[] tags = new string[DGV_tags.RowCount - 1];
                for (int i = 0; i < DGV_tags.RowCount - 1; i++)
                    tags[i] = DGV_tags.Rows[i].Cells[0].Value.ToString();

                Email tmp_email = new Email()
                {
                    id = id,
                    date = DTP_date.Value,
                    name = TB_name.Text,
                    sender = TB_sender.Text.Trim(),
                    recepient = TB_recepient.Text.Trim(),
                    content = RTB_content.Text,
                    tags = tags
                };
                
                if ((bool)Functions.UserAction(new UserActionParams()
                {
                    action = act,
                    email = tmp_email
                }))
                {
                    MessageBox.Show("Письмо успешно отправлено", "Отправка письма", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при отправке письма", "Отправка письма", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
            else
            {
                MessageBox.Show("Поля некорректно заполнены либо пусты", "Отправка письма", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
