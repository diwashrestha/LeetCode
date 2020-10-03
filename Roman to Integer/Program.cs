using System;
using System.Collections.Generic;

namespace Roman_to_Integer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Roman Number:");
            string romanNum =  Console.ReadLine();
            Console.WriteLine("Roman Number:{0}",romanNum);
            var romanInt = new Program();
            int intValue = romanInt.RomanToInt(romanNum);
            Console.WriteLine("Roman Number:{0} \nInteger Value:{1}",romanNum,intValue);
        }

        public int RomanToInt(string s){
            char[] romanCharArray = s.ToCharArray();
            Dictionary<char,int> RomanSym = new Dictionary<char, int>(){
                {char.Parse("I"),1},
                {char.Parse("V"),5},
                {char.Parse("X"),10},
                {char.Parse("L"),50},
                {char.Parse("C"),100},
                {char.Parse("D"),500},
                {char.Parse("M"),1000}
            
            };
            
            
            int[] nums = new int[s.Length];
            int i = 0;
            foreach( char romanCha in romanCharArray)
            {
                if(RomanSym.ContainsKey(romanCha))
                {
                    nums[i] = RomanSym[romanCha];
                }
                i++;
            }

            int integerNum = 0;

            for(int j = 0; j < s.Length-1;j++)
            {
                if(nums[j] < nums[j+1])
                {
                    integerNum -= nums[j];
                }
                else
                {
                    integerNum += nums[j];
                }
            }
            return integerNum+nums[s.Length-1];
        }
    }
}
