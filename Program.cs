using System;

namespace LinearSearch
{
    class Program
    {
        
        //time complexty is worst case O(n)
        //because we have to try for all the elements to find the true value
        static Boolean LinearSearch(int [] arr,int n)
        {
            foreach (var currentItem in arr)
            {
                if (currentItem==n)
                {
                    return true;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {
            int [] arr = {12,32,1,3,4,52,12};
            Console.WriteLine(LinearSearch(arr,4));


            //Extra example for linear search 
            //return only 1 val
            int value = Array.Find(arr,element=>element==11);
            Console.WriteLine(value);
            //return Array
            int[] items = Array.FindAll(arr,element=>element>=11);
            Array.ForEach(items,Console.WriteLine);
            
           
        }
    }
}
