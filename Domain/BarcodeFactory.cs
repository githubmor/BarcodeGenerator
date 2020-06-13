namespace Domain
{
    public class BarcodeFactory
    {
        public static IBarcode GetBarcode(IData data)
        {
            IBarcode b;
            switch (data.FaniCode4)
            {
                case 0019:
                    b = new Barcode_0019(data.batch, data.roz, data.start);
                    break;
                case 3231:
                    b = new Barcode_3231(data.batch, data.roz, data.start);
                    break;
                case 5580:
                    b = new Barcode_5580(data.batch, data.roz, data.start);
                    break;
                case 6303:
                    b = new Barcode_6303(data.batch, data.roz, data.start);
                    break;
                case 6594:
                    b = new Barcode_6594(data.batch, data.roz, data.start);
                    break;
                case 6602:
                    b = new Barcode_6602(data.batch, data.roz, data.start);
                    break;
                case 8055:
                    b = new Barcode_8055(data.batch, data.roz, data.start);
                    break;
                default:
                    b = null;
                    break;
            }

            return b;
        }
    }
}