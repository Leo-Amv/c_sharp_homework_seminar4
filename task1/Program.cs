namespace Homework_Seminar4
{
    class Task25 //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    {
        public static double Exponentiation(int a, uint b) // Метод возведения в степень
        {
            double s = Math.Pow(a, b);
            return s;
        }
        public static void Main(string[] args)
        {
            try
            {
                int A;
                uint B; // uint так как возводим в натуральную степень, а отрицательное число не может быть натуральным
                for (Console.Clear();;Console.WriteLine("Enter number A"), A = Convert.ToInt32(Console.ReadLine()), Console.WriteLine("Enter number B"), B = Convert.ToUInt32(Console.ReadLine()), Console.WriteLine("Result = " + Exponentiation(A, B)))
                {
                    Console.WriteLine();
                }                
            }
            catch
            {
                Console.WriteLine("Incorrect data try entering a positive number B or do not enter letters!");
            }
        }
    }
}
