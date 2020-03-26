

using System.ComponentModel.DataAnnotations.Schema;

namespace TestandoDapper.Entidades
{
    [Table("Cliente")]
    public class ClienteDb
    {

        [Column("Id")]
        public int codigo { get; set; }
        [Column("Nome")]
        public string name { get; set; }
    }
}
