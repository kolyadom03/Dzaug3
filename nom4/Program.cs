 
for (int i = 0; i < arr.GetLength(0); i++)
 
   for (int j = 0; j < arr.GetLength(1); j++)
    
        for (int k = 0; k < arr.GetLength(2); k++)
 
            arr[i, j, k] = random.Next(10, 99);
            int t = arr[i, j, k];
               int w = 0;
                if (w ==t)
                    break;
                if (w != t)
                t = w;
      
 
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.WriteLine("Page N: "+ (i + 1));
 
   for (int j = 0; j < arr.GetLength(1); j++)
       {
        for (int k = 0; k < arr.GetLength(2); k++)
            {
            Console.Write(arr[i, j, k] + " ");
            }
        Console.WriteLine();
       }
    Console.WriteLine("============================");
}
 
Console.ReadLine();