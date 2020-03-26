using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using TestandoDapper.Entidades;

namespace TestandoDapper.Maps
{
    public class itemvendaMap : EntityMap<ItemVenda>, IMapping
    {
        public itemvendaMap()
        {
            Map(i => i.codigoItem).ToColumn("id");
            Map(i => i.vendinha).ToColumn("codigoVenda");
        }
    }
}
