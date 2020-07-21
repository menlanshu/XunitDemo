using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        List<PersonModel> currPeople = DataAccess.GetAllPersons();
        public Dashboard()
        {
            InitializeComponent();

            WireUpUser();
        }

        private void WireUpUser()
        {
            // set current list to null
            this.userComboBox.DataSource = null;

            // set combobox data source to current people list
            this.userComboBox.DataSource = currPeople;
            this.userComboBox.DisplayMember = "FullName";

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(ValidateNumberInput(out double firstNumber, out double secondNumber))
            {
                this.resultTextBox.Text = Calculator.Add(firstNumber, secondNumber).ToString();
            }
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            if(ValidateNumberInput(out double firstNumber, out double secondNumber))
            {
                this.resultTextBox.Text = Calculator.Substract(firstNumber, secondNumber).ToString();
            }

        }

        private void mulitiplyButton_Click(object sender, EventArgs e)
        {
            if(ValidateNumberInput(out double firstNumber, out double secondNumber))
            {
                this.resultTextBox.Text = Calculator.Multiply(firstNumber, secondNumber).ToString();
            }

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if(ValidateNumberInput(out double firstNumber, out double secondNumber))
            {
                this.resultTextBox.Text = Calculator.Divide(firstNumber, secondNumber).ToString();
            }

        }
        
        private bool ValidateNumberInput(out double firstNumber,out double secondNumber)
        {
            bool isValid = true;
            string errDesc = "";

            if(!double.TryParse(this.firstNumberUD.Text,out firstNumber))
            {
                isValid = false;
                errDesc = $"First Name invalid input {this.firstNumberUD.Text}\n";
            }
            
            if(!double.TryParse(this.secondNumberUD.Text,out secondNumber))
            {
                isValid = false;
                errDesc += $"Second Name invalid input {this.secondNumberUD.Text}\n";
            }

            if (!isValid) MessageBox.Show(errDesc);

            return isValid;
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (this.firstNameTextBox.Text.Length == 0 ||
                this.secondNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid user name, please revise it!");
            }else
            {
                PersonModel personModel = new PersonModel();
                personModel.FirstName = this.firstNameTextBox.Text;
                personModel.LastName = this.secondNameTextBox.Text;

                currPeople.Add(personModel);
                DataAccess.AddNewPerson(personModel);

                WireUpUser();

                MessageBox.Show("Add Success");
            }
        }
    }
}
