using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Utils
{
    public class FileIO
    {

        public FileIO()
        {

        }

        public static Picture ReadFromFile(string fileName)
        {
            Type[] elementTypes = { typeof(Dot), typeof(Circle), typeof(Rectangle) };
            XmlSerializer serializer = new XmlSerializer(typeof(Picture), elementTypes);
            FileStream fs = new FileStream(fileName, FileMode.Open);
            Picture picture = (Picture)serializer.Deserialize(fs);
            fs.Close();
            return picture;
        }

        public static void WriteToFile(string fileName, Picture picture)
        {
            Type[] elementTypes = {typeof(Dot), typeof(Circle), typeof(Rectangle)};
            XmlSerializer serializer = new XmlSerializer(typeof(Picture), elementTypes);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            serializer.Serialize(fs, picture);
            fs.Close();
        }
    }
}
