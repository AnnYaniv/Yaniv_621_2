using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace CarInterface
{
    public static class ToOffice
    {
        public static bool toExcel(DataTable[] ds, string filename)
        {
            try
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = false ;

                Excel.Workbook workbook = excelApp.Application.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                
                foreach (DataTable dt in ds)
                {
                    worksheet.Name = dt.TableName;

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString(); 
                        }
                    }
                    worksheet = (Excel.Worksheet)workbook.Sheets.Add(After: workbook.ActiveSheet);
                }
                workbook.SaveAs(filename);
                excelApp.Quit();
                return true;
            }
            catch
            {
                return false;
            }
        }
    
        public static bool toWord(DataTable[] ds, string filename)
        {
            try
            {
                object myMissingValue = System.Reflection.Missing.Value;
                Word.Application word = new Word.Application();
                word.Visible = true;
                Word.Document doc = word.Documents.Add(Visible: true);
                doc = word.ActiveDocument;
                Word.Range range = doc.Range();
                int style = 4;
                foreach(DataTable dt in ds)
                {
                    Word.Table table = doc.Tables.Add(range, dt.Rows.Count + 1, dt.Columns.Count);
                    doc.Words.Last.InsertBreak(Word.WdBreakType.wdTextWrappingBreak);
                    range = doc.Range(doc.Content.End - 1, ref myMissingValue);
                    
                    table.Borders.Enable = 1;
                    table.set_Style("List Table 4 - Accent " + style);
                    style++;
                    int i = 0;
                    foreach (Word.Row row in table.Rows)
                    {
                        int j = 0;
                        foreach (Word.Cell cell in row.Cells)
                        {
                            if (cell.RowIndex == 1)
                                cell.Range.Text = dt.Columns[j].ColumnName;
                            else
                                cell.Range.Text = dt.Rows[i][j].ToString();
                            j += 1;
                        }
                        if (row.Index > 1)
                            i += 1;

                        
                    }
                }
                doc.SaveAs(filename);
                doc.Close();
                word.Quit();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
