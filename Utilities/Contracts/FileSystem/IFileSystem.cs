namespace Utilities.Contracts.FileSystem
{
    public interface IFileSystem
    {
        void CreateDirectory(string directoryName);

        void WriteFile(string fullFileName, string data);
    }
}
