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
    public partial class Tovars : Form
    {
        public Tovars()
        {
            InitializeComponent();
            var context = new Model1();
            var productList = context.Product.ToList();
            dataGridView1.DataSource = productList;
            if(UserState.user == null)
            {
                label_name.Text = "Аноним";
            }
            else
            {
                label_name.Text = $"{UserState.user.UserSurname} {UserState.user.UserName}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
