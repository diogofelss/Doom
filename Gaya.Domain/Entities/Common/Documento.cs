namespace Gaya.Domain.Entities.Common
{
    public class Documento
    {
        public string Numero { get; set; }
        public string Serie { get; set; }
        public bool Cancelado { get; set; }
        public Enums.DocumentEnum.EnStatusDocumento Status { get; set; }
    }
}
