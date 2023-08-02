namespace HomeWorkSeminar9LanguageProgram;
class Program
{
    static void Main(string[] args)
    {
        void task64()
        {
            // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём
            // в промежутке от M до N.
            // M = 1; N = 9. -> "3, 6, 9"  M = 13; N = 20. -> "15, 18"

            int numberM = MyLib.Input("Введите число M: ");
            int numberN = MyLib.Input("Введите число N: ");
            Console.Write($"Натуральные числа кратные 3 в диапозоне от {numberM} до {numberN} - ");
            MyLib.Recursion64(numberM, numberN);
        }

        void task66()
        {
            // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов
            // в промежутке от M до N.
            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30

            int numberM = MyLib.Input("Введите число M: ");
            int numberN = MyLib.Input("Введите число N: ");
            Console.Write($"Сумма всех натуральных чисел от {numberM} до {numberN} = ");
            MyLib.Recursion66(numberM, numberN, 0);

        }

        void task68()
        {
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 3, n = 2 -> A(m,n) = 29

            int numberM = MyLib.Input("Введите число не отрицательное число M: ");
            int numberN = MyLib.Input("Введите не отрицательное число N: ");
            int functionAkkerman = MyLib.Recursion68(numberM, numberN);
            if(functionAkkerman == 0) Console.WriteLine("Функция Аккермана не работает для отрицательных чисел!");
            else Console.WriteLine($"Функция Аккермана для чисеел ({numberM}, {numberN}) = {functionAkkerman}");
            
            

        }

        Console.WriteLine("Введите номер задачи 64, 66 или 68: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch(task)
        {
            case 64:task64();break;
            case 66:task66();break;
            case 68:task68();break;
            default:Console.WriteLine("Задачи с таким номером не существует!");break;
        }
        
        
    }
}
