using System;
using System.IO;
using OfficeOpenXml;


class Program
{
    static void Main(string[] args)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        ;

        string filePath = "data/legos.xlsx";
        FileInfo existingFile = new FileInfo(filePath);

        using (ExcelPackage package = new ExcelPackage(existingFile))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int colCount = worksheet.Dimension.End.Column;  // Column count
            int rowCount = worksheet.Dimension.End.Row;     // Row count

            for (int row = 1; row <= rowCount; row++)
            {
                /*
                for (int col = 1; col <= colCount; col++)
                {
                    Console.WriteLine($"Row: {row}, Column: {col}, Value: {worksheet.Cells[row, col].Value?.ToString().Trim()}");
                } */
                Console.WriteLine($"Row: {row}, Column: {1}, Value: {int.Parse(worksheet.Cells[row, 1].Value?.ToString().Trim())}");
                Console.WriteLine($"Row: {row}, Column: {2}, Value: {worksheet.Cells[row, 2].Value?.ToString().Trim()}");
                Console.WriteLine($"Row: {row}, Column: {3}, Value: {int.Parse(worksheet.Cells[row, 3].Value?.ToString().Trim())}");
                Console.WriteLine($"Row: {row}, Column: {4}, Value: {Convert.ToDecimal(worksheet.Cells[row, 4].Value?.ToString().Trim())}");
                Console.WriteLine("\n");
            }
        }
    }

    // Add excel data to sql database

    // Remove data from sql database

    // Display data from sql database
}
