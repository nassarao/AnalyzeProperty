﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class FinancingAssumptions
    {
        public double FinanceAmount { get; set; } //ak loan amount
        public double DownPayment { get; set; }
        public double DownPaymentPercentage { get; set; }
        public double PMIRate { get; set; }

        public double MonthlyPMI { get; set; }
        public double YearlyPMI { get; set; }
        public double InterestRate { get; set; }
        public double MortgageYears { get; set; }
        public double MonthlyPayment { get; set; }
        public double YearlyMortgagePayment { get; set; }



        public FinancingAssumptions(double financeAmount,double downPayment, double downPayemntPercentage, double interestRate,double pmiRate, int mortgageYears)
        {
            this.FinanceAmount = financeAmount;
            this.DownPaymentPercentage = downPayemntPercentage;
            this.DownPayment = downPayment;
            this.InterestRate = interestRate;
            this.PMIRate = pmiRate;

            this.YearlyPMI = FinanceAmount * PMIRate;
            this.MonthlyPMI = YearlyPMI / 12;

            this.MortgageYears = mortgageYears;

            this.MonthlyPayment = CalculateMortgagePayment();
            this.YearlyMortgagePayment = MonthlyPayment * 12;


        }

        public double CalculateMortgagePayment()
        {
            double monthlyRate = InterestRate / 12;
            double numberOfMonths = MortgageYears * 12;

            return (monthlyRate / (1 - Math.Pow(monthlyRate + 1, numberOfMonths * -1))) * FinanceAmount;
        }

        override
        public string ToString()
        {
            return String.Format("Financing Assumptions|Finance Amount: {0}|Down Payment: {1}| Down Payment Percentage: {2}| Interest Rate: {3}|Mortgage length: {4}|Monthly Payment: {5}",
                FinanceAmount, DownPayment, DownPaymentPercentage, InterestRate, MortgageYears, MonthlyPayment);
        }

    }
}
