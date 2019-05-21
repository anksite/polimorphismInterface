using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LatihanPolymorphism2
{
    class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter()) {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                    serializer.Serialize(writer, mhs);

                    string xml = writer.ToString();

                    Console.WriteLine("Hasil konversi ke XML\n");
                    Console.WriteLine(xml);
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }
              
            }
                
        }
    }
}
