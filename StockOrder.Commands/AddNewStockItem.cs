namespace StockOrder.Commands
{
    using System;
    using Ncqrs.Commanding;
    using Ncqrs.Commanding.CommandExecution.Mapping.Attributes;

    [MapsToAggregateRootConstructor("StockOrder.Domain.StockItem, StockOrder.Domain")]
    public class AddNewStockItem : CommandBase
    {
        [AggregateRootId]
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }

        public AddNewStockItem()
        {
        }

        public AddNewStockItem(Guid itemId, string itemName)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
        }
    }
}
