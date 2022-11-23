namespace TaxCalculatorProject;

public  interface ICalculateTaxService
{
          decimal CalculateTaxForFirst300000(decimal income);
          decimal CalculateTaxForNext300000(decimal income);
          decimal CalculateTaxForFirst500000(decimal income);
          decimal CalculateTaxForNext500000(decimal income);
          decimal CalculateTaxFor1600000(decimal income);
          decimal CalculateTaxForIncomeOver3200000(decimal income);
          decimal GeneralCalc(decimal income);
}
