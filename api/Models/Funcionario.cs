namespace SysDente.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public double Remuneracao { get; set; }
        public double Especialidade { get; set; }
        public string CPF { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
    }
}