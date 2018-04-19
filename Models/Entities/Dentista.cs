using System.Collections.Generic;

namespace SysDente.Entities
{
    public class Dentista
    {
        public Dentista()
        {
            Agendas = new HashSet<Agenda>();
            Convenios = new HashSet<Convenio>();
            Exames = new HashSet<Exame>();
            Pacientes = new HashSet<Paciente>();
            Fornecedores = new HashSet<Fornecedor>();
            Funcionarios = new HashSet<Funcionario>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public double Remuneracao { get; set; }
        public double Especialidade { get; set; }
        public string CPF { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Agenda> Agendas { get; set; }
        public ICollection<Convenio> Convenios { get; set; }
        public ICollection<Exame> Exames { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}