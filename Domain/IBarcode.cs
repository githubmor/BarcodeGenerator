namespace Domain
{
    public interface IBarcode
    {
        string batch { get; set; }

        int count { get; }

        int Roz { get; set; }

        string getSerial(int p);
    }
}