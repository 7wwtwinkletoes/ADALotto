using System;
using System.Collections.Generic;

namespace Cardano.Domain.Models
{
    public partial class WithdrawalReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public long Amount { get; set; }

        public long TxId { get; set; }

        #endregion

    }
}
