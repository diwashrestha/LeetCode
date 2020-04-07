using System;

namespace Two_Sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[]  {5,3,4,1,9};

            Program.Solution(num, 9);
        }

        public static int[] Solution(int[] nums , int target)
            {
             for(int i = 0;i < nums.Length;i++ )
             {
                 for(int j = i+1; j < nums.Length; j++)
                 {
                     if(nums[i] + nums[j] == target)
                     {
                         int[] numlist = new int[] {i,j};
                         Console.WriteLine("The index of number is {0} and {1}",numlist[0],numlist[1]);
                         return numlist;
                     }
                 }

             }
             return null;
            }
    }
}
