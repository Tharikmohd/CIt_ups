using System;

namespace DemoUps
{
    public delegate void Notification(string message);
    public delegate void Paymentmethod(double amount);
    public delegate void Orderprocess();

    class NotificationService
    {
        public  void SmsNotification(string message)
        {
            Console.WriteLine($"SMS : {message}");
        }

        public static void GenerateInvoice()
        {
            Console.WriteLine("Your invoice has generated and send to your mail.. Thank you");
        }

        public static void Orderstatus()
        {
            Console.WriteLine("Your order has been ready for shipment. It will arrive shortly");
        }

        public static void SendOrder()
        {
            Console.WriteLine("Your order in Transist it will reach within a day..");
        }

        public static void Deliveryconfirmation()
        {
            Console.WriteLine("Your order has been delivered to you. Thanks for choosing us.");
        }

        public  void EmailNotification(string message)
        {
            Console.WriteLine($"Email : {message}");
        }

        public void Call()
        {
            Notification notification;
            
            notification = SmsNotification;
            notification("Your order has been placed");
            Orderprocess orderprocess;
            orderprocess = GenerateInvoice;
            orderprocess += Orderstatus;
            orderprocess += SendOrder;
            orderprocess += Deliveryconfirmation;
            orderprocess();
            notification = EmailNotification;
            notification("Your order has out of delivery");
            
            
        }
    }

    class Paymentservice
    {
        public static void PayusingUPI(double amount)
        {
            Console.WriteLine($"Payment received by UPI : ₹ {amount}");
        }
        public static void Payusingcard(double amount)
        {
            Console.WriteLine($"Payment done by credit card : ₹ {amount}");
        }
        public static void COD(double amount)
        {
            Console.WriteLine($"Customer will pay at time of product deliver : ₹ {amount}");
        }


        public void Paymentcall()
        {
               Paymentmethod paymentmethod;
               paymentmethod = PayusingUPI;
               PayusingUPI(4500);
               paymentmethod += Payusingcard;
               Payusingcard(5600);
               paymentmethod += COD;
               COD(7800);

        }
    }

    class Totalpayment
    {
        public double grs;
        public double disc;
        public double totalamount;
        public  double Calculateamount(double amount, int quantity)
        {
            grs = amount * quantity;
            return grs;
        }

        public  double Discount(double total)
        {
            disc = total * 0.10;
            return disc;
        }

        public  void finalamount(double totalamount)
        {
             totalamount = grs - disc;
        }

        public bool Freedelivery(double amount)
        {

            return amount >= 5000;
        }

        public  void Functions()
        {
            
            Func<double, int, double> totalcalc = Calculateamount;
            Func<double, double> disctotal = Discount;
            double finlamount = Calculateamount(5600, 3);
            double discamount = Discount(4508);
            Console.WriteLine($"Total Amount : {finlamount}");
            Console.WriteLine($"Total Discount : {discamount}");
            Console.WriteLine($"After discount : {finlamount - discamount}");
            Predicate<double> predicate = new Predicate<double>(Freedelivery);
            Console.WriteLine(predicate(4000));
            
        }


    }



    

    class DelegateDemo
    {
        public static void Main()
        {
            NotificationService service = new NotificationService();
            Paymentservice paymentservice = new Paymentservice();
            Totalpayment totalpayment = new Totalpayment();
            service.Call();
            paymentservice.Paymentcall();
            totalpayment.Functions();
            Action<double> action = totalpayment.finalamount;

            
            
        }
    }
}