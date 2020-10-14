using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using DungeonCrawl;

namespace Editor
{
    abstract class BazovyEditor<T>
    {
        private readonly string nazevSouboru = $"{typeof(T).Name}" + ".xml";

        public List<T> Objekty { get; set; }
        public void Deserializuj()
        {
            try
            {
                if (File.Exists(nazevSouboru))
                {
                    XmlSerializer serializer = new XmlSerializer(Objekty.GetType());
                    using (StreamReader sr = new StreamReader(nazevSouboru))
                    {
                        Objekty = (List<T>)serializer.Deserialize(sr);
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
                XmlSerializer serializer = new XmlSerializer(Objekty.GetType());
                using (StreamWriter sw = new StreamWriter(nazevSouboru))
                {
                    serializer.Serialize(sw, Objekty);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        abstract public void Vytvor();


        //metoda na formatovani vstupu od editora?
    }
}
