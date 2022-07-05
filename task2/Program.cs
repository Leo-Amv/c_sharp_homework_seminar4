namespace Homework_Seminar4
{
    class Task27 // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    {
        public static int Sum(string a) // Метод преобразует из строкового значения (при вводе в консоли) числа в целое и находит сумму цифр этого числа 
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += int.Parse((a[i]).ToString());
            }
            return sum;
        }
        public static void Main(string[] args) // Метод требует ввести число в консоль, проверяя корректность введенных данных и выводит в консоль сумму цифр этого числа (результат метода Sum) 
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Enter number: ");
                string? str = (Console.ReadLine());
                if (str != null)
                {
                    Console.WriteLine("Result = " + Sum(str));
                }
            }
            catch
            {
                Console.WriteLine("Incorrect data! Try enter the positive number!");
            }            
        }
    }
}
