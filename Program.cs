﻿using System;

namespace Home_work_week_3
{
    
        class Program
        {
            static void Main(string[] args)
            {
                string[][] EqualArray = new string[3][];
                EqualArray[0] = new string[] { "0", "0", "0" };
                EqualArray[1] = new string[] { "0", "0", "0" };
                EqualArray[2] = new string[] { "0", "0", "0" };
                for (int num_Of_Rows_matrix = 0; num_Of_Rows_matrix < EqualArray.Length; num_Of_Rows_matrix++)
                {
                    for (int num_Of_Columns_matrix = 0; num_Of_Columns_matrix < EqualArray[num_Of_Rows_matrix].Length; num_Of_Columns_matrix++)
                    {
                        if (num_Of_Rows_matrix == num_Of_Columns_matrix && (num_Of_Rows_matrix + num_Of_Columns_matrix != EqualArray[num_Of_Rows_matrix].Length - 1))
                        {
                            EqualArray[num_Of_Columns_matrix][num_Of_Columns_matrix] = "main    ";
                            Console.Write("the values that sits only on the main diagonal is : " + ($"{ EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix]}"));
                        }
                        else
                            if (num_Of_Rows_matrix == num_Of_Columns_matrix && (num_Of_Rows_matrix + num_Of_Columns_matrix == EqualArray[num_Of_Rows_matrix].Length - 1))
                        {
                            EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix] = "center ";
                            Console.Write("the value that sits on the main diagonal and the secondary diagonal is : " + ($"{ EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix]}"));
                        }
                        else
                            if (num_Of_Columns_matrix + num_Of_Rows_matrix == EqualArray[num_Of_Rows_matrix].Length - 1)
                        {
                            EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix] = "sub    ";
                            Console.Write("the values that sits only the main diagonal  is : " + ($"{ EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix]}"));
                        }
                        else
                            if (num_Of_Rows_matrix < num_Of_Columns_matrix && num_Of_Columns_matrix + num_Of_Rows_matrix != EqualArray[num_Of_Rows_matrix].Length - 1)
                        {
                            EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix] = "up ";
                            Console.Write("the values that sits above the main diagonal  is : " + ($"{ EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix]}"));
                        }

                        else
                        {
                            EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix] = "down  ";
                            Console.Write("the values that sits below the main diagonal  is : " + ($"{ EqualArray[num_Of_Rows_matrix][num_Of_Columns_matrix]}"));
                        }
                    }
                    Console.WriteLine();
                }


            }
        }
    }

    

