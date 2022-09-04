  int[,]x1 = new int[3, 3];
            int[,]x2 = new int[3, 3];
            int[,]x3 = new int[3, 3];
 
           x1[0,0] = 1;
           x1[0,1] = 1;
           x1[0,2] = 2;
 
           x1[1,0] = 5;
           x1[1,1] = 4;
           x1[1,2] = 3;
 
           x1[2,0] = 2;
           x1[2,1] = 4;
           x1[2,2] = 9;
 
 
           x2[0,0] = 1;
           x2[0,1] = 1;
           x2[0,2] = 5;
 
           x2[1,0] = 3;
           x2[1,1] = 6;
           x2[1,2] = 8;
 
           x2[2,0] = 5;
           x2[2,1] = 4;
           x2[2,2] = 6;
            int j;
            for (int i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                   x1[i, j] =x1[i, j] *x2[i, j];
                    Console.Write(x1[i, j]);
                    Console.WriteLine("\n");
                }
                j = 0;
            }
            Console.ReadKey();
        