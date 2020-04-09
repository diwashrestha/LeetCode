using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -234;
            Console.WriteLine("Reverse of the {0} is {1}",num,ReverseInt(num));
        }

        static int ReverseInt(int num)
        {
            bool negativeFlag = false;
            if (num < 0)
            {
                negativeFlag = true;
                num = -num;
            }
            int revNum = 0;
            int prevRevNum = 0;

            while (num > 0)
            {
                int rem = num % 10; // Remainder
                revNum = revNum * 10 + rem; 

                if((revNum-rem)/10 != prevRevNum)
                {
                    return 0;
                }
                prevRevNum = revNum;
                num = num / 10;


            }
            return (negativeFlag == true)? -revNum:revNum;
        }
    }

    
}
