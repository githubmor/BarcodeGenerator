namespace Domain
{
    public class Barcode_6602 : Barcode
    {
        public Barcode_6602(string batch, int roz, int start)
            : base(batch, roz, start)
        {
        }

        public override int count
        {
            get { return 72; }
        }

        protected override string KIND
        {
            get { return "BR"; }
        }

        protected override string KALA
        {
            get { return "01"; }
        }

        protected override string SHERKAT
        {
            get { return "AH"; }
        }
    }
}