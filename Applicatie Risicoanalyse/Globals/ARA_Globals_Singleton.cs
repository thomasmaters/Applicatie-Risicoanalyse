using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters;

namespace Applicatie_Risicoanalyse.Globals
{
    public class ARA_Globals_Singleton
    {
        private static ARA_Globals_Singleton instance;
        private static Select_Add_Risk_To_Project_DataTableAdapter select_Add_Risk_To_Project_DataTableAdapter = new Select_Add_Risk_To_Project_DataTableAdapter();
        private static DataRowCollection risksByGroupAndType;

        private ARA_Globals_Singleton()
        {
            risksByGroupAndType = select_Add_Risk_To_Project_DataTableAdapter.GetData().Rows;
        }

        public static ARA_Globals_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ARA_Globals_Singleton();
                }
                return instance;
            }
        }

        public static DataRowCollection RisksByGroupAndType
        {
            get
            {
                return risksByGroupAndType;
            }
        }
    }
}
