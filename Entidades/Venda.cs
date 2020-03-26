

using System.ComponentModel.DataAnnotations.Schema;

namespace TestandoDapper.Entidades
{
    [Table("Venda")]
    public class VendaDb
    {
        [Column("Id")]
        public int codigo { get; set; }
        [Column("codigoCliente")]
        public virtual int codigoCliente { get; set; }
        public ClienteDb cliente { get; set; }
        public ItemVenda itemVenda { get; set; }
    }
}
