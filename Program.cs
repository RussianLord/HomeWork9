void HW1()
{
    Console.Clear();
    Console.WriteLine("Данная программа выводит числа из введённого диапазона чисел кратные числу, которое вы укажете...");
    Console.WriteLine("Введите число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кратность");
    int step = Convert.ToInt32(Console.ReadLine());
    NumberDiff(numberN, numberM, step);
}

void NumberDiff(int numberN, int numberM, int step, int fill = 0)
{
    fill = numberN;
    if(fill >= numberM)
    {
        return;
    }
    if(fill % step == 0)
    {
        Console.WriteLine(fill);
    }
    numberN = numberN + step - 1;
    NumberDiff(numberN, numberM, step);
}

void HW2()
{
    Console.Clear();
    Console.WriteLine("Данная программа суммирует числа в заданном диапазоне...");
    Console.WriteLine("Введите число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    SumNumbers(numberN, numberM);
}

void SumNumbers(int numberN, int numberM, int sum = 0)
{
    if(numberN > numberM)
    {
        return;
    }
    sum = sum + numberN;
    Console.WriteLine($"{sum - numberN} + {numberN} = {sum}");
    numberN++;
    SumNumbers(numberN, numberM, sum);
}

void HW3()
{
    Console.Clear();
    Console.WriteLine("Данная программа рассчитывает число по функции Аккермана...");
    Console.WriteLine("Введите число M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Akkerman(numberM, numberN);
    PrintAkkerman(numberM, numberN);
}

int Akkerman(int numberM, int numberN)
{  
    if( numberM == 0)
    {
        return numberN + 1;
    }
    else if(numberN == 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else if(numberM > 0 && numberN > 0)
    { 
        return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)); 
    }
    return Akkerman(numberM, numberN);   
}

void PrintAkkerman(int numberM, int numberN)
{
    Console.WriteLine("Полученное число Аккермана");
    int A = Akkerman(numberM, numberN);
    Console.WriteLine($"Из введённых чисел M = {numberM} и N = {numberN}");
    Console.WriteLine("Получаем число А = " + A);
}

HW1();
// HW2();
// HW3();
