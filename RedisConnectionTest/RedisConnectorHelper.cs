using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisConnectionTest
{
    public class RedisConnectorHelper
    {
        // statyczna właściwość, aby nie tworzyć instancji za każdym razem 
        static RedisConnectorHelper()
        {
            RedisConnectorHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                // do połączenia z instancją Redis korzystamy z ConnectionMultiplekser.Connect
                return ConnectionMultiplexer.Connect("localhost");
            });
        }
        private static Lazy<ConnectionMultiplexer> lazyConnection;


        // połączenie z Redis jest obsłużone przez ConnectionMultiplekser
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}
