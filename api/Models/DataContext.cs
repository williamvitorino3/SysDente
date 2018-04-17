
using System;
using Microsoft.EntityFrameworkCore;
namespace SysDente.Models
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
    : base(options) {}
    public DataContext()
    {}
    public DbSet<Agenda> Agendas{ get; set; }
    public DbSet<Convenio> Convenios{ get; set; }
    public DbSet<Dentista> Dentistas{ get; set; }
    public DbSet<Endereco> Enderecos{ get; set; }
    public DbSet<Exame> Exames{ get; set; }
    public DbSet<Funcionario> Funcionarios{ get; set; }
    public DbSet<PacienteConvenio> PacienteConvenios{ get; set; }
    public DbSet<Cidade> Cidades{ get; set; }
    public DbSet<Empresa> Empresas{ get; set; }
    public DbSet<Estado> Estados{ get; set; }
    public DbSet<Fornecedor> Fornecedores{ get; set; }
    public DbSet<HistoricoPaciente> HistoricoPacientes{ get; set; }
    public DbSet<Paciente> Pacientes{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      
      optionsBuilder.UseSqlServer("");
    }
  }
} 
    