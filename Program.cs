using System;
using System.IO;
using Markdig;
using Markdig.SyntaxHighlighting;

namespace md2html
{
    internal class Program
    {
        static void Main(string[] argv)
        {
            if (argv.Length != 2)
            {
                Usage();
                Environment.Exit(1);
            }

            string mdFname = argv[0];
            string htmlFname = argv[1];
#if DEBUG
            Console.WriteLine($"argv count: {argv.Length}");
            Console.WriteLine("md file:    " + mdFname);
            Console.WriteLine("html file:  " + htmlFname);
            Console.WriteLine($"cwd:        {Environment.CurrentDirectory}{Path.DirectorySeparatorChar}");
#endif
            string md = File.ReadAllText(mdFname);

            var pipeline = new Markdig.MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseYamlFrontMatter()
                .UseSyntaxHighlighting(null).Build();

            // Console.WriteLine(Markdown.ToHtml(md, pipeline));
            File.WriteAllText($"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}{htmlFname}",
                Markdown.ToHtml(md, pipeline));
            // File.WriteAllText($"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}",
            //    Markdown.ToHtml(md, pipeline));
        }

        static void Usage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  md2html [markdown file] [html file]");
        }
    }
}
