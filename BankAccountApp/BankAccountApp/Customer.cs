using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Customer
    {
        public string CustomerName { set; get; }
        public string CustomerEmail { set; get; }
        public Account CustomerAccount { set; get; }
    }
}
