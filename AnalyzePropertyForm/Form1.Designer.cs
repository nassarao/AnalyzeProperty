namespace AnalyzePropertyForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCashOutlay = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtClosingCosts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImprovements = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMonthlyMortgage = new System.Windows.Forms.Label();
            this.txtMortgaageLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFinanceAmount = new System.Windows.Forms.TextBox();
            this.txtDownPaymentPercentage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numUnitCount = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblGrossYearlyIncome = new System.Windows.Forms.Label();
            this.lblGrossMonthlyIncome = new System.Windows.Forms.Label();
            this.txtOtherIncome = new System.Windows.Forms.TextBox();
            this.txtVacancyRate = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblYearlyExpenses = new System.Windows.Forms.Label();
            this.lblMonthlyExpenses = new System.Windows.Forms.Label();
            this.txtUtilities = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAdvertising = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMaintenacneAndRepair = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPropertyManagement = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPropertyTax = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblROI = new System.Windows.Forms.Label();
            this.lblCOCRate = new System.Windows.Forms.Label();
            this.lblCAPRate = new System.Windows.Forms.Label();
            this.lblCashFlow = new System.Windows.Forms.Label();
            this.lblEquity = new System.Windows.Forms.Label();
            this.lblNOI = new System.Windows.Forms.Label();
            this.btnUpFive = new System.Windows.Forms.Button();
            this.btnDownFive = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMonthlyPMI = new System.Windows.Forms.Label();
            this.txtPMIRate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblYearlyMortgage = new System.Windows.Forms.Label();
            this.lblYearlyPMI = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitCount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(11, 31);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(47, 13);
            this.lblStreetNumber.TabIndex = 0;
            this.lblStreetNumber.Text = "Number:";
            this.lblStreetNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(64, 28);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNumber.TabIndex = 1;
            this.txtStreetNumber.Text = "7110";
            this.txtStreetNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(226, 28);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtStreetName.TabIndex = 2;
            this.txtStreetName.Text = "Eastlawn Drive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Street:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtZipCode);
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStreetNumber);
            this.groupBox1.Controls.Add(this.txtStreetName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStreetNumber);
            this.groupBox1.Location = new System.Drawing.Point(301, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(64, 59);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 14;
            this.txtState.Text = "OH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "State:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(226, 59);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 12;
            this.txtZipCode.Text = "45237";
            // 
            // txtZip
            // 
            this.txtZip.AutoSize = true;
            this.txtZip.Location = new System.Drawing.Point(195, 63);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(25, 13);
            this.txtZip.TabIndex = 13;
            this.txtZip.Text = "Zip:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(394, 28);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 10;
            this.txtCity.Text = "Cincinnati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCashOutlay);
            this.groupBox2.Controls.Add(this.lblTotalCost);
            this.groupBox2.Controls.Add(this.txtClosingCosts);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtImprovements);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPurchasePrice);
            this.groupBox2.Controls.Add(this.txtDownPayment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 211);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cost Assumptions";
            // 
            // lblCashOutlay
            // 
            this.lblCashOutlay.AutoSize = true;
            this.lblCashOutlay.Location = new System.Drawing.Point(8, 177);
            this.lblCashOutlay.Name = "lblCashOutlay";
            this.lblCashOutlay.Size = new System.Drawing.Size(97, 13);
            this.lblCashOutlay.TabIndex = 22;
            this.lblCashOutlay.Text = "Total Cash Outlay: ";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(8, 150);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(61, 13);
            this.lblTotalCost.TabIndex = 21;
            this.lblTotalCost.Text = "Total Cost: ";
            // 
            // txtClosingCosts
            // 
            this.txtClosingCosts.Location = new System.Drawing.Point(94, 111);
            this.txtClosingCosts.Name = "txtClosingCosts";
            this.txtClosingCosts.Size = new System.Drawing.Size(195, 20);
            this.txtClosingCosts.TabIndex = 14;
            this.txtClosingCosts.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Closing Costs:";
            // 
            // txtImprovements
            // 
            this.txtImprovements.Location = new System.Drawing.Point(94, 85);
            this.txtImprovements.Name = "txtImprovements";
            this.txtImprovements.Size = new System.Drawing.Size(195, 20);
            this.txtImprovements.TabIndex = 10;
            this.txtImprovements.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Improvements:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(94, 25);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(195, 20);
            this.txtPurchasePrice.TabIndex = 1;
            this.txtPurchasePrice.Text = "129900";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(94, 56);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(195, 20);
            this.txtDownPayment.TabIndex = 2;
            this.txtDownPayment.Text = "4546.5";
            this.txtDownPayment.Leave += new System.EventHandler(this.onDownPaymentUpdated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Down Payment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblYearlyPMI);
            this.groupBox3.Controls.Add(this.lblYearlyMortgage);
            this.groupBox3.Controls.Add(this.txtPMIRate);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lblMonthlyPMI);
            this.groupBox3.Controls.Add(this.lblMonthlyMortgage);
            this.groupBox3.Controls.Add(this.txtMortgaageLength);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtInterestRate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFinanceAmount);
            this.groupBox3.Controls.Add(this.txtDownPaymentPercentage);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(322, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 211);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finance Assumptions";
            // 
            // lblMonthlyMortgage
            // 
            this.lblMonthlyMortgage.AutoSize = true;
            this.lblMonthlyMortgage.Location = new System.Drawing.Point(12, 166);
            this.lblMonthlyMortgage.Name = "lblMonthlyMortgage";
            this.lblMonthlyMortgage.Size = new System.Drawing.Size(95, 13);
            this.lblMonthlyMortgage.TabIndex = 23;
            this.lblMonthlyMortgage.Text = "Monthly Mortgage:";
            // 
            // txtMortgaageLength
            // 
            this.txtMortgaageLength.Location = new System.Drawing.Point(152, 111);
            this.txtMortgaageLength.Name = "txtMortgaageLength";
            this.txtMortgaageLength.Size = new System.Drawing.Size(137, 20);
            this.txtMortgaageLength.TabIndex = 14;
            this.txtMortgaageLength.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mortgage Length:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(152, 85);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(137, 20);
            this.txtInterestRate.TabIndex = 10;
            this.txtInterestRate.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Interest Rate:";
            // 
            // txtFinanceAmount
            // 
            this.txtFinanceAmount.Location = new System.Drawing.Point(152, 25);
            this.txtFinanceAmount.Name = "txtFinanceAmount";
            this.txtFinanceAmount.Size = new System.Drawing.Size(137, 20);
            this.txtFinanceAmount.TabIndex = 1;
            this.txtFinanceAmount.Text = "125353.5";
            // 
            // txtDownPaymentPercentage
            // 
            this.txtDownPaymentPercentage.Location = new System.Drawing.Point(152, 56);
            this.txtDownPaymentPercentage.Name = "txtDownPaymentPercentage";
            this.txtDownPaymentPercentage.Size = new System.Drawing.Size(137, 20);
            this.txtDownPaymentPercentage.TabIndex = 2;
            this.txtDownPaymentPercentage.Text = "3.5";
            this.txtDownPaymentPercentage.Leave += new System.EventHandler(this.onDownPaymentPercentageUpdated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Down Payment Percentage:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Finance Ammount:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numUnitCount);
            this.groupBox4.Controls.Add(this.cmbType);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(934, 145);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Property Details";
            // 
            // numUnitCount
            // 
            this.numUnitCount.Location = new System.Drawing.Point(94, 61);
            this.numUnitCount.Name = "numUnitCount";
            this.numUnitCount.Size = new System.Drawing.Size(98, 20);
            this.numUnitCount.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Single Family",
            "Duplex",
            "Triplex",
            "Quadplex",
            "Apartment Building"});
            this.cmbType.Location = new System.Drawing.Point(94, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(98, 21);
            this.cmbType.TabIndex = 5;
            this.cmbType.Text = "Quadplex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Unit Count:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Type:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblGrossYearlyIncome);
            this.groupBox5.Controls.Add(this.lblGrossMonthlyIncome);
            this.groupBox5.Controls.Add(this.txtOtherIncome);
            this.groupBox5.Controls.Add(this.txtVacancyRate);
            this.groupBox5.Controls.Add(this.txtRent);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(623, 163);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 211);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Revenue";
            // 
            // lblGrossYearlyIncome
            // 
            this.lblGrossYearlyIncome.AutoSize = true;
            this.lblGrossYearlyIncome.Location = new System.Drawing.Point(6, 177);
            this.lblGrossYearlyIncome.Name = "lblGrossYearlyIncome";
            this.lblGrossYearlyIncome.Size = new System.Drawing.Size(107, 13);
            this.lblGrossYearlyIncome.TabIndex = 26;
            this.lblGrossYearlyIncome.Text = "Gross Yearly Income:";
            // 
            // lblGrossMonthlyIncome
            // 
            this.lblGrossMonthlyIncome.AutoSize = true;
            this.lblGrossMonthlyIncome.Location = new System.Drawing.Point(6, 150);
            this.lblGrossMonthlyIncome.Name = "lblGrossMonthlyIncome";
            this.lblGrossMonthlyIncome.Size = new System.Drawing.Size(115, 13);
            this.lblGrossMonthlyIncome.TabIndex = 25;
            this.lblGrossMonthlyIncome.Text = "Gross Monthly Income:";
            // 
            // txtOtherIncome
            // 
            this.txtOtherIncome.Location = new System.Drawing.Point(105, 85);
            this.txtOtherIncome.Name = "txtOtherIncome";
            this.txtOtherIncome.Size = new System.Drawing.Size(180, 20);
            this.txtOtherIncome.TabIndex = 24;
            this.txtOtherIncome.Text = "0";
            // 
            // txtVacancyRate
            // 
            this.txtVacancyRate.Location = new System.Drawing.Point(105, 56);
            this.txtVacancyRate.Name = "txtVacancyRate";
            this.txtVacancyRate.Size = new System.Drawing.Size(180, 20);
            this.txtVacancyRate.TabIndex = 23;
            this.txtVacancyRate.Text = "0";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(105, 25);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(180, 20);
            this.txtRent.TabIndex = 22;
            this.txtRent.Text = "2235";
            this.txtRent.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Other Income:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Vacancy Rate:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Rent:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblYearlyExpenses);
            this.groupBox6.Controls.Add(this.lblMonthlyExpenses);
            this.groupBox6.Controls.Add(this.txtUtilities);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.txtAdvertising);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txtOther);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.txtMaintenacneAndRepair);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtPropertyManagement);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.txtPropertyTax);
            this.groupBox6.Controls.Add(this.txtInsurance);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(12, 380);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(605, 145);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yearly Expenses";
            // 
            // lblYearlyExpenses
            // 
            this.lblYearlyExpenses.AutoSize = true;
            this.lblYearlyExpenses.Location = new System.Drawing.Point(450, 122);
            this.lblYearlyExpenses.Name = "lblYearlyExpenses";
            this.lblYearlyExpenses.Size = new System.Drawing.Size(88, 13);
            this.lblYearlyExpenses.TabIndex = 24;
            this.lblYearlyExpenses.Text = "Yearly Expenses:";
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(307, 119);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(96, 13);
            this.lblMonthlyExpenses.TabIndex = 23;
            this.lblMonthlyExpenses.Text = "Monthly Expenses:";
            // 
            // txtUtilities
            // 
            this.txtUtilities.Location = new System.Drawing.Point(94, 119);
            this.txtUtilities.Name = "txtUtilities";
            this.txtUtilities.Size = new System.Drawing.Size(100, 20);
            this.txtUtilities.TabIndex = 20;
            this.txtUtilities.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Utilities:";
            // 
            // txtAdvertising
            // 
            this.txtAdvertising.Location = new System.Drawing.Point(94, 89);
            this.txtAdvertising.Name = "txtAdvertising";
            this.txtAdvertising.Size = new System.Drawing.Size(100, 20);
            this.txtAdvertising.TabIndex = 18;
            this.txtAdvertising.Text = "200";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Advertisnig:";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(453, 86);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(133, 20);
            this.txtOther.TabIndex = 16;
            this.txtOther.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(307, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Other:";
            // 
            // txtMaintenacneAndRepair
            // 
            this.txtMaintenacneAndRepair.Location = new System.Drawing.Point(453, 29);
            this.txtMaintenacneAndRepair.Name = "txtMaintenacneAndRepair";
            this.txtMaintenacneAndRepair.Size = new System.Drawing.Size(133, 20);
            this.txtMaintenacneAndRepair.TabIndex = 14;
            this.txtMaintenacneAndRepair.Text = "1500";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(307, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Maintenance and Repair:";
            // 
            // txtPropertyManagement
            // 
            this.txtPropertyManagement.Location = new System.Drawing.Point(453, 56);
            this.txtPropertyManagement.Name = "txtPropertyManagement";
            this.txtPropertyManagement.Size = new System.Drawing.Size(133, 20);
            this.txtPropertyManagement.TabIndex = 10;
            this.txtPropertyManagement.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(307, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Property Management:";
            // 
            // txtPropertyTax
            // 
            this.txtPropertyTax.Location = new System.Drawing.Point(94, 25);
            this.txtPropertyTax.Name = "txtPropertyTax";
            this.txtPropertyTax.Size = new System.Drawing.Size(100, 20);
            this.txtPropertyTax.TabIndex = 1;
            this.txtPropertyTax.Text = "3500";
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(94, 56);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(100, 20);
            this.txtInsurance.TabIndex = 2;
            this.txtInsurance.Text = "800";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Insurance:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Property Tax:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(377, 531);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(125, 23);
            this.btnAnalyze.TabIndex = 19;
            this.btnAnalyze.Text = "Run Analysis";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblROI);
            this.groupBox7.Controls.Add(this.lblCOCRate);
            this.groupBox7.Controls.Add(this.lblCAPRate);
            this.groupBox7.Controls.Add(this.lblCashFlow);
            this.groupBox7.Controls.Add(this.lblEquity);
            this.groupBox7.Controls.Add(this.lblNOI);
            this.groupBox7.Location = new System.Drawing.Point(632, 380);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 145);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Analysis";
            // 
            // lblROI
            // 
            this.lblROI.AutoSize = true;
            this.lblROI.Location = new System.Drawing.Point(134, 66);
            this.lblROI.Name = "lblROI";
            this.lblROI.Size = new System.Drawing.Size(56, 13);
            this.lblROI.TabIndex = 5;
            this.lblROI.Text = "Total ROI:";
            // 
            // lblCOCRate
            // 
            this.lblCOCRate.AutoSize = true;
            this.lblCOCRate.Location = new System.Drawing.Point(6, 122);
            this.lblCOCRate.Name = "lblCOCRate";
            this.lblCOCRate.Size = new System.Drawing.Size(58, 13);
            this.lblCOCRate.TabIndex = 4;
            this.lblCOCRate.Text = "COC Rate:";
            // 
            // lblCAPRate
            // 
            this.lblCAPRate.AutoSize = true;
            this.lblCAPRate.Location = new System.Drawing.Point(6, 96);
            this.lblCAPRate.Name = "lblCAPRate";
            this.lblCAPRate.Size = new System.Drawing.Size(57, 13);
            this.lblCAPRate.TabIndex = 3;
            this.lblCAPRate.Text = "CAP Rate:";
            // 
            // lblCashFlow
            // 
            this.lblCashFlow.AutoSize = true;
            this.lblCashFlow.Location = new System.Drawing.Point(6, 66);
            this.lblCashFlow.Name = "lblCashFlow";
            this.lblCashFlow.Size = new System.Drawing.Size(59, 13);
            this.lblCashFlow.TabIndex = 2;
            this.lblCashFlow.Text = "Cash Flow:";
            // 
            // lblEquity
            // 
            this.lblEquity.AutoSize = true;
            this.lblEquity.Location = new System.Drawing.Point(134, 36);
            this.lblEquity.Name = "lblEquity";
            this.lblEquity.Size = new System.Drawing.Size(71, 13);
            this.lblEquity.TabIndex = 1;
            this.lblEquity.Text = "Equity 1 year:";
            // 
            // lblNOI
            // 
            this.lblNOI.AutoSize = true;
            this.lblNOI.Location = new System.Drawing.Point(6, 36);
            this.lblNOI.Name = "lblNOI";
            this.lblNOI.Size = new System.Drawing.Size(29, 13);
            this.lblNOI.TabIndex = 0;
            this.lblNOI.Text = "NOI:";
            // 
            // btnUpFive
            // 
            this.btnUpFive.Location = new System.Drawing.Point(12, 531);
            this.btnUpFive.Name = "btnUpFive";
            this.btnUpFive.Size = new System.Drawing.Size(105, 23);
            this.btnUpFive.TabIndex = 23;
            this.btnUpFive.Text = "+ 5% Price";
            this.btnUpFive.UseVisualStyleBackColor = true;
            this.btnUpFive.Click += new System.EventHandler(this.btnUpFive_Click);
            // 
            // btnDownFive
            // 
            this.btnDownFive.Location = new System.Drawing.Point(123, 531);
            this.btnDownFive.Name = "btnDownFive";
            this.btnDownFive.Size = new System.Drawing.Size(105, 23);
            this.btnDownFive.TabIndex = 28;
            this.btnDownFive.Text = "- 5% Price";
            this.btnDownFive.UseVisualStyleBackColor = true;
            this.btnDownFive.Click += new System.EventHandler(this.btnDownFive_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(728, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save Analysis";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMonthlyPMI
            // 
            this.lblMonthlyPMI.AutoSize = true;
            this.lblMonthlyPMI.Location = new System.Drawing.Point(12, 195);
            this.lblMonthlyPMI.Name = "lblMonthlyPMI";
            this.lblMonthlyPMI.Size = new System.Drawing.Size(69, 13);
            this.lblMonthlyPMI.TabIndex = 24;
            this.lblMonthlyPMI.Text = "Monthly PMI:";
            // 
            // txtPMIRate
            // 
            this.txtPMIRate.Location = new System.Drawing.Point(152, 137);
            this.txtPMIRate.Name = "txtPMIRate";
            this.txtPMIRate.Size = new System.Drawing.Size(137, 20);
            this.txtPMIRate.TabIndex = 25;
            this.txtPMIRate.Text = "0.0085";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "PMI Rate:";
            // 
            // lblYearlyMortgage
            // 
            this.lblYearlyMortgage.AutoSize = true;
            this.lblYearlyMortgage.Location = new System.Drawing.Point(149, 166);
            this.lblYearlyMortgage.Name = "lblYearlyMortgage";
            this.lblYearlyMortgage.Size = new System.Drawing.Size(87, 13);
            this.lblYearlyMortgage.TabIndex = 27;
            this.lblYearlyMortgage.Text = "Yearly Mortgage:";
            // 
            // lblYearlyPMI
            // 
            this.lblYearlyPMI.AutoSize = true;
            this.lblYearlyPMI.Location = new System.Drawing.Point(150, 195);
            this.lblYearlyPMI.Name = "lblYearlyPMI";
            this.lblYearlyPMI.Size = new System.Drawing.Size(61, 13);
            this.lblYearlyPMI.TabIndex = 28;
            this.lblYearlyPMI.Text = "Yearly PMI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(964, 579);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDownFive);
            this.Controls.Add(this.btnUpFive);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Property Analyzer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitCount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label txtZip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClosingCosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImprovements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMortgaageLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFinanceAmount;
        private System.Windows.Forms.TextBox txtDownPaymentPercentage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numUnitCount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOtherIncome;
        private System.Windows.Forms.TextBox txtVacancyRate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAdvertising;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMaintenacneAndRepair;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPropertyManagement;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPropertyTax;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAnalyze;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtUtilities;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCashOutlay;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblMonthlyMortgage;
        private System.Windows.Forms.Label lblGrossYearlyIncome;
        private System.Windows.Forms.Label lblGrossMonthlyIncome;
        private System.Windows.Forms.Label lblYearlyExpenses;
        private System.Windows.Forms.Label lblMonthlyExpenses;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCOCRate;
        private System.Windows.Forms.Label lblCAPRate;
        private System.Windows.Forms.Label lblCashFlow;
        private System.Windows.Forms.Label lblEquity;
        private System.Windows.Forms.Label lblNOI;
        private System.Windows.Forms.Label lblROI;
        private System.Windows.Forms.Button btnUpFive;
        private System.Windows.Forms.Button btnDownFive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMonthlyPMI;
        private System.Windows.Forms.TextBox txtPMIRate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblYearlyPMI;
        private System.Windows.Forms.Label lblYearlyMortgage;
    }
}

