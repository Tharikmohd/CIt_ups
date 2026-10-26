using System;

class Ctppoly
{
    public static void Main()
    {
        Payment payment = new Payment();
        payment.Makepayment(45000);
        payment.Makepayment(34000, "txn0098");
        payment.Makepayment(54344, "CHq12345", "23/10/2026");
    }
}

class Payment
{
    public void Makepayment(double amount)
    {
        Console.WriteLine("Payment received by cash : " +amount);
    }

    public void Makepayment(double amount, string upiid)
    {
        Console.WriteLine("Payment Received by upi : " + amount);
        Console.WriteLine("UPI id  : " + upiid);
    }

    public void Makepayment(double amount, string chequnum, string date)
    {
        Console.WriteLine("Payment Received by cheques : " + amount);
        Console.WriteLine("Cheque number  : " + chequnum);
        Console.WriteLine("Date : " +date);
    }

}