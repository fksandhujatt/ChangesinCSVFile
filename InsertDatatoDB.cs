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
                    //////
               ////////why all these empty sapce in all your files
            }
            catch (Exception)
            {
//throwing exception like that has no purpose, you need to understand what you are trying to achieve here
                throw;
            }
        }
    }
}
