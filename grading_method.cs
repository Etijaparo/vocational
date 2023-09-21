public static void grading2()
{
  Console.WriteLine("Enter the score you reached (max is 60): ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score > 60 || score < 0)
        {
            Console.WriteLine("Invalid score. Please enter a score between 0 and 60.");
        }
        else if (score <= 20)
        {
            Console.WriteLine("Your grade is 5.");
        }
        else
        {
            double grade = 1 + (60 - score) * 0.1;
            Console.WriteLine($"Your grade is {grade}.");
}
    
   
  public static void gradingWithLoop()
  {
    Console.WriteLine("Enter the score you reached (max is 60): ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score > 60 || score < 0)
        {
            Console.WriteLine("Invalid score. Please enter a score between 0 and 60.");
        }
        else if (score <= 20)
        {
            Console.WriteLine("Your grade is 5.");
        }
        else
        {
            double grade = 1;
            for (int i = score; i < 60; i++)
            {
                grade += 0.1;
            }
            Console.WriteLine($"Your grade is {grade}.");
  }
   
 
    
