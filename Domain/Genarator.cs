using GemBox.Spreadsheet;
using System;
using System.IO;

namespace Domain
{
    public class Genarator
    {
        private IBarcode barcode;
        private IFile file;

        public Genarator(IBarcode barcode, IFile file)
        {
            this.barcode = barcode;
            this.file = file;
        }

        internal void Generate()
        {
            try
            {
                CreateFile();

                var workbook = CreateWorkBook();

                SetBarcodeToWorkSheet(CreateWorkSheet(workbook));

                workbook.Save(file.Path);
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        private void SetBarcodeToWorkSheet(ExcelWorksheet workSheet)
        {
            var yearSymbol = getYearSymbol();
            for (int row = 1; row <= (barcode.count); row++)
            {
                workSheet.Cells[row+1, 0].Value = yearSymbol + barcode.getSerial(row);
            }
        }

        private ExcelWorksheet CreateWorkSheet(ExcelFile workbook)
        {
            var workSheet = workbook.Worksheets.Add("barcode");
            workSheet.Cells[0, 0].Value = "BARCODE";
            workSheet.Cells[1, 0].Value = barcode.batch;
            return workSheet;
        }

        private static ExcelFile CreateWorkBook()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            return new ExcelFile();
        }

        private void CreateFile()
        {
            FileInfo saveFile = new FileInfo(file.Path);
            if (saveFile.Exists)
            {
                saveFile.Delete();
            }
        }

        private string getYearSymbol()
        {
            return new YearSymbol().getYearSymbol(barcode.Roz);
        }
    }
}