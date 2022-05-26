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
            List<Stock> Stock = ReadCSV.getDataFromCSVFile(csv_file_path);//why not use IList<Stock> here
            InsertDatatoDB.insertDatatoDBStock(Stock);
            GetStockList GetStockList = new GetStockList();//you don't need to do that unless there is a requirement to save and retrieve from db, so be careful
            List<Stock> stocks = GetStockList.getStockList();
            foreach (var item in stocks)//formatting is important, why this for is right after previous lines
            {
                Console.WriteLine("{0} {1} {2}", item.Product, item.ProductCode, item.Price);
            }
            Console.ReadLine();
        }
    }
}
