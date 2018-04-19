namespace SysDente.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public int DentistaId { get; set; }
        public Dentista Dentista { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}