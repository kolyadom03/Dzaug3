Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
if (0>N)
for (int i = N; i <= 0; i++)
    Console.Write(i);
else
    for (int i = 0; i <= N; i++)
        Console.Write(i);