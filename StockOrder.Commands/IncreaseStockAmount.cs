namespace StockOrder.Commands
{
    using System;

    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    using StockOrder.Domain;

    [MapsToAggregateRootMethod(typeof(StockItem), "IncreaseStockAmount")]
    public class IncreaseStockAmount : CommandBase
    {
        [AggregateRootId]
        public Guid ItemId
        {
            get;
            set;
        }

        public int AddedQuantity
        {
            get;
            set;
        }
    }
}
