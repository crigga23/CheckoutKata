namespace CheckoutKata
{
    public interface ICheckout
    {
        void Scan(SKU sku);
        int GetTotalPrice();
    }
}