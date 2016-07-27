using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    /// <summary>
    /// This class defines Customer
    /// </summary>
  public  class Customer
    {
        #region Properties

        /// <summary>
        /// Customer Id
        /// </summary>
        [Key]
        public int Id{ get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }
        #endregion

    }
}
