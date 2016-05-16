namespace StockOrder.Events
{
    using System;
    using Ncqrs.Eventing.Sourcing;
    [Serializable]
    public class NewStockItemAdded : SourcedEvent
    {
        public Guid ItemId
        {
            get; set;
        }

        public string ItemTitle
        {
            get; set;
        }

        public DateTime CreatedOn
        {
            get; set;
        }
    }
}
