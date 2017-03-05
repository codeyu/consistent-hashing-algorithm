using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = JumpHash.JumpConsistentHash(3, 15);
            Console.WriteLine($"buckets: {result}");
            result = JumpHash.JumpConsistentHash(3, 17);
            Console.WriteLine($"buckets: {result}");

            var ip = "192.168.1.10";
            Console.WriteLine(ip.GetHashCode());
            result = JumpHash.JumpConsistentHash(ip, 20);
            Console.WriteLine($"buckets: {result}");
            Console.WriteLine(ip.GetHashCode());
            result = JumpHash.JumpConsistentHash(ip, 22);
            Console.WriteLine($"buckets: {result}");
        }
    }
}
