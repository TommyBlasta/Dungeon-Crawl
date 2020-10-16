using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Editor
{
    abstract class BazovyEditor2<T>
    {
        private readonly string nazevSouboru = $"testSerializer" + ".xml";

        public List<T> Objekty { get; set; }
        public void Deserializuj()
        {
            try
            {
                if (File.Exists(nazevSouboru))
                {
                    //DataContractSerializer serializer = new DataContractSerializer(Objekty.GetType());
                    //FileStream fs = new FileStream(nazevSouboru, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    //XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    //Objekty = (List<T>)serializer.ReadObject(fs);
                    using (Stream stream = new MemoryStream())
                    {
                        byte[] data = System.Text.Encoding.UTF8.GetBytes(nazevSouboru);
                        stream.Write(data, 0, data.Length);
                        stream.Position = 0;
                        DataContractSerializer deserializer = new DataContractSerializer(Objekty.GetType());
                        Objekty = (List<T>)deserializer.ReadObject(stream);
                    }
                }
                else throw new FileNotFoundException("Soubor nebyl nalezen");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Serializuj()
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                using (StreamReader reader = new StreamReader(memoryStream))
                {
                    DataContractSerializer serializer = new DataContractSerializer(Objekty.GetType());
                    serializer.WriteObject(memoryStream, Objekty);
                    memoryStream.Position = 0;
                    File.WriteAllText(nazevSouboru, reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        abstract public void Vytvor();


        //metoda na formatovani vstupu od editora?
    }
}
