using System.IO;
using Utilities.Contracts.FileSystem;

namespace Utilities.FileSystem
{
    public class FileSystem : IFileSystem
    {
        public void CreateDirectory(string directoryName)
        {
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        public void WriteFile(string fullFileName, string data)
        {
            CreateDirectory(Path.GetDirectoryName(fullFileName));

            using (var writer = new StreamWriter(fullFileName, false))
            {
                writer.Write(data);
            }
        }
    }
}