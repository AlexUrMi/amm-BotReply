using McMaster.Extensions.CommandLineUtils;
using System;

namespace BotReply
{
    class Program
    {
        public static int Main(string[] args)
            => CommandLineApplication.Execute<Program>(args);

        [Option(Description = "The subject")]
        public string Subject { get; }

        private void OnExecute()
        {
            var subject = Subject ?? "world";
            Console.WriteLine($"Hello {subject}!");
        }
    }
}
