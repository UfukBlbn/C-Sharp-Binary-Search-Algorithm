using System;

namespace BinarySearch
{
    class Program
    {
        
        static Boolean BinarySearch(int [] inputArray,int item)
        {
            //index
            int min =0;
            //we arae getting the exact index
            int max = inputArray.Length-1;

            while (min<=max)
            {
                int mid = (max+min)/2;
                if (item==inputArray[mid])
                {return true;}
                else if (item<inputArray[mid])
                {
                    max=mid-1;
                }
                else{

                    min = mid+1;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int [ ] inputArray = {1,2,3,4,5,6,7,8,9};
           Console.WriteLine(BinarySearch(inputArray,3));
        }
    }
}
