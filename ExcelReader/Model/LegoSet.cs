using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelReader.Model
{
    public class LegoSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfPieces { get; set; }
        public decimal Price { get; set; }
    }
}
