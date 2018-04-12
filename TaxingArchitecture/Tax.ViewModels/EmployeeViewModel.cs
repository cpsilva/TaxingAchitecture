namespace Tax.ViewModels
{
    public class EmployeeViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioLiquido { get; set; }
        public decimal Imposto { get; set; }
    }
}