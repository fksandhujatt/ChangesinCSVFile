using CSVFILE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVFILE
{
    public class InsertDatatoDB
    {
        public void insertDatatoDBStock(List<Stock> Stock)
        {
            try
            {
                using (CSVFILEContext db = new CSVFILEContext())
                {
                    db.AddRange(Stock);
                    db.SaveChanges();
                }
                    
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
