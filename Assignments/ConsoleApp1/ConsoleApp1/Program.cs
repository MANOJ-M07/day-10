using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class RegularExpression
        {
            public static int CountWords(string input)
            {
                return Regex.Matches(input, @"[^\s]+").Count;
            }

            public static List<string> ExtractEmails(string input)
            {
                List<string> emails = new List<string>();
                string emailPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";
                MatchCollection matches = Regex.Matches(input, emailPattern);
                foreach (Match match in matches)
                {
                    emails.Add(match.Value);
                }
                return emails;
            }

            public static List<string> ExtractMobileNumbers(string input)
            {
                List<string> mobileNumbers = new List<string>();
                string mobileNumberPattern = @"\d{10}";
                MatchCollection matches = Regex.Matches(input, mobileNumberPattern);
                foreach (Match match in matches)
                {
                    mobileNumbers.Add(match.Value);
                }
                return mobileNumbers;
            }

            public static List<string> CustomRegexSearch(string input, string pattern)
            {
                List<string> matches = new List<string>();
                MatchCollection customMatches = Regex.Matches(input, pattern);
                foreach (Match match in customMatches)
                {
                    matches.Add(match.Value);
                }
                return matches;
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Enter a piece of text:");
                string inputText = Console.ReadLine();

                // 1. Word Count
                int wordCount = CountWords(inputText);
                Console.WriteLine($"Word Count: {wordCount}");

                // 2. Email Validation
                List<string> emails = ExtractEmails(inputText);
                if (emails.Count > 0)
                {
                    Console.WriteLine("Email addresses found:");
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }
                }
                else
                {
                    Console.WriteLine("No email addresses found.");
                }

                // 3. Mobile Number Extraction
                List<string> mobileNumbers = ExtractMobileNumbers(inputText);
                if (mobileNumbers.Count > 0)
                {
                    Console.WriteLine("Mobile numbers found:");
                    foreach (string number in mobileNumbers)
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    Console.WriteLine("No mobile numbers found.");
                }

                // 4. Custom Regex Search
                Console.WriteLine("Enter a custom regular expression:");
                string customRegex = Console.ReadLine();
                List<string> customMatches = CustomRegexSearch(inputText, customRegex);
                if (customMatches.Count > 0)
                {
                    Console.WriteLine("Custom regex matches:");
                    foreach (string match in customMatches)
                    {
                        Console.WriteLine(match);
                    }
                }
                else
                {
                    Console.WriteLine("No matches found with the custom regex.");
                }
                Console.ReadKey();
            }
        }

        /*static int CountWords(string input)
        {
            return Regex.Matches(input, @"[^\s]+").Count;
        }

        static List<string> ExtractEmails(string input)
        {
            List<string> emails = new List<string>();
            string emailPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";
            MatchCollection matches = Regex.Matches(input, emailPattern);
            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }
            return emails;
        }

        static List<string> ExtractMobileNumbers(string input)
        {
            List<string> mobileNumbers = new List<string>();
            string mobileNumberPattern = @"\d{10}";
            MatchCollection matches = Regex.Matches(input, mobileNumberPattern);
            foreach (Match match in matches)
            {
                mobileNumbers.Add(match.Value);
            }
            return mobileNumbers;
        }

        static List<string> CustomRegexSearch(string input, string pattern)
        {
            List<string> matches = new List<string>();
            MatchCollection customMatches = Regex.Matches(input, pattern);
            foreach (Match match in customMatches)
            {
                matches.Add(match.Value);
            }
            return matches;
        }*/
       
    }
}
