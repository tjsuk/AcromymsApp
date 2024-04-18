namespace Acromyms
{
    public class PaymentGateway
    {
        private IPaymentProvider paymentProvider;
        public PaymentGateway(IPaymentProvider paymentProvider)
        {
            this.paymentProvider = paymentProvider;
        }

        public void ProcessPayment(decimal amount)
        {
            paymentProvider.ProcessPayment(amount);
        }
    }

    public interface IPaymentProvider
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPalPaymentProvider : IPaymentProvider
    {
        public void ProcessPayment(decimal amount)
        {
            // Paypal logic payment processing.
        }
    }
}
