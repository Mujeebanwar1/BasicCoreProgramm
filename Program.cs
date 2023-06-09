﻿using BasicCoreProgramm;
using System;
using static BasicCoreProgramm.SwappingTwoNumbers;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program number which is to be executed \n 1. Flip Coin \n 2. Leap Year \n 3. Power of Two \n 4. Harmonic Number \n 5. Factors \n 6. Quotient Remainder \n 7. SwapTwoNumers \n 8. Even Or Odd Number \n 9. Vowel or Consonent \n 10.Largest Number \n 11.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                 switch (option)
                {
                    case 1:
                        Flipcoin coin = new Flipcoin();
                        coin.Play();
                        break;
                    case 2:
                        LeapYear check = new LeapYear();
                        check.Leap();
                        break;
                    case 3:
                        PowerOfTwo res = new PowerOfTwo();
                        res.Power();
                        break;
                    case 4:
                        HarmonicNumber sum = new HarmonicNumber();
                        sum.Harmonic();
                        break;
                    case 5:
                        Factors fac = new Factors();
                        fac.Factor();
                        break;
                    case 6:
                        QuotientRemainder result = new QuotientRemainder();
                        result.Division();
                        break;
                    case 7:
                        Swapping ans = new Swapping();
                        ans.Swap();
                        break;
                    case 8:
                        EvenOrOdd num = new EvenOrOdd();
                        num.EvenOdd();
                        break;
                    case 9:
                        VowelorConsonant letter = new VowelorConsonant();
                        letter.Alphabet();
                        break;
                    case 10:
                        LargestNumber max = new LargestNumber();
                        max.Largest();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}