namespace SelfHostedWCF.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public decimal PercentualPresenca { get; set; }
    }
}
