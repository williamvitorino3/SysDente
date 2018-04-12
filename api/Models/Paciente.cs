using System.Collections.Generic;

namespace WebApiVendas.Models
{
    public class Produto
    {
        public Produto()
        {
            Enderecos = new HashSet<Endereco>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
        public int EnderecoId { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}