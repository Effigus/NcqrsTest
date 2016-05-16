namespace StockOrder.Events
{
    using System;
    using Ncqrs.Eventing.Sourcing;

    [Serializable]
    public class StockItemAmountDecreased : SourcedEvent
    {
        public int SubstractedAmount
        {
            get; set;
        }
    }
}
