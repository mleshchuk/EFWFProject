using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Extention;

namespace TestProject
{
    public partial class Form1 : Form
    {
        MyDBEntities db;
        WebRequest request;
        public delegate void ErrorStateHandler(string message);
        public event ErrorStateHandler Error;
        public Form1()
        {
            InitializeComponent();
            db = new MyDBEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.MailInfo". При необходимости она может быть перемещена или удалена.
            //this.mailInfoTableAdapter.Fill(this.myDBDataSet.MailInfo);
            db.MailInfoes.Load();
            Error = (message =>
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(message, "Error");
            });
            dataGridView1.DataSource = db.MailInfoes.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var mail = dataGridView1.CurrentRow.DataBoundItem as MailInfo;
            idField.Text = Convert.ToString(mail.Id);
            mailBox.Text = mail.Mail;
        }
        private async Task<bool> IsNotExistAsync()
        {
            var isNotExist = await db.MailInfoes
                                .Where(x => x.Mail == mailBox.Text)
                                .AsNoTracking().FirstOrDefaultAsync();
            return isNotExist == null;
        }
        private bool IsNotExist()
        {
            var isNotExist =    db.MailInfoes
                                .Where(x => x.Mail == mailBox.Text)
                                .AsNoTracking().FirstOrDefaultAsync();
            return isNotExist == null;
        }
        private void ClearField()
        {
            mailBox.Text = string.Empty;
            idField.Text = string.Empty;
        }

        private async void addMail_Click(object sender, EventArgs e)
        {
            if (mailBox.Text == string.Empty) return;

            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))";
            if (!Regex.IsMatch(mailBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                Error("Invalid email address");
                return;
            }
            // why i can't use ternar operator
            if (await IsNotExistAsync())
            {
                await AddMailAsync();
                return;
            }
            Error("This mail already exists");
        }

        private async Task AddMailAsync()
        {
            db.MailInfoes.Add(new MailInfo { Mail = mailBox.Text });
            await db.SaveChangesAsync();
            dataGridView1.Refresh();
            ClearField();
            return;
        }

        private async void editMail_Click(object sender, EventArgs e)
        {
            if (mailBox.Text == string.Empty || idField.Text == string.Empty)
            {
                Error("Empty field");
                return;
            }
            if (await IsNotExistAsync())
            {
                var id = Convert.ToInt32(idField.Text);
                var editingMail = await db.MailInfoes.FindAsync(id);
                editingMail.Mail = mailBox.Text;
                db.MailInfoes.AddOrUpdate(editingMail);
                await db.SaveChangesAsync();
                ClearField();
                dataGridView1.Refresh();
                return;
            }
            Error("This mail already exists");
        }

        private async void deleteMail_Click(object sender, EventArgs e)
        {
            if (mailBox.Text == string.Empty || idField.Text == string.Empty) return;
            int id;
            MailInfo deletingMail;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = (int)dataGridView1.SelectedCells[0].Value;
                deletingMail = await db.MailInfoes.FindAsync(id);
                db.MailInfoes.Remove(deletingMail);
                await db.SaveChangesAsync();
                ClearField();
            }
            dataGridView1.Refresh();
            return;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (urlTextBox.Text == string.Empty)
            {
                Error("URL field is empty");
                return;
            }
            string urlPattern = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$";
            if (!Regex.IsMatch(urlTextBox.Text, urlPattern, RegexOptions.IgnoreCase))
            {
                Error("Invalid url address");
                return;
            }
            request = WebRequest.Create(urlTextBox.Text);
            string responseContent;
            using (WebResponse response = request.GetResponse())
            {
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            //email pattern
            Regex regex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            MatchCollection matches = regex.Matches(responseContent);
            if (matches.Count == 0)
            {
                Error("Not found mail");
                return;
            }
            List<string> matchesList = matches.ToStringCollection().ToList();
            matchesList = matchesList.Distinct().ToList();
            bool addedMail = false;
            foreach (string match in matchesList)
            {
                if (await IsNotExistAsync())
                {
                    addedMail = true;
                    db.MailInfoes.AddOrUpdate(new MailInfo { Mail = match });
                    db.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
            if (!addedMail)
            {
                Error("Not found new mail");
            }
        }
    }
}
