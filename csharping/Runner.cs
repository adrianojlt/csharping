namespace csharping
{
    using System.Threading.Tasks;
    using System.Net.Http;
    using System;
    using System.Threading;

    public class Runner
    {
        private static async Task Main(string[] args)
        {
            //new Start().Run();
            //new Menu().Start();
            await MyRequest();
        }

        public static void cast()
        {
            //var long = 2
        }

        public static async Task MyRequest()
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
}
