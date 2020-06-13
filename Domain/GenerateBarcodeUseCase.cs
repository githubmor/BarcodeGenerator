namespace Domain
{
    public class GenerateBarcodeUseCase
    {
        public void Generate(IData data, IFile file)
        {
            var barcode = BarcodeFactory.GetBarcode(data);

            var generator = new Genarator(barcode, file);

            generator.Generate();
        }
    }
}