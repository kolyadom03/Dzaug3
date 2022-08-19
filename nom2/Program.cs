Console.WriteLine("Введите число");
string number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    string temp = Convert.ToString(number[i]);
    sum += Convert.ToInt32(temp);
}
Console.WriteLine(sum);


