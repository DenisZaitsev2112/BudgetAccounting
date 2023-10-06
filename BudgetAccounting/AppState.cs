using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace BudgetAccounting
{
    internal class AppState
    {
        public List<Record> Records { get; set; }
        public decimal TotalAmount { get; set; }
        public List<string> RecordTypes { get; set; }
    }
}
