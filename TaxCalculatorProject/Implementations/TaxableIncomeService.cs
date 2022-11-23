namespace TaxCalculatorProject;

public class TaxableIncomeService : ITaxableIncomeService
{
          public decimal CalculatePension(decimal income)
          {
                    if(income <= 0) throw new InvalidOperationException("income cannot be zero");
                    decimal percent = (decimal)(8.0/100.0);
                    decimal pension = income * percent;
                    return pension;
          }
          private decimal CalculateGI2(decimal amount)
          {
                    if(amount <= 0) throw new InvalidOperationException("income cannot be zero");
                    return amount - CalculatePension(amount);
          }

          public decimal ConsolidatedReliefAllowance(decimal income)
          {
                    if(income <= 0) throw new InvalidOperationException("income cannot be zero");
                    decimal percent20 = (decimal)(20.0/100.0);
                    decimal percent1 = (decimal)(1.0/100.0);
                    decimal a = percent20 * (CalculateGI2(income));
                    decimal b = percent1 * income;
                    decimal max = Math.Max(200000, b);
                    return a + max;
          }


          public decimal CalculateTaxableIncome(decimal income)
          {
                    if(income <= 0) throw new InvalidOperationException("income cannot be zero");
                    income *= 12;
                    decimal taxIncome = income - (ConsolidatedReliefAllowance(income) + CalculatePension(income));
                    return taxIncome;
          }
}
