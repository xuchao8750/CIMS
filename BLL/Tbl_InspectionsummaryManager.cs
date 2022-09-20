using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    
    public class Tbl_InspectionsummaryManager
    {
        private Tbl_InspectionsummaryService tbl_InspectionsummaryService = new Tbl_InspectionsummaryService();
        public List<Tbl_Inspectionsummary> select(Tbl_Inspectionsummary objuser)
        {
            return tbl_InspectionsummaryService.select(objuser);
        }
    }
}
