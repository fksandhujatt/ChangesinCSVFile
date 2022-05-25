using CSVFILE.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CSVFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string csv_file_path = @"G:\CSVFileCSharp\CSV-Import-to-Database-Csharp\stock_list.csv";
            ReadCSV ReadCSV = new ReadCSV();
            InsertDatatoDB InsertDatatoDB = new InsertDatatoDB();
            List<Stock> Stock = ReadCSV.getDataFromCSVFile(csv_file_path);
            InsertDatatoDB.insertDatatoDBStock(Stock);
            GetStockList GetStockList = new GetStockList();
            List<Stock> stocks = GetStockList.getStockList();
            foreach (var item in stocks)
            {
                Console.WriteLine("{0} {1} {2}", item.Product, item.ProductCode, item.Price);
            }
            Console.ReadLine();
        }
    }
}
