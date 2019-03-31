using System;
using PropertyAnalyzerLib;

namespace AnalyzeProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            //Property

            string streetNumber = "7110";
            string streetName = "Eastlawn Drive";
            string city = "Cincinnati";
            string zip = "45237";
            string state = "OH";

            string propertyType = PropertyTypes.QUADPLEX;

            //Cost assumptions
            double purchasePrice = 129900;
            double downPaymentPercentage = .035;
            double downPayment = downPaymentPercentage * purchasePrice;
            double improvements = 5000;
            double closingCosts = 3000;


            //Finance Assumptions
            double interestRate = .04;
            int mortgageLength = 30;
            double loanAmount = purchasePrice - downPayment;

            //expenses
            double propertyTax = 3500;
            double insurance = 800;
            double yearlyMaintence = 1500;
            double advertising = 200;

            //Revenue
            double monthylyRent = 2235;
            double vacancyRate = 0;
            double otherIncome = 0;

            Analyze(streetNumber, streetName, city, zip, state, propertyType, purchasePrice, downPayment, downPaymentPercentage, improvements, closingCosts, interestRate, mortgageLength, loanAmount, propertyTax, insurance, yearlyMaintence, advertising, monthylyRent, vacancyRate, otherIncome);
        }

        private static void Analyze(string streetNumber, string streetName, string city, string zip, string state, string propertyType, double purchasePrice, double downPayment, double downPaymentPercentage, double improvements, double closingCosts, double interestRate, int mortgageLength, double loanAmount, double propertyTax, double insurance, double yearlyMaintence, double advertising, double monthylyRent, double vacancyRate, double otherIncome)
        {
            Property property = new Property(new Address(streetNumber, streetName, city, zip, state), propertyType);
            Console.WriteLine(property.Address.ToString());
            CostAssumption ca = new CostAssumption(purchasePrice, downPayment, improvements, closingCosts);
            FinancingAssumptions fa = new FinancingAssumptions(loanAmount, downPayment, downPaymentPercentage, interestRate, mortgageLength);
            property.PropertyTax = propertyTax;
            Expenses expenses = new Expenses(propertyTax, insurance, yearlyMaintence);
            expenses.Advertising = advertising;
            expenses.CalculateTotal();


            Revenue revenue = new Revenue(monthylyRent, vacancyRate, otherIncome);


            PropertyAnalyzer pa = new PropertyAnalyzer(expenses, fa, ca, revenue, property);

            logToScreen(ca.ToString());
            logToScreen(fa.ToString());
            logToScreen(expenses.ToString());
            logToScreen(revenue.ToString());
            logToScreen(pa.ToString());


            Console.WriteLine("Write to log? y/n");


            bool writeToLog = Console.ReadLine().ToLower() == "y";

            if (writeToLog)
            {
                Logger log = new Logger(property);
                log.write("************************************************NEW ANALYSIS************************************************");
                log.write(ca.ToString());
                log.write(fa.ToString());
                log.write(expenses.ToString());
                log.write(revenue.ToString());
                log.write(pa.ToString());


                Console.WriteLine("Open anlaysis? y/n");
                bool openAnlaysis = Console.ReadLine().ToLower() == "y";

                if (openAnlaysis)
                {
                    log.openAnalysisFile();
                }
            }

            Console.WriteLine("Quickly Analyze again? y/n");
            bool analyzeAgain = Console.ReadLine().ToLower() == "y";
            if (analyzeAgain)
            {
                Console.WriteLine("Change Purchase price by -5% ? y/n");
                bool fivePercent = Console.ReadLine().ToLower() == "y";
                if (fivePercent)
                {
                    purchasePrice = purchasePrice - (purchasePrice * 0.05);
                }
                else
                {
                    Console.WriteLine("Enter new Purchase Price: ");
                    purchasePrice = Double.Parse(Console.ReadLine());
                }

                Analyze(streetNumber, streetName, city, zip, state, propertyType, purchasePrice, downPayment, downPaymentPercentage, improvements, closingCosts, interestRate, mortgageLength, loanAmount, propertyTax, insurance, yearlyMaintence, advertising, monthylyRent, vacancyRate, otherIncome);
            }
        }

        private static void logToScreen(string message)
        {
            string lineBreak = "----------------------------------------------------------------------------";
            if (message.Contains("|"))
            {
                Console.WriteLine(lineBreak);
                string[] messages = message.Split('|');
                for (int i = 0; i < messages.Length; i++)
                {
                    Console.WriteLine(messages[i].Trim());
                }
            }
            else
                Console.WriteLine(message);
        }
    }
}
