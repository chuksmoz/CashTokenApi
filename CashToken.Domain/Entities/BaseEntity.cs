using System;
using System.Collections.Generic;
using System.Text;

namespace CashToken.Domain.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the added date.
        /// </summary>
        /// <value>The added date.</value>
        public DateTime AddedDate { get; set; }
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>The modified date.</value>
        public DateTime ModifiedDate { get; set; }
    }
}
