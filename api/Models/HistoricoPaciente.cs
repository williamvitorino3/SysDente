namespace SysDente.Models
{
    public class HistoricoPaciente
    {
        public int Id { get; set; }
        public string Servico { get; set; }
        public double Pagamento { get; set; }
        public string Descricao { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}