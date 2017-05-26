using System;
using System.IO;
using System.Xml;
using Nota.CharacterGenerator.CoreData.Core;

namespace Nota.CharacterGenerator
{
    public static class Root
    {

        public static Daten Daten { get; private set; }

        public static void Initilize(string xml)
        {
            var serelizer = new System.Xml.Serialization.XmlSerializer(typeof(CoreData.Core.Daten));

            using (var s = XmlReader.Create(new StringReader(xml)))
            {
                Daten = serelizer.Deserialize(s) as CoreData.Core.Daten;

            }
        }
    }
}
