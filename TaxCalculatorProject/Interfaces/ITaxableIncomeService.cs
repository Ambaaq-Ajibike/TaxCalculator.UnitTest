namespace TaxCalculatorProject;

public interface ITaxableIncomeService
{
          decimal CalculatePension(decimal income);
          decimal ConsolidatedReliefAllowance(decimal income);
          decimal CalculateTaxableIncome(decimal income);
}
