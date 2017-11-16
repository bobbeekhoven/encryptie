using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here you input the word(s) or sentences you want to encrypt
            Console.WriteLine("Input whatever you want to encrypt");

            //This is were the program turns your input into the string value
            // which the program needs in order to encrypt your input
            string value = Console.ReadLine();

            // In this part the value is truly being encrypted with help of 
            // the code determined in the static class Rot13 below
            value = Rot13.Transform(value);

            // This is where you get your encrypted output
            Console.WriteLine(value);
            Console.Read();
        }

        static class Rot13
        {
            public static string Transform (string value)
            {
                char[] array = value.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'a' && number <= 'z')
                    {
                        if (number > 'm')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    else if (number >= 'A' && number <= 'Z')
                    {
                        if (number > 'M')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    array[i] = (char)number;
                }
                return new string(array);
            }
        }
    }
}

