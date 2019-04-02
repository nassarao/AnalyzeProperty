using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PropertyAnalyzerLib;

namespace AnalyzePropertyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UnecessaryMethods

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }
        #endregion

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            RunForm(false);

        }

        private void RunForm(bool logToFile)
        {
            //Property Details
            Address address = new Address(txtStreetNumber.Text, txtStreetName.Text, txtCity.Text, txtZip.Text, txtState.Text);
            Property property = new Property(address, cmbType.Text);

            //Cost Assumptions
            double purcahsePrice = Double.Parse(txtPurchasePrice.Text);
            double downPayment = Double.Parse(txtDownPayment.Text);
            double improvements = Double.Parse(txtImprovements.Text);
            double closingCost = Double.Parse(txtClosingCosts.Text);

            CostAssumption ca = new CostAssumption(purcahsePrice, downPayment, improvements, closingCost);
            lblCashOutlay.Text = "Total Cash Outaly: " + ca.CashOutaly.ToString("C2");
            lblTotalCost.Text = "Total Cost: " + ca.TotalCost.ToString("C2");


            //Financial Assumptions
            double loanAmount = Double.Parse(txtFinanceAmount.Text);
            double downPaymentPercentage = Double.Parse(txtDownPaymentPercentage.Text);
            double interestRate = Double.Parse(txtInterestRate.Text) / 100;
            int mortgageLength = Int32.Parse(txtMortgaageLength.Text);
            double pmiRate = Double.Parse(txtPMIRate.Text);


            FinancingAssumptions fa = new FinancingAssumptions(loanAmount, downPayment, downPaymentPercentage, interestRate, pmiRate, mortgageLength);
            lblMonthlyMortgage.Text = "Monthly Mortgage: " + fa.MonthlyPayment.ToString("C2");
            lblMonthlyPMI.Text = "Monthly PMI: " + fa.MonthlyPMI.ToString("C2");
            lblYearlyMortgage.Text = "Yearly Mortgage: " + fa.YearlyMortgagePayment.ToString("C2");
            lblYearlyPMI.Text = "Yearly PMI: " + fa.YearlyPMI.ToString("C2");

            //Revenue
            double rent = Double.Parse(txtRent.Text);
            double vacancyRate = Double.Parse(txtVacancyRate.Text);
            double otherIncome = Double.Parse(txtOtherIncome.Text);

            Revenue revenue = new Revenue(rent, vacancyRate, otherIncome);
            lblGrossMonthlyIncome.Text = "Gross Monthly Income: " + revenue.GrossIncome.ToString("C2");
            lblGrossYearlyIncome.Text = "Gross Yearly Income: " + revenue.YearlyGrossIncome.ToString("C2");

            //Expenses
            double propertyTax = Double.Parse(txtPropertyTax.Text);
            double insurance = Double.Parse(txtInsurance.Text);
            double advertising = Double.Parse(txtAdvertising.Text);
            double maintenanceAndRepair = Double.Parse(txtMaintenacneAndRepair.Text);
            double propertyManagement = Double.Parse(txtPropertyManagement.Text);
            double other = Double.Parse(txtOther.Text);
            double utilities = Double.Parse(txtUtilities.Text);

            Expenses expenses = new Expenses(propertyTax, insurance, maintenanceAndRepair, advertising, utilities, other);

            lblMonthlyExpenses.Text = "Monthly Expenses: " + (expenses.Total / 12).ToString("C2");
            lblYearlyExpenses.Text = "Yearly Expenses: " + expenses.Total.ToString("C2");


            PropertyAnalyzer pa = new PropertyAnalyzer(expenses, fa, ca, revenue, property);

            lblNOI.Text = "NOI: $" + Math.Round(pa.NOI, 3);
            lblCashFlow.Text = "Cash Flow: " + pa.CashFlow.ToString("C2");
            lblCAPRate.Text = "CAP Rate: " + Math.Round(pa.CapRate, 3) + "%";
            lblCOCRate.Text = "COC Rate: " + Math.Round(pa.COCRate, 3) + "%";
            lblEquity.Text = "Equity 1 year: " + pa.Equity.ToString("C2");
            lblROI.Text = "Total ROI: " + Math.Round(pa.TotalROI, 3) + "%";


            if (logToFile)
            {
                Logger log = new Logger(property);
                log.write("************************************************NEW ANALYSIS************************************************");
                log.write(ca.ToString());
                log.write(fa.ToString());
                log.write(expenses.ToString());
                log.write(revenue.ToString());
                log.write(pa.ToString());

                log.openAnalysisFile();
            }
        }

        private void onDownPaymentUpdated(object sender, EventArgs e)
        {
            double downPayment = Double.Parse(txtDownPayment.Text);
            double purchasePrice = Double.Parse(txtPurchasePrice.Text);

            double downPaymentPercentage = Math.Round((downPayment / purchasePrice) * 100, 3);
            txtDownPaymentPercentage.Text = downPaymentPercentage.ToString();

            double financeAmount = purchasePrice - downPayment;
            txtFinanceAmount.Text = financeAmount.ToString();
        }

        private void onDownPaymentPercentageUpdated(object sender, EventArgs e)
        {
            double downPaymentPercentage = Double.Parse(txtDownPaymentPercentage.Text);
            downPaymentPercentage = downPaymentPercentage / 100;


            double purchasePrice = Double.Parse(txtPurchasePrice.Text);

            double downPayment = purchasePrice * downPaymentPercentage;
            txtDownPayment.Text = downPayment.ToString();

            double financeAmount = purchasePrice - downPayment;
            txtFinanceAmount.Text = financeAmount.ToString();
        }

        private string formatOutput(string message)
        {
            string output = "";

            string lineBreak = "\n----------------------------------------------------------------------------\n";
            output += lineBreak;

            if (message.Contains("|"))
            {
                output += message.Replace("|", "\n");
            }
            else
                output += message;

            return output;
        }

        private void btnUpFive_Click(object sender, EventArgs e)
        {
            double price = Double.Parse(txtPurchasePrice.Text);
            price = Math.Round(price + (price * 0.05));
            txtPurchasePrice.Text = price.ToString();
        }

        private void btnDownFive_Click(object sender, EventArgs e)
        {
            double price = Double.Parse(txtPurchasePrice.Text);
            price = Math.Round(price - (price * 0.05));
            txtPurchasePrice.Text = price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RunForm(true);

        }
    }
}
