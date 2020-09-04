using System;

namespace PatternExemple
{
    class Program
    {
        bool Test (int x, int y) =>
            x * y is var product && product > 10 && product < 100;

        static void Test(object obj)
        {
            bool ShouldAllow (Uri uri) => uri switch
            {
                { Scheme: "http",  Port: 80  } when uri.Host.Length < 1000 => true,
                { Scheme: "http",  Port: 80  } => true,
                { Scheme: "https", Port: 443 } => true,
                { Scheme: "ftp",   Port: 21  } => true,
                { IsLoopback: true           } => true,
                _ => false
            };




            if (obj is string)
            {
                string ss = (string)obj;
                Console.WriteLine (ss.Length);
            }


            // if(obj is string s && s.Length == 4)
            //     Console.WriteLine(s.Length);

            // if(obj is string { Length: 4})
            //     Console.WriteLine(s.Length);
        }
        static void Main(string[] args)
        {

        }
    }
}
