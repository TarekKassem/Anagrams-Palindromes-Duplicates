using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD01
{
    public class Arrays
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("Enter string 1.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2.");
            string str2 = Console.ReadLine();

            //var str1List = str1.AsEnumerable().ToList();
            //var str2List = str2.AsEnumerable().ToList();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("The two string have different sizes!");
            }
            for (int i = 0; i < str1.Length; i++)
            {
                var str1Current = str1[i];
                var str2Current = str2[str2.Length-1 - i];
                if (str1[i] != str2[str2.Length-1 - i])
                {
                    Console.WriteLine("Not Palindromes!");
                    break;
                }
                
            }
            Console.WriteLine("They are palidromess!!!!!!!!!");

        }
        public static bool CheckIfPalindrome(string s)
        {
            //Console.WriteLine("Enter string to check if it's a palindrome");
            //var s = Console.ReadLine();

            var reverse = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                reverse += s[i].ToString();
            }
            if (reverse == s)
            {
                Console.WriteLine("The word you entered is palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine("NOT ¨Palindrome!");
                return false;
            }

        }

        public static void FindDuplicates()
        {
            int[] array = { 1, 1, 2, 5, 5, 9, 3, 3, 3, 3, 3, 3, 3, 3, 5, 1, 4,}; 
            int[] array2 = { 1, 2, 5, 9, 3,}; 
            var duplicates = array.GroupBy(x => x).Where(x => x.Count() > 1).Select(y => y.Key).ToList();

            Console.WriteLine(String.Join(", ", duplicates));
            //Array.Sort(array2);

                object num = 9;
                Console.WriteLine($"The index of number 9 is : {Array.BinarySearch(array2, num)}");

        }
        public static void AreAnagrams()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            var str1List = str1.AsEnumerable().ToList();
            var str2List = str2.AsEnumerable().ToList();

            CheckIfAnagrams(str1List, str2List);

        }

        private static void CheckIfAnagrams(List<char> str1List, List<char> str2List)
        {
            if (str1List.Count != str2List.Count)
            {
                Console.WriteLine("The two strings are not anagrams!");
            }
            else
            {
                str1List.Sort();
                str2List.Sort();
                for (int i = 0; i < str1List.Count; i++)
                {
                    if (!str1List[i].Equals(str2List[i]))
                    {
                        Console.WriteLine("The two strings are not anagrams!");
                    }
                }
                Console.WriteLine("The two string ARE ANAGRAMS!!!!!");
            }
        }
    }
}
