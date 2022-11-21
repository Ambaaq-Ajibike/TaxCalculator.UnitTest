namespace TaxCalculatorProject;

public class TaxableIncomeService
{
          public decimal CalculatePension(decimal income)
          {
                    decimal percent = (decimal)(8.0/100.0);
                    decimal pension = income * percent;
                    return pension;
          }
          public decimal CalculateGI2(decimal amount)
          {
                    return amount - CalculatePension(amount);
          }

          public decimal ConsolidatedReliefAllowance(decimal income)
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
                    decimal taxIncome = income - (ConsolidatedReliefAllowance(income) + CalculatePension(income));
                    return taxIncome;
          }
}
