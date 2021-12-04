using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCard : Payment
    {
        public CreditCard(DateTime paidDate,
                          DateTime expireDate,
                          decimal total,
                          decimal totalPaid,
                          string payer,
                          Document document,
                          Address address,
                          Email email,
                          string cardHolderName,
                          string cardNumber,
                          string lastTransactionNumber) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}