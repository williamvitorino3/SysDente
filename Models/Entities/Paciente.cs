using System.Collections.Generic;

namespace SysDente.Entities
{
    public class Paciente : IEntity
    {
        public Paciente()
        {
            HistoricoPacientes = new HashSet<HistoricoPaciente>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<HistoricoPaciente> HistoricoPacientes { get; set; }
    }
}