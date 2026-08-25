using Calculator.BaseEntity;

namespace Calculator.Models
{
    public class CalculatorModel : IBaseEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal FirstValue { get; set; } = 10;
        public decimal SecondValue { get; set; } = 20;
        public decimal Amount { get; set; }
        public string Process { get; set; } = "Toplam";
    }
}
