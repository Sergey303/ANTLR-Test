using System;
using System.IO;
using System.Xml.Linq;
using Antlr4.Runtime;
using ANTLR_Test;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //В качестве входного потока символов устанавливаем консольный ввод

            var te = new StreamReader(@"..\..\Input.txt").ReadToEnd();
            // Console.WriteLine(te);
            DateTime start = DateTime.Now;
            //Parse(te);
            //);

            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);
            start = DateTime.Now;
            Parse(te).Save(@"..\..\output.xml");
            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);

            DirectoryInfo queriesDir = new DirectoryInfo(@"..\..\sparql data\queries");
            foreach (var file in queriesDir.GetFiles("*.rq"))
            {
                Parse(File.ReadAllText(file.FullName)).Save(Path.ChangeExtension(file.FullName, ".xml"));
            }
        }


        private static XElement Parse(string te)
        {
            ICharStream input = new AntlrInputStream(te);


            // Console.WriteLine(input);
            // Настраиваем лексер на этот поток
            //CalcLexer lexer = new CalcLexer(input);
            //// Создаем поток токенов на основе лексера
            //CommonTokenStream tokens = new CommonTokenStream(lexer);
            //// Создаем парсер
            //CalcParser parser = new CalcParser(tokens);
            //// И запускаем первое правило грамматики!!!
            //parser.calc();
            sparqlLexer lexer = new sparqlLexer(input);
            var commonTokenStream = new CommonTokenStream(lexer);
            var sparqlParser = new sparqlParser(commonTokenStream);
            sparqlParser.query();
            return sparqlParser.x;
        }
    }
}
