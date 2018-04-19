namespace SysDente.Entities
{
    public class Exame
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
    }
}