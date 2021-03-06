namespace Domain
{
    public class Barcode_6303 : Barcode
    {
        public Barcode_6303(string batch, int roz, int start)
            : base(batch, roz, start)
        {
        }

        public override int count
        {
            get { return 41; }
        }

        protected override string KIND
        {
            get { return "SW"; }
        }

        protected override string KALA
        {
            get { return "03"; }
        }

        protected override string SHERKAT
        {
            get { return "IA"; }
        }
    }
}