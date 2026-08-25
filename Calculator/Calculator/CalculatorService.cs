using Calculator.Calculator;
using Calculator.Enums;
using Calculator.Models;

namespace Calculator.CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        public decimal CalculatorProcess(CalculatorModel calculatorModel)
        {
            decimal response = 0;

            var process = GetProcessTypes(calculatorModel.Process);

            switch (process)
            {
                case CalculatorProcessEnum.Toplam:
                    
                    calculatorModel.Amount = calculatorModel.FirstValue + calculatorModel.SecondValue;
                    response = calculatorModel.Amount;
                    break;

                case CalculatorProcessEnum.Çıkarma:
                    calculatorModel.Amount = calculatorModel.FirstValue - calculatorModel.SecondValue;
                    response = calculatorModel.Amount;
                    break;

                case CalculatorProcessEnum.Bölme:
                    calculatorModel.Amount = calculatorModel.FirstValue / calculatorModel.SecondValue;
                    response = calculatorModel.Amount;
                    break;

                case CalculatorProcessEnum.Çarpma:
                    calculatorModel.Amount = calculatorModel.FirstValue * calculatorModel.SecondValue;
                    response = calculatorModel.Amount;
                    break;

                default:
                    break;
            }
            return response;
        }

        private CalculatorProcessEnum GetProcessTypes(string currentStatus)
        {
            var state = new CalculatorProcessEnum();

            if (Enum.TryParse<CalculatorProcessEnum>(currentStatus, true, out var result))
            {
                state = result;
            }
            return state;
        }
    }
   
}
