using System;

class Tasks
{
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
            
        }
    }

    class InvalidFormatException : ApplicationException
    {
        public InvalidFormatException(string message) : base(message)
        {
            
        }
    }
    
    public static void Main()
    {
        
           Console.Write("Enter the count of students : ");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count <= 0)
            {
                Console.WriteLine("Student count must be greater than zero.");
                return;
            }

            int [] marks = new int[count];
            for(int i =0; i<count; i++)
            {
                while(true)
                {
                    try
                    {
                        Console.Write($"Enter the students of {i+1} : ");
                        int score = Convert.ToInt32(Console.ReadLine());

                        if(score <0 || score >100)
                        {
                            throw new InvalidMarksException("Marks must be between 0 to 100");
                        }
                        marks[i] = score;
                        break;
                        
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Enter numbers only");
                    }
                    catch(InvalidMarksException ex)
                    {
                        Console.WriteLine($"Error : {ex.Message}");
                    }
                    finally
                    {
                        Console.WriteLine("Marks are updated");
                    }
                }  
                  
            }

            foreach(int m in marks)
        {
            Console.Write(m +" ");
        }

            int total = marks.Sum();
            double average = (double)total/count;
            Console.WriteLine("Total Marks : " +total);
            Console.WriteLine("Average : "+average);


            
    }
    

        
}