namespace Domain
{
    public class Barcode_3231 : Barcode
    {
        public Barcode_3231(string batch, int roz, int start)
            : base(batch, roz, start)
        {
        }

        public override int count
        {
            get { return 48; }
        }

        protected override string KIND
        {
            get { return "SW"; }
        }

        protected override string KALA
        {
            get { return "43"; }
        }

        protected override string SHERKAT
        {
            get { return "IA"; }
        }
    }
}