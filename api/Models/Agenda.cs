namespace SysDente.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
    }
}