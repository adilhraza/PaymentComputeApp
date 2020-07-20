using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Extensions
{
    public static class ExcelExtensions
    {
        public static void ExportToExcel<T>(this ExcelPackage ep, string sheetName, IEnumerable<T> data)
        {
            ExcelWorksheet sheet = ep.Workbook.Worksheets.Add(sheetName);
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            CreateExcelHeader(sheet, props, 1);
            CreateExcelDataRows(sheet, data, props, 2);
        }

        private static void CreateExcelHeader(ExcelWorksheet sheet, PropertyDescriptorCollection props, int startRow)
        {
            for (int i = 1; i <= props.Count; i++)
            {
                sheet.Cells[startRow, i].Value = props[i - 1].DisplayName;
            }
        }

        private static void CreateExcelDataRows<T>(ExcelWorksheet sheet, IEnumerable<T> data, 
            PropertyDescriptorCollection props, int startRow)
        {
            foreach (T item in data)
            {
                for (int i = 1; i <= props.Count; i++)
                {
                    sheet.Cells[startRow, i].Value = props[i - 1].GetValue(item);
                }
                startRow++;
            }
            sheet.Cells["A:AZ"].AutoFitColumns();
        }
    }
}
