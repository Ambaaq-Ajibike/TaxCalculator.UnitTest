namespace TaxCalculatorProject;

public class CalculateTaxService
{
    private readonly  TaxableIncomeService _taxableIncomeService;

          public CalculateTaxService(TaxableIncomeService taxableIncomeService)
          {
                    _taxableIncomeService = taxableIncomeService;
          }
          public CalculateTaxService()
          {
            
          }

          public decimal CalculateTaxForFirst300000(decimal income)
        {
            decimal amount = (income >= 300000) ? 300000 : income;
            decimal percentage = (decimal)(7.00/100.00);
            decimal result = amount * percentage;
            return result;
        }
        public decimal CalculateTaxForNext300000(decimal income)
        {
            if(income <= 0) return 0;
             decimal amount = (income >= 300000) ? 300000 : income;
            decimal percentage = (decimal)(11.00/100.00);
            decimal result = amount * percentage;
            return result;
        }
        public decimal CalculateTaxForFirst500000(decimal income)
        {
            if(income <= 0) return 0;
             decimal amount = (income >= 500000) ? 500000 : income;
            decimal percentage = (decimal)(15.00/100.00);
            decimal result = amount * percentage;
            return result;
        }
        public decimal CalculateTaxForNext500000(decimal income)
        {
            if(income <= 0) return 0;
            decimal amount = (income >= 500000) ? 500000 : income;
            decimal percentage = (decimal)(19.00/100.00);
             decimal result = amount * percentage;
            return result;
        }
        public decimal CalculateTaxFor1600000(decimal income)
        {
            if(income <= 0) return 0;
             decimal amount = (income >= 1600000) ? 1600000 : income;
            decimal percentage = (decimal)(21.00/100.00);
            decimal result = amount * percentage;
            return result;
        }
        public decimal CalculateTaxForIncomeOver3200000(decimal income)
        {
            if(income <= 0) return 0;
            decimal amount = (income >= 3200000) ? 3200000 : income;
            decimal percentage = (decimal)(24.00/100.00);
            decimal result = amount * percentage;
            return result;
        }
        public decimal GeneralCalc(decimal income)
        {
            income *= 12;
            decimal amount = _taxableIncomeService.CalculateTaxableIncome(income);
            decimal first300 = CalculateTaxForFirst300000(amount);
            amount -= 300000;
            decimal second300 = CalculateTaxForNext300000(amount);
            amount -= 300000;
            decimal first500 = CalculateTaxForFirst500000(amount);
            amount -= 500000;
            decimal second500 = CalculateTaxForNext500000(amount);
            amount -= 500000;
            decimal first1600000 = CalculateTaxFor1600000(amount);
            amount -= 1600000;
            decimal over = CalculateTaxForIncomeOver3200000(amount);
            decimal result = first300 + second300 + first500 + second500 + first1600000 + over;
            return result / 12;
        }
        
}
