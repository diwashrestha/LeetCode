using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome(121));
        }

        static bool Palindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }

/*             else if(num == Program.ReverseNum(num))
            {
                  return true;
            }

            else
            {
                return false;
            } */

            return(Program.ReverseNum(num) == num)? true:false;

              

        }

        static int ReverseNum(int num)
        {
            int revNum = 0;
            int prevRevNum = 0;

            while(num != 0)
            {
                int rem = num % 10;
                revNum = revNum*10+rem;
                if((revNum-rem)/10 != prevRevNum)
                {
                    return 0;
                }
                prevRevNum = revNum;
                num = num/10;
            }
            return revNum;
        }
    }
}
