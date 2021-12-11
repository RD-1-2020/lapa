using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_connect
{
    class Program
    {
        static void Main(string[] args)
        {
            Pdf_Reader pdf = new Pdf_Reader();
            Console.WriteLine(pdf.get_Hello());
            Console.ReadKey();
        }
    }
}
