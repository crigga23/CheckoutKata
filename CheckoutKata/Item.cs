namespace CheckoutKata
{
    public class Item
    {
        public SKU SKU { get; set; }
        public int UnitPrice { get; set; }
        public int DiscountRule { get; set; }
        public int DiscountValue { get; set; }
    }
}