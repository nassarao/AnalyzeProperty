using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class Revenue
    {
        public double Rent { get; set; }
        public double VacancyRate { get; set; }
        public double NetRentalIncome { get; set; }
        public double OtherIncome { get; set; }
        public double GrossIncome { get; set; }

        public double YearlyRent { get; set; }
        public double YearlyNetIncome { get; set; }
        public double YearlyOther { get; set; }
        public double YearlyGrossIncome { get; set; }


        public Revenue(double monthlyRent, double vavancyRate, double otherIncome)
        {
            this.Rent = monthlyRent;
            this.VacancyRate = vavancyRate;
            this.OtherIncome = OtherIncome;
            YearlyRent = monthlyRent * 12;
            YearlyOther = OtherIncome * 12;

            NetRentalIncome = Rent - (Rent * vavancyRate);
            YearlyNetIncome = NetRentalIncome * 12;

            GrossIncome = NetRentalIncome + OtherIncome;
            YearlyGrossIncome = GrossIncome * 12;


        }

        override
        public string ToString()
        {
            return String.Format("Revenue|Rent: {0}|Vacancy Rate: {1}|Other Income: {2}|Gross Income:{3}| Yearly Rent: {4}| Yearly Other Income: {5}| Yearly Net Income: {6}| Yearly Gross Income: {7}",
                Rent, VacancyRate, NetRentalIncome, OtherIncome, GrossIncome, YearlyRent, YearlyOther, YearlyNetIncome, YearlyGrossIncome);

        }
    }
}
