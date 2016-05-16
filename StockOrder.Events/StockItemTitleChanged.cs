namespace StockOrder.Events
{
    using System;
    using Ncqrs.Eventing.Sourcing;
    [Serializable]
    public class StockItemTitleChanged : SourcedEvent
    {
        public string NewTitle
        {
            get; set;
        }
    }
}
