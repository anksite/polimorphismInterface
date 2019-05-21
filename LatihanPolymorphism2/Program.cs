using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2288";
            mhs.nama = "ANK";
            mhs.email = "amk@gmail.com";

            Console.WriteLine("Pilih format konversi data");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. CSV\n");
            Console.Write("Pilihan anda [1..3]: ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (pilih == 1)
            {
                convert = new ConvertToJson();
            }
            else if (pilih == 2)
            {
                convert = new ConvertToXml();
            }
            else {
                convert = new ConvertToCsv();
            }

            convert.Convert(mhs);
            Console.ReadKey();
        }
    }
}
