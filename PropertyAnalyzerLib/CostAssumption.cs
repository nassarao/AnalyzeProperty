using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class CostAssumption
    {
        public double PurchasePrice { get; set; }
        public double DownPayment { get; set; }
        public double Improvements { get; set; }
        public double ClosingCosts { get; set; }
        public double TotalCost { get; set; }
        public double CashOutaly { get; set; }


        public CostAssumption(double purchasePrice, double downPayment, double improvements, double closingCosts )
        {
            this.PurchasePrice = purchasePrice;
            this.DownPayment = downPayment;
            this.Improvements = improvements;
            this.ClosingCosts = closingCosts;
            this.TotalCost = PurchasePrice + DownPayment + Improvements + ClosingCosts;
            this.CashOutaly = DownPayment + Improvements + ClosingCosts;

        }

        override
        public string ToString()
        {
            return (String.Format("Cost Assumptions|Purchase Price: {0}|DownPayment: {1}|Improvements: {2}|Closing Costs: {3}|Total Cost: {4}|Cash Outlay: {5}",
                PurchasePrice,DownPayment,Improvements,ClosingCosts,TotalCost,CashOutaly));
        }
    }
}
