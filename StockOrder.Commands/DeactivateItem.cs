namespace StockOrder.Commands
{
    using System;

    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    using StockOrder.Domain;

    [MapsToAggregateRootMethod(typeof(StockItem), "DeactivateItem")]
    public class DeactivateItem : CommandBase
    {
        [AggregateRootId]
        public Guid ItemId
        {
            get;
            set;
        }
    }
}
