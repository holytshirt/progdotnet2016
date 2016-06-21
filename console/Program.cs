using System;
using Newtonsoft.Json;
using Language;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = new Localise().Translate(args[0]);
            var jsonText = JsonConvert.SerializeObject(new { Text = text });
            Console.WriteLine(jsonText);
        }
    }
}
