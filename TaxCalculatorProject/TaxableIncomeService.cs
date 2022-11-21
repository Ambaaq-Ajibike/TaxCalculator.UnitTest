namespace TaxCalculatorProject;

public class TaxableIncomeService
{
          private decimal CalculatePension(decimal income)
          {
                    decimal percent = (decimal)(8.0/100.0);
                    decimal pension = income * percent;
                    return pension;
          }
          private decimal CalculateGI2(decimal amount)
          {
                    return amount - CalculatePension(amount);
          }

          private decimal ConsolidatedReliefAllowance(decimal income)
          {
                    decimal percent20 = (decimal)(20.0/100.0);
                    decimal percent1 = (decimal)(1.0/100.0);
                    decimal a = percent20 * (CalculateGI2(income));
                    decimal b = percent1 * income;
                    decimal max = Math.Max(200000, b);
                    return a + max;
          }


          public decimal CalculateTaxableIncome(decimal income)
          {
                    income *= 12;
                    decimal taxIncome = income - (ConsolidatedReliefAllowance(income) + CalculatePension(income));
                    return taxIncome;
          }
}
