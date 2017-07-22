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
        List<MenuChildModel> ModelMenuChild = new List<MenuChildModel>();
        UtilityClass UC = new UtilityClass();
        string sql = "";
        string ret = "";
        int sqlaffectedrows = 0;

        public List<MenuModel> GenerateMenu()
        {
            if (UC.OpenConnection())
            {

                sql =
                    "SELECT Tree_ID , Tree_Name , Parent_ID FROM MenuTree where Parent_ID = 0 order by Full_index";
                UC.command.CommandType = System.Data.CommandType.Text;
                UC.command.Connection = UC.connection;
                UC.command.CommandText = sql;
                UC.dtreader = UC.command.ExecuteReader();
                ModelMenu.Clear();
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

        public List<MenuChildModel> GenerateMenuChild(string parent)
        {
            if (UC.OpenConnection())
            {

                sql =
                     "SELECT Tree_ID , Tree_Name , Parent_ID FROM MenuTree where Parent_ID = '"+parent+"' order by Full_index";
                UC.command.CommandType = System.Data.CommandType.Text;
                UC.command.Connection = UC.connection;
                UC.command.CommandText = sql;
                UC.dtreader = UC.command.ExecuteReader();
                ModelMenu.Clear();
                while (UC.dtreader.Read())
                {
                    var XX = new MenuChildModel();
                    XX.t_menu_id = UC.dtreader[0].ToString();
                    XX.menu_name = UC.dtreader[1].ToString();
                    XX.parent = UC.dtreader[2].ToString();
                    ModelMenuChild.Add(XX);
                }
            }
            return ModelMenuChild;

        }
    }
}
