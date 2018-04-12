namespace WebApiVendas.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}