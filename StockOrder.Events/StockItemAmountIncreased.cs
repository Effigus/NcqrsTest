﻿namespace StockOrder.Events
{
    using System;
    using Ncqrs.Eventing.Sourcing;
    [Serializable]
    public class StockItemAmountIncreased : SourcedEvent
    {
        public int AddedAmount
        {
            get; set;
        }
    }
}
