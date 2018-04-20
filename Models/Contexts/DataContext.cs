using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SysDente.Entities;

namespace SysDente.Contexts
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
      // Obtém as configurações especificadas em appsettings.json
      var config = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      // Define a base de dados a ser usada
      var cnn = config.GetConnectionString("ModelConnection");
      optionsBuilder.UseSqlite(cnn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relacionamento Many-to-Many (chaves compostas)
        // modelBuilder.Entity<ProdutoEtiqueta>()
        //     .HasKey(pt => new { ProductId = pt.ProdutoId, TagId = pt.EtiquetaId });

        // Chaves Únicas
        modelBuilder.Entity<Agenda>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<Cidade>().HasIndex(c => c.EstadoId).IsUnique(true);
        modelBuilder.Entity<Convenio>().HasIndex(c => c.EnderecoId).IsUnique(true);
        modelBuilder.Entity<Convenio>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<Dentista>().HasIndex(c => c.EnderecoId).IsUnique(true);
        modelBuilder.Entity<Empresa>().HasIndex(c => c.EnderecoId).IsUnique(true);
        modelBuilder.Entity<Exame>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<Fornecedor>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<Fornecedor>().HasIndex(c => c.EmpresaId).IsUnique(true);
        modelBuilder.Entity<Funcionario>().HasIndex(c => c.EnderecoId).IsUnique(true);
        modelBuilder.Entity<Funcionario>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<HistoricoPaciente>().HasIndex(c => c.PacienteId).IsUnique(true);
        modelBuilder.Entity<Paciente>().HasIndex(c => c.EnderecoId).IsUnique(true);
        modelBuilder.Entity<Paciente>().HasIndex(c => c.DentistaId).IsUnique(true);
        modelBuilder.Entity<PacienteConvenio>().HasIndex(c => c.PacienteId).IsUnique(true);
        modelBuilder.Entity<PacienteConvenio>().HasIndex(c => c.ConvenioId).IsUnique(true);


        // Solução OnDelete
        //modelBuilder.Entity<ProdutoEtiqueta>()
        //    .HasOne(p => p.Produto)
        //    .WithMany(m => m.ProdutosEtiquetas)
        //    .OnDelete(DeleteBehavior.Restrict);

    }
  }

}
