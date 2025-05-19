using System;
using System.IO;
using OfficeOpenXml;


class Program
{
    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
;

        string filePath = "data/jobs.xlsx";
        FileInfo existingFile = new FileInfo(filePath);

        using (ExcelPackage package = new ExcelPackage(existingFile))
        {
            // Get the first worksheet (index 0 = first worksheet)
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int colCount = worksheet.Dimension.End.Column;  // Column count
            int rowCount = worksheet.Dimension.End.Row;     // Row count

            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    Console.WriteLine($"Row: {row}, Column: {col}, Value: {worksheet.Cells[row, col].Value?.ToString().Trim()}");
                }
            }
        }
    }
}
