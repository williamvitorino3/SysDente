dados = "Agenda Convenio Dentista Endereco Exame Funcionario PacienteConvenio Cidade Empresa Estado Fornecedor HistoricoPaciente Paciente"

with open("DataContext.cs", "w+") as target:
  target.writelines(
    """
using Microsoft.EntityFrameworkCore;
namespace SysDente.Models
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
    : base(options) {}
    public DataContext()
    {}
    """
  )
  for entity in dados.split():
        target.write("public DbSet<{0}> {0}s".format(entity) + "{ get; set; }\n")
  target.writelines(
    """
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      
      optionsBuilder.UseSqlServer("");
    }
  }
} 
    """
  )