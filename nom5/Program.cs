

int n = 4;
int[,] nMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= nMatrix.GetLength(0) * nMatrix.GetLength(1))
{
  nMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < nMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= nMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > nMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(nMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}