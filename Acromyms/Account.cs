namespace Acromyms;

public class Account
{
    public decimal Balance { get; set; }
    public decimal InterestRate { get; set; }

    public decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}
