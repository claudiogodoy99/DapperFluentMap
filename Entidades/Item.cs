
using System.ComponentModel.DataAnnotations.Schema;

namespace TestandoDapper.Entidades
{
    [Table("Item")]
    public class ItemDb
    {
        [Column("Id")]
        public int codigoItem { get; set; }
        [Column("Venda")]
        public int codigoVenda { get; set; }
        public VendaDb venda{ get; set; }


    }
}
