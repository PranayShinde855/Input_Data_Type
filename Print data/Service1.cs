using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_data
{
    public class Service1 : Generic<dynamic>
    {

        public Task<dynamic> GetString(dynamic value)
        {
            Console.WriteLine(value);
            return value;
        }
    }
}
