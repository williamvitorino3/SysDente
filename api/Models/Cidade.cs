using System.Collections.Generic;

namespace SysDente.Models
{
    public class Cidade
    {
        public Cidade()
        {
            Enderecos = new HashSet<Endereco>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}