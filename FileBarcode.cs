using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator
{
    public class FileBarcode :IFile
    {
        public FileBarcode(string batch)
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + batch + ".xls";
        }

        public string Path { get; set; }
        
    }
}
