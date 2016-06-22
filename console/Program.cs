using System;
using Newtonsoft.Json;
using Language;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "Translate Hello World",
                FullName = ".NET Core Translate Hello World",
                Description = "Translate hello world based on alpha 2 code",
            };
            app.HelpOption("-h|--help");
            var alphaTwoCodeOption = app.Option("--alphaTwoCode|-a", "Alpha Two Code", CommandOptionType.SingleValue);

            app.OnExecute(() => 
            {
                var alphaTwoCode = alphaTwoCodeOption.Value();
                if (alphaTwoCode == null)
                {
                    app.ShowHelp();
                    return 2;
                }

                GetTranslated(alphaTwoCode);

                return 0;
            });

            app.Execute(args);
        }

        private static void GetTranslated(string alphaTwoCode)
        {
            var text = new Localise().Translate(alphaTwoCode);
            var jsonText = JsonConvert.SerializeObject(new { Text = text });
            Console.WriteLine(jsonText);
        }
    }
}
