using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.Style;
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
            StyleExcelDocument(sheet, props, data, 1);
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

        private static void StyleExcelDocument<T>(ExcelWorksheet sheet, PropertyDescriptorCollection props, IEnumerable<T> data, int startRow)
        {
            StyleExcelHeader(sheet, props, data, startRow);

            startRow += 1;
            StyleExcelDataRow(sheet, props, data, startRow);
        }

        private static void StyleExcelHeader<T>(ExcelWorksheet sheet, PropertyDescriptorCollection props, IEnumerable<T> data, int startRow)
        {
            for (int i = 1; i <= props.Count; i++)
            {
                sheet.Cells[startRow, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                sheet.Cells[startRow, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                sheet.Cells[startRow, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                sheet.Cells[startRow, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                sheet.Cells[startRow, i].Style.Font.Bold = true;
                sheet.Cells[startRow, i].Value = props[i - 1].DisplayName;
                sheet.Cells[startRow, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells[startRow, i].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DodgerBlue);
            }
        }

        private static void StyleExcelDataRow<T>(ExcelWorksheet sheet, PropertyDescriptorCollection props, IEnumerable<T> data, int startRow)
        {
            foreach (T item in data)
            {
                for (int i = 1; i <= props.Count; i++)
                {
                    sheet.Cells[startRow, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[startRow, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[startRow, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[startRow, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                }
                startRow++;
            }
        }
    }
}
