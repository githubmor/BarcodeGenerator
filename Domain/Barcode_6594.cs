namespace Domain
{
    public class Barcode_6594 : Barcode
    {
        public Barcode_6594(string batch, int roz, int start)
            : base(batch, roz, start)
        {
        }

        public override int count
        {
            get { return 96; }
        }

        protected override string KIND
        {
            get { return "SB"; }
        }

        protected override string KALA
        {
            get { return "42"; }
        }

        protected override string SHERKAT
        {
            get { return "AH"; }
        }
    }
}