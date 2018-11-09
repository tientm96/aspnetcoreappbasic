using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }


        /*
        - Fundamentals (nguyên tắc cơ bản): .net core đơn giản chỉ là ứng dụng console, vì là ứng dụng console nên trong hàm main() 
            nó tạo ra một host web và run host đó => Đó chính là điểm chung giữa console app và web app trong core, rất đơn giản.



         */

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
