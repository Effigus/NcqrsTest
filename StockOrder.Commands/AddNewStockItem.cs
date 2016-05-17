namespace StockOrder.Commands
{
    using System;
    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    using StockOrder.Domain;

    [MapsToAggregateRootConstructor(typeof(StockItem))]
    public class AddNewStockItem : CommandBase
    {
        public AddNewStockItem()
        {
        }

        public AddNewStockItem(Guid itemId, string itemName)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
        }

        [AggregateRootId]
        public Guid ItemId
        {
            get;
            set;
        }

        public string ItemName
        {
            get;
            set;
        }
    }
}
