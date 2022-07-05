namespace Homework_Seminar4
{
    class Task29 // Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от -15 до 15) и выводит на экран массив квадратов этих чисел.
    {
        public static int[] RandomArray(int[] array) // Метод заполняет массив случайными значениями [от-15 до 15]
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-15, 16);
            }
            return array;
        }
        public static int[] SquareArray(int[] array) // Метод возводит в квадрат каждое число массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i]; //Convert.ToInt32(Math.Pow(array[i], 2));                
            }
            return array;
        }
        public static void PrintArray(int[] array) // Метод выводит в консоль все значения массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }
        public static void Main(string[] args) // Метод задаёт случайный массив случайного размера [от 5 до 10] со значениями [от -15 до 15] и выводит его в консоль, затем выводит квадраты чисел этого массива
        {
            Console.Clear();
            int[] array = new int[new Random().Next(5, 11)];
            RandomArray(array);
            Console.Write("Random array:  ");
            PrintArray(array);
            SquareArray(array);
            Console.WriteLine();
            Console.Write("Squares array: ");
            PrintArray(array);
        }
    }
}
