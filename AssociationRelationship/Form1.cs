using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociationRelationship
{
    public partial class Form1 : Form
    {
        private Customer customer1;
        private Account anAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();
            anAccount.AccountNumber = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = openingDateEntryTextBox.Text;

            customer1 = new Customer();
            customer1.Name = customerNameEntryTextBox.Text;
            customer1.Email = customerEmailEntryTextBox.Text;
            customer1.AnAccount = anAccount;
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            customer1.AnAccount.Deposite(Convert.ToDouble(amountEntryTextBox.Text));
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            customer1.AnAccount.Withdrawn(Convert.ToDouble(amountEntryTextBox.Text));
        }

        private void showMeDetailsButton_Click(object sender, EventArgs e)
        {
            string customerName = customer1.Name;
            string email = customer1.Email;
            string accountNumber = customer1.AnAccount.AccountNumber;
            string openingDate = customer1.AnAccount.OpeningDate;
            string balance = customer1.AnAccount.Amount.ToString();

            customerNameShowTextBox.Text = customerName ;
            customerEmailShowTextBox.Text = email ;
            accountNumberShowTextBox.Text =  accountNumber ;
            openingDateShowTextBox.Text = openingDate ;
            balanceShowTextBox.Text = balance ; 
        }
    }
}
