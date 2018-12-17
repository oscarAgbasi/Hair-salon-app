/**
 * Agbasi Oscar, 
 

 * */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2bb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTotal()
        {
            //Determinte the stylist
            decimal stylistRate = GetStylistRate();

            //determine the discount rate
            double ClientsDiscout = GetClientsDiscount();

            //determine the servicecharges
            decimal serviceCharges = GetserviceCharges();

            //determine the loyaltydiscount
            double LoyaltyDiscount = GetLoyaltyDiscount();

            //determine the total charges
            decimal TotalCharges = (stylistRate + serviceCharges) * (decimal)(1 - (LoyaltyDiscount + ClientsDiscout));

            //update the ui
            label2.Text = "Total Price: " + TotalCharges.ToString(); 

        }

        private double GetLoyaltyDiscount()
        {


            int ClientVisits; //initalzing the clientVisits
            if (!int.TryParse(txtBoxNoVisits.Text, out ClientVisits))
                throw new Exception("Number of client vistis not specified. ");

            if (ClientVisits < 0)
            {
                throw new Exception("Number of client can't be a negative number");
            }
            else if (ClientVisits < 4) {
                return 0;
            }
            else if (ClientVisits < 9)
                return 0.5;
            else if (ClientVisits < 14)
                return 0.01;
            else  if (ClientVisits > 14)
                return 0.15;
            


        }
        private decimal GetStylistRate()
        {
            if (rbJane.Checked)
                return 30.0m;
            else if (rbPat.Checked)
                return 45.0m;
            else if (rbLaura.Checked)
                return 55.0m;
            else if (rbRon.Checked)
                return 40.0m;
            else if (rbSue.Checked)
                return 50.0m;
            else
                throw new Exception("You have to pick a stylist");




        }

        private double GetClientsDiscount()


        {
            if (rbAdult.Checked)
                return 0;
            else if (rbChild.Checked)
                return 0.1d;
            else if (rbstudent.Checked)
                return 0.5d;
            else if (rbSenior.Checked)
                return 0.15d;
            else
                throw new Exception("You have to pick a service");

        }


        private decimal GetserviceCharges()
        {
            decimal TotalChargeForService = 0;

            if (chkHaircut.Checked)
                TotalChargeForService += 30;
            else if (chkColour.Checked)
                TotalChargeForService += 40;
            else if (ChkHightlights.Checked)
                TotalChargeForService += 50;
            else if (chkExtension.Checked)
                TotalChargeForService += 200;
            else
                throw new Exception("You have no services picked");

            return TotalChargeForService;
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            //set all checkbox to false
            chkColour.Checked = false;
            chkHaircut.Checked = false;
            ChkHightlights.Checked = false;
            chkExtension.Checked = false;

            //uncheck all radiio to false
            rbAdult.Checked = false;
            rbChild.Checked = false;
            rbJane.Checked = false;
            rbLaura.Checked = false;
            rbPat.Checked = false;
            rbRon.Checked = false;
            rbSenior.Checked = false;
            rbstudent.Checked = false;
            rbSue.Checked = false;

            //set text box to empty
            txtBoxNoVisits.Text = "";

            //reset total

        }

        private void txtBoxNoVisits_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
