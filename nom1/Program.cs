Console.Write("Введите 2 числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int res = 1;
for(int i = 1; i <= numberB; ++i)
    res = res  * numberA;
        Console.WriteLine(res);