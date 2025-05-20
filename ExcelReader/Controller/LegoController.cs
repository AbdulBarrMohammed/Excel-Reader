using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcelReader.Data;
using ExcelReader.Model;

namespace ExcelReader.Controller
{
    static class LegoController
    {
        public static void AddLego(string name, int numOfPieces, decimal price)
        {
            using var db = new LegoDBContext();
            db.Add(new LegoSet { Name = name, NumOfPieces = numOfPieces, Price = price });
            db.SaveChanges();
        }

        public static void DeleteAllLegos()
        {

        }

        public static List<LegoSet> DisplayAllLegos()
        {
            var db = new LegoDBContext();
            var legos = db.Legos.ToList<LegoSet>();
            return legos;
        }
    }
}
