using System;
using System.Collections.Generic;
using System.IO;

namespace Serxplorer.Models
{
    public class FileSystemExplorerService
    {
        public List<string> GetDirectories(string path)
        {
            try
            {
                return new List<string>(Directory.GetDirectories(path));
            }
            catch (Exception ex)
            {
                // Здесь можно добавить обработку исключений, если необходимо
                throw;
            }
        }

        public List<string> GetFiles(string path)
        {
            try
            {
                return new List<string>(Directory.GetFiles(path));
            }
            catch (Exception ex)
            {
                // Здесь также можно добавить обработку исключений
                throw;
            }
        }
    }
}
