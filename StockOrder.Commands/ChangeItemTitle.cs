namespace StockOrder.Commands
{
    using System;

    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    using StockOrder.Domain;

    [MapsToAggregateRootMethod(typeof(StockItem), "ChangeTitle")]
    public class ChangeItemTitle : CommandBase
    {
        [AggregateRootId]
        public Guid ItemId
        {
            get;
            set;
        }

        public string NewTitle
        {
            get;
            set;
        }
    }
}
