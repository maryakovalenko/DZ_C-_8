//Знакомство с языками программирования домашняя работа к уроку 8. Как не нужно писать код.  
Console.WriteLine("Задача № 62");
Console.WriteLine("-------------------------------");
int n = Int32.Parse(Console.ReadLine());
            int[,] matr = new int[n, n];
 
            Console.WriteLine();
 
            int i, j;
                        
            for (j = 0, i = 0; j < n; j++)
                matr[i, j] = 1;
 
            for (i = 0, j = n - 1; i < n; i++)
                matr[i, j] = 1;
 
            for (j = n-1, i = n-1; j >=0; j--)
                matr[i, j] = 1;
 
            int count = 3;
            int c = 0;
 
            i= n - 1;
            j= 0;
 
            for (int x = n - 3; x > 0; x -= 2)
            {
                if (n % 2 == 0 & x == 1)
                    c = 1;
                else
                    c = 0;
 
                while (c < 2)
                {
                    switch (count)
                    {
                        case 1: //Down
                            for (int t = 0; t < x; t++)
                            {
                                i++;
                               matr[i, j] = 1;
 
                            }
 
                            count++;
                            break;
                        case 2: //Left
                            for (int t = 0; t < x; t++)
                            {
                                j--;
                                matr[i, j] = 1;
                            }
 
                            count++;
                            break;
                        case 3: //Up
                            for (int t = 0; t < x; t++)
                            {
                                i--;
                                matr[i, j] = 1;
                            }
 
                            count++;
                            break;
                        case 4: //Right
                            for (int t = 0; t < x; t++)
                            {
                                j++;
                                matr[i, j] = 1;
                            }
 
                            count = 1;
                            break;
                    }
 
 
                    c++;
                }
            }
 
            for (int ii = 0; ii < n; ii++)
            {
                for (int jj = 0; jj < n; jj++)
                    Console.Write(matr[ii, jj]);
                Console.WriteLine();
            }
 
