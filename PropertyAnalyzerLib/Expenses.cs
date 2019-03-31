using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class Expenses
    {
        public double PropertyTax { get; set; }
        public double Insurance { get; set; }
        public double PropertyManagement { get; set; }
        public double MaintenanceRepair { get; set; }
       
        public double Advertising { get; set; }
        public double Utilities { get; set; }
        public double Other { get; set; }
        public double Total { get; set; }

        public Expenses(double proptax, double insurace, double maintenanceRepair)
        {
            this.PropertyTax = proptax;
            this.Insurance = insurace;
            this.MaintenanceRepair = maintenanceRepair;

            CalculateTotal();
         
        }
        public Expenses(double proptax, double insurace, double maintenanceRepair,double advertising, double utilities, double other)
        {
            this.PropertyTax = proptax;
            this.Insurance = insurace;
            this.MaintenanceRepair = maintenanceRepair;
            Advertising = advertising;
            Utilities = utilities;
            Other = other;

            CalculateTotal();

        }

        public double CalculateTotal()
        {
            this.Total = PropertyTax + Insurance + PropertyManagement + MaintenanceRepair + Advertising + Utilities + Other;
            return Total;
        }

        override
        public string ToString()
        {
            return String.Format("Expenses|Property tax: {0}|Insurance: {1}|Property Management: {2}|Maintenance and Repair: {3}|Advertising: {4}|Utilities: {5}|Other: {6}|Total Expenses: {7}",
                PropertyTax, Insurance, PropertyManagement, MaintenanceRepair, Advertising, Utilities, Other, Total);
        }

    }
}
