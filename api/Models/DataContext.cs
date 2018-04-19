using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        // modelBuilder.Entity<Cliente>().HasIndex(c => c.PessoaId).IsUnique(true);
        // modelBuilder.Entity<Empregado>().HasIndex(e => e.PessoaId).IsUnique(true);
        // modelBuilder.Entity<Gerente>().HasIndex(m => m.PessoaId).IsUnique(true);

        // Solução OnDelete
        //modelBuilder.Entity<ProdutoEtiqueta>()
        //    .HasOne(p => p.Produto)
        //    .WithMany(m => m.ProdutosEtiquetas)
        //    .OnDelete(DeleteBehavior.Restrict);

    }
  }

}
