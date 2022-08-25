int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int Max = numbers[0];
int Min = numbers[0];
for(int i = 1; i < size; i++)
{
    if(Max < numbers[i])
        Max = numbers[i];
    if(Min > numbers[i])
        Min = numbers[i];
}
Console.Write(Max + Min); 