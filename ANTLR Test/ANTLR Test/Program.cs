using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml.Linq;
using Antlr4.Runtime;
using Sparql;
using TrueRdfViewer;

namespace ANTLR_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> s;
                 //В качестве входного потока символов устанавливаем консольный ввод
            
            //var te = new StreamReader(@"..\..\Input.txt").ReadToEnd();
           // Console.WriteLine(te);
            DateTime start = DateTime.Now;
            //Parse(te);
            //);  
         
             //ParseXML(te).Save(@"..\..\output.xml");
          //  Console.WriteLine((DateTime.Now - start).TotalMilliseconds);
           //var f= Expression.Lambda<Func<string, double>>(Expression.Convert(Expression.Constant(null), typeof (double)),new ParameterExpression[]{Expression.Parameter(typeof(string))}).Compile();


            TripleStoreInt ts = new TripleStoreInt(@"C:\Users\Admin\Source\Repos\PolarDemo\Databases\");
           // ts.LoadTurtle(@"C:\deployed\dataset1M.ttl");
          
       
            DirectoryInfo queriesDir = new DirectoryInfo(@"..\..\sparql data\queries");
            double dd;
            if (double.TryParse("10,01", out dd))
            {
                Console.WriteLine();
            }
         //   ts.LoadTurtle(@"C:\deployed\dataset1M.ttl");
          //  Parse("SELECT * {}");
           RunBerlins(queriesDir, ts);
      //      RunBerlins(queriesDir, ts);
            //Parse(te, ts);
        }

        private static void RunBerlins(DirectoryInfo queriesDir, TripleStoreInt ts)
        {
            foreach (var file in queriesDir.GetFiles("*.rq"))
            {
                var readAllText = File.ReadAllText(file.FullName);
                var st = DateTime.Now;
                var q = Parse(readAllText);

                Console.WriteLine((DateTime.Now - st).TotalMilliseconds);
                var resultString = q.Run(ts);
                File.WriteAllText(Path.ChangeExtension(file.FullName, ".txt"), resultString);

                //.Save(Path.ChangeExtension(file.FullName,".xml"));
            }
        }

        private static Query Parse(string te)
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
            DateTime tm = DateTime.Now;

            var lexer = new sparql2PacLexer(input);
           
            var commonTokenStream = new CommonTokenStream(lexer);
            var sparqlParser = new sparql2PacParser(commonTokenStream);
            sparqlParser.query();
         //   Console.WriteLine((DateTime.Now-tm).TotalMilliseconds);
            return sparqlParser.q;
        }

        private static XElement ParseXML(string te)
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
            sparql2XMLLexer lexer = new sparql2XMLLexer(input);
            var commonTokenStream = new CommonTokenStream(lexer);
            var sparqlParser = new sparql2XMLParser(commonTokenStream);
            sparqlParser.query();
            return sparqlParser.x;   
        }
    }
}
