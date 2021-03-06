using System;
using System.Collections.Generic;

namespace Cardano.Data.Entities
{
    public partial class TxOut
    {
        public TxOut()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long TxId { get; set; }

        public short Index { get; set; }

        public string Address { get; set; }

        public long Value { get; set; }

        public Byte[] AddressRaw { get; set; }

        public Byte[] PaymentCred { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Tx Tx { get; set; }

        #endregion

    }
}
