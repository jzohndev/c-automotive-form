using System;
using System.Windows.Forms;

namespace Homework10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display() //displays all calculated values on form
        {
            const double TAX = .06;

            int oilLubeTotal = OilLubeCharges(); //assignment of values to display on form
            int flushTotal = FlushCharges();
            int miscTotal = MiscCharges();

            int otherTotal = 0; //initialize working values
            int labor = 0;
            int parts = 0;
            double servicesLaborTotal = 0; 
            double total = 0;
            double taxTotal = 0;
            bool validation = false;
            string zero = 0.ToString();

            validation = ValidationCheck(ref parts, ref labor); //checks for validation and assigns values to parts and labor
            otherTotal = OtherCharges(parts: parts, labor: labor); //assigns total of other charges
            taxTotal = TaxCharges(tax: TAX, parts: parts); //assigns total of tax

            servicesLaborTotal = (oilLubeTotal + flushTotal + miscTotal + labor); //total services and labor, oil & lube + flushes + misc + labor
            total = TotalCharges(oilLube: oilLubeTotal, flushes: flushTotal, misc: miscTotal, other: otherTotal, tax: taxTotal); //total assigned value of TotalCharge method, all services, labor, parts, and taxes

            if (validation)
            {
                servicesLabel.Text = servicesLaborTotal.ToString("c"); //all values assigned to respective labels
                partsLabel.Text = partsTextBox.Text;
                taxLabel.Text = taxTotal.ToString("c");
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                servicesLabel.Text = zero;
                partsLabel.Text = zero;
                taxLabel.Text = zero;
                totalLabel.Text = zero;
            }

        }

        private int OilLubeCharges() //checks state of both oil and lube checkboxes, returns prices respectively
        {
            int total = 0;
            int oil = 0;
            int lube = 0;

            switch (oilCheckBox.Checked)
            {
                case true:
                    oil = 26;
                    break;
                case false:
                    oil = 0;
                    break;
            }
            switch (lubeCheckBox.Checked)
            {
                case true:
                    lube = 18;
                    break;
                case false:
                    lube = 0;
                    break;
            }

            return total = (oil + lube);
        }  

        private int FlushCharges() //checks state of both transmission and radiator checkboxes, returns prices respectively
        {
            int total = 0;
            int radFlush = 0;
            int transFlush = 0;

            switch (radiatorCheckBox.Checked)
            {
                case true:
                    radFlush = 30;
                    break;
                case false:
                    radFlush = 0;
                    break;
            }
            switch (transmissionCheckBox.Checked)
            {
                case true:
                    transFlush = 80;
                    break;
                case false:
                    transFlush = 0;
                    break;
            }

            return total = (radFlush + transFlush);
        }

        private int MiscCharges() //checks state of inspection, muffler and tire rotation checkboxes, returns prices respectively
        {
            int inspec = 0;
            int replaceMuff = 0;
            int tireRotate = 0;
            int total = 0;

            switch (inspectionCheckBox.Checked)
            {
                case true:
                    inspec = 15;
                    break;
                case false:
                    inspec = 0;
                    break;
            }
            switch (mufflerCheckBox.Checked)
            {
                case true:
                    replaceMuff = 100;
                    break;
                case false:
                    replaceMuff = 0;
                    break;
            }
            switch (rotationCheckBox.Checked)
            {
                case true:
                    tireRotate = 20;
                    break;
                case false:
                    tireRotate = 0;
                    break;
            }

            return total = (inspec + replaceMuff + tireRotate);

        }

        private int OtherCharges(int parts, int labor) //returns prices respectively for both labor and parts textboxes
        {
            int total = 0;

            return total = (parts + labor);
        }

        private double TaxCharges(double tax, int parts) //calculates taxes from parts
        {
            return parts * tax;
        }

        private int GetLabor()
        {
            int labor = 0;
            
            if (laborTextBox.Text != "")
            {
                labor = Int32.Parse(laborTextBox.Text);
            }
            return labor;
        } //method to get labor

        private double TotalCharges(int oilLube, int flushes, int misc, int other, double tax) //redundant method for calculating the total of all values
        {
            double total;

            return total = (oilLube + flushes + misc + other + tax);
        }

        private void calcButton_Click(object sender, EventArgs e) //invokes the display method
        {
            Display(); 
        }

        private bool ValidationCheck(ref int parts, ref int labor) //checks to see if parts and labor are valid values
        {
            bool validation = false;

            if (Int32.TryParse(laborTextBox.Text, out labor)){ //validates labor
                if (Int32.TryParse(partsTextBox.Text, out parts)) //validates parts
                {
                    validation = true;
                }
                else
                {
                    MessageBox.Show("Missing value in Parts field.");
                    partsTextBox.Focus();
                }
            }
            else
            {
                if (!Int32.TryParse(partsTextBox.Text, out parts)) //validates labor AND parts
                {
                    MessageBox.Show("Missing value in Labor & Parts fields.");
                    laborTextBox.Focus();
                }
                else {
                    MessageBox.Show("Missing value in Labor field.");
                    laborTextBox.Focus();
                }
            }
            return validation;
        }

        private void ClearOilLube()
        {
            oilCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorCheckBox.Checked = false;
            transmissionCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            rotationCheckBox.Checked = false;
        }
        
        private void ClearOther()
        {
            laborTextBox.Text = "";
            partsTextBox.Text = "";
        }

        private void ClearFees()
        {
            servicesLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
