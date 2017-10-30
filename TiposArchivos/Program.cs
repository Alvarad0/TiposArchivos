using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHelper fh = new FileHelper();
            var res = fh.GetFileSystemObjects("./");

            foreach (var item in res)
            {
                Console.WriteLine($"Name: {item.Name} - Type: {item.FileType}");
            }
            Console.ReadLine();
        }
    }
}
