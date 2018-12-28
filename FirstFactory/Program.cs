using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'zombieCluster' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY zombies as parameter.
     */

    public static int zombieCluster(List<string> zombies)
    {

        int zombieCount = Convert.ToInt32(zombies.FirstOrDefault().Length);

        int[,] zombieMatrix = new int[zombieCount, zombieCount];

        for (int i = 0; i < zombieCount; i++)
        {
            for (int j = 0; j < zombieCount; j++)
            {
                //zombieMatrix[i, j] = Convert.ToInt32(zombies[i+1][j] + "");
                zombieMatrix[i, j] = Convert.ToInt32(zombies[i][j] + "");

            }
        }

        bool[] zombieAccounted = new bool[zombieCount];

        bool[] zombieNotAccounted = new bool[zombieCount];

        int count = 0;

        for (int i = 0; i < zombieCount; i++)
        {
            if (!zombieAccounted[i])
            {
                zombieAccounted[i] = true;
                ZombiesProccesed(zombieMatrix, zombieCount, zombieAccounted, zombieNotAccounted, i);
            }
        }
        return count;
    }

    static void ZombiesProccesed(int[,] zombieMatrix, int zombieCount1, bool[] visited, bool[] visiting, int s)
    {
        if (!visited[s])
        {
            visiting[s] = true;

            for (int j = s + 1; j < zombieCount1; j++)
            {
                if (zombieMatrix[s, j] == 1 && !visited[j])
                {
                    visiting[j] = true;
                    ZombiesProccesed(zombieMatrix, zombieCount1, visited, visiting, j);
                    visited[j] = true;
                }
            }
        }
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int zombiesCount = Convert.ToInt32(Console.ReadLine().Trim());
        int zombiesCount = Convert.ToInt32(4);

        List<string> zombies = new List<string>();

        for (int i = 0; i < zombiesCount; i++)
        {
            string zombiesItem = Console.ReadLine();
            zombies.Add(zombiesItem);
        }

        int count = Result.zombieCluster(zombies);

        // textWriter.WriteLine(result); 
        Console.WriteLine(count);

        Console.ReadLine();


        // textWriter.Flush();
        //textWriter.Close();
    }
}