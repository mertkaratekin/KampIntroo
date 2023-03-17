using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Sql Added");
            }

            public void Delete()
            {
                Console.WriteLine("Sql deleted");
            }

            public void Update()
            {
                Console.WriteLine("Sql updated");
            }
        }
    }

