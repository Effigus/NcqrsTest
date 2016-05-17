namespace StockOrder.Domain
{
    using System;
    using Events;
    using Ncqrs;
    using Ncqrs.Domain;

    public class StockItem : AggregateRootMappedByConvention
    {
        private string title;
        private bool isActive;
        private int stockAmount;
        private DateTime createdOn;

        public StockItem(Guid itemId, string itemName)
            : base(itemId)
        {
            var clock = NcqrsEnvironment.Get<IClock>();

            this.ApplyEvent(new NewStockItemAdded
                           {
                               ItemId = itemId,
                               CreatedOn = clock.UtcNow(),
                               ItemTitle = itemName
                           });
        }

        public void ChangeTitle(string newTitle)
        {
            this.ApplyEvent(new StockItemTitleChanged
                           {
                               NewTitle = newTitle
                           });
        }

        public void DeactivateItem()
        {
            this.ApplyEvent(new StockItemDeactivated());
        }

        public void IncreaseStockAmount(int addedQuantity)
        {
            this.ApplyEvent(new StockItemAmountIncreased
                           {
                               AddedAmount = addedQuantity
                           });
        }

        public void DecreaseStockAmount(int substractedQuantity)
        {
            this.ApplyEvent(new StockItemAmountDecreased
            {
                SubstractedAmount = substractedQuantity
            });
        }

        protected void OnNewStockItemAdded(NewStockItemAdded e)
        {
            this.isActive = true;
            this.title = e.ItemTitle;
            this.createdOn = e.CreatedOn;
            this.stockAmount = 0;
        }

        protected void OnStockItemTitleChanged(StockItemTitleChanged e)
        {
            if (this.isActive)
            {
                this.title = e.NewTitle;
            }
        }

        protected void OnStockItemDeactivated(StockItemDeactivated e)
        {
            this.isActive = false;
            this.stockAmount = 0;
        }

        protected void OnStockItemAmountIncreased(StockItemAmountIncreased e)
        {
            if (this.isActive)
            {
                this.stockAmount += e.AddedAmount;
            }
        }

        protected void OnStockItemAmountIncreased(StockItemAmountDecreased e)
        {
            if (this.isActive)
            {
                this.stockAmount += e.SubstractedAmount;
            }
        }
    }
}
