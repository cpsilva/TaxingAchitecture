namespace Tax.ViewModels
{
    public class EmployeeViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public double Imposto { get; set; }
    }
}