﻿using System.Collections.Generic;

namespace CryptoArbitrageSharp.Exchanges.GDAX.Models
{
    public class OrderBook
    {
        public decimal Sequence { get; set; }

        public IEnumerable<IEnumerable<decimal>> Bids { get; set; }

        public IEnumerable<IEnumerable<decimal>> Asks { get; set; }
    }
}
