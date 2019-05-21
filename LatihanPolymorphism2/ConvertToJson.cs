using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);
            Console.WriteLine("Hasil konversi ke JSON\n");
            Console.WriteLine(json);
        }
    }
}
