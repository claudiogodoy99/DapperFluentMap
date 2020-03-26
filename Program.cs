using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Dapper;
using Dapper.FluentMap;
using Dapper.FluentMap.Mapping;
using TestandoDapper.Entidades;
using TestandoDapper.Maps;

namespace TestandoDapper
{
    class Program
    {
        public static  SqlConnection con;

        static Program()
        {
            con = new SqlConnection("Data Source = LAPTOP-5HMS9AV4\\SQLEXPRESS; Initial Catalog = TesteDapper; Integrated Security= true");
        }



        static void Main(string[] args)
        {

            InitializeMapStrategic();

            Read();
        }

        static void InitializeMapStrategic() 
        {

            List<Type> listMapping = (from x in Assembly.GetExecutingAssembly().GetTypes()
                                      where x.IsClass && typeof(IMapping).IsAssignableFrom(x)
                                      select x).ToList();

            FluentMapper.Initialize(config =>
            {
                foreach (var map in listMapping)
                {
                    dynamic instanceMap = Activator.CreateInstance(map);
                    config.AddMap(instanceMap);
                }
            });
        }

      


        private static void Read()
        {

            var response = con.Query<
                ItemDb,
                VendaDb,
                ClienteDb,
                ItemVenda,
                ItemDb>(@"select * from Item inner join Venda 
                                            on Item.codigoCliente = Venda.Id 
                                            inner join 
                                            Cliente on Venda.codigoCliente = Cliente.id
											inner join ItemVenda 
											on ItemVenda.codigoVenda = Venda.id",
                map: (i, v, c,iv) =>
                {
                    
                    i.venda = v;   
                    v.cliente = c;
                    v.itemVenda = iv;
                    return i;
                }).ToList() ;

            Console.WriteLine($"response: {JsonSerializer.Serialize(response)}");
            Console.Read();
        }
      

    }

   

   
}
