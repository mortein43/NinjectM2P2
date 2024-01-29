namespace NinjectM2P2;

public class FileService : IFileService
{
    public void WriteToFile(string fileName, string content)
    {
        File.AppendAllText(fileName, content + Environment.NewLine);
    }

}
