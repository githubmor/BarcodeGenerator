using System;
namespace Domain
{
    public abstract class Barcode : IBarcode
    {
        private int start;

        public Barcode(string batch, int roz, int start)
        {
            this.batch = batch;
            this.Roz = roz;
            this.start = start;
        }

        public string batch { get; set; }
        public abstract int count { get; }
        protected abstract string KIND { get; }
        protected abstract string KALA { get; }
        protected abstract string SHERKAT { get; }

        public int Roz { get; set; }
        private string getRoz_XXX()
        {
            return getZero(Roz, 3) + Roz;
        }

        public string getSerial(int row)
        {
            if (row>count || row <1)
            {
                throw new ArgumentNullException("رديف باركد اشتباه است");
            }

            var re = KIND + KALA + SHERKAT + getRoz_XXX();

            re = re + getRowXXXX(start + row-1);

            return re;
        }

        private string getRowXXXX(int num)
        {
            return getZero(num, 4) + num;
        }

        private string getZero(int num,int count)
        {
            return new String('0', count - num.ToString().Length);
        }
    }
}