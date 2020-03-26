

using Dapper.FluentMap.Mapping;
using TestandoDapper.Entidades;

namespace TestandoDapper.Maps
{
    public class vendaMap : EntityMap<VendaDb>, IMapping
    {
        public vendaMap()
        {
            Map(i => i.codigo).ToColumn("id");
            Map(i => i.codigoCliente).ToColumn("codigoCliente");

            Map(i => i.cliente).Ignore();
            Map(i => i.itemVenda).Ignore();
        }
    }
}
