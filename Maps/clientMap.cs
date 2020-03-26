
using Dapper.FluentMap.Mapping;
using System.Linq;
using TestandoDapper.Entidades;

namespace TestandoDapper.Maps
{
    public class clienteMap : EntityMap<ClienteDb>, IMapping
    {
        public clienteMap()
        {
            Map(i => i.codigo).ToColumn("Id");
            Map(i => i.name).ToColumn("Nome");000000
        }
    }
}
