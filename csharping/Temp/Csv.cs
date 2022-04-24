﻿namespace csharping.Temp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Csv
    {
        private const string CsvFilePath = (@"C:\tmp\freguesias.csv");
        private const string DistritoSqlFile = (@"C:\tmp\distrito.sql");
        private const string ConcelhoSqlFile = (@"C:\tmp\concelho.sql");
        private const string FreguesiaSqlFile = (@"C:\tmp\freguesia.sql");

        private static System.Text.Encoding Encoding = System.Text.Encoding.UTF8;

        public static void ReadCSV()
        {
            using (var reader = new StreamReader(CsvFilePath))
            {
                //reader.Peek();
                //Encoding = reader.CurrentEncoding;

                reader.ReadLine();

                var locals = new List<Local>();

                while (!reader.EndOfStream)
                {
                    
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    var distrito = new Distrito(int.Parse(values[0]), values[1].Trim());
                    var freguesia = new Freguesia(int.Parse(values[7]), values[5].Trim());

                    locals.Add(new Local(distrito, values[3].Trim(), freguesia));
                }

                var localDistritos = locals.GroupBy(x => x.Distrito.Id).Select(s => s.First());

                var idConselho = 1;

                foreach (var ld in localDistritos)
                {
                    var insertDistritoQuery = $"insert into Distrito values ({ld.Distrito.Id}, '{ld.Distrito.Name}');";

                    Console.WriteLine(insertDistritoQuery);

                    using (StreamWriter sw = new StreamWriter(DistritoSqlFile, true, Encoding))
                    {
                        sw.WriteLine(insertDistritoQuery);
                    }

                    Console.WriteLine();

                    var localConcelhos = locals
                        .Where(w => w.Distrito.Id == ld.Distrito.Id)
                        .GroupBy(x => x.Concelho)
                        .Select(s => s.ToList())
                        .ToList();

                    for (int i = 0; i < localConcelhos.Count; i++)
                    {
                        var insertConcelhosQuery = $"insert into Concelhos values ({idConselho}, '{localConcelhos[i].First().Concelho}', {ld.Distrito.Id});";

                        idConselho++;

                        Console.WriteLine(insertConcelhosQuery);

                        using (StreamWriter sw = new StreamWriter(ConcelhoSqlFile, true, Encoding))
                        {
                            sw.WriteLine(insertConcelhosQuery);
                        }

                        Console.WriteLine();

                        foreach (var lf in localConcelhos[i])
                        {
                            //var insertFreguesiasQuery = $"insert into Freguesias values ('{lf.Freguesia.Name}', {i + 1}, {lf.Freguesia.CodCF});";
                            var insertFreguesiasQuery = $"insert into Freguesias values ('{lf.Freguesia.Name}', {idConselho});";

                            Console.WriteLine(insertFreguesiasQuery);

                            using (StreamWriter sw = new StreamWriter(FreguesiaSqlFile, true, Encoding))
                            {
                                sw.WriteLine(insertFreguesiasQuery);
                            }
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
