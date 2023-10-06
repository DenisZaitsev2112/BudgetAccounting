using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAccounting
{
    internal class Record
    {
        public string Date { get; set; }
        public string Type { get; set; }
        public string EntryName { get; set; }
        public decimal Money { get; set; }
    }
}
