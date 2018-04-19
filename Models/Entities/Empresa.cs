namespace SysDente.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}