using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System.Data;
using ClosedXML.Excel;

namespace IDGEN.Code
{
    public static class ExcelExporter
    {

        public static void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "تصدير الملف على شكل اكسل";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) // Creat Excel File
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); // Add Sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    // Check if file exists before attempting to open it
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("File not found or could not be saved.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



    }
}