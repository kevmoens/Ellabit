namespace Ellabit.Pages.Models
{
    public class TestDisplayResult
    {
        public int Number { get; set; }
        public bool Passed { get; set; }
        public string ExpectedValue { get; set; }
        public string ActualValue { get; set; }
        public string Message { get; set; }
    }
}
