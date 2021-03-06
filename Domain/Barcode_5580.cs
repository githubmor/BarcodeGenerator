namespace Domain
{
    public class Barcode_5580 : Barcode
    {
        public Barcode_5580(string batch, int roz, int start)
            : base(batch, roz, start)
        {
        }

        public override int count
        {
            get { return 120; }
        }

        protected override string KIND
        {
            get { return "BR"; }
        }

        protected override string KALA
        {
            get { return "23"; }
        }

        protected override string SHERKAT
        {
            get { return "AH"; }
        }
    }
}