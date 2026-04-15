namespace CalculatorApp.Models
{
    public class CalculatorViewModel
    {
        public string FirstValue { get; set; } = "";
        public string SecondValue { get; set; } = "";
        public string PendingOperation { get; set; } = "";
        public decimal Result { get; set; } = 0;
        public string Display { get; set; } = "0";
    }
} 