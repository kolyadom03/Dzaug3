int size = 10;
int[] numbers = new int[size];
int sum = 0;
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
    if(array[i] % 2 == 0)
        sum++;
    {
        Console.Write(sum);
    }
}