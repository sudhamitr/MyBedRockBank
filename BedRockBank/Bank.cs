using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    public static class Bank
    {
        #region Properties
        public static string Name { get; set; }
        #endregion
        #region Methods
        public static Customer CreateCutomer(string name, string emailAddress,string address)
        {
            var customer = new Customer { Name = name,Address=address,EmailAddress=emailAddress };
            return customer;
        }

        #endregion

    }
}
