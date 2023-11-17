using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportProducts
{
    public partial class Auntification : Form
    {
        public Auntification()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                var login = textBox1.Text;
                var password = textBox2.Text;

                var user = context.User.FirstOrDefault(x => x.UserLogin == login && x.UserPassword == password);
                if (user == null)
                {
                    MessageBox.Show("Неверные данные");
                    return;
                }

                var role = context.Role.FirstOrDefault(x => x.RoleID == user.UserRole);
                user.Role = role;
                UserState.user = user;
                var order = new Tovars();
                Hide();
                order.ShowDialog();
                Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var order = new Tovars();
            Hide();
            order.ShowDialog();
            Show();
        }
    }
}
