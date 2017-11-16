﻿using System;
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
            Console.WriteLine("Input whatever you want to decrypt");

            string value = Console.ReadLine();
            
            value = Rot13.Transform(value);

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

