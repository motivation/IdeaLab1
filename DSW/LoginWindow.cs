using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSW
{
    public partial class LoginWindow : Form
    {
        MainWindow frontPage;
        public LoginWindow()
        {
            frontPage = new MainWindow();
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.frontPage.Show();
        }
    }
}
