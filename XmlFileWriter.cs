namespace BookInterfaceExample
{
    class XmlFileWriter : IFileWriter
    {
        public string Location { get { return @"C:\Users\simon\source\repos\InterfacesExampleTwo-main\sparfunktion\"; } }

        public string Extension { get { return ".xml"; } }

        public string WriteToFile(string fileName)
        {
            return $"Filen har sparats i {Location + fileName + Extension}";
        }
    }
}
