namespace csharping
{
    using System.Threading.Tasks;
    using System.Net.Http;
    using System;
    using System.Threading;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public class Runner
    {
        private static async Task Main(string[] args)
        {
            //new Start().Run();
            //new Menu().Start();
            //await RepeatedRequest();
            ReadCSV();
        }

        public static void cast()
        {
            //var long = 2
        }

        public static void ReadCSV()
        {
            using( var reader = new StreamReader(@"C:\tmp\freguesias.csv"))
            {
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

                foreach (var ld in localDistritos)
                {
                    Console.WriteLine($"insert into Distrito values ({ld.Distrito.Id}, '{ld.Distrito.Name}');");

                    Console.WriteLine();

                    var localConcelhos = locals
                        .Where(w => w.Distrito.Id == ld.Distrito.Id)
                        .GroupBy(x => x.Concelho)
                        .Select(s => s.ToList())
                        .ToList();

                    for (int i = 0; i < localConcelhos.Count; i++)
                    //foreach (var lc in localConcelhos)
                    { 
                        Console.WriteLine($"insert into Concelhos values ({i+1}, '{localConcelhos[i].First().Concelho}', {ld.Distrito.Id});");

                        Console.WriteLine();

                        foreach (var lf in localConcelhos[i])
                        {
                            Console.WriteLine($"insert into Freguesias values ('{lf.Freguesia.Name}', {i+1}, {lf.Freguesia.CodCF});");
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }



                /*
                foreach (var local in locals)
                {
                    Console.WriteLine(local.ToString());
                }
                */
            }

            Console.ReadLine();
        }

        public static async Task RepeatedRequest()
        {
            var Client = new HttpClient();

            Console.WriteLine("Starting connections");

            for (int i = 0; i < 1000; i++)
            {
                //var result = await Client.GetAsync("http://aspnetmonsters.com");
                var result = await Client.GetAsync("https://oespanhol.us3.list-manage.com/subscribe/send-email?e=bmluZ3VlbUBvZXNwYW5ob2wuY29t&u=2fad61dcffd495fc8d7faaefc&id=d345b48bec");

                Console.WriteLine(result.StatusCode);
                Thread.Sleep(1000);

                if (result.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    Thread.Sleep(32000);
                    //await Task.Delay(5000);
                }

            }

            Console.WriteLine("Connections done");
            Console.ReadLine();
        }

    }

    public class Local
    {
        public Local(Distrito distrito, string concelho, Freguesia freguesia)
        {
            this.Distrito = distrito;
            this.Concelho = concelho;
            this.Freguesia = freguesia;
        }

        public Distrito Distrito { get; }
        public string Concelho { get; }
        public Freguesia Freguesia { get; }

        public override string ToString()
        {
            return $"{Distrito.Id}:{Distrito.Name}:{Concelho}:{Freguesia.Name}:{Freguesia.CodCF}";
        }
    }

    public class Distrito
    {
        public Distrito(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; } 
        public string Name { get; set; }
    }

    public class Freguesia
    {
        public Freguesia(int codcf, string name)
        {
            this.CodCF = codcf;
            this.Name = name;
        }

        public int CodCF { get; set; }
        public string Name { get; set; }
    }
}
