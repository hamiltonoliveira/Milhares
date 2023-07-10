namespace Pedido.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        public Boolean Ativo { get; set; }
    }
}
