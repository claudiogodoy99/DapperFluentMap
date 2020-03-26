using Dapper.FluentMap.Mapping;
using TestandoDapper.Entidades;

namespace TestandoDapper.Maps
{
    public class ItemMap : EntityMap<ItemDb>, IMapping
    {        public ItemMap()
        {

            Map(i => i.codigoItem).ToColumn("id");
            Map(i => i.codigoVenda).ToColumn("codigoCliente");
            Map(i => i.venda).Ignore();

        }
    }
}
