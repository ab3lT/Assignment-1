using System;

namespace assignment_one
{
   class LargersIntiger{
       public static void largint(){
                try{
                int n, i, j = 0, largest, secondLargest;
            int[] arr1 = new int[50];
 
            Console.Write("\nFind the second largest element in an array :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            largest = 0;
 
            for (i = 0; i < n; i++)
            {
                if (largest < arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }
            
            secondLargest = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (secondLargest < arr1[i])
                    {
                        secondLargest = arr1[i];
                    }
                }
            }
 
            Console.Write(">>> The Second largest element in the array is :  {0} \n\n", secondLargest +" <<<");
            }
        
        catch{Console.WriteLine("invalid input please try again");
        largint();
        }
   }

   }}