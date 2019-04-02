using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class PropertyAnalyzer
    {
        public double NOI { get; set; }
        public double CashFlow { get; set; }
        public double ROI { get; set; }
        public double CapRate { get; set; }
        public double TotalROI { get; set; }
        public double COCRate { get; set; }
        public double AppreciationRate { get; set; }
        public double Equity { get; set; }
        public double TaxBreak { get; set; }
        public double ExtraTax { get; set; }

        public Property Property { get; set; }
        public Expenses Expenses { get; set; }
        public FinancingAssumptions FA { get; set; }
        public CostAssumption CA { get; set; }
        public Revenue Revenue { get; set; }


        public PropertyAnalyzer(Expenses expenses, FinancingAssumptions fa, CostAssumption ca, Revenue re, Property property)
        {
            Expenses = expenses;
            FA = fa;
            CA = ca;
            Revenue = re;
            Property = property;
            CalcNOI();
            CalcCashFlow();
            CalcCAPRate();
            CalcCOCRate();
            CalcEquity();
            CalcToalROI();
        }

        public double CalcNOI()
        {
            NOI = Revenue.YearlyGrossIncome - Expenses.Total;
            return NOI;

        }

        public double CalcCashFlow()
        {
            CashFlow = NOI - (FA.MonthlyPayment * 12) - FA.YearlyPMI;
            return CashFlow;
        }

        public double CalcCAPRate()
        {
           CapRate = NOI / CA.PurchasePrice;
           CapRate = Math.Round(CapRate * 100, 3);
            return CapRate;
        }

        public double CalcCOCRate()
        {
            COCRate = CashFlow / CA.CashOutaly;
            COCRate = Math.Round(COCRate * 100, 3);
            return COCRate;
        }

        public double CalcEquity()
        {
           Equity = (AppreciationValueOneYear() - (FA.FinanceAmount - (FA.CalculateMortgagePayment() * 12)));
            return Equity;
        }

        public double AppreciationValueOneYear()
        {
           return (CA.PurchasePrice * AppreciationRate) + CA.PurchasePrice;
        }

        public double CalcToalROI()
        {
            TotalROI = (CashFlow + Equity + (CA.PurchasePrice * AppreciationRate) + TaxBreak + ExtraTax) / CA.CashOutaly;
            TotalROI = Math.Round(TotalROI * 100, 3);
            return TotalROI;
        }

        public void OutputData()
        {
            Console.WriteLine("NOI: " + NOI);
            Console.WriteLine("Cash Flow: " + CashFlow);
            Console.WriteLine("CAP Rate: " + CapRate );
            Console.WriteLine("COC Rate: " + COCRate );
            Console.WriteLine("Total ROI: " + TotalROI);
        }

        override
        public string ToString()
        {
            return String.Format("Property Analysis|NOI: {0} | Cash Flow: {1} | CAP Rate: {2} | COC Rate: {3} | Total ROI: {4}", NOI, CashFlow, CapRate, COCRate, TotalROI);
        }

    }
}
