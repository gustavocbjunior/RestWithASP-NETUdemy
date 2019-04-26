using System.IO;
using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();
            var fullPath = path + "\\Other\\aspnet-life-cycles-events.pdf";

            return File.ReadAllBytes(fullPath);
        }
    }
}
