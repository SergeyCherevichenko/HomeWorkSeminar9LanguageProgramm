namespace HomeWorkSeminar9LanguageProgram;
class MyLib
{
    public static int Input(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static void Recursion64(int numberM, int numberN)
    {
        if (numberM > numberN) return;

        if (numberM % 3 == 0)
        {
            Console.Write(numberM + ", ");
        }
        numberM++;
        Recursion64(numberM, numberN);

    }

    public static void Recursion66(int numberM, int numberN, int sum)
    {
        if (numberN < numberM)
        {
            Console.Write(sum);
            return;
        }
        sum += numberM;
        numberM++;
        Recursion66(numberM, numberN, sum);
    }



    // функция Аккермана
    public static int Recursion68(int numberM, int numberN)
    {
        if (numberM == 0)
        {
            return numberN + 1;
        }
        else if (numberN == 0 && numberM > 0)
        {
            return Recursion68(numberM - 1, 1);
        }
        else if(numberM>0&&numberN>0)
        {
            return Recursion68(numberM - 1, Recursion68(numberM, numberN - 1));
        }
        else return 0;
        
    }

}