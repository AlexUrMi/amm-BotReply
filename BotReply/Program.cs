﻿using McMaster.Extensions.CommandLineUtils;
using System;

namespace BotReply
{
    class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication();

            app.HelpOption();
            var optionSubject = app.Option("-s|--subject <SUBJECT>", "The subject", CommandOptionType.SingleValue);

            app.OnExecute(() =>
            {
                var subject = optionSubject.HasValue()
                    ? optionSubject.Value()
                    : "world";

                Console.WriteLine($"Hello {subject}!");
                return 0;
            });

            return app.Execute(args);
        }
    }
}
