using System.Collections.Generic;

namespace SysDente.Models
{
    public class Endereco
    {
        public Endereco()
        {
            Convenios = new HashSet<Convenio>();
            Empresas = new HashSet<Empresa>();
            Dentistas = new HashSet<Dentista>();
            Pacientes = new HashSet<Paciente>();
            Funcionarios = new HashSet<Funcionario>();
        }
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public ICollection<Convenio> Convenios { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
        public ICollection<Dentista> Dentistas { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}