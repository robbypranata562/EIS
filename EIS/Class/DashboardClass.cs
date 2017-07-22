using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EIS.Model;
namespace EIS.Class
{
    
    class DashboardClass
    {
        List<MenuModel> ModelMenu = new List<MenuModel>();
        UtilityClass UC = new UtilityClass();
        string sql = "";
        string ret = "";
        int sqlaffectedrows = 0;

        public List<MenuModel> GenerateMenu()
        {
            if (UC.OpenConnection())
            {

                sql =
                    ";WITH Tree_CTE(Tree_ID, Tree_name, Parent_ID, Seq_index, Full_index, Tree_level) " +
                    "    AS " +
                    "    ( " +
                    "        SELECT [MenuTree].*, 0  FROM [MenuTree] WHERE Parent_ID =0 " +
                    "        UNION ALL " +
                    "        SELECT ChildNode.*, Tree_level+1  FROM [MenuTree] AS ChildNode " +
                    "        INNER JOIN Tree_CTE " +
                    "        ON ChildNode.Parent_ID = Tree_CTE.Tree_ID " +
                    "    ) " +
                    "    SELECT * FROM Tree_CTE order by Full_index";
                UC.command.CommandType = System.Data.CommandType.Text;
                UC.command.Connection = UC.connection;
                UC.command.CommandText = sql;
                UC.dtreader = UC.command.ExecuteReader();
                while (UC.dtreader.Read())
                {
                    var BM = new MenuModel();
                    BM.t_menu_id = UC.dtreader[0].ToString();
                    BM.menu_name = UC.dtreader[1].ToString();
                    BM.parent = UC.dtreader[2].ToString();
                    ModelMenu.Add(BM);
                }
            }
            return ModelMenu;

        }
    }
}
