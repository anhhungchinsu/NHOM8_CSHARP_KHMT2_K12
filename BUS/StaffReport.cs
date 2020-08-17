using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StaffReport
    {

        public static DataTable getRevenue(String date)
        {
            DateTime a = DateTime.Parse(date);
            string sql = "select export_staff_id ,SUM(export_amount*product_exprice) from tblexport8 inner join tblexportdetail8 on tblexport8.export_id = tblexportdetail8.export_detail_export_id" +
                " inner join tblproduct8 on tblexportdetail8.export_detail_product_id = tblproduct8.product_id" +
                " where export_date ='"+a+"'" +
                " group by export_staff_id";
            Data da = new Data();
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
