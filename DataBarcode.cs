using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator
{
    public class DataBarcode :IData
    {
        public DataBarcode(int faniCode4,string batch, int roz, int start)
        {
            this.batch = batch;
            this.roz = roz;
            this.start = start;
            this.FaniCode4 = faniCode4;
        }

        public int FaniCode4 { get; set; }


        public int start{ get; set; }
        

        public int roz{ get; set; }
        

        public string batch{ get; set; }
        
    }
}
