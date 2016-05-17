namespace StockOrder.Commands
{
    using System;

    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    using StockOrder.Domain;

    [MapsToAggregateRootMethod(typeof(StockItem), "DecreaseStockAmount")]
    public class DecreaseStockAmount : CommandBase
    {
        [AggregateRootId]
        public Guid ItemId
        {
            get;
            set;
        }

        public int SubstractedQuantity
        {
            get;
            set;
        }
    }
}
