using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //Receiving inputs for number of elements in list
        Console.WriteLine("Enter number of array elements");
        try
            {
                //int inputNum = Convert.ToInt32(Console.ReadLine());
                int inputNum;
                string newInput = Console.ReadLine();
                //inputNum = Convert.ToInt32(inputNum);
                bool isParsable = Int32.TryParse(newInput, out inputNum);
                if (isParsable){
                    Console.WriteLine(inputNum);
                }
                else{
                    Console.WriteLine("Could not be parsed.");
                }
                
                /*if (!int.TryParse(newInput, out inputNum))
                {
                    
                    Console.WriteLine("Bad input from Console.ReadLine(): {0}", newInput);
                            
                        
                    
                }
                */
                
                List<int> add_list = new List<int>();

                Console.WriteLine("Enter each value");
                int num = inputNum;
                for (int i = 0; i < num; i++)
                {
                    int value = 0;
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    //int value = Convert.ToInt32(Console.ReadLine());
                    add_list.Add(value);
                }
                int[] addList = add_list.ToArray();
                //Receiving inputs for the weight
                List<int> add_weight = new List<int>();
                Console.WriteLine("Enter each weight");
                for (int i = 0; i < inputNum; i++)
                {
                    int value = 0;
                    try
                    {
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    add_weight.Add(value);
                }
                int[] addWeight = add_weight.ToArray();
                double sum = 0.00, denominator = 0.00;
                for (int i = 0; i < inputNum; i++)
                {

                    sum += addList[i] * addWeight[i];
                }
                for (int i = 0; i < inputNum; i++)
                {

                    denominator += addWeight[i];
                }
                double weighted_mean = sum / denominator;
                Console.WriteLine("weighted mean");
                
                Console.WriteLine(weighted_mean.ToString("0.0"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.ReadKey();
        
        
        
        
        
    }
}