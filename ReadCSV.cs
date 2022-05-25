using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CSVFILE.IServices;
using CSVFILE.Models;
using NotVisualBasic.FileIO;

namespace CSVFILE
{
    public class ReadCSV: IReadCSV
    {
        //public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        //{
        //    DataTable csvData = new DataTable();

        //    try
        //    {

        //        using (CsvTextFieldParser csvReader = new CsvTextFieldParser(csv_file_path))
        //        {
        //            csvReader.SetDelimiter(',');
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            string[] colFields = csvReader.ReadFields();
        //            foreach (string column in colFields)
        //            {
        //                DataColumn datecolumn = new DataColumn(column);
        //                datecolumn.AllowDBNull = true;
        //                csvData.Columns.Add(datecolumn);
        //            }
        //            InsertDatatoDB InsertDatatoDB = new InsertDatatoDB();
        //            List<Stock> Stocks = new List<Stock>();
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                Stock Stock = new Stock();
        //                //foreach (var item in fieldData)
        //                //{
        //                //    Stock.Product = item.ToString();
        //                //    //Stock.Price = item.ToString();
        //                //}
        //                Stock.Product = fieldData[0];
        //                Stock.ProductCode = fieldData[1];
        //                Stock.Price = Convert.ToDecimal(fieldData[2]);

        //                Stocks.Add(Stock);
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                csvData.Rows.Add(fieldData);

        //            }
        //            InsertDatatoDB.insertDatatoDBStock(Stocks);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return csvData;
        //}
        public List<Stock> getDataFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            List<Stock> Stocks = new List<Stock>();

            try
            {
                
                using (CsvTextFieldParser csvReader = new CsvTextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiter(',');
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();

                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    //InsertDatatoDB InsertDatatoDB = new InsertDatatoDB();
                    

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        Stock Stock = new Stock();
                        
                        Stock.Product = fieldData[0];
                        Stock.ProductCode = fieldData[1];
                        Stock.Price = Convert.ToDecimal(fieldData[2]);

                        Stocks.Add(Stock);

                        csvData.Rows.Add(fieldData);

                    }

                    //InsertDatatoDB.insertDatatoDBStock(Stocks);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return Stocks;
        }
    }
}
