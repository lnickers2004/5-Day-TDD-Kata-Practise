using System;

namespace Gaddzeit.Kata.Domain
{
    public class InvoiceItem
    {
        private readonly int _quantity;
        private readonly decimal _amount;

        public InvoiceItem(int quantity, decimal amount)
        {
            if(quantity.Equals(0) || amount.Equals(0M))
            {
                throw new NullOrZeroConstructorParameterException();
            }
            _quantity = quantity;
            _amount = amount;
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public decimal Amount
        {
            get { return _amount; }
        }
    }
}