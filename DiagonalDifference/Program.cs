using System;
using System.IO;

class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr, int n)
    {
        int primaryD = 0;
        int secondaryD = 0;
        int avarage = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                //Condition first diagonal
                if (i == j)
                {
                    primaryD += arr[i][j];
                }

                //Condition second diagonal

                if ((i + j) == (n - 1))
                {
                    secondaryD += arr[i][j];
                }
            }

        }

        //This function gives the absolute avarage of the equation, it means, it will always be postive.
        avarage = Math.Abs(secondaryD - primaryD);

        Console.WriteLine(primaryD);
        Console.WriteLine(secondaryD);

        return avarage;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = 9;* /*Convert.ToInt32(Console.ReadLine());*/
        int n = Convert.ToInt32(Console.ReadLine());


        int[][] arr = new int[n][];

        //arr[0] = new int[9] { 6, 6, 7, -10, 9, -3, 8, 9, -1 };
        //arr[1] = new int[9] { 9, 7, -10, 6, 4, 1, 6, 1, 1, };
        //arr[2] = new int[9] { -1, -2, 4, -6, 1, -4, -6, 3, 9 };
        //arr[3] = new int[9] { -8, 7, 6, -1, -6, -6, 6, -7, 2 };
        //arr[4] = new int[9] { -10, -4, 9, 1, -7, 8, -5, 3, -5 };
        //arr[5] = new int[9] { -8, -3, -4, 2, -3, 7, -5, 1, -5 };
        //arr[6] = new int[9] { -2, -7, -4, 8, 3, -1, 8, 2, 3 };
        //arr[7] = new int[9] { -3, 4, 6, -7, -7, -8, -3, 9, -6 };
        //arr[8] = new int[9] { -2, 0, 5, 4, 4, 4, -3, 3, 0 };

        //Coment this for loop for manual test
        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int avarage = diagonalDifference(arr, n);

        Console.WriteLine(avarage);

        Console.ReadLine();

        //textWriter.WriteLine(avarage);

        // textWriter.Flush();
        //textWriter.Close();
    }
}
