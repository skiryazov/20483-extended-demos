using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamDemo
{
    class Program
    {
        static string data = "";
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("data.txt", FileMode.Open);

            ProcessStream(stream);

            Console.WriteLine(data);
        }

        private static void ProcessStream(Stream stream)
        {
            const int BUFFER_SIZE = 1024;
            byte[] buffer = new byte[BUFFER_SIZE];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            while (bytesRead > 0)
            {
                ProcessData(buffer);
                bytesRead = stream.Read(buffer, 0, buffer.Length);
            }

        }

        private static void ProcessData(byte[] buffer)
        {
            data += Encoding.Default.GetString(buffer);
        }
    }
}
