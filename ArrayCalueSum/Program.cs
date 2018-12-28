//using System;
//using System.IO;

//class Solution
//{

//    /*
//     * Complete the simpleArraySum function below.
//     */
//    static int simpleArraySum(int[] ar, int arCount)
//    {
        
//        int result = 0;

//        for (int i = 0; i < ar.Length; i++)
//        {
//            result += ar[i];
//        }

//        return result;
//}


//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int arCount = Convert.ToInt32(Console.ReadLine());

//        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//        ;
//        int result = simpleArraySum(ar, arCount);

//        Console.WriteLine(result);

//        Console.ReadLine();


//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}