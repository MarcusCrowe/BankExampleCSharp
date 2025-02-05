using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //WITHDRAW BUTTON
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
        }

        //EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
