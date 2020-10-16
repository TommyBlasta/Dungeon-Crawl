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
        private readonly string nazevSouboru = $"{typeof(T).Name}" + ".xml";

        public List<T> Objekty { get; set; }
        public void Deserializuj()
        {
            try
            {
                if (File.Exists(nazevSouboru))
                {
                    var loadedFile = File.ReadAllText(nazevSouboru);
                    using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(loadedFile)))
                    {
                        XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(memoryStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                        DataContractSerializer serializer = new DataContractSerializer(Objekty.GetType());
                        Objekty = (List<T>)serializer.ReadObject(reader);
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
                {
                    DataContractSerializer serializer = new DataContractSerializer(Objekty.GetType());
                    serializer.WriteObject(memoryStream, Objekty);
                    File.WriteAllText(nazevSouboru, Encoding.UTF8.GetString(memoryStream.ToArray()));
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
