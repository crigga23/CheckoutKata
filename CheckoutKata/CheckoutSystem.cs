using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    public enum SKU
    {
        A,
        B,
        C,
        D
    }

    public class CheckoutSystem : ICheckout
    {
        private int totalPrice;
        private List<Item> Items = new List<Item>();

        public void Scan(SKU sku)
        {
            Item item = AddItemToCheckout(sku);
            CalculateTotalPrice(item);
        }

        private void CalculateTotalPrice(Item item)
        {
            totalPrice += item.UnitPrice;

            if (item.DiscountRule < 1 && item.DiscountValue < 1)
            {
                return;
            }

            if (Items.Count%item.DiscountRule == 0)
            {
                totalPrice -= item.DiscountValue;
            }
        }

        private Item AddItemToCheckout(SKU sku)
        {
            Item item = new Item();

            switch (sku)
            {
                case SKU.A:
                    item.SKU = sku;
                    item.UnitPrice = 50;
                    item.DiscountRule = 3;
                    item.DiscountValue = 20;
                    break;
                case SKU.B:
                    item.SKU = sku;
                    item.UnitPrice = 30;
                    item.DiscountRule = 2;
                    item.DiscountValue = 15;
                    break;
                case SKU.C:
                    item.SKU = sku;
                    item.UnitPrice = 20;
                    item.DiscountRule = 0;
                    item.DiscountValue = 0;
                    break;
                case SKU.D:
                    item.SKU = sku;
                    item.UnitPrice = 15;
                    item.DiscountRule = 0;
                    item.DiscountValue = 0;
                    break;
            }

            Items.Add(item);
            return item;
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }
    }
}