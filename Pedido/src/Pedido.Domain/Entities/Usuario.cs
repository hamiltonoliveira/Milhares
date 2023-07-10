using Pedido.Domain.Enums;
using System.Text.Json.Serialization;

namespace Pedido.Domain.Entities
{
    public class Usuario : Base
    {
        public string? UserName { get; set; }

        [JsonIgnore]
        public string? Password { get; set; }

        public string? GuidI { get; set; } = Guid.NewGuid().ToString();

        public string? Email { get; set; }

        public TipoOperador TipoOperador { get; set; }
    }
}
