using System.Collections.Generic;

namespace SysDente.Entities
{
    public class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
    }
}