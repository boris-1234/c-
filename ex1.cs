using System;

namespace class_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

         

            //קליטת מספר ראשון
            Console.WriteLine("enter please the Array Length :");
            // length of array :
            int lengthofArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number to multiply :");
            // number to multiply each cell in the array :
            int numToMul = Convert.ToInt32(Console.ReadLine());

            // initialize array :

            int[] arr = new int[lengthofArray];

            Console.WriteLine($"Num of elements  : {lengthofArray} \n,number to multiply : {numToMul}\n");
            for (int i=0; i<arr.Length;i++)
            {
                arr[i] = i * numToMul;
                Console.Write(arr[i] + ",");
            }

        }
    }
}
