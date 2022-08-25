int size = 3;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] array)
{
    for(int i = 1; i < array.Length; i+=2)
 {
    sum += array[i];
 }    
    
         Console.Write(sum);

}
