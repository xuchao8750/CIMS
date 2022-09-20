using Common;
using DBUtility;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tbl_InspectionsummaryService
    {
        public List<Tbl_Inspectionsummary> select(Tbl_Inspectionsummary objuser)
        {
            string SQL = $"SELECT {MyReflector.GetSelectProp(typeof(Tbl_Inspectionsummary))} FROM Tbl_Inspectionsummary";
            List<Tbl_Inspectionsummary> tbl_Inspectionsummary = DPHelper2.ReadDB<Tbl_Inspectionsummary>(SQL, objuser);
            return tbl_Inspectionsummary;
        }
    }
}
