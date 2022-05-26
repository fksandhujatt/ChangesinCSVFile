using CSVFILE.IServices;
using CSVFILE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSVFILE
{
    public class GetStockList : IGetStockList
    {
        public List<Stock> getStockList()
        {
            try
            {
                List<Stock> stocks = new List<Stock>();

                using (CSVFILEContext db = new CSVFILEContext())
                {
                    
                   return db.Stock.ToList();
                    
                }
            }
            catch (Exception)//why there is even need for a try catch block here, if db fails, that's a problem whole application should fail, this catch throw does nothing at all
            {
                throw;
            }
        }
    }
}

