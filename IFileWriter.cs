namespace BookInterfaceExample
{
    interface IFileWriter
    {
        string Location { get; }

        string Extension { get; }

        string WriteToFile(string fileName);
    }
}
