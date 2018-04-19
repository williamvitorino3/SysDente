namespace SysDente.Entities
{
    public class PacienteConvenio
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
    }
}