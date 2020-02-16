using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region MyExperments


            //parallelHandsON parallelHandsON = new parallelHandsON();

            //int i = Convert.ToInt32(args[0].ToString());
            //i.IsGreterThan(20);

            //Console.WriteLine(i.IsGreterThan(20));

            //string input = args[0].ToString();

            //Console.WriteLine(input.MakeSrtingCamelCase()); 

            #endregion
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
