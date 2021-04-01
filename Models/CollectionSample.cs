using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CollectionSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }
}
