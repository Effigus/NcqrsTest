namespace StockOrder.Events
{
    using System;
    using Ncqrs.Eventing.Sourcing;
    [Serializable]
    public class StockItemDeactivated : SourcedEvent
    {
    }
}
