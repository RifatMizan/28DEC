using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class BankAccountUI : Form
    {
        public BankAccountUI()
        {
            InitializeComponent();
        }
        Customer aCustomer = new Customer();
        private void Savebutton_Click(object sender, EventArgs e)
        {
            Account aAccount = new Account();
            aAccount.AccountNo = accountNumberTextBox.Text;
            aAccount.OpeningDate = openDateTextBox.Text;
            
            
            aCustomer.CustomerName = customerNameTextBox.Text;
            aCustomer.CustomerEmail = emailTextBox.Text;
            aCustomer.CustomerAccount = aAccount;
        }

        private void withdraw_Button_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            aCustomer.CustomerAccount.Withdraw(amount);
        }

        private void deposit_Button_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            aCustomer.CustomerAccount.Deposit(amount);
        }

        private void showMeAll_Button_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.CustomerName;
            EmailDisplayTextBox.Text = aCustomer.CustomerEmail;
            AccountNumberDisplayTextBox.Text = aCustomer.CustomerAccount.AccountNo;
            openDateDisplayTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceDisplayTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }

    }
}
