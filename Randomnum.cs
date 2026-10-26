using System;

class Randomnum
{
    public static void Main()
    {
        Random rand = new Random();

        int secret = rand.Next(1,100);
        


        int guess =0;
        int attempt =0;

        string  coupon = "abcdefghijklmnopqrstuvwxyz1234567890" ;

        Console.WriteLine("Guess the number from 1 to 100 and win the prize");
        

        while(guess != secret)
        {
            Console.Write("Your guess number : ");
            guess = Convert.ToInt32(Console.ReadLine());

            if(guess< secret)
            {
                Console.WriteLine("Too Low");
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too High");
            }

            attempt ++;
            
        }

        string generatecoupon = "";
        for(int i=0; i<6; i++)
        {
            int index = rand.Next(coupon.Length);
            generatecoupon += coupon[index];
        }

        Console.WriteLine($"You won at attempt {attempt}");
        Console.WriteLine($"Your coupon number : {generatecoupon}");

        
            
    
    }
}

